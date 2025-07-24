namespace f24aa014_nurturing
{
    partial class TrainingDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            NameLabel = new Label();
            LevelLabel = new Label();
            StatusGroup = new GroupBox();
            ATKLabel = new Label();
            DEFLabel = new Label();
            HPLabel = new Label();
            groupBox3 = new GroupBox();
            expLabel = new Label();
            progressBarExp = new ProgressBar();
            presentButton = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            groupBox4 = new GroupBox();
            comboBox1 = new ComboBox();
            GoBattleButton = new Button();
            CSVoutButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            StatusGroup.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = SystemColors.ActiveCaption;
            Title.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Title.ForeColor = SystemColors.ButtonHighlight;
            Title.Location = new Point(396, 5);
            Title.Name = "Title";
            Title.Size = new Size(215, 46);
            Title.TabIndex = 1;
            Title.Text = "バードナーチュア";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(StatusGroup);
            groupBox1.Location = new Point(12, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(269, 307);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "詳細";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(NameLabel);
            groupBox2.Controls.Add(LevelLabel);
            groupBox2.Location = new Point(13, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(246, 91);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "名前";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(23, 23);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(24, 20);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "仮";
            // 
            // LevelLabel
            // 
            LevelLabel.AutoSize = true;
            LevelLabel.Location = new Point(23, 55);
            LevelLabel.Name = "LevelLabel";
            LevelLabel.Size = new Size(44, 20);
            LevelLabel.TabIndex = 6;
            LevelLabel.Text = "レベル";
            // 
            // StatusGroup
            // 
            StatusGroup.Controls.Add(ATKLabel);
            StatusGroup.Controls.Add(DEFLabel);
            StatusGroup.Controls.Add(HPLabel);
            StatusGroup.Location = new Point(13, 152);
            StatusGroup.Name = "StatusGroup";
            StatusGroup.Size = new Size(246, 125);
            StatusGroup.TabIndex = 10;
            StatusGroup.TabStop = false;
            StatusGroup.Text = "ステータス";
            // 
            // ATKLabel
            // 
            ATKLabel.AutoSize = true;
            ATKLabel.Location = new Point(23, 58);
            ATKLabel.Name = "ATKLabel";
            ATKLabel.Size = new Size(54, 20);
            ATKLabel.TabIndex = 8;
            ATKLabel.Text = "攻撃力";
            // 
            // DEFLabel
            // 
            DEFLabel.AutoSize = true;
            DEFLabel.Location = new Point(23, 83);
            DEFLabel.Name = "DEFLabel";
            DEFLabel.Size = new Size(54, 20);
            DEFLabel.TabIndex = 9;
            DEFLabel.Text = "防御力";
            // 
            // HPLabel
            // 
            HPLabel.AutoSize = true;
            HPLabel.Location = new Point(23, 33);
            HPLabel.Name = "HPLabel";
            HPLabel.Size = new Size(39, 20);
            HPLabel.TabIndex = 7;
            HPLabel.Text = "体力";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(expLabel);
            groupBox3.Controls.Add(progressBarExp);
            groupBox3.Location = new Point(13, 85);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(246, 103);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "経験値";
            // 
            // expLabel
            // 
            expLabel.AutoSize = true;
            expLabel.Location = new Point(12, 28);
            expLabel.Name = "expLabel";
            expLabel.Size = new Size(107, 20);
            expLabel.TabIndex = 2;
            expLabel.Text = "経験値：0/100";
            // 
            // progressBarExp
            // 
            progressBarExp.Location = new Point(6, 60);
            progressBarExp.Name = "progressBarExp";
            progressBarExp.Size = new Size(227, 29);
            progressBarExp.TabIndex = 1;
            // 
            // presentButton
            // 
            presentButton.BackColor = Color.Transparent;
            presentButton.Location = new Point(173, 26);
            presentButton.Name = "presentButton";
            presentButton.Size = new Size(86, 53);
            presentButton.TabIndex = 3;
            presentButton.Text = "餌をあげる";
            presentButton.UseVisualStyleBackColor = false;
            presentButton.Click += presentButton_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.room_yuka_tatami;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(279, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(586, 601);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(122, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ControlLightLight;
            groupBox4.Controls.Add(groupBox3);
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Controls.Add(presentButton);
            groupBox4.Location = new Point(12, 409);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(269, 197);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "ふれあい";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(19, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 4;
            // 
            // GoBattleButton
            // 
            GoBattleButton.Location = new Point(868, 501);
            GoBattleButton.Name = "GoBattleButton";
            GoBattleButton.Size = new Size(181, 105);
            GoBattleButton.TabIndex = 11;
            GoBattleButton.Text = "バトルへ";
            GoBattleButton.UseVisualStyleBackColor = true;
            GoBattleButton.Click += GoBattleButton_Click;
            // 
            // CSVoutButton
            // 
            CSVoutButton.Location = new Point(866, 370);
            CSVoutButton.Name = "CSVoutButton";
            CSVoutButton.Size = new Size(181, 123);
            CSVoutButton.TabIndex = 12;
            CSVoutButton.Text = "データを保存する";
            CSVoutButton.UseVisualStyleBackColor = true;
            CSVoutButton.Click += CSVoutButton_Click;
            // 
            // TrainingDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1053, 632);
            Controls.Add(CSVoutButton);
            Controls.Add(GoBattleButton);
            Controls.Add(groupBox1);
            Controls.Add(Title);
            Controls.Add(panel1);
            Controls.Add(groupBox4);
            Name = "TrainingDisplay";
            Text = "トレーニング";
            Load += TrainingDisplay_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            StatusGroup.ResumeLayout(false);
            StatusGroup.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Title;
        private GroupBox groupBox1;
        private Label NameLabel;
        private Button presentButton;
        private Label DEFLabel;
        private Label ATKLabel;
        private Label HPLabel;
        private Panel panel1;
        private PictureBox pictureBox1;
        private GroupBox StatusGroup;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label LevelLabel;
        private ProgressBar progressBarExp;
        private Label expLabel;
        private GroupBox groupBox4;
        private ComboBox comboBox1;
        private Button GoBattleButton;
        private Button CSVoutButton;
    }
}