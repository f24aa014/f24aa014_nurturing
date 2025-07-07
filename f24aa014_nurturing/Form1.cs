using System.Reflection.Metadata;

namespace f24aa014_nurturing
{
    public partial class ChoiceDisplay : Form
    {
        private int hp;
        private int atk;
        private int def;

        public ChoiceDisplay()
        {
            InitializeComponent();
            NameBox.PlaceholderText = "育てていく鳥に好きなお名前をつけることができます。";
        }

        // 選択した鳥に応じた描画を行う関数
            private void SetBirdStatus(string name, int hpvalue, int atkvalue, int defvalue, string description,PictureBox activeBox, PictureBox inactiveBox1, PictureBox inactiveBox2)
        {
            hp = hpvalue;
            atk = atkvalue;
            def = defvalue;

            activeBox.BackColor = Color.LightYellow;
            inactiveBox1.BackColor = Color.White;
            inactiveBox2.BackColor = Color.White;

            StatusLabel.Text = $"体力: {hp}\n攻撃力: {atk}\n防御力: {def}\n＜説明＞\n{description}";
        }
        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SetBirdStatus(NameBox.Text, 80, 80, 80,
                    "青色の鳥。全てのステータスがバランスよく整った鳥。\nどんな状況にも対応できる安定型で、初心者にも扱いやすい。\n育て方次第で攻守ともに活躍できる万能型。",
                    pictureBox1, pictureBox2, pictureBox3);
                Program.Birdimage = pictureBox1.Image;
            }
            else if (radioButton2.Checked)
            {
                SetBirdStatus(NameBox.Text, 60, 110, 70,
                    "黄色の鳥。スピードと攻撃力に特化した攻撃型の鳥。\n高い攻撃力で素早く敵を倒すスタイルが得意。\n打たれ弱いため、先手必勝の戦術が求められる。",
                    pictureBox2, pictureBox1, pictureBox3);
                Program.Birdimage = pictureBox2.Image;
            }
            else if (radioButton3.Checked)
            {
                SetBirdStatus(NameBox.Text, 100, 50, 90,
                    "桃色の鳥。高い体力と防御力を誇る守備特化の鳥。\n持久戦に強く、パーティの盾役として大活躍。\nじっくり育てて安定した守りを築こう。",
                    pictureBox3, pictureBox1, pictureBox2);
                Program.Birdimage = pictureBox3.Image;
            }
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            // フォントに基づいて文字列の幅を測定
            Size textSize = TextRenderer.MeasureText(NameBox.Text, NameBox.Font);

            // 最小幅を設定（必要に応じて）
            int minWidth = 100;

            // 測定した幅 + 少し余裕（10px）でTextBoxの幅を調整
            NameBox.Width = Math.Max(minWidth, textSize.Width + 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name =NameBox.Text;
            if(NameBox.Text == "")
            {
                MessageBox.Show("ニックネームを入力してください。");
            }
            else
            {
                DialogResult result = MessageBox.Show($"ニックネームは{name}でよろしいですか？", "確認", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("ニックネームが設定されました！");
                    // ニックネームの内容をProgram.inputTxtに保存
                    Program.NametTxt = NameBox.Text;
                    Program.HP = hp;
                    Program.ATK = atk;
                    Program.DEF = def;
                    Program.Display_Training();
                    //メインディスプレイを閉じる処理
                    this.Close();
                }
            }
        }
    }
}
