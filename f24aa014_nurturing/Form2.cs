using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f24aa014_nurturing
{
    public partial class TrainingDisplay : Form
    {
        public class Food //餌クラスを定義
        {
            public string Name { get; set; } //餌の名前
            public int Exp { get; set; } //餌の経験値
            public int Count { get; set; } //餌の所持数

            public Food(string name, int exp, int count)
            {
                Name = name;
                Exp = exp;
                Count = count;
            }

            public override string ToString() //餌の残りを表示
            {
                return $"{Name}（残り{Count}）";
            }
        }

        private void SaveStatusToCsv() //
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "CSVファイル (*.csv)|*.csv";
                dialog.Title = "ステータスを保存";
                dialog.FileName = "status.csv";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = {
                        "名前,レベル,経験値,体力,攻撃力,防御力",
                        $"{Program.NametTxt},{level},{exp},{hp},{atk},{def}"
                    };

                    try
                    {
                        System.IO.File.WriteAllLines(dialog.FileName, lines, Encoding.UTF8);
                        MessageBox.Show("ステータスを保存しました！");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("保存時にエラーが発生しました:\n" + ex.Message);
                    }
                }
            }
        }

        public TrainingDisplay()
        {
            InitializeComponent();
        }

        private PictureBox foodEffectBox;

        private int level;
        private int exp;
        private int maxExp;

        private int hp;
        private int atk;
        private int def;

        private int dx = 2;
        private int dy = 1;
        private Random random = new Random();
        private System.Windows.Forms.Timer moveTimer;

        private List<Food> foodList;

        private void UpdateStatusLabel()
        {
            LevelLabel.Text = $"レベル: {level}";
            HPLabel.Text = $"体力   : {hp}";
            ATKLabel.Text = $"攻撃力: {atk}";
            DEFLabel.Text = $"防御力: {def}";
        }

        private async void addexp(int point)
        {
            exp += point;
            Program.EXP = exp;

            while (exp >= maxExp)
            {
                int overflow = exp - maxExp;
                UpdateExpBar(maxExp);
                await Task.Delay(300);

                exp = overflow;
                Program.EXP = exp;
                LevelUP();
            }

            UpdateExpBar(exp);
        }

        private void UpdateExpBar(int tempValue)
        {
            if (level == 5)
            {
                UpdateExpBarMax();
            }
            else
            {
                progressBarExp.Maximum = maxExp;
                progressBarExp.Value = Math.Min(tempValue, maxExp);
                expLabel.Text = $"経験値: {tempValue}/{maxExp}";
            }
        }

        private void UpdateExpBarMax()
        {
            progressBarExp.Maximum = maxExp;
            progressBarExp.Value = maxExp;
            expLabel.Text = $"経験値: MAX";
        }
        private void LevelUP()
        {
            level++;
            hp += 6;
            atk += 3;
            def += 2;
            maxExp += 20;
            MessageBox.Show($"レベルアップ！ レベル {level} に到達しました！");

            Program.Level = level;
            Program.MaxEXP = maxExp;
            Program.HP = hp;
            Program.ATK = atk;
            Program.DEF = def;
            UpdateStatusLabel();
        }

        private void MoveBird(object sender, EventArgs e)
        {
            if (random.Next(0, 10) == 0)
            {
                dx = random.Next(-3, 4);
                dy = random.Next(-3, 4);
                moveTimer.Interval = random.Next(80, 201);
            }

            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            int newX = Math.Clamp(x + dx, 0, panel1.Width - pictureBox1.Width);
            int newY = Math.Clamp(y + dy, 0, panel1.Height - pictureBox1.Height);

            pictureBox1.Location = new Point(newX, newY);
        }

        private async void ShowFoodEffect(string imagePath)
        {
            int x = pictureBox1.Location.X + pictureBox1.Width / 2;
            int y = pictureBox1.Location.Y - 20;

            foodEffectBox.Location = new Point(x, y);
            foodEffectBox.Image = Image.FromFile(imagePath);
            foodEffectBox.Visible = true;

            foodEffectBox.BringToFront();

            await Task.Delay(800);

            foodEffectBox.Visible = false;
        }

        private void TrainingDisplay_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Program.Birdimage;
            NameLabel.Text = Program.NametTxt;

            hp = Program.HP;
            atk = Program.ATK;
            def = Program.DEF;
            level = Program.Level;
            exp = Program.EXP;
            maxExp = Program.MaxEXP;

            foodEffectBox = new PictureBox();
            foodEffectBox.Size = new Size(50, 50);
            foodEffectBox.BackColor = Color.Transparent;
            foodEffectBox.Visible = false;
            foodEffectBox.SizeMode = PictureBoxSizeMode.StretchImage;
            panel1.Controls.Add(foodEffectBox);

            foodList = new List<Food>
            {
                new Food("リンゴ", 10, Program.Food_Apple),
                new Food("トウモロコシ", 20, Program.Food_Corn),
                new Food("魚", 40, Program.Food_Fish)
            };

            comboBox1.DataSource = null;
            comboBox1.DataSource = foodList;

            moveTimer = new System.Windows.Forms.Timer();
            moveTimer.Interval = 100;
            moveTimer.Tick += MoveBird;
            moveTimer.Start();

            UpdateStatusLabel();
            UpdateExpBar(exp);
        }

        private async void presentButton_Click(object sender, EventArgs e)
        {
            if(level < 5)
            {
                if (comboBox1.SelectedItem is Food selectedFood)
                {
                    if (selectedFood.Count <= 0)
                    {
                        MessageBox.Show("この餌はもう残っていません！");
                        return;
                    }

                    switch (selectedFood.Name)
                    {
                        case "リンゴ":
                            ShowFoodEffect("Resources/apple_01.png");
                            break;
                        case "トウモロコシ":
                            ShowFoodEffect("Resources/corn_01.png");
                            break;
                        case "魚":
                            ShowFoodEffect("Resources/fish_01.png");
                            break;
                    }
                    selectedFood.Count--;
                    // Program 側にも反映
                    switch (selectedFood.Name)
                    {
                        case "リンゴ":
                            Program.Food_Apple = selectedFood.Count;
                            break;
                        case "トウモロコシ":
                            Program.Food_Corn = selectedFood.Count;
                            break;
                        case "魚":
                            Program.Food_Fish = selectedFood.Count;
                            break;
                    }
                    await Task.Run(() => Invoke(new Action(() => addexp(selectedFood.Exp))));


                    comboBox1.DataSource = null;
                    comboBox1.DataSource = foodList;

                    MessageBox.Show($"{selectedFood.Name} を与えた！経験値 +{selectedFood.Exp}");
                }
            }
            else if (level == 5)
            {
                MessageBox.Show("レベルはマックスです。");
            }
        }

        private void CSVoutButton_Click(object sender, EventArgs e)
        {
            SaveStatusToCsv();
        }

        private void GoBattleButton_Click(object sender, EventArgs e)
        {
            Program.Level = level;
            Program.HP = hp;
            Program.ATK = atk;
            Program.DEF = def;
            Program.EXP = exp;
            Program.MaxEXP = maxExp;

            Program.Display_Battle();
            this.Close();
        }
    }
}
