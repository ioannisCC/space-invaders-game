using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Media;

namespace game
{
    public partial class GameOver : Form
    {
        int[] topScores = new int[10];
        SoundPlayer gameOverSound;
        public GameOver()
        {
            InitializeComponent();
            gameOverSound = new SoundPlayer("game-over-arcade-6435.wav");
            gameOverSound.Play();
        }

        void DeserializeScores()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("topScores.ser", FileMode.Open, FileAccess.Read);
            topScores = (int[])formatter.Deserialize(stream);
            string toDisplay = string.Join(Environment.NewLine, topScores);
            MessageBox.Show(toDisplay);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeserializeScores();
            Application.Exit();
        }
    }
}
