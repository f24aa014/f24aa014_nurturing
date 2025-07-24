namespace f24aa014_nurturing
{
    partial class BattleDisplay
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            labelName = new Label();
            labelLevel = new Label();
            StatusGroup = new GroupBox();
            labelAtk = new Label();
            labelDef = new Label();
            labelHP = new Label();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            labelMonsName = new Label();
            labelMonsLevel = new Label();
            groupBox5 = new GroupBox();
            labelMonsAtk = new Label();
            labelMonsDef = new Label();
            labelMonsHP = new Label();
            Title = new Label();
            playerImage = new PictureBox();
            monsterImage = new PictureBox();
            buttonAttack = new Button();
            buttonElem = new Button();
            buttonItem = new Button();
            buttonRun = new Button();
            panel1 = new Panel();
            battleLog = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            StatusGroup.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)monsterImage).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(StatusGroup);
            groupBox1.Location = new Point(33, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 273);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "自分";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelName);
            groupBox2.Controls.Add(labelLevel);
            groupBox2.Location = new Point(13, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(212, 91);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "名前";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(23, 23);
            labelName.Name = "labelName";
            labelName.Size = new Size(24, 20);
            labelName.TabIndex = 0;
            labelName.Text = "仮";
            // 
            // labelLevel
            // 
            labelLevel.AutoSize = true;
            labelLevel.Location = new Point(23, 55);
            labelLevel.Name = "labelLevel";
            labelLevel.Size = new Size(44, 20);
            labelLevel.TabIndex = 6;
            labelLevel.Text = "レベル";
            // 
            // StatusGroup
            // 
            StatusGroup.Controls.Add(labelAtk);
            StatusGroup.Controls.Add(labelDef);
            StatusGroup.Controls.Add(labelHP);
            StatusGroup.Location = new Point(15, 136);
            StatusGroup.Name = "StatusGroup";
            StatusGroup.Size = new Size(212, 125);
            StatusGroup.TabIndex = 10;
            StatusGroup.TabStop = false;
            StatusGroup.Text = "ステータス";
            // 
            // labelAtk
            // 
            labelAtk.AutoSize = true;
            labelAtk.Location = new Point(23, 58);
            labelAtk.Name = "labelAtk";
            labelAtk.Size = new Size(54, 20);
            labelAtk.TabIndex = 8;
            labelAtk.Text = "攻撃力";
            // 
            // labelDef
            // 
            labelDef.AutoSize = true;
            labelDef.Location = new Point(23, 83);
            labelDef.Name = "labelDef";
            labelDef.Size = new Size(54, 20);
            labelDef.TabIndex = 9;
            labelDef.Text = "防御力";
            // 
            // labelHP
            // 
            labelHP.AutoSize = true;
            labelHP.Location = new Point(23, 33);
            labelHP.Name = "labelHP";
            labelHP.Size = new Size(39, 20);
            labelHP.TabIndex = 7;
            labelHP.Text = "体力";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlLightLight;
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(groupBox5);
            groupBox3.Location = new Point(768, 10);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(244, 273);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "敵";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(labelMonsName);
            groupBox4.Controls.Add(labelMonsLevel);
            groupBox4.Location = new Point(13, 39);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(212, 91);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "名前";
            // 
            // labelMonsName
            // 
            labelMonsName.AutoSize = true;
            labelMonsName.Location = new Point(23, 23);
            labelMonsName.Name = "labelMonsName";
            labelMonsName.Size = new Size(24, 20);
            labelMonsName.TabIndex = 0;
            labelMonsName.Text = "仮";
            // 
            // labelMonsLevel
            // 
            labelMonsLevel.AutoSize = true;
            labelMonsLevel.Location = new Point(23, 55);
            labelMonsLevel.Name = "labelMonsLevel";
            labelMonsLevel.Size = new Size(44, 20);
            labelMonsLevel.TabIndex = 6;
            labelMonsLevel.Text = "レベル";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(labelMonsAtk);
            groupBox5.Controls.Add(labelMonsDef);
            groupBox5.Controls.Add(labelMonsHP);
            groupBox5.Location = new Point(15, 136);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(212, 125);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "ステータス";
            // 
            // labelMonsAtk
            // 
            labelMonsAtk.AutoSize = true;
            labelMonsAtk.Location = new Point(23, 58);
            labelMonsAtk.Name = "labelMonsAtk";
            labelMonsAtk.Size = new Size(54, 20);
            labelMonsAtk.TabIndex = 8;
            labelMonsAtk.Text = "攻撃力";
            // 
            // labelMonsDef
            // 
            labelMonsDef.AutoSize = true;
            labelMonsDef.Location = new Point(23, 83);
            labelMonsDef.Name = "labelMonsDef";
            labelMonsDef.Size = new Size(54, 20);
            labelMonsDef.TabIndex = 9;
            labelMonsDef.Text = "防御力";
            // 
            // labelMonsHP
            // 
            labelMonsHP.AutoSize = true;
            labelMonsHP.Location = new Point(23, 33);
            labelMonsHP.Name = "labelMonsHP";
            labelMonsHP.Size = new Size(39, 20);
            labelMonsHP.TabIndex = 7;
            labelMonsHP.Text = "体力";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = SystemColors.ActiveCaption;
            Title.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Title.ForeColor = SystemColors.ButtonHighlight;
            Title.Location = new Point(410, 8);
            Title.Name = "Title";
            Title.Size = new Size(215, 46);
            Title.TabIndex = 14;
            Title.Text = "バードナーチュア";
            // 
            // playerImage
            // 
            playerImage.BackColor = Color.Transparent;
            playerImage.Location = new Point(55, 89);
            playerImage.Name = "playerImage";
            playerImage.Size = new Size(190, 190);
            playerImage.SizeMode = PictureBoxSizeMode.StretchImage;
            playerImage.TabIndex = 16;
            playerImage.TabStop = false;
            // 
            // monsterImage
            // 
            monsterImage.BackColor = Color.Transparent;
            monsterImage.Location = new Point(753, 47);
            monsterImage.Name = "monsterImage";
            monsterImage.Size = new Size(250, 250);
            monsterImage.SizeMode = PictureBoxSizeMode.StretchImage;
            monsterImage.TabIndex = 17;
            monsterImage.TabStop = false;
            // 
            // buttonAttack
            // 
            buttonAttack.Location = new Point(328, 84);
            buttonAttack.Name = "buttonAttack";
            buttonAttack.Size = new Size(177, 85);
            buttonAttack.TabIndex = 19;
            buttonAttack.Text = "攻撃";
            buttonAttack.UseVisualStyleBackColor = true;
            buttonAttack.Click += buttonAttack_Click;
            // 
            // buttonElem
            // 
            buttonElem.Location = new Point(328, 173);
            buttonElem.Name = "buttonElem";
            buttonElem.Size = new Size(177, 85);
            buttonElem.TabIndex = 20;
            buttonElem.Text = "未実装です";
            buttonElem.UseVisualStyleBackColor = true;
            // 
            // buttonItem
            // 
            buttonItem.Location = new Point(511, 82);
            buttonItem.Name = "buttonItem";
            buttonItem.Size = new Size(177, 85);
            buttonItem.TabIndex = 21;
            buttonItem.Text = "未実装です";
            buttonItem.UseVisualStyleBackColor = true;
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(512, 174);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(177, 85);
            buttonRun.TabIndex = 22;
            buttonRun.Text = "逃げる";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.bg_natural_sougen;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(battleLog);
            panel1.Controls.Add(monsterImage);
            panel1.Controls.Add(playerImage);
            panel1.Location = new Point(12, 289);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 339);
            panel1.TabIndex = 23;
            // 
            // battleLog
            // 
            battleLog.BackColor = SystemColors.ActiveBorder;
            battleLog.Location = new Point(300, -3);
            battleLog.Multiline = true;
            battleLog.Name = "battleLog";
            battleLog.Size = new Size(411, 339);
            battleLog.TabIndex = 18;
            // 
            // BattleDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1053, 640);
            Controls.Add(buttonRun);
            Controls.Add(buttonItem);
            Controls.Add(buttonElem);
            Controls.Add(buttonAttack);
            Controls.Add(Title);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "BattleDisplay";
            Text = "バトル";
            Load += BattleDisplay_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            StatusGroup.ResumeLayout(false);
            StatusGroup.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)playerImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)monsterImage).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label labelName;
        private Label labelLevel;
        private GroupBox StatusGroup;
        private Label labelAtk;
        private Label labelDef;
        private Label labelHP;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label labelMonsName;
        private Label labelMonsLevel;
        private GroupBox groupBox5;
        private Label labelMonsAtk;
        private Label labelMonsDef;
        private Label labelMonsHP;
        private Label Title;
        private PictureBox playerImage;
        private PictureBox monsterImage;
        private Button buttonAttack;
        private Button buttonElem;
        private Button buttonItem;
        private Button buttonRun;
        private Panel panel1;
        private TextBox battleLog;
    }
}