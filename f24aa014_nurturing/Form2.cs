using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private int hp;// 体力を管理する変数
        private int atk;// 攻撃力を管理する変数
        private int def;// 防御力を管理する減数

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
        private void addexp(int point)
        {
            exp += point; // 現在の経験値に引数を加算
            while (exp >= maxExp) // 現在の経験値がレベルアップに必要な経験値より大きい間繰り返す。
            {
                exp -= maxExp;
                UpdateExpBar();
                LevelUP();
            }
            UpdateExpBar();
        }
        // 加算された経験値に応じてバーを描画する処理（AIに頼りました。）
        private void UpdateExpBar()
        {
            progressBarExp.Maximum = maxExp;
            progressBarExp.Value = Math.Min(exp, maxExp); // オーバーフロー防止
            expLavel.Text = $"経験値: {exp}/{maxExp}";
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

        private void TrainingDisplay_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Program.Birdimage; // 前の画面で選択した鳥をpictureBox1に表示
            NameLabel.Text = Program.NametTxt; //前の画面で入力したニックネームを引き継ぎ

            //選択した鳥のステータス値を引き継ぎ
            hp = Program.HP;
            atk = Program.ATK;
            def = Program.DEF;

            // 餌の種類を初期化
            foodList = new List<Food>
            {
                new Food("リンゴ", 10),
                new Food("トウモロコシ", 20),
                new Food("魚", 40)
            };

            UpdateStatusLabel();
            comboBox1.DataSource = foodList;
            comboBox1.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 選ばれた餌によって得られる経験値が変化する
            if (comboBox1.SelectedItem is Food selectedFood)
            {
                addexp(selectedFood.Exp);
                MessageBox.Show($"{selectedFood.Name} を与えた！経験値 +{selectedFood.Exp}");
            }
        }

        private void CSVoutButton_Click(object sender, EventArgs e)
        {
            SaveStatusToCsv();
        }
    }
}
