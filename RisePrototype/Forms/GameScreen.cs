using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RisePrototype
{
    public partial class GameScreen : Form
    {
        private Random rnd = new Random();

        public GameScreen()
        {
            Sg.LoginForm.Hide();
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Sg.Initiate();
            //Sg.Reference.Child("Image").AsObservable<string>().Subscribe( i => {

            //    Invoke((MethodInvoker)delegate {

            //        pictureBox1.ImageLocation = i.Object;
            //    });

            //});
            timer1.Interval = 60;
            timer1.Start();
        }

        private void GameScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));


            pictureBox1.BackColor = randomColor;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Sg.StringPath != pictureBox1.ImageLocation)
            {
                pictureBox1.ImageLocation = Sg.StringPath;
            }
        }
    }
}
