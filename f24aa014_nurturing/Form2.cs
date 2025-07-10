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
        // 餌のクラス定義
        public class Food
        {
            public string Name { get; set; }
            public int Exp { get; set; }

            public Food(string name, int exp)
            {
                Name = name;
                Exp = exp;
            }
        }
        // csvファイルの出力（AIに頼りました。）
        private void SaveStatusToCsv()
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "CSVファイル (*.csv)|*.csv"; // ファイルの種類
                dialog.Title = "ステータスを保存"; // ダイアログの名前
                dialog.FileName = "status.csv"; // ファイルのデフォルトの名前

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


        private int level = 1; //レベルを管理する変数
        private int exp = 0;// 現在の経験値を管理する変数
        private int maxExp = 100;// 次のレベルアップに必要な経験値を管理する変数

        private PictureBox foodEffectBox;

        private int hp;// 体力を管理する変数
        private int atk;// 攻撃力を管理する変数
        private int def;// 防御力を管理する減数

        private int dx = 2;
        private int dy = 1;
        private Random random = new Random();
        private System.Windows.Forms.Timer moveTimer;
      
        private List<Food> foodList; // 餌の種類を管理するリスト

        // ステータスラベルを更新する関数
        private void UpdateStatusLabel()
        {
            LevelLabel.Text = $"レベル: {level}";// 変数と結合してそれぞれラベルテキストを変更する
            HPLabel.Text = $"体力   : {hp}";
            ATKLabel.Text = $"攻撃力: {atk}";
            DEFLabel.Text = $"防御力: {def}";
        }

        // 経験値を加算する処理（餌によって引数が変わり、引数によって得られる経験値が変わる）
        private async void addexp(int point)
        {
            exp += point;

            // 経験値が最大を超えていたら一度ゲージMAXを表示
            while (exp >= maxExp)
            {
                int overflow = exp - maxExp; // 超過分を保存
                // 一旦ゲージをMAXまで表示してユーザーに見せる
                UpdateExpBar(maxExp);
                await Task.Delay(300); // 0.3秒表示（演出用）

                // 残りの処理（経験値繰越とレベルアップ）
                exp = overflow;
                LevelUP();
            }

            UpdateExpBar(exp); // 通常の描画更新
        }

        // 加算された経験値に応じてバーを描画する処理（AIに頼りました。）
        private void UpdateExpBar(int tempValue)
        {
            progressBarExp.Maximum = maxExp;
            progressBarExp.Value = Math.Min(tempValue, maxExp);
            expLavel.Text = $"経験値: {tempValue}/{maxExp}";
        }

        // レベルアップ時の処理
        private void LevelUP()
        {
            level++; // レベルの更新とステータス値の更新 
            hp += 10;
            atk += 10;
            def += 10;
            maxExp += 20;
            MessageBox.Show($"レベルアップ！ レベル {level} に到達しました！");

            UpdateStatusLabel();
        }

        // 鳥の画像を動かす処理（AIに頼りました）
        private void MoveBird(object sender, EventArgs e)
        {
            // 時々（10%の確率）方向・速度変更
            if (random.Next(0, 10) == 0)
            {
                dx = random.Next(-3, 4);  // -3〜+3 の移動速度
                dy = random.Next(-3, 4);

                // タイマー間隔も変更（80〜200ミリ秒）
                moveTimer.Interval = random.Next(80, 201);
            }

            // 現在位置取得
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            // 移動後の座標（画面外に出ないよう制限）
            int newX = Math.Clamp(x + dx, 0, panel1.Width - pictureBox1.Width);
            int newY = Math.Clamp(y + dy, 0, panel1.Height - pictureBox1.Height);

            // 鳥の位置を更新
            pictureBox1.Location = new Point(newX, newY);
        }

        // 餌の画像を表示する関数
        private async void ShowFoodEffect(string imagePath)
        {
            // 鳥の近くに配置（例：右上にずらす）
            int x = pictureBox1.Location.X + pictureBox1.Width / 2;
            int y = pictureBox1.Location.Y - 20;

            foodEffectBox.Location = new Point(x, y);
            foodEffectBox.Image = Image.FromFile(imagePath);
            foodEffectBox.Visible = true;

            foodEffectBox.BringToFront();  // ⭐ 最前面に表示！

            await Task.Delay(800); // 0.8秒表示

            foodEffectBox.Visible = false;
        }
        private void TrainingDisplay_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Program.Birdimage; // 前の画面で選択した鳥をpictureBox1に表示
            NameLabel.Text = Program.NametTxt; //前の画面で入力したニックネームを引き継ぎ

            //選択した鳥のステータス値を引き継ぎ
            hp = Program.HP;
            atk = Program.ATK;
            def = Program.DEF;

            // 餌の画像表示用 PictureBox を準備（初期は非表示）
            foodEffectBox = new PictureBox();
            foodEffectBox.Size = new Size(50, 50); // サイズ調整（必要に応じて）
            foodEffectBox.BackColor = Color.Transparent;
            foodEffectBox.Visible = false;
            foodEffectBox.SizeMode = PictureBoxSizeMode.StretchImage;
            panel1.Controls.Add(foodEffectBox); // 畳の上に表示されるように

            // 餌の種類を初期化
            foodList = new List<Food>
            {
                new Food("リンゴ", 10),
                new Food("トウモロコシ", 20),
                new Food("魚", 40)
            };

            moveTimer = new System.Windows.Forms.Timer();
            moveTimer.Interval = 100; // 初期速度
            moveTimer.Tick += MoveBird;
            moveTimer.Start();

            UpdateStatusLabel();
            comboBox1.DataSource = foodList;
            comboBox1.DisplayMember = "Name";
        }
        private async void presentButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Food selectedFood)
            {
                // 餌画像の表示（パスは正しく調整）
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

                // 経験値加算（非同期演出付き）
                await Task.Run(() => Invoke(new Action(() => addexp(selectedFood.Exp))));

                // メッセージ表示
                MessageBox.Show($"{selectedFood.Name} を与えた！経験値 +{selectedFood.Exp}");
            }
        }

        private void CSVoutButton_Click(object sender, EventArgs e)
        {
            SaveStatusToCsv();
        }
    }
}
