using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static f24aa014_nurturing.Program;

namespace f24aa014_nurturing
{
    public partial class BattleDisplay : Form
    {
        private Bird player;
        private Enemy enemy;
        // 敵キャラの候補をリスト化
        private List<Enemy> enemies;

        //プレイヤー（鳥）のクラスを定義
        public class Bird
        {
            public string Name { get; set; }
            public int Level { get; set; }
            public int HP { get; set; }
            public int Attack { get; set; }
            public int Defense { get; set; }
            public Image Image { get; set; }

            public Bird(string name, int level, int hp, int attack, int defense, Image image)
            {
                Name = name;
                Level = level;
                HP = hp;
                Attack = attack;
                Defense = defense;
                Image = image;
            }
        }
        //モンスター（敵）のクラスを定義
        public class Enemy
        {
            public string Name { get; set; }
            public int Level { get; set; }
            public int HP { get; set; }
            public int Atk { get; set; }
            public int Def { get; set; }
            public Image Image { get; set; }

            public Enemy(string name, int level, int hp, int attack, int defense, Image image)
            {
                Name = name;
                Level = level;
                HP = hp;
                Atk = attack;
                Def = defense;
                Image = image;
            }
        }

        private void PlayerAttack()//自分のターン
        {
            // 計算式例：ダメージ = プレイヤー攻撃力 * 1.5 - 敵防御力
            int damage = (int)(player.Attack * 1.5) - enemy.Def;
            if (damage < 1) damage = 1;

            enemy.HP -= damage;
            labelMonsHP.Text = $"HP: {Math.Max(enemy.HP, 0)}";
            AppendBattleLog($"{player.Name} の攻撃！ {damage} のダメージ！");

            if (enemy.HP <= 0)
            {
                WinBattle();

            }
            else
            {
                EnemyTurn();
            }
        }
        private void EnemyTurn()//相手のターン
        {
            int damage = enemy.Atk - player.Defense;
            if (damage < 1) damage = 1;

            player.HP -= damage;
            labelHP.Text = $"HP: {Math.Max(player.HP, 0)}";
            AppendBattleLog($"{enemy.Name} の攻撃！ {damage} のダメージ！");

            if (player.HP <= 0)
            {
                LoseBattle();
            }
        }
        private void AppendBattleLog(string message)//バトルログへの書き込み
        {
            battleLog.AppendText(message + Environment.NewLine);
        }

        private void WinBattle()//勝利時の処理
        {
            AppendBattleLog($"{enemy.Name} を倒した！");
            GiveRewards();

            var result = MessageBox.Show("戦闘に勝利しました！ 続けますか？", "戦闘終了", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                InitializeEnemy();
                InitializePlayer();
            }
            else
            {
                Program.HP = player.HP = GetMaxHP(player); // HP全回復
                Program.Display_Training();
                this.Close();
            }
        }

        private void LoseBattle()//敗北時の処理
        {
            AppendBattleLog("敗北しました...");
            MessageBox.Show("ゲームオーバーです。トレーニングに戻ります。");
            Program.Display_Training();
            this.Close();
        }
        private void GiveRewards()
        {
            if(player.Level < 5)
            {
                int expGain = enemy.Level * 20;
                Program.EXP += expGain;
                StatusManager.CheckLevelUp();
            }
           
            Random rnd = new Random();
            int drop = rnd.Next(3);
            switch (drop)
            {
                case 0: Program.Food_Apple++; MessageBox.Show("リンゴをゲット！"); break;
                case 1: Program.Food_Corn++; MessageBox.Show("トウモロコシをゲット！"); break;
                case 2: Program.Food_Fish++; MessageBox.Show("魚をゲット！"); break;
            }
        }
        private int GetMaxHP(Bird bird)
        {
            return 80 + (bird.Level - 1) * 10;  
        }


        public BattleDisplay()
        {
            InitializeComponent();
            enemies = new List<Enemy>()
            {
                new Enemy("anaconda", 2, 50, 20, 10, Properties.Resources.anaconda),
                new Enemy("bear", 3, 70, 28, 18, Properties.Resources.bear),
                new Enemy("bull", 4, 90, 35, 25, Properties.Resources.bull)
            };
        }

        private Enemy currentEnemy;
        private void InitializeEnemy()
        {
            Random rnd = new Random();
            int index = rnd.Next(enemies.Count);
            var baseEnemy = enemies[index];

            // プレイヤーのレベルに応じたスケーリング（例：Lv1 → x1.0, Lv2 → x1.2, Lv3 → x1.4...）
            float scale = 1.0f + (Program.Level - 1) * 0.2f;

            // スケーリングした敵を新たに生成（HP等が共有されないように new で毎回作る）
            enemy = new Enemy(
                baseEnemy.Name,
                baseEnemy.Level,
                (int)(baseEnemy.HP * scale),
                (int)(baseEnemy.Atk * scale),
                (int)(baseEnemy.Def * scale),
                baseEnemy.Image
            );

            // ラベルやPictureBoxに表示
            labelMonsName.Text = enemy.Name;
            labelMonsLevel.Text = $"レベル{enemy.Level}";
            labelMonsHP.Text = $"HP: {enemy.HP}";
            labelMonsAtk.Text = $"攻撃力: {enemy.Atk}";
            labelMonsDef.Text = $"防御力：{enemy.Def}";
            monsterImage.Image = enemy.Image;
        }

        private void InitializePlayer()
        {
            player = new Bird(
                Program.NametTxt,
                Program.Level,
                Program.HP,
                Program.ATK,
                Program.DEF,
                Program.Birdimage);
            labelName.Text = player.Name;
            labelLevel.Text = $"レベル：{player.Level}";
            labelHP.Text = $"HP: {player.HP}";
            labelAtk.Text = $"攻撃力: {player.Attack}";
            labelDef.Text = $"防御力: {player.Defense}";
            playerImage.Image = player.Image;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            Program.Display_Training();
            this.Close();
        }

        private void BattleDisplay_Load(object sender, EventArgs e)
        {
            InitializeEnemy();
            InitializePlayer();
        }

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            PlayerAttack();
        }
    }
}
