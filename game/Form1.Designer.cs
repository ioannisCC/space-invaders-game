namespace game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Up = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.Down = new System.Windows.Forms.Timer(this.components);
            this.Left = new System.Windows.Forms.Timer(this.components);
            this.Right = new System.Windows.Forms.Timer(this.components);
            this.progressBarShields = new System.Windows.Forms.ProgressBar();
            this.labelShields = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lazersTimer = new System.Windows.Forms.Timer(this.components);
            this.enemy = new System.Windows.Forms.PictureBox();
            this.enemyLocation = new System.Windows.Forms.Timer(this.components);
            this.enemyLazerManager = new System.Windows.Forms.Timer(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.playPictureBox = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.spriteChange = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Up
            // 
            this.Up.Interval = 10;
            this.Up.Tick += new System.EventHandler(this.Up_Tick);
            // 
            // player
            // 
            this.player.ImageLocation = "";
            this.player.Location = new System.Drawing.Point(344, 544);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 103);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // Down
            // 
            this.Down.Interval = 10;
            this.Down.Tick += new System.EventHandler(this.Down_Tick);
            // 
            // Left
            // 
            this.Left.Interval = 10;
            this.Left.Tick += new System.EventHandler(this.Left_Tick);
            // 
            // Right
            // 
            this.Right.Interval = 10;
            this.Right.Tick += new System.EventHandler(this.Right_Tick);
            // 
            // progressBarShields
            // 
            this.progressBarShields.BackColor = System.Drawing.SystemColors.Control;
            this.progressBarShields.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBarShields.Location = new System.Drawing.Point(625, 735);
            this.progressBarShields.Name = "progressBarShields";
            this.progressBarShields.Size = new System.Drawing.Size(176, 23);
            this.progressBarShields.Step = 5;
            this.progressBarShields.TabIndex = 2;
            this.progressBarShields.Value = 100;
            // 
            // labelShields
            // 
            this.labelShields.AutoSize = true;
            this.labelShields.Font = new System.Drawing.Font("Summer Pixel 22", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShields.ForeColor = System.Drawing.SystemColors.Window;
            this.labelShields.Location = new System.Drawing.Point(500, 735);
            this.labelShields.Name = "labelShields";
            this.labelShields.Size = new System.Drawing.Size(119, 32);
            this.labelShields.TabIndex = 3;
            this.labelShields.Text = "shields";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Summer Pixel 22", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.Window;
            this.labelScore.Location = new System.Drawing.Point(4, 735);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(134, 32);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lazersTimer
            // 
            this.lazersTimer.Interval = 5;
            this.lazersTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // enemy
            // 
            this.enemy.ImageLocation = "";
            this.enemy.Location = new System.Drawing.Point(344, 50);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(100, 103);
            this.enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy.TabIndex = 7;
            this.enemy.TabStop = false;
            // 
            // enemyLocation
            // 
            this.enemyLocation.Interval = 1000;
            this.enemyLocation.Tick += new System.EventHandler(this.enemyLocation_Tick);
            // 
            // enemyLazerManager
            // 
            this.enemyLazerManager.Interval = 5;
            this.enemyLazerManager.Tick += new System.EventHandler(this.enemyLazerManager_Tick);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // playPictureBox
            // 
            this.playPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playPictureBox.BackgroundImage")));
            this.playPictureBox.Location = new System.Drawing.Point(141, 263);
            this.playPictureBox.Name = "playPictureBox";
            this.playPictureBox.Size = new System.Drawing.Size(523, 199);
            this.playPictureBox.TabIndex = 8;
            this.playPictureBox.TabStop = false;
            this.playPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1129, 494);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 36);
            this.label13.TabIndex = 26;
            this.label13.Text = "*";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.SystemColors.WindowText;
            this.label29.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.Window;
            this.label29.Location = new System.Drawing.Point(47, 83);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(11, 11);
            this.label29.TabIndex = 37;
            this.label29.Tag = "star";
            this.label29.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(179, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 11);
            this.label1.TabIndex = 38;
            this.label1.Tag = "star";
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowText;
            this.label2.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(688, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 11);
            this.label2.TabIndex = 39;
            this.label2.Tag = "star";
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowText;
            this.label3.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(560, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 11);
            this.label3.TabIndex = 40;
            this.label3.Tag = "star";
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.WindowText;
            this.label4.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(429, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 11);
            this.label4.TabIndex = 41;
            this.label4.Tag = "star";
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.WindowText;
            this.label5.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(604, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 11);
            this.label5.TabIndex = 42;
            this.label5.Tag = "star";
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.WindowText;
            this.label6.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(61, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 11);
            this.label6.TabIndex = 43;
            this.label6.Tag = "star";
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.WindowText;
            this.label7.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(244, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 11);
            this.label7.TabIndex = 44;
            this.label7.Tag = "star";
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.WindowText;
            this.label8.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(429, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 11);
            this.label8.TabIndex = 45;
            this.label8.Tag = "star";
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.WindowText;
            this.label9.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(301, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 11);
            this.label9.TabIndex = 46;
            this.label9.Tag = "star";
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.WindowText;
            this.label10.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(550, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 11);
            this.label10.TabIndex = 47;
            this.label10.Tag = "star";
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.WindowText;
            this.label11.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(94, 504);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 11);
            this.label11.TabIndex = 48;
            this.label11.Tag = "star";
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.WindowText;
            this.label12.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(752, 613);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 11);
            this.label12.TabIndex = 49;
            this.label12.Tag = "star";
            this.label12.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.WindowText;
            this.label14.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(382, 504);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 11);
            this.label14.TabIndex = 50;
            this.label14.Tag = "star";
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.WindowText;
            this.label15.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Window;
            this.label15.Location = new System.Drawing.Point(592, 650);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 11);
            this.label15.TabIndex = 51;
            this.label15.Tag = "star";
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.WindowText;
            this.label16.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Window;
            this.label16.Location = new System.Drawing.Point(123, 670);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 11);
            this.label16.TabIndex = 52;
            this.label16.Tag = "star";
            this.label16.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.WindowText;
            this.label17.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Window;
            this.label17.Location = new System.Drawing.Point(340, 650);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 11);
            this.label17.TabIndex = 53;
            this.label17.Tag = "star";
            this.label17.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.WindowText;
            this.label18.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Window;
            this.label18.Location = new System.Drawing.Point(707, 529);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 11);
            this.label18.TabIndex = 54;
            this.label18.Tag = "star";
            this.label18.Text = "*";
            // 
            // spriteChange
            // 
            this.spriteChange.Interval = 500;
            this.spriteChange.Tick += new System.EventHandler(this.spriteChange_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Summer Pixel 22", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.timerLabel.Location = new System.Drawing.Point(659, 20);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(120, 27);
            this.timerLabel.TabIndex = 55;
            this.timerLabel.Text = "time : 80";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.WindowText;
            this.label19.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Window;
            this.label19.Location = new System.Drawing.Point(258, 717);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(11, 11);
            this.label19.TabIndex = 56;
            this.label19.Tag = "star";
            this.label19.Text = "*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.WindowText;
            this.label20.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.Window;
            this.label20.Location = new System.Drawing.Point(733, 721);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(11, 11);
            this.label20.TabIndex = 57;
            this.label20.Tag = "star";
            this.label20.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.WindowText;
            this.label21.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.Window;
            this.label21.Location = new System.Drawing.Point(12, 724);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(11, 11);
            this.label21.TabIndex = 58;
            this.label21.Tag = "star";
            this.label21.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.WindowText;
            this.label22.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.Window;
            this.label22.Location = new System.Drawing.Point(540, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(11, 11);
            this.label22.TabIndex = 59;
            this.label22.Tag = "star";
            this.label22.Text = "*";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.WindowText;
            this.label23.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.Window;
            this.label23.Location = new System.Drawing.Point(123, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(11, 11);
            this.label23.TabIndex = 60;
            this.label23.Tag = "star";
            this.label23.Text = "*";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.WindowText;
            this.label24.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.Window;
            this.label24.Location = new System.Drawing.Point(733, 331);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(11, 11);
            this.label24.TabIndex = 61;
            this.label24.Tag = "star";
            this.label24.Text = "*";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.WindowText;
            this.label25.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.Window;
            this.label25.Location = new System.Drawing.Point(433, 706);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(11, 11);
            this.label25.TabIndex = 63;
            this.label25.Tag = "star";
            this.label25.Text = "*";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.SystemColors.WindowText;
            this.label26.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.Window;
            this.label26.Location = new System.Drawing.Point(528, 544);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(11, 11);
            this.label26.TabIndex = 64;
            this.label26.Tag = "star";
            this.label26.Text = "*";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.WindowText;
            this.label27.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.Window;
            this.label27.Location = new System.Drawing.Point(560, 236);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(11, 11);
            this.label27.TabIndex = 65;
            this.label27.Tag = "star";
            this.label27.Text = "*";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.SystemColors.WindowText;
            this.label28.Font = new System.Drawing.Font("Summer Pixel 22", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.Window;
            this.label28.Location = new System.Drawing.Point(382, 123);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(11, 11);
            this.label28.TabIndex = 66;
            this.label28.Tag = "star";
            this.label28.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 757);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.player);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.playPictureBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelShields);
            this.Controls.Add(this.progressBarShields);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "space invaders";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Up;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer Down;
        private System.Windows.Forms.Timer Left;
        private System.Windows.Forms.Timer Right;
        private System.Windows.Forms.ProgressBar progressBarShields;
        private System.Windows.Forms.Label labelShields;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer lazersTimer;
        private System.Windows.Forms.PictureBox enemy;
        private System.Windows.Forms.Timer enemyLocation;
        private System.Windows.Forms.Timer enemyLazerManager;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox playPictureBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Timer spriteChange;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
    }
}

