namespace f24aa014_nurturing
{
    internal static class Program
    {
        // 各フォームの切り替えやフォーム間でデータ共有をするための変数
        public static ApplicationContext main_form;   // メインフォーム用の変数
        public static string NametTxt = ""; // 名前を次のフォームに渡す用の変数
        public static int HP = 0;
        public static int ATK = 0;
        public static int DEF = 0;
        public static Image Birdimage = null;// 画像を次のフォームに渡す用の変数


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // 初めに生成されているコードをコメントアウトする
            // Application.Run(new Form1());
            // メインフォーム用の変数をApplication.Runの引数に設定
            main_form = new ApplicationContext();
            main_form.MainForm = new ChoiceDisplay();
            Application.Run(main_form);
        }
        // Form1に切り替える処理
        public static void Display_Coice()
        {
            main_form.MainForm = new ChoiceDisplay();
            main_form.MainForm.Show();
        }
        // Form2に切り替える処理
        public static void Display_Training()
        {
            main_form.MainForm = new TrainingDisplay();
            main_form.MainForm.Show();
        }
    }
}