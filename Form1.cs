using System;
using System.Drawing;
using System.Windows.Forms;

namespace BulbOnOff
{
    public partial class BulbOnOff : Form
    {

        private bool isImageDisplayed = true;

        public BulbOnOff()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isImageDisplayed)
            {
                pictureBox1.Image = Image.FromFile(@"Images\offButton.jpg");
                pictureBox2.Image = Image.FromFile(@"Images\bulbOff.jpg");
                serialPort1.Write("L");
                isImageDisplayed = false;
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"Images\onButton.jpg");
                pictureBox2.Image = Image.FromFile(@"Images\bulbOn.jpg");
                serialPort1.Write("H");
                isImageDisplayed = true;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BulbOnOff_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
