using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ArcadeValeriaV
{
    public partial class Form1 : Form
    {
        //declare global variables
        //integers variables
        int counter = 1;
        int speed = 20;
        int score = 0;
        int soundCounter = 1;
        //lists
        List<int>arrayPosition = new List<int>();

        //sound variabels 
        SoundPlayer sound1 = new SoundPlayer();
        SoundPlayer sound2 = new SoundPlayer();
        SoundPlayer sound3 = new SoundPlayer();
        SoundPlayer sound4 = new SoundPlayer();
        SoundPlayer sound5 = new SoundPlayer();
        SoundPlayer sound6 = new SoundPlayer();
        SoundPlayer sound7 = new SoundPlayer();
        SoundPlayer sound8 = new SoundPlayer();
        SoundPlayer sound9 = new SoundPlayer();
        SoundPlayer sound10 = new SoundPlayer();
        SoundPlayer sound11 = new SoundPlayer();
        SoundPlayer sound12 = new SoundPlayer();
        SoundPlayer sound13 = new SoundPlayer();
        SoundPlayer sound14 = new SoundPlayer();
        SoundPlayer sound15 = new SoundPlayer();
        SoundPlayer sound16 = new SoundPlayer();
        SoundPlayer sound17 = new SoundPlayer();
        SoundPlayer sound18 = new SoundPlayer();
        SoundPlayer sound19 = new SoundPlayer();
        SoundPlayer sound20 = new SoundPlayer();
        SoundPlayer sound21 = new SoundPlayer();
        SoundPlayer sound22 = new SoundPlayer();
        SoundPlayer sound23 = new SoundPlayer();
        SoundPlayer sound24 = new SoundPlayer();
        SoundPlayer sound25 = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();
            //////////////////////////
            //LIST - Add elements
            /////////////////////////
            arrayPosition.Add(303) ;
            arrayPosition.Add(202);
            arrayPosition.Add(101);
            arrayPosition.Add(0);
            /////////////////////////
            //Import sound files
            sound1.SoundLocation = "0.wav";
            sound2.SoundLocation = "1.wav";
            sound3.SoundLocation = "2.wav";
            sound4.SoundLocation = "3.wav";
            sound5.SoundLocation = "4.wav";
            sound6.SoundLocation = "5.wav";
            sound7.SoundLocation = "6.wav";
            sound8.SoundLocation = "7.wav";
            sound9.SoundLocation = "8.wav";
            sound10.SoundLocation = "9.wav";
            sound11.SoundLocation = "10.wav";
            sound12.SoundLocation = "11.wav";
            sound13.SoundLocation = "12.wav";
            sound14.SoundLocation = "13.wav";
            sound15.SoundLocation = "14.wav";
            sound16.SoundLocation = "15.wav";
            sound17.SoundLocation = "16.wav";
            sound18.SoundLocation = "17.wav";
            sound19.SoundLocation = "18.wav";
            sound20.SoundLocation = "19.wav";
            sound21.SoundLocation = "20.wav";
            sound22.SoundLocation = "21.wav";
            sound23.SoundLocation = "22.wav";
            sound24.SoundLocation = "23.wav";
            sound25.SoundLocation = "24.wav";
        }

        //Procedure: PlayMusic
        //Input: void
        //Output: void
        //Description: this procedure checks what sound should be played
        private void PlayMusic()
        {
            if (soundCounter == 1)
            {
                sound1.Play();
                soundCounter++;
            }
            else if (soundCounter == 2)
            {
                sound2.Play();
                soundCounter++;
            }
            else if (soundCounter == 3)
            {
                sound3.Play();
                soundCounter++;
            }
            else if (soundCounter == 4)
            {
                sound4.Play();
                soundCounter++;
            }
            else if (soundCounter == 5)
            {
                sound5.Play();
                soundCounter++;
            }
            else if (soundCounter == 6)
            {
                sound6.Play();
                soundCounter++;
            }
            else if (soundCounter == 7)
            {
                sound7.Play();
                soundCounter++;
            }
            else if (soundCounter == 8)
            {
                sound8.Play();
                soundCounter++;
            }
            else  if (soundCounter == 9)
            {
                sound9.Play();
                soundCounter++;
            }
            else if (soundCounter == 10)
            {
                sound10.Play();
                soundCounter++;
            }
            else if (soundCounter == 11)
            {
                sound11.Play();
                soundCounter++;
            }
            else if (soundCounter == 12)
            {
                sound12.Play();
                soundCounter++;
            }
            else if (soundCounter == 13)
            {
                sound13.Play();
                soundCounter++;
            }
            else if (soundCounter == 14)
            {
                sound14.Play();
                soundCounter++;
            }
            else if (soundCounter == 15)
            {
                sound15.Play();
                soundCounter++;
            }
            else if (soundCounter == 16)
            {
                sound16.Play();
                soundCounter++;
            }
            else if (soundCounter == 17)
            {
                sound17.Play();
                soundCounter++;
            }
            else if (soundCounter == 18)
            {
                sound18.Play();
                soundCounter++;
            }
            else if (soundCounter == 19)
            {
                sound19.Play();
                soundCounter++;
            }
            else if (soundCounter == 20)
            {
                sound20.Play();
                soundCounter++;
            }
            else if (soundCounter == 21)
            {
                sound21.Play();
                soundCounter++;
            }
            else if (soundCounter == 22)
            {
                sound22.Play();
                soundCounter++;
            }
            else if (soundCounter == 23)
            {
                sound23.Play();
                soundCounter++;
            }
            else if (soundCounter == 24)
            {
                sound24.Play();
                soundCounter++;
            }
            else if (soundCounter == 25)
            {
                sound25.Play();
                soundCounter = 1;
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //check if the rights button was pressed
            if (counter == 4)
            {
                //play the sound
                PlayMusic();
                //declare local variables
                int xPosition, index;
                Random generateIndex = new Random();
                //Generate a random index
                index = generateIndex.Next(0, arrayPosition.Count);
                //get the elemnt from the list
                xPosition = arrayPosition[index];
                //set the counter to be equal to 1
                counter = 1;
                //increment the score
                score++;
                //set the new position of the tile
                pictureBox4.Location = new Point(xPosition, pictureBox3.Location.Y - 140);
                //start the timer
                tmrFourthMove.Start();
                //check if the speed should be incremented
                if(score == 5)
                {
                    speed = speed + 10;
                }
                else if (score == 20)
                {
                    speed = speed + 10;
                }

            }
            //if the user presses the wrong tile, stop the timer and display the "You lose" text
            else
            {
                tmrFirstMove.Stop();
                MessageBox.Show("U lost");
   
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //check if the rights button was pressed
            if (counter == 1)
            {
                //play the sound
                PlayMusic();
                //declare local variables
                int xPosition, index;
                Random generateIndex = new Random();
                //Generate a random index
                index = generateIndex.Next(0, arrayPosition.Count);
                //get the elemnt from the list
                xPosition = arrayPosition[index];
                //set the counter to be equal to 1
                counter++;
                //increment the score
                score++;
                //set the new position of the tile
                pictureBox1.Location = new Point(xPosition, pictureBox4.Location.Y - 140);
                //start the timer
                tmrFirstMove.Start();
                //check if the speed should be incremented
                if (score == 5)
                {
                    speed = speed + 10;
                }
                else if (score == 20)
                {
                    speed = speed + 10;
                }

            }
            //if the user presses the wrong tile, stop the timer and display the "You lose" text
            else
            {
                tmrFirstMove.Stop();
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
            pictureBox1.Location = new Point(pictureBox1.Location.X,pictureBox1.Location.Y + speed);
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + speed);
            pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + speed);
            pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y + speed);

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
                //check if the rights button was pressed
                if (counter == 2)
                {
                    //play the sound
                    PlayMusic();
                    //declare local variables
                    int xPosition, index;
                    Random generateIndex = new Random();
                    //Generate a random index
                    index = generateIndex.Next(0, arrayPosition.Count);
                    //get the elemnt from the list
                    xPosition = arrayPosition[index];
                    //set the counter to be equal to 1
                    counter++;
                    //increment the score
                    score++;
                    //set the new position of the tile
                    pictureBox2.Location = new Point(xPosition, pictureBox1.Location.Y - 140);
                    //start the timer
                    tmrSecondMove.Start();
                    //check if the speed should be incremented
                    if (score == 5)
                    {
                        speed = speed + 10;
                    }
                    else if (score == 20)
                    {
                        speed = speed + 10;
                    }

                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (counter == 3)
            {
                //play the sound
                PlayMusic();

                int xPosition, index;
                Random generateIndex = new Random();
                index = generateIndex.Next(0, arrayPosition.Count);
                xPosition = arrayPosition[index];
                Console.WriteLine(xPosition);

                ////////////////////
                counter++;
                score++;
                pictureBox3.Location = new Point(xPosition, pictureBox2.Location.Y - 140);
                tmrFirstMove.Start();
                //tmrFirstMove.Start(ref pictureBox1, ref pictureBox3, ref pictureBox4);
                if (score == 5)
                {
                    speed = speed + 10;
                    
                }
                else if (score == 20)
                {
                    speed = speed + 10;
                }

            }
            else
            {
                tmrFirstMove.Stop();
                MessageBox.Show("U lost");
            }
        }

       
    }
}
