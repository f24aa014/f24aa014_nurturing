namespace f24aa014_nurturing
{
    internal static class Program
    {
        // �e�t�H�[���̐؂�ւ���t�H�[���ԂŃf�[�^���L�����邽�߂̕ϐ�
        public static ApplicationContext main_form;   // ���C���t�H�[���p�̕ϐ�
        public static string NametTxt = ""; // ���O�����̃t�H�[���ɓn���p�̕ϐ�
        public static int HP = 0;
        public static int ATK = 0;
        public static int DEF = 0;
        public static Image Birdimage = null;// �摜�����̃t�H�[���ɓn���p�̕ϐ�


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // ���߂ɐ�������Ă���R�[�h���R�����g�A�E�g����
            // Application.Run(new Form1());
            // ���C���t�H�[���p�̕ϐ���Application.Run�̈����ɐݒ�
            main_form = new ApplicationContext();
            main_form.MainForm = new ChoiceDisplay();
            Application.Run(main_form);
        }
        // Form1�ɐ؂�ւ��鏈��
        public static void Display_Coice()
        {
            main_form.MainForm = new ChoiceDisplay();
            main_form.MainForm.Show();
        }
        // Form2�ɐ؂�ւ��鏈��
        public static void Display_Training()
        {
            main_form.MainForm = new TrainingDisplay();
            main_form.MainForm.Show();
        }
    }
}