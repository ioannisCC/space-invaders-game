using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Media;
using NAudio.Wave;

namespace game
{
    [Serializable]
    public partial class Form1 : Form
    {
        Random random;

        private int score = 0;
        private int playerShields = 100;
        private int[] topScores = new int[10];
        int time = 80;
        List<PictureBox> lazers = new List<PictureBox>();
        List<PictureBox> enemyLazers = new List<PictureBox>();
        SoundPlayer backgroundMusic;
        SoundPlayer lazerSound;
        private WaveStream bgMusicStream;
        private WaveOut bgMusicOut;

        
        public int PlayerShields { get => playerShields; set => playerShields = value; }
        public int Score { get => score; set => score = value; }

        void Assign()
        {
            topScores = DeserializeScores();
        }
        public Form1()
        {   
            InitializeComponent();
            bgMusicStream = new AudioFileReader("sci-fi-cyberpunk-trailer-110587.wav");
            bgMusicOut = new WaveOut();
            bgMusicOut.Init(bgMusicStream);
            bgMusicStream.CurrentTime = new TimeSpan(0L);
            bgMusicOut.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.ImageLocation = "layer-space-ship-space-ship-png-pixel-art-11562897009dytcvah4cy-removebg-preview.png";
            enemy.ImageLocation = "enemy.png";
            random = new Random();
            Assign();            
            lazerSound = new SoundPlayer("blaster-2-81267.wav");            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString().Equals("Left"))
            {
                Left.Enabled = true;
            }

            if (e.KeyCode.ToString().Equals("Right"))
            {
                Right.Enabled = true;
            }

            if (e.KeyCode.ToString().Equals("Up"))
            {
                Up.Enabled = true;
            }

            if (e.KeyCode.ToString().Equals("Down"))
            {
                Down.Enabled = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Left"))
            {
                Left.Enabled = false;
            }

            if (e.KeyCode.ToString().Equals("Right"))
            {
                Right.Enabled = false;
            }

            if (e.KeyCode.ToString().Equals("Up"))
            {               
                Up.Enabled = false;
            }

            if (e.KeyCode.ToString().Equals("Down"))
            {
                Down.Enabled = false;
            }


            if (e.KeyCode.ToString().Equals("Space"))
            {
                ShootLazer(player.Location.X+20, player.Location.Y-80);
                lazerSound.Play();
            }
        }

        int newX = 0;
        int newY = 0;
        int dX = 10;
        int dY = 10;
                
        private void Up_Tick(object sender, EventArgs e)
        {
            if (player.Location.Y > 0)
            {
                newY = player.Location.Y - dY;
                player.Location = new Point(player.Location.X, newY);
            }
        }

        private void Down_Tick(object sender, EventArgs e)
        {
            if (player.Location.Y < this.Height - 200)
            {
                newY = player.Location.Y + dY;
                player.Location = new Point(player.Location.X, newY);
            }
        }

        private void Left_Tick(object sender, EventArgs e)
        {
            if (player.Location.X > 0)
            {
                newX = player.Location.X - dX;
                player.Location = new Point(newX, player.Location.Y);
            }
        }

        private void Right_Tick(object sender, EventArgs e)
        {
            if (player.Location.X < this.Width - 115)
            {
                newX = player.Location.X + dX;
                player.Location = new Point(newX, player.Location.Y);
            }
        }

        int progress = 100;

        void SerializeScores(int[] scores)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("topScores.ser",
                FileMode.OpenOrCreate, FileAccess.Write);
            formatter.Serialize(stream, topScores);
            stream.Close();
        }

        int[] DeserializeScores()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("topScores.ser", FileMode.Open, FileAccess.Read);
            topScores = (int[])formatter.Deserialize(stream);
            return topScores;
        }

        private void IsPlayerAlive()
        {
            if (PlayerShields > 0 || time > 0)
            {
                progressBarShields.Value = PlayerShields;
            }
            else if (PlayerShields == 0 || time == 0)
            {
                bgMusicOut.Stop();
                Array.Sort(topScores);
                topScores[0] = score;
                Array.Sort(topScores);
                Array.Reverse(topScores);
                SerializeScores(topScores);                   
                gameTimer.Stop();
                Timer.Stop();
                Left.Stop();
                Right.Stop();
                Up.Stop();
                Down.Stop();
                lazersTimer.Stop();
                enemyLocation.Stop();
                enemyLazerManager.Stop();
                GameOver form = new GameOver();
                form.ShowDialog();
                this.Hide();
            }
        }

        private PictureBox LazerCreate()
        {
            PictureBox lazer = new PictureBox();
            
            lazer.ImageLocation = "874fa0e5bf7b854-removebg-preview.png";
            lazers.Add(lazer);
            lazer.Size = new Size(20, 50);
            lazer.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(lazer);
            return lazer;
        }

        void StarsEffect()
        {
            foreach (Control j in this.Controls)
            {
                if (j is Label && j.Tag == "star")
                {
                    j.SendToBack();
                    j.Top += 1;
                    if (j.Top > 900)
                    {
                        j.Top = 0;
                    }
                }
            }
        }

        private PictureBox EnemyLazerCreate()
        {
            PictureBox lazer = new PictureBox();

            lazer.ImageLocation = "rocket-laser-beam-pixel-art-maker-229033-removebg-preview.png";
            enemyLazers.Add(lazer);
            lazer.Size = new Size(60, 100);
            lazer.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(lazer);
            return lazer;
        }

        private void ShootLazer(int startX, int startY)
        {
            LazerCreate().Location = new Point(startX, startY);
        }

        private void ShootEnemyLazer(int startX, int startY)
        {
            EnemyLazerCreate().Location = new Point(startX, startY);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            player.BringToFront();
            enemy.BringToFront();
            IsPlayerAlive();
            labelScore.Text = "score : " + Score;
        }

        bool check = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            StarsEffect();
            for (int i = 0; i < lazers.Count; i++)
            {
                lazers[i].Location = new Point(lazers[i].Location.X, lazers[i].Location.Y - 10);
                enemy.ImageLocation = "enemy.png";
                if (lazers[i].Bounds.IntersectsWith(enemy.Bounds))
                {
                    check = true;
                    spriteChange.Start();
                    Score += 10;
                    Controls.Remove(lazers[i]);
                    lazers.RemoveAt(i);                    
                }                  
            }
        }

        private void enemyLocation_Tick(object sender, EventArgs e)
        {
            int randomX = random.Next(Width - enemy.Width);
            if (randomX > enemy.Location.X)
            {
                for (int dx = enemy.Location.X; dx <= randomX; dx++)
                {
                    enemy.Location = new Point(dx, enemy.Location.Y);
                }
            }
            else if (randomX < enemy.Location.X)
            {
                for (int dx = enemy.Location.X; dx > randomX; dx--)
                {
                    enemy.Location = new Point(dx, enemy.Location.Y);
                }
            }
            ShootEnemyLazer(enemy.Location.X, enemy.Location.Y);
        }

        private void enemyLazerManager_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemyLazers.Count; i++)
            {
                enemyLazers[i].Location = new Point(enemyLazers[i].Location.X, enemyLazers[i].Location.Y + 10);
                if (enemyLazers[i].Bounds.IntersectsWith(player.Bounds))
                {
                    progress -= 5;
                    if (progress >= 0)
                        PlayerShields -= 5;
                    else
                    {
                        bgMusicOut.Stop();
                        Array.Sort(topScores);
                        topScores[0] = score;
                        Array.Sort(topScores);
                        Array.Reverse(topScores);
                        SerializeScores(topScores);                        
                        gameTimer.Stop();
                        Timer.Stop();
                        Left.Stop();
                        Right.Stop();
                        Up.Stop();
                        Down.Stop();
                        lazersTimer.Stop();
                        enemyLocation.Stop();
                        enemyLazerManager.Stop();
                        GameOver form = new GameOver();
                        form.ShowDialog();
                        this.Hide();
                    }
                    Controls.Remove(enemyLazers[i]);
                    enemyLazers.RemoveAt(i);
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time -= 1;
            if (time < 0)
            { 
                bgMusicOut.Stop();
                Array.Sort(topScores);
                topScores[0] = score;
                Array.Sort(topScores);
                Array.Reverse(topScores);
                SerializeScores(topScores);
                gameTimer.Stop();
                Timer.Stop();
                Left.Stop();
                Right.Stop();
                Up.Stop();
                Down.Stop();
                lazersTimer.Stop();
                enemyLocation.Stop();
                enemyLazerManager.Stop();
                GameOver form = new GameOver();
                form.ShowDialog();
                this.Hide();
            }
            timerLabel.Text = "time : " + time;            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            playPictureBox.BringToFront();
            gameTimer.Start();
            Timer.Start();
            Left.Start();
            Right.Start();
            Up.Start();
            Down.Start();
            lazersTimer.Start();
            enemyLocation.Start();
            enemyLazerManager.Start();
            playPictureBox.Hide();
        }

        private void spriteChange_Tick(object sender, EventArgs e)
        {
            if (check == true)
            { 
                enemy.ImageLocation = "enemy_hit.png";
                check = false;
                spriteChange.Stop();
            }
            else 
            {
                enemy.ImageLocation = "enemy.png";
                check = false;
                spriteChange.Stop();
            }
        }
    }

}
