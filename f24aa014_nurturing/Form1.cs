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
            NameBox.PlaceholderText = "��ĂĂ������ɍD���Ȃ����O�����邱�Ƃ��ł��܂��B";
        }

        // �I���������ɉ������`����s���֐�
            private void SetBirdStatus(string name, int hpvalue, int atkvalue, int defvalue, string description,PictureBox activeBox, PictureBox inactiveBox1, PictureBox inactiveBox2)
        {
            hp = hpvalue;
            atk = atkvalue;
            def = defvalue;

            activeBox.BackColor = Color.LightYellow;
            inactiveBox1.BackColor = Color.White;
            inactiveBox2.BackColor = Color.White;

            StatusLabel.Text = $"�̗�: {hp}\n�U����: {atk}\n�h���: {def}\n��������\n{description}";
        }
        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SetBirdStatus(NameBox.Text, 80, 80, 80,
                    "�F�̒��B�S�ẴX�e�[�^�X���o�����X�悭���������B\n�ǂ�ȏ󋵂ɂ��Ή��ł������^�ŁA���S�҂ɂ������₷���B\n��ĕ�����ōU��Ƃ��Ɋ���ł��閜�\�^�B",
                    pictureBox1, pictureBox2, pictureBox3);
                Program.Birdimage = pictureBox1.Image;
            }
            else if (radioButton2.Checked)
            {
                SetBirdStatus(NameBox.Text, 60, 110, 70,
                    "���F�̒��B�X�s�[�h�ƍU���͂ɓ��������U���^�̒��B\n�����U���͂őf�����G��|���X�^�C�������ӁB\n�ł���ア���߁A���K���̐�p�����߂���B",
                    pictureBox2, pictureBox1, pictureBox3);
                Program.Birdimage = pictureBox2.Image;
            }
            else if (radioButton3.Checked)
            {
                SetBirdStatus(NameBox.Text, 100, 50, 90,
                    "���F�̒��B�����̗͂Ɩh��͂��ւ��������̒��B\n���v��ɋ����A�p�[�e�B�̏����Ƃ��đ劈��B\n���������ĂĈ��肵������z�����B",
                    pictureBox3, pictureBox1, pictureBox2);
                Program.Birdimage = pictureBox3.Image;
            }
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            // �t�H���g�Ɋ�Â��ĕ�����̕��𑪒�
            Size textSize = TextRenderer.MeasureText(NameBox.Text, NameBox.Font);

            // �ŏ�����ݒ�i�K�v�ɉ����āj
            int minWidth = 100;

            // ���肵���� + �����]�T�i10px�j��TextBox�̕��𒲐�
            NameBox.Width = Math.Max(minWidth, textSize.Width + 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name =NameBox.Text;
            if(NameBox.Text == "")
            {
                MessageBox.Show("�j�b�N�l�[������͂��Ă��������B");
            }
            else
            {
                DialogResult result = MessageBox.Show($"�j�b�N�l�[����{name}�ł�낵���ł����H", "�m�F", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("�j�b�N�l�[�����ݒ肳��܂����I");
                    // �j�b�N�l�[���̓��e��Program.inputTxt�ɕۑ�
                    Program.NametTxt = NameBox.Text;
                    Program.HP = hp;
                    Program.ATK = atk;
                    Program.DEF = def;
                    Program.Display_Training();
                    //���C���f�B�X�v���C����鏈��
                    this.Close();
                }
            }
        }
    }
}
