namespace f24aa014_nurturing
{
    partial class ChoiceDisplay
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            nameTitle = new Label();
            StatusLabel = new Label();
            statusTitle = new Label();
            groupBox1 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            NameBox = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = SystemColors.ActiveCaption;
            Title.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Title.ForeColor = SystemColors.ButtonHighlight;
            Title.Location = new Point(305, 9);
            Title.Name = "Title";
            Title.Size = new Size(215, 46);
            Title.TabIndex = 0;
            Title.Text = "バードナーチュア";
            // 
            // nameTitle
            // 
            nameTitle.AutoSize = true;
            nameTitle.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nameTitle.ForeColor = SystemColors.ButtonHighlight;
            nameTitle.Location = new Point(12, 48);
            nameTitle.Name = "nameTitle";
            nameTitle.Size = new Size(141, 28);
            nameTitle.TabIndex = 2;
            nameTitle.Text = "＜ニックネーム＞";
            // 
            // StatusLabel
            // 
            StatusLabel.BackColor = SystemColors.ControlLightLight;
            StatusLabel.BorderStyle = BorderStyle.Fixed3D;
            StatusLabel.ForeColor = SystemColors.ActiveCaptionText;
            StatusLabel.Location = new Point(12, 457);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(606, 163);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "\r\n\r\n\r\n";
            // 
            // statusTitle
            // 
            statusTitle.AutoSize = true;
            statusTitle.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            statusTitle.ForeColor = SystemColors.ButtonHighlight;
            statusTitle.Location = new Point(12, 425);
            statusTitle.Name = "statusTitle";
            statusTitle.Size = new Size(180, 28);
            statusTitle.TabIndex = 4;
            statusTitle.Text = "＜ステイタスと説明＞";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(829, 294);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "タイプ";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pink_bird;
            pictureBox3.Location = new Point(558, 26);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(200, 200);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.yellow_bird;
            pictureBox2.Location = new Point(312, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(612, 246);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(87, 24);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "桃色の鳥";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(367, 246);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(87, 24);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "黄色の鳥";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(113, 246);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 24);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "青色の鳥";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.blue_bird;
            pictureBox1.Location = new Point(67, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button1.Location = new Point(624, 457);
            button1.Name = "button1";
            button1.Size = new Size(217, 163);
            button1.TabIndex = 10;
            button1.Text = "決定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(12, 79);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(829, 27);
            NameBox.TabIndex = 11;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // ChoiceDisplay
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(853, 632);
            Controls.Add(NameBox);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(statusTitle);
            Controls.Add(StatusLabel);
            Controls.Add(nameTitle);
            Controls.Add(Title);
            Name = "ChoiceDisplay";
            Text = "メイン";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label nameTitle;
        private Label StatusLabel;
        private Label statusTitle;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private TextBox NameBox;
    }
}
