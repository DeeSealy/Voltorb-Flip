using Microsoft.VisualBasic;
using System.Media;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Net.WebRequestMethods;
using System.Diagnostics;

namespace Voltorb_Flip
{
    public partial class formGame : Form
    {   

        //2d array, 1st is row, 2nd is column
        int[,] result = new int [5,5];

        int pointTotal = 0;

        int linePointTotal = 0;
        int[] intVoltorbRow = new int [5];
        int[] intVoltorbCol = new int [5];


        System.Windows.Forms.Button[,] btnArray = new System.Windows.Forms.Button [5,5];
        System.Windows.Forms.Label[] lblArrayRow = new System.Windows.Forms.Label [5];
        System.Windows.Forms.Label[] lblArrayCol = new System.Windows.Forms.Label [5];
        System.Windows.Forms.Label[] lblArrayVoltorbRow = new System.Windows.Forms.Label[5];
        System.Windows.Forms.Label[] lblArrayVoltorbCol = new System.Windows.Forms.Label[5];
        System.Windows.Forms.PictureBox[] picVoltorbCol = new System.Windows.Forms.PictureBox[5];
        System.Windows.Forms.PictureBox[] picVoltorbRow = new System.Windows.Forms.PictureBox[5];



        public formGame()
        {

            InitializeComponent();

        }


        //creates buttons, labels, pictures and stores numbers
        public void start()
        {
            Random randomizer = new Random();
            int[,] intBtnNumber = new int[5, 5];

            int lblXCoordinateVoltorbCol = 525;
            int lblYCoordinateVoltorbCol = 135;

            int lblXCoordinateVoltorbRow = 125;
            int lblYCoordinateVoltorbRow = 540;


            int lblXCoordinateRow = 125;
            int lblYCoordinateRow = 520;

            int lblXCoordinateCol = 525;
            int lblYCoordinateCol = 455;

            int picXCoordVoltorbCol = 540;
            int picYCoordVoltorbCol = 130;

            int picXCoordVoltorbRow = 140;
            int picYCoordVoltorbRow = 535;

            //voltorb image creation 
            for (int i = 0; i < 5; i++)
            {


                picVoltorbCol[i] = new PictureBox();
                picVoltorbCol[i].Location = new Point(picXCoordVoltorbCol, picYCoordVoltorbCol); 
                picVoltorbCol[i].Width = 31;
                picVoltorbCol[i].Height = 28;
                picVoltorbCol[i].Image = Image.FromFile("Voltorb.gif");
                picVoltorbCol[i].SizeMode = PictureBoxSizeMode.Zoom;
                this.Controls.Add(picVoltorbCol[i]);
                picYCoordVoltorbCol += 85;
                

            }

            for (int i = 0; i < 5; i++)
            {


                picVoltorbRow[i] = new PictureBox();
                picVoltorbRow[i].Location = new Point(picXCoordVoltorbRow, picYCoordVoltorbRow);
                picVoltorbRow[i].Width = 31;
                picVoltorbRow[i].Height = 28;
                picVoltorbRow[i].Image = Image.FromFile("Voltorb.gif");
                picVoltorbRow[i].SizeMode = PictureBoxSizeMode.Zoom;
                this.Controls.Add(picVoltorbRow[i]);
                picXCoordVoltorbRow += 85;


            }


            //label creation attempt #2

            for (int i = 0; i < 5; i++)
            {

                lblArrayVoltorbCol[i] = new Label();
                lblArrayVoltorbCol[i].Location = new Point(lblXCoordinateVoltorbCol, lblYCoordinateVoltorbCol);
                lblArrayVoltorbCol[i].Width = 30;
                lblArrayVoltorbCol[i].Height = 30;
                lblArrayVoltorbCol[i].Text = "0";
                this.Controls.Add(lblArrayVoltorbCol[i]);
                lblYCoordinateVoltorbCol += 85;
                

            }

            for (int i = 0; i < 5; i++)
            {

                lblArrayVoltorbRow[i] = new Label();
                lblArrayVoltorbRow[i].Location = new Point(lblXCoordinateVoltorbRow, lblYCoordinateVoltorbRow);
                lblArrayVoltorbRow[i].Width = 30;
                lblArrayVoltorbRow[i].Height = 30;
                lblArrayVoltorbRow[i].Text = "0";
                this.Controls.Add(lblArrayVoltorbRow[i]);
                lblXCoordinateVoltorbRow += 85;


            }




            for (int i = 0; i < 5; i++)
            {

                lblArrayRow[i] = new Label();
                lblArrayRow[i].Location = new Point(lblXCoordinateRow, lblYCoordinateRow);
                lblArrayRow[i].Width = 30;
                lblArrayRow[i].Height = 30;
                lblArrayRow[i].Text = "0";
                this.Controls.Add(lblArrayRow[i]);
                lblXCoordinateRow += 85;



            }
            

            for (int i = 0; i < 5; i++)
            {

                lblArrayCol[i] = new Label();
                lblArrayCol[i].Location = new Point(lblXCoordinateCol, lblYCoordinateCol);
                lblArrayCol[i].Width = 30;
                lblArrayCol[i].Height = 30;
                lblArrayCol[i].Text = "0";
                this.Controls.Add(lblArrayCol[i]);
                lblYCoordinateCol -= 85;

            }

            lblXCoordinateRow = 125;
            lblYCoordinateRow = 520;

            lblXCoordinateCol = 525;
            lblYCoordinateCol = 455;

            int xCoordinate = 90;
            int yCoordinate = 85;


            for (int i = 0; i < 5; i++)
            {


                for (int j = 0; j < 5; j++)
                {

                    //creates the buttons
                    btnArray[i, j] = new Button();
                    btnArray[i, j].Location = new Point(xCoordinate, yCoordinate);


                    btnArray[i, j].Width = 85;
                    btnArray[i, j].Height = 85;
                    btnArray[i, j].Text = "?";
                    this.Controls.Add(btnArray[i, j]);
                    xCoordinate += 85;
                    btnArray[i, j].Click += new EventHandler(this.Box_Click);

                    //set RNG for buttons
                    result[i, j] = randomizer.Next(4);

                    //voltorb count
                    if (result[i, j] == 0)
                    {

                        intVoltorbRow[i]++; 

                    }
                    if (result[i,j] == 0)
                    {

                        intVoltorbCol[j]++;

                    }


                    //assign rng totals to labels
                    linePointTotal = Convert.ToInt32(lblArrayRow[i].Text);
                    lblArrayRow[i].Text = Convert.ToString(linePointTotal + result[i, j]);

                    linePointTotal = Convert.ToInt32(lblArrayCol[4 - j].Text);
                    lblArrayCol[4 - j].Text = Convert.ToString(linePointTotal + result[i, j]);

                    lblArrayVoltorbCol[j].Text = Convert.ToString(intVoltorbCol[j]);

                    lblArrayVoltorbRow[i].Text = Convert.ToString(intVoltorbRow[i]);


                }

                xCoordinate = 90;
                yCoordinate += 85;



            }



        }
        


        void Box_Click(object sender, EventArgs e)
        {
            //Determines which panel is clicked
            int xPosition;
            int yPosition;

            Button clickedButton = sender as Button;
            Point point = clickedButton.Location;

            xPosition = (point.X - 90) / 85; 
            yPosition = (point.Y - 80) / 85;

            //reveals panel's determined number
            clickedButton.Text = Convert.ToString(result[xPosition, yPosition]);

                //adds to point total
                if ((Convert.ToInt32(result[xPosition, yPosition]) == 1 || Convert.ToInt32(result[xPosition, yPosition]) == 2) || Convert.ToInt32(result[xPosition, yPosition]) == 3)
                { 

                    pointTotal = pointTotal + result[xPosition, yPosition];
                    lblPointTotal.Text = Convert.ToString(pointTotal);          

                }
                else
                {

                MessageBox.Show("BZZ! You hit a Voltorb. Your point total was " + pointTotal);
                reset();

                }
        }

        public void reset()
        {

            try
            {
                //remove buttons and labels
                foreach (Button b in btnArray)
                {

                    this.Controls.Remove(b);

                }
                foreach (Label l in lblArrayRow)
                {

                    this.Controls.Remove(l);

                }
                foreach (Label l in lblArrayCol)
                {

                    this.Controls.Remove(l);

                }

                foreach (Label l in lblArrayVoltorbCol)
                {

                    this.Controls.Remove(l);

                }

                foreach (Label l in lblArrayVoltorbRow)
                {

                    this.Controls.Remove(l);

                }

                foreach (Label l in lblArrayVoltorbCol)
                {

                    this.Controls.Remove(l);

                }

                foreach (Label l in lblArrayRow)
                {

                    this.Controls.Remove(l);

                }
                foreach (Label l in lblArrayCol)
                {

                    this.Controls.Remove(l);

                }
                foreach (PictureBox p in picVoltorbCol)
                {

                    this.Controls.Remove(p);

                }
                foreach (PictureBox p in picVoltorbRow)
                {

                    this.Controls.Remove(p);

                }

                foreach (int i in intVoltorbRow)
                {

                    intVoltorbRow[i] = 0;

                }
                
                foreach (int i in intVoltorbCol)
                {

                    intVoltorbCol[i] = 0;

                }

                intVoltorbCol = new int[5];
                intVoltorbRow = new int[5];

                //starts over and reverts Point Total
                start();

                pointTotal = 0;
                lblPointTotal.Text = Convert.ToString(pointTotal);

            }
            catch
            {

                MessageBox.Show("You can't reset until you start!");

            }


        }


        private void btnStart_Click(object sender, EventArgs e)
        {

            start();
            this.Controls.Remove(btnStart);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            reset();

        }

        private void Pl(object sender, EventArgs e)
        {

        }


        private void btnThanks_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Special thanks to Butterfree/Dragonfree/antialiasis for use of their guide.\n\n\nThanks to Math, Ben the Bee and Kevin Bourque, Esquire for coding help and TT for the idea");
        }

        static void voltorbPicture()
        {



        }
    }
}