using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcadeValeriaV
{
    public partial class Form1 : Form
    {
        //declare global variables
        int counter = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (counter == 4)
            {
                counter = 1;
                pictureBox4.Location = new Point(pictureBox4.Location.X, -75);
                tmrFourthMove.Start();

            }
            else
            {
                MessageBox.Show("U lost");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (counter == 1)
            {
                counter++;
                pictureBox1.Location = new Point(pictureBox1.Location.X, -75);
                tmrFirstMove.Start();
                
            }
            else
            {
                MessageBox.Show("U lost");
            }
        }

        private void moveTiles(ref PictureBox pic1, ref PictureBox pic2, ref PictureBox pic3)
        {
            pic1.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 10);
            pic2.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + 10);
            pic3.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y + 10);
        }
        private void tmrFirstMove_Tick( object sender, EventArgs e)//ref PictureBox pic1, ref PictureBox pic2, ref PictureBox
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X,pictureBox1.Location.Y + 10);
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 10);
            pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + 10);
            pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y + 10);
            if (pictureBox1.Location.Y >=470)
            {
                tmrFirstMove.Stop();
                MessageBox.Show("Ulose");
            }
            else if (pictureBox2.Location.Y >= 470)
            {
                tmrFirstMove.Stop();
                MessageBox.Show("Ulose");
            }
            else if (pictureBox3.Location.Y >= 470)
            {
                tmrFirstMove.Stop();
                MessageBox.Show("Ulose");
            }
            else if (pictureBox4.Location.Y >= 470)
            {
                tmrFirstMove.Stop();
                MessageBox.Show("Ulose");
            }
        }
        private void tmrThirdMove_Tick(object sender, EventArgs e)
        {
            
        }
        private void tmrFourthMove_Tick(object sender, EventArgs e)
        {

        }
        private void tmrSecondMove_Tick(object sender, EventArgs e)
        {
            /*pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 10);
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
            pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + 10);
            pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y + 10);
            
            if (pictureBox3.Location.Y >= 342)
            {
                Console.WriteLine("Stop");
                tmrSecondMove.Stop();
            }
            else
            {
               if (pictureBox2.Location.Y >= 470)
               {
                    tmrSecondMove.Stop();
                    MessageBox.Show("U lost");
               }
               else
                {

                }
            
            else if (pictureBox2.Location.Y != -75)
            {
                tmrSecondMove.Stop();
                MessageBox.Show("U lost");
            }*/
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (counter == 2)
            {
                counter++;
                pictureBox2.Location = new Point(pictureBox2.Location.X, -75);
                tmrFirstMove.Start();
                //tmrFirstMove.Start(ref pictureBox1, ref pictureBox3, ref pictureBox4);

            }
            else
            {
                MessageBox.Show("U lost");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (counter == 3)
            {
                counter++;
                pictureBox3.Location = new Point(pictureBox3.Location.X, -75);
                tmrFirstMove.Start();
                //tmrFirstMove.Start(ref pictureBox1, ref pictureBox3, ref pictureBox4);

            }
            else
            {
                MessageBox.Show("U lost");
            }
        }

       
    }
}
