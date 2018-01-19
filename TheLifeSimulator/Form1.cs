using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheLifeSimulator
{
    public partial class mainMenu : Form
    {
        int scene = 1;
        string username;
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown;
        int drawX = 728;
        int drawY = 165;
        SolidBrush mainCharacterOne = new SolidBrush(Color.Tan);
        SolidBrush mainCharacterTwo = new SolidBrush(Color.Black);
        SolidBrush mainCharacterThr = new SolidBrush(Color.LightYellow);
        SolidBrush mainCharacterFou = new SolidBrush(Color.SandyBrown);
        int bankSavings;
        Graphics onScreen, offScreen;
        Bitmap bm;
        Rectangle mainCharacter;

        public mainMenu()
        {
            InitializeComponent();

            bankmoneyLabel.Visible = false;
            bankLabel.Visible = false;
            workperfLabel.Visible = false;
            hungerlabel.Visible = false;
            hygienelabel.Visible = false;
            loolabel.Visible = false;
            entertainmentlabel.Visible = false;
            imageO.Visible = false;
            imageT.Visible = false;
            titleLabel.Visible = true;
            startLabel.Visible = true;
            howtoplaylabel.Visible = true;
            instructionlabel.Visible = true;
            nameinput.Visible = false;

            titleLabel.Text = "Game Menu";
            startLabel.Text = "Start Gameplay";
            howtoplaylabel.Text = "How To Play";
            instructionlabel.Text = "Press Y to start, Press U for how to play";
            //startLabel.Location = new Point(100, 100);
            //startLabel.Text = "H";

            onScreen = this.CreateGraphics();
            bm = new Bitmap(this.Width, this.Height);
            offScreen = Graphics.FromImage(bm);
        }

        Pen draw = new Pen(Color.Black, 3);
        SolidBrush fill = new SolidBrush(Color.White);

        public void needsBar(int needsX, int needsY)
        {
            //creating method to create the needsbar
            Graphics Draw = instructionlabel.CreateGraphics();
            Pen drawNeeds = new Pen(Color.Black, 3);
            SolidBrush fillNeeds = new SolidBrush(Color.LightGreen);
            Draw.DrawRectangle(drawNeeds, needsX, needsY, 120, 20);
            Draw.FillRectangle(fillNeeds, needsX, needsY, 120, 20);
        }

        public void workperfBar(int workX, int workY)
        {
            //creating method to create the needsbar
            Graphics Draw = instructionlabel.CreateGraphics();
            Pen drawNeeds = new Pen(Color.Black, 3);
            SolidBrush fillNeeds = new SolidBrush(Color.Yellow);
            Draw.DrawRectangle(drawNeeds, workX, workY, 120, 20);
            Draw.FillRectangle(fillNeeds, workX, workY, 0, 20);

        }
        

        private void mainMenu_Paint(object sender, PaintEventArgs e)
        {
            if (scene == 10)
            {
                Pen draw = new Pen(Color.Black, 3);
                SolidBrush fill = new SolidBrush(Color.Black);
                e.Graphics.DrawRectangle(draw, 0, 0, 12, 390);
                e.Graphics.FillRectangle(fill, 0, 0, 12, 390);
                e.Graphics.DrawRectangle(draw, 0, 0, 1044, 5);
                e.Graphics.FillRectangle(fill, 0, 0, 1044, 5);

                e.Graphics.DrawRectangle(draw, 758, 0, 12, 390);
                e.Graphics.FillRectangle(fill, 758, 0, 12, 390);
                e.Graphics.DrawRectangle(draw, 0, 390, 1044, 8);
                e.Graphics.FillRectangle(fill, 0, 390, 1044, 8);

                //  onScreen.DrawImage(bm, 0, 0);
                //  offScreen.Clear(Color.Black);

                //drawhouse
                //Room 1

                fill = new SolidBrush(Color.SaddleBrown);
                e.Graphics.DrawRectangle(draw, 32, 5, 30, 40);
                e.Graphics.FillRectangle(fill, 32, 5, 30, 40);
                e.Graphics.DrawRectangle(draw, 212, 5, 30, 40);
                e.Graphics.FillRectangle(fill, 212, 5, 30, 40);
                fill = new SolidBrush(Color.SaddleBrown);
                e.Graphics.DrawRectangle(draw, 47, 185, 180, 40);
                e.Graphics.FillRectangle(fill, 47, 185, 180, 40);
                fill = new SolidBrush(Color.Beige);
                e.Graphics.DrawRectangle(draw, 82, 15, 50, 20);
                e.Graphics.FillRectangle(fill, 82, 15, 50, 20);
                e.Graphics.DrawRectangle(draw, 142, 15, 50, 20);
                e.Graphics.FillRectangle(fill, 142, 15, 50, 20);

                //interactiveObjects(62, 45, 150, 120);//design/patterns needeed
                fill = new SolidBrush(Color.Coral);
                e.Graphics.FillRectangle(fill, 62, 45, 150, 120);
                e.Graphics.DrawRectangle(draw, 62, 45, 150, 120);

                //interactiveObjects(62, 45, 150, 10);//Need to be colored
                fill = new SolidBrush(Color.LightBlue);
                e.Graphics.FillRectangle(fill, 62, 45, 150, 10);
                e.Graphics.DrawRectangle(draw, 62, 45, 150, 10);

                //interactiveObjects(62, 55, 150, 80);
                fill = new SolidBrush(Color.Coral);
                e.Graphics.FillRectangle(fill, 62, 55, 150, 80);
                e.Graphics.DrawRectangle(draw, 62, 55, 150, 80);
                //Room 2
                //interactiveObjects(17, 290, 60, 100);
                fill = new SolidBrush(Color.White);
                e.Graphics.FillRectangle(fill, 17, 290, 60, 100);
                e.Graphics.DrawRectangle(draw, 17, 290, 60, 100);

                fill = new SolidBrush(Color.LightGray);
                e.Graphics.FillRectangle(fill, 22, 305, 50, 70);
                e.Graphics.DrawRectangle(draw, 22, 305, 50, 70);
                fill = new SolidBrush(Color.White);
                e.Graphics.FillRectangle(fill, 202, 230, 60, 40);
                e.Graphics.DrawRectangle(draw, 202, 230, 60, 40);
                fill = new SolidBrush(Color.LightGray);
                e.Graphics.FillRectangle(fill, 207, 245, 50, 20);
                e.Graphics.DrawRectangle(draw, 207, 245, 50, 20);

                //interactiveObjects(207, 350, 50, 30);
                fill = new SolidBrush(Color.White);
                e.Graphics.FillRectangle(fill, 207, 350, 50, 30);
                e.Graphics.DrawRectangle(draw, 207, 350, 50, 30);

                //interactiveObjects(202, 380, 60, 10);
                fill = new SolidBrush(Color.White);
                e.Graphics.FillRectangle(fill, 202, 380, 60, 10);
                e.Graphics.DrawRectangle(draw, 202, 380, 60, 10);

                fill = new SolidBrush(Color.LightGray);
                e.Graphics.FillRectangle(fill, 212, 360, 40, 20);
                e.Graphics.DrawRectangle(draw, 212, 360, 40, 20);
                fill = new SolidBrush(Color.White);
                e.Graphics.FillRectangle(fill, 230, 240, 4, 8);
                e.Graphics.DrawRectangle(draw, 230, 240, 4, 8);
                e.Graphics.FillRectangle(fill, 45, 300, 4, 8);
                e.Graphics.DrawRectangle(draw, 45, 300, 4, 8);
                e.Graphics.DrawEllipse(draw, 207, 240, 4, 4);
                e.Graphics.DrawEllipse(draw, 253, 240, 4, 4);
                e.Graphics.DrawEllipse(draw, 22, 300, 4, 4);
                e.Graphics.DrawEllipse(draw, 68, 300, 4, 4);
                //Room 3
                fill = new SolidBrush(Color.Linen);
                e.Graphics.FillRectangle(fill, 308, 340, 50, 50);
                e.Graphics.FillRectangle(fill, 358, 340, 50, 50);
                e.Graphics.FillRectangle(fill, 408, 340, 50, 50);
                e.Graphics.FillRectangle(fill, 458, 340, 50, 50);
                e.Graphics.FillRectangle(fill, 658, 340, 50, 50);

                e.Graphics.DrawRectangle(draw, 308, 340, 50, 50);
                e.Graphics.DrawRectangle(draw, 358, 340, 50, 50);
                e.Graphics.DrawRectangle(draw, 408, 340, 50, 50);
                e.Graphics.DrawRectangle(draw, 458, 340, 50, 50);
                e.Graphics.DrawRectangle(draw, 658, 340, 50, 50);

                fill = new SolidBrush(Color.White);
                e.Graphics.FillRectangle(fill, 508, 340, 75, 50);
                e.Graphics.DrawRectangle(draw, 508, 340, 75, 50);
                fill = new SolidBrush(Color.LightGray);
                e.Graphics.FillRectangle(fill, 513, 345, 65, 30);
                e.Graphics.DrawRectangle(draw, 513, 345, 65, 30);
                e.Graphics.DrawEllipse(draw, 513, 380, 4, 4);
                e.Graphics.DrawEllipse(draw, 574, 380, 4, 4);
                fill = new SolidBrush(Color.White);
                e.Graphics.FillRectangle(fill, 544, 372, 4, 8);
                e.Graphics.DrawRectangle(draw, 544, 372, 4, 8);
                fill = new SolidBrush(Color.Plum);
                e.Graphics.FillRectangle(fill, 583, 340, 75, 50);
                e.Graphics.DrawRectangle(draw, 583, 340, 75, 50);
                e.Graphics.DrawEllipse(draw, 593, 350, 20, 10);
                e.Graphics.DrawEllipse(draw, 628, 350, 20, 10);
                e.Graphics.DrawEllipse(draw, 593, 375, 20, 10);
                e.Graphics.DrawEllipse(draw, 628, 375, 20, 10);

                fill = new SolidBrush(Color.White);
                //interactiveObjects(708, 340, 50, 50);
                e.Graphics.FillRectangle(fill, 708, 340, 50, 50);
                e.Graphics.DrawRectangle(draw, 708, 340, 50, 50);

                //interactiveObjects(708, 330, 50, 10);
                e.Graphics.FillRectangle(fill, 708, 330, 50, 10);
                e.Graphics.DrawRectangle(draw, 708, 330, 50, 10);

                fill = new SolidBrush(Color.Brown);
                e.Graphics.FillRectangle(fill, 468, 260, 30, 20);
                e.Graphics.FillRectangle(fill, 518, 260, 30, 20);
                e.Graphics.DrawRectangle(draw, 468, 260, 30, 20);
                e.Graphics.DrawRectangle(draw, 518, 260, 30, 20);
                fill = new SolidBrush(Color.SandyBrown);
                e.Graphics.FillRectangle(fill, 458, 270, 100, 40);
                e.Graphics.DrawRectangle(draw, 458, 270, 100, 40);

                //Room 4
                fill = new SolidBrush(Color.LightSalmon);
                //interactiveObjects(483, 55, 60, 20);
                e.Graphics.FillRectangle(fill, 483, 55, 60, 20);
                e.Graphics.DrawRectangle(draw, 483, 55, 60, 20);

                //interactiveObjects(483, 155, 60, 20);
                e.Graphics.FillRectangle(fill, 483, 155, 60, 20);
                e.Graphics.DrawRectangle(draw, 483, 155, 60, 20);

                fill = new SolidBrush(Color.LightSkyBlue);
                //interactiveObjects(493, 75, 50, 40);
                e.Graphics.FillRectangle(fill, 493, 75, 50, 40);
                e.Graphics.DrawRectangle(draw, 493, 75, 50, 40);

                //interactiveObjects(493, 115, 50, 40);
                e.Graphics.FillRectangle(fill, 493, 115, 50, 40);
                e.Graphics.DrawRectangle(draw, 493, 115, 50, 40);

                fill = new SolidBrush(Color.DarkBlue);
                //interactiveObjects(523, 75, 20, 80);
                e.Graphics.FillRectangle(fill, 523, 75, 20, 80);
                e.Graphics.DrawRectangle(draw, 523, 75, 20, 80);


                fill = new SolidBrush(Color.DimGray);
                e.Graphics.FillRectangle(fill, 363, 70, 20, 80);
                e.Graphics.DrawRectangle(draw, 363, 70, 20, 80);

                fill = new SolidBrush(Color.Brown);
                //interactiveObjects(708, 55, 20, 20);
                e.Graphics.FillRectangle(fill, 708, 55, 20, 20);
                e.Graphics.DrawRectangle(draw, 708, 55, 20, 20);

                fill = new SolidBrush(Color.White);
                //interactiveObjects(718, 25, 40, 80);
                e.Graphics.FillRectangle(fill, 718, 25, 40, 80);
                e.Graphics.DrawRectangle(draw, 718, 25, 40, 80);

                fill = new SolidBrush(Color.Gray);
                e.Graphics.FillRectangle(fill, 733, 55, 15, 20);
                e.Graphics.DrawRectangle(draw, 733, 55, 15, 20);

                //offScreen.DrawRectangle(draw, x, y, w, h);
                //offScreen.FillRectangle(fill, x, y, w, h);
                //house scene
                e.Graphics.DrawRectangle(draw, 12, 225, 255, 5);
                e.Graphics.DrawRectangle(draw, 262, 5, 5, 80);
                e.Graphics.DrawRectangle(draw, 262, 125, 5, 160);
                e.Graphics.DrawRectangle(draw, 262, 330, 5, 60);
                e.Graphics.DrawRectangle(draw, 308, 5, 5, 80);
                e.Graphics.DrawRectangle(draw, 308, 225, 200, 5);
                e.Graphics.DrawRectangle(draw, 558, 225, 200, 5);
                e.Graphics.DrawRectangle(draw, 308, 125, 5, 265);

                e.Graphics.FillRectangle(fill, 12, 225, 255, 5);
                e.Graphics.FillRectangle(fill, 262, 5, 5, 80);
                e.Graphics.FillRectangle(fill, 262, 125, 5, 160);
                e.Graphics.FillRectangle(fill, 262, 330, 5, 60);
                e.Graphics.FillRectangle(fill, 308, 5, 5, 80);
                e.Graphics.FillRectangle(fill, 308, 225, 200, 5);
                e.Graphics.FillRectangle(fill, 558, 225, 200, 5);
                e.Graphics.FillRectangle(fill, 308, 125, 5, 265);

                e.Graphics.FillRectangle(mainCharacterOne, drawX, drawY, 20, 20);
                
            }

        }
        private void mainMenu_KeyUp(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }
        }

        private void mainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            //Graphics Draw = this.CreateGraphics();

            if (e.KeyCode == Keys.Y)
            {
                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 4; }//girl
                else if (scene == 3) { scene = 2; }
                else if (scene == 4) { scene = 6; }//naming girlone
                else if (scene == 5) { scene = 7; }//naming guyone
                else if (scene == 6) { scene = 10; }//girlone house scene
                else if (scene == 7) { scene = 11; }//guyone house scene
                else if (scene == 8) { scene = 12; }//girltwo house scene
                else if (scene == 9) { scene = 13; }//guytwo house scene

            }
            if (e.KeyCode == Keys.U)
            {
                if (scene == 1) { scene = 3; }
                else if (scene == 2) { scene = 5; }//guy
                else if (scene == 4) { scene = 8; }//naming girltwo
                else if (scene == 5) { scene = 9; }//naming guytwo
            }
            if (e.KeyCode == Keys.I)
            {
                if (scene == 10) { Close(); }
            }

            //character 
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
            }
            if (leftArrowDown == true)
            {
                drawX = drawX - 3;
                Refresh();
            }
            if (rightArrowDown == true)
            {
                drawX = drawX + 3;
                Refresh();
            }
            if (upArrowDown == true)
            {
                drawY = drawY - 3;
                Refresh();
            }
            if (downArrowDown == true)
            {
                drawY = drawY + 3;
                Refresh();
            }

            switch (scene)
            {
                case 2: //Start Gameplay
                    bankmoneyLabel.Visible = false;
                    bankLabel.Visible = false;
                    workperfLabel.Visible = false;
                    hungerlabel.Visible = false;
                    hygienelabel.Visible = false;
                    loolabel.Visible = false;
                    entertainmentlabel.Visible = false;
                    imageO.Visible = false;
                    imageT.Visible = false;
                    titleLabel.Visible = true;
                    startLabel.Visible = true;
                    howtoplaylabel.Visible = true;
                    instructionlabel.Visible = true;
                    nameinput.Visible = false;
                    startLabel.Font = new Font("Impact", 12);
                    howtoplaylabel.Font = new Font("Impact", 12);
                    startLabel.Text = "Girl";
                    howtoplaylabel.Text = "Boy";
                    instructionlabel.Text = "Press Y to choose a girl character and Press U to choose a guy character";
                    break;
                case 3: //how to play
                    bankmoneyLabel.Visible = false;
                    bankLabel.Visible = false;
                    workperfLabel.Visible = false;
                    hungerlabel.Visible = false;
                    hygienelabel.Visible = false;
                    loolabel.Visible = false;
                    entertainmentlabel.Visible = false;
                    imageO.Visible = false;
                    imageT.Visible = false;
                    titleLabel.Visible = true;
                    startLabel.Visible = true;
                    howtoplaylabel.Visible = false;
                    instructionlabel.Visible = true;
                    nameinput.Visible = false;
                    titleLabel.Text = "How to Play";
                    startLabel.Font = new Font("Courier New", 10);
                    startLabel.Location = new Point(100, 170);
                    startLabel.Text = "The Living Simulator is inspired by Electronic Arts’ The Sims 3." + "\n" + "It allows players to choose which" + "\n" +
                        "character they want to be and to give their character " + "\n" + "creative and exclusive names that belong only to" + "\n" +
                        "them. Players can also fill their character’s needs by" + "\n" + " making their character “go to the washroom”, by" + "\n" +
                        "making their character “eat food”, by communicating with" + "\n" + " other characters present in the game, etc. This" + "\n" +
                        "of course means that players are able to move their " + "\n" + "character in desired directions. If needs are not up to a" + "\n" +
                        "certain level, the player’s character can be disliked " + "\n" + "and rejected by other characters or die in the worst" + "\n" +
                        "case scenario. If needs are fulfilled, the character can go" + "\n" + " to work to earn money so that there will be more" + "\n" +
                        "money present in their account. The more money a character has in" + "\n" + " his/her account, the higher the chance" + "\n" +
                        "of them earning likes from other characters. This allows other " + "\n" + "characters to accept certain interactions" + "\n" +
                        "from the player’s character."; //Instructions and such
                    instructionlabel.Text = "Press Y to proceed";
                    break;
                case 4: //girl
                    bankmoneyLabel.Visible = false;
                    bankLabel.Visible = false;
                    workperfLabel.Visible = false;
                    hungerlabel.Visible = false;
                    hygienelabel.Visible = false;
                    loolabel.Visible = false;
                    entertainmentlabel.Visible = false;
                    titleLabel.Visible = true;
                    startLabel.Visible = false;
                    howtoplaylabel.Visible = true;
                    instructionlabel.Visible = true;
                    imageO.Visible = true;
                    imageT.Visible = true;
                    nameinput.Visible = false;
                    titleLabel.Text = "Choosing your character";
                    imageO.Image = TheLifeSimulator.Properties.Resources.girlone;
                    imageT.Image = TheLifeSimulator.Properties.Resources.girltwo;
                    nameinput.Visible = false;
                    instructionlabel.Location = new Point(12, 350);
                    instructionlabel.Text = "Press Y for the girl on the right and press U for the girl on the left";
                    break;
                case 5: //guy
                    bankmoneyLabel.Visible = false;
                    bankLabel.Visible = false;
                    workperfLabel.Visible = false;
                    hungerlabel.Visible = false;
                    hygienelabel.Visible = false;
                    loolabel.Visible = false;
                    entertainmentlabel.Visible = false;
                    titleLabel.Visible = true;
                    startLabel.Visible = false;
                    howtoplaylabel.Visible = true;
                    instructionlabel.Visible = true;
                    imageO.Visible = true;
                    imageT.Visible = true;
                    nameinput.Visible = false;
                    titleLabel.Text = "Choosing your character";
                    imageO.Image = TheLifeSimulator.Properties.Resources.guyone;
                    imageT.Image = TheLifeSimulator.Properties.Resources.guytwo;
                    instructionlabel.Text = "Press Y for the guy on the right and press U for the guy on the left";
                    break;
                case 6: //girlone
                    bankmoneyLabel.Visible = false;
                    bankLabel.Visible = false;
                    workperfLabel.Visible = false;
                    hungerlabel.Visible = false;
                    hygienelabel.Visible = false;
                    loolabel.Visible = false;
                    entertainmentlabel.Visible = false;
                    titleLabel.Visible = true;
                    titleLabel.Text = "Naming";
                    startLabel.Location = new Point(100, 170);
                    startLabel.Visible = true;
                    startLabel.Text = "Please Type Character Name";
                    howtoplaylabel.Visible = true;
                    howtoplaylabel.Text = "Press Y to move on";
                    instructionlabel.Location = new Point(12, 400);
                    instructionlabel.Size = new Size(746, 130);
                    instructionlabel.Visible = true;
                    instructionlabel.Text = "";
                    instructionlabel.BackColor = Color.Pink;
                    imageO.Location = new Point(12, 400);
                    imageO.Size = new Size(100, 130);
                    imageO.Visible = true;
                    imageO.Image = TheLifeSimulator.Properties.Resources.girlone;
                    imageT.Visible = false;
                    nameinput.Location = new Point(340, 170);
                    nameinput.Visible = true;
                    username = nameinput.Text;
                    break;
                case 7: //guyone
                    bankmoneyLabel.Visible = false;
                    bankLabel.Visible = false;
                    workperfLabel.Visible = false;
                    hungerlabel.Visible = false;
                    hygienelabel.Visible = false;
                    loolabel.Visible = false;
                    entertainmentlabel.Visible = false;
                    titleLabel.Visible = true;
                    titleLabel.Text = "Naming";
                    startLabel.Location = new Point(100, 170);
                    startLabel.Visible = true;
                    startLabel.Text = "Please Type Character Name";
                    howtoplaylabel.Visible = true;
                    howtoplaylabel.Text = "Press Y to move on";
                    instructionlabel.Location = new Point(12, 400);
                    instructionlabel.Size = new Size(746, 130);
                    instructionlabel.Visible = true;
                    instructionlabel.Text = "";
                    instructionlabel.BackColor = Color.LightBlue;
                    imageO.Location = new Point(12, 400);
                    imageO.Size = new Size(100, 130);
                    imageO.Visible = true;
                    imageO.Image = TheLifeSimulator.Properties.Resources.guyone;
                    imageT.Visible = false;
                    nameinput.Location = new Point(340, 170);
                    nameinput.Visible = true;
                    username = nameinput.Text;
                    break;
                case 8: //girltwo
                    bankmoneyLabel.Visible = false;
                    bankLabel.Visible = false;
                    workperfLabel.Visible = false;
                    hungerlabel.Visible = false;
                    hygienelabel.Visible = false;
                    loolabel.Visible = false;
                    entertainmentlabel.Visible = false;
                    titleLabel.Visible = true;
                    titleLabel.Text = "Naming";
                    startLabel.Location = new Point(100, 170);
                    startLabel.Visible = true;
                    startLabel.Text = "Please Type Character Name";
                    howtoplaylabel.Visible = true;
                    howtoplaylabel.Text = "Press Y to move on";
                    instructionlabel.Location = new Point(12, 400);
                    instructionlabel.Size = new Size(746, 130);
                    instructionlabel.Visible = true;
                    instructionlabel.Text = "";
                    instructionlabel.BackColor = Color.Pink;
                    imageO.Location = new Point(12, 400);
                    imageO.Size = new Size(100, 130);
                    imageO.Visible = true;
                    imageO.Image = TheLifeSimulator.Properties.Resources.girltwo;
                    imageT.Visible = false;
                    nameinput.Location = new Point(340, 170);
                    nameinput.Visible = true;
                    username = nameinput.Text;
                    break;
                case 9: //guytwo
                    bankmoneyLabel.Visible = false;
                    bankLabel.Visible = false;
                    workperfLabel.Visible = false;
                    hungerlabel.Visible = false;
                    hygienelabel.Visible = false;
                    loolabel.Visible = false;
                    entertainmentlabel.Visible = false;
                    titleLabel.Visible = true;
                    titleLabel.Text = "Naming";
                    startLabel.Location = new Point(100, 170);
                    startLabel.Visible = true;
                    startLabel.Text = "Please Type Character Name";
                    howtoplaylabel.Visible = true;
                    howtoplaylabel.Text = "Press Y to move on";
                    instructionlabel.Location = new Point(12, 400);
                    instructionlabel.Size = new Size(746, 130);
                    instructionlabel.Visible = true;
                    instructionlabel.Text = "";
                    instructionlabel.BackColor = Color.LightBlue;
                    imageO.Location = new Point(12, 400);
                    imageO.Size = new Size(100, 130);
                    imageO.Visible = true;
                    imageO.Image = TheLifeSimulator.Properties.Resources.guytwo;
                    imageT.Visible = false;
                    nameinput.Location = new Point(340, 170);
                    nameinput.Visible = true;
                    username = nameinput.Text;
                    break;

                case 10://girlone house scene
                        simulatorClock.Enabled = true;

                        this.BackColor = Color.AntiqueWhite;
                        

                        bankLabel.Location = new Point(400, 420);
                        bankLabel.BackColor = Color.Pink;
                        bankLabel.Text = "Bank";
                        bankLabel.Visible = true;
                        bankmoneyLabel.BackColor = Color.White;
                        bankmoneyLabel.Location = new Point(530, 410);
                        bankmoneyLabel.Visible = true;
                        workperfLabel.Location = new Point(400, 440);
                        workperfLabel.BackColor = Color.Pink;
                        workperfLabel.Text = "Work Performance";
                        workperfLabel.Visible = true;

                        workperfBar(520, 40);

                        hungerlabel.BackColor = Color.Pink;
                        entertainmentlabel.BackColor = Color.Pink;
                        loolabel.BackColor = Color.Pink;
                        hygienelabel.BackColor = Color.Pink;
                        hungerlabel.Location = new Point(120, 420);
                        entertainmentlabel.Location = new Point(120, 440);
                        loolabel.Location = new Point(120, 460);
                        hygienelabel.Location = new Point(120, 480);
                        hungerlabel.Size = new Size(120, 20);
                        entertainmentlabel.Size = new Size(120, 20);
                        loolabel.Size = new Size(120, 20);
                        hygienelabel.Size = new Size(120, 20);
                        hungerlabel.Visible = true;
                        hygienelabel.Visible = true;
                        loolabel.Visible = true;
                        entertainmentlabel.Visible = true;
                        hungerlabel.Text = "Hunger";
                        entertainmentlabel.Text = "Entertainment";
                        loolabel.Text = "Loo";
                        hygienelabel.Text = "Hygiene";

                        needsBar(250, 10);
                        needsBar(250, 40);
                        needsBar(250, 70);
                        needsBar(250, 100);

                        imageO.Visible = true;///
                        imageT.Visible = false;///
                        titleLabel.Visible = false;///
                        startLabel.Location = new Point(274, 400);
                        startLabel.Visible = true;///
                        startLabel.Text = username;
                        howtoplaylabel.Visible = false;///
                        instructionlabel.Visible = true;///
                        nameinput.Visible = false;///

                    mainCharacter = new Rectangle(drawX, drawY, 20, 20);

                    if (drawX < 14) { drawX = 14;}
                    if (drawY < 7) { drawY = 7; }
                    //if (drawX > 262 && drawX < 264.5 && drawY < 85 || drawY > 125 && drawY < 285 || drawY > 330)
                    //{
                    //    drawX = 262;
                    //}
                    //if (drawX > 264.5 && drawX < 267 && drawY < 85 || drawY > 125 && drawY < 285 || drawY > 330)
                    //{
                    //    drawX = 270;
                    //}
                    //if (drawX > 308 && drawX < 310.5 && drawY < 85 || drawY > 125 && drawY < 285 || drawY > 330)
                    //{
                    //    drawX = 308;
                    //}
                    //if (drawX > 310.5 && drawX < 313 && drawY < 85 || drawY > 125 && drawY < 285 || drawY > 330)
                    //{
                    //    drawX = 313;
                    //}
                    //if (drawY > 225 && drawY < 227.5 && (drawX > 12 && drawX < 262 || drawX > 308 && drawX < 508 || drawX > 558 && drawX < 758))
                    //{
                    //    drawY = 225;
                    //}
                    //if (drawY > 227.5 && drawY < 230)
                    //{
                    //    drawY = 230;
                    //}
                    if (drawX > 735) { drawX = 735; }
                    if (drawY > 367) { drawY = 367; }
                    
                    //e.Graphics.DrawRectangle(draw, 12, 225, 255, 5);
                    //e.Graphics.DrawRectangle(draw, 262, 5, 5, 80);
                    //e.Graphics.DrawRectangle(draw, 262, 125, 5, 160);
                    //e.Graphics.DrawRectangle(draw, 262, 330, 5, 60);
                    //e.Graphics.DrawRectangle(draw, 308, 5, 5, 80);
                    //e.Graphics.DrawRectangle(draw, 308, 225, 200, 5);
                    //e.Graphics.DrawRectangle(draw, 558, 225, 200, 5);
                    //e.Graphics.DrawRectangle(draw, 308, 125, 5, 265);
                    Rectangle divisionOne = new Rectangle(12, 225, 255, 5);
                    Rectangle divisionTwo = new Rectangle(262, 5, 5, 80);
                    Rectangle divisionThree = new Rectangle(262, 125, 5, 160);
                    Rectangle divisionFour = new Rectangle(262, 330, 5, 60);
                    Rectangle divisionFive = new Rectangle(308, 5, 5, 80);
                    Rectangle divisionSix = new Rectangle(308, 225, 200, 5);
                    Rectangle divisionSeven = new Rectangle(558, 225, 200, 5);
                    Rectangle divisionEight = new Rectangle(308, 125, 5, 265);

                    if (divisionOne.IntersectsWith(mainCharacter))
                    {
                        if (drawY < 225) { drawY = 205; }
                        if (drawY > 225) { drawY = 235; }
                    }
                    if (divisionTwo.IntersectsWith(mainCharacter))
                    {
                        if (drawX < 262) { drawX = 242; }
                        if (drawX > 262) { drawX = 272; }
                    }
                    if (divisionThree.IntersectsWith(mainCharacter))
                    {
                        if (drawX < 262) { drawX = 242; }
                        if (drawX > 262) { drawX = 272; }
                    }
                    if (divisionFour.IntersectsWith(mainCharacter))
                    {
                        if (drawX < 262) { drawX = 242; }
                        if (drawX > 262) { drawX = 272; }
                    }
                    if (divisionFive.IntersectsWith(mainCharacter))
                    {
                        if (drawX < 308) { drawX = 288; }
                        if (drawX > 308) { drawX = 318; }
                    }
                    if (divisionEight.IntersectsWith(mainCharacter))
                    {
                        if (drawX < 308) { drawX = 288; }
                        if (drawX > 308) { drawX = 318; }
                    }
                    if (divisionSix.IntersectsWith(mainCharacter))
                    {
                        if (drawY < 225) { drawY = 205; }
                        if (drawY > 225) { drawY = 235; }
                    }
                    if (divisionSeven.IntersectsWith(mainCharacter))
                    {
                        if (drawY < 225) { drawY = 205; }
                        if (drawY > 225) { drawY = 235; }
                    }

                    break;
                case 11://guyone house scene
                    bankLabel.Location = new Point(400, 420);
                    bankLabel.BackColor = Color.LightBlue;
                    bankLabel.Text = "Bank";
                    bankLabel.Visible = true;
                    bankmoneyLabel.BackColor = Color.White;
                    bankmoneyLabel.Location = new Point(530, 410);
                    bankmoneyLabel.Visible = true;
                    workperfLabel.Location = new Point(400, 440);
                    workperfLabel.BackColor = Color.LightBlue;
                    workperfLabel.Text = "Work Performance";
                    workperfLabel.Visible = true;

                    workperfBar(520, 40);

                    hungerlabel.BackColor = Color.LightBlue;
                    entertainmentlabel.BackColor = Color.LightBlue;
                    loolabel.BackColor = Color.LightBlue;
                    hygienelabel.BackColor = Color.LightBlue;
                    hungerlabel.Location = new Point(120, 420);
                    entertainmentlabel.Location = new Point(120, 440);
                    loolabel.Location = new Point(120, 460);
                    hygienelabel.Location = new Point(120, 480);
                    hungerlabel.Size = new Size(120, 20);
                    entertainmentlabel.Size = new Size(120, 20);
                    loolabel.Size = new Size(120, 20);
                    hygienelabel.Size = new Size(120, 20);
                    hungerlabel.Visible = true;
                    hygienelabel.Visible = true;
                    loolabel.Visible = true;
                    entertainmentlabel.Visible = true;
                    hungerlabel.Text = "Hunger";
                    entertainmentlabel.Text = "Entertainment";
                    loolabel.Text = "Loo";
                    hygienelabel.Text = "Hygiene";

                    needsBar(250, 10);
                    needsBar(250, 40);
                    needsBar(250, 70);
                    needsBar(250, 100);

                    imageO.Visible = true;///
                    imageT.BackColor = Color.White;
                    imageT.Location = new Point(12, 5);
                    imageT.Size = new Size(746, 385);
                    imageT.Image = null;
                    imageT.Visible = true;///
                    titleLabel.Visible = false;///
                    startLabel.Location = new Point(274, 400);
                    startLabel.Visible = true;///
                    startLabel.Text = username;
                    howtoplaylabel.Visible = false;///
                    instructionlabel.Visible = true;///
                    nameinput.Visible = false;///

                    break;
                case 12://girltwo house scene
                    bankLabel.Location = new Point(400, 420);
                    bankLabel.BackColor = Color.Pink;
                    bankLabel.Text = "Bank";
                    bankLabel.Visible = true;
                    bankmoneyLabel.BackColor = Color.White;
                    bankmoneyLabel.Location = new Point(530, 410);
                    bankmoneyLabel.Visible = true;
                    workperfLabel.Location = new Point(400, 440);
                    workperfLabel.BackColor = Color.Pink;
                    workperfLabel.Text = "Work Performance";
                    workperfLabel.Visible = true;

                    workperfBar(520, 40);

                    hungerlabel.BackColor = Color.Pink;
                    entertainmentlabel.BackColor = Color.Pink;
                    loolabel.BackColor = Color.Pink;
                    hygienelabel.BackColor = Color.Pink;
                    hungerlabel.Location = new Point(120, 420);
                    entertainmentlabel.Location = new Point(120, 440);
                    loolabel.Location = new Point(120, 460);
                    hygienelabel.Location = new Point(120, 480);
                    hungerlabel.Size = new Size(120, 20);
                    entertainmentlabel.Size = new Size(120, 20);
                    loolabel.Size = new Size(120, 20);
                    hygienelabel.Size = new Size(120, 20);
                    hungerlabel.Visible = true;
                    hygienelabel.Visible = true;
                    loolabel.Visible = true;
                    entertainmentlabel.Visible = true;
                    hungerlabel.Text = "Hunger";
                    entertainmentlabel.Text = "Entertainment";
                    loolabel.Text = "Loo";
                    hygienelabel.Text = "Hygiene";

                    needsBar(250, 10);
                    needsBar(250, 40);
                    needsBar(250, 70);
                    needsBar(250, 100);

                    imageO.Visible = true;///
                    imageT.BackColor = Color.White;
                    imageT.Location = new Point(12, 5);
                    imageT.Size = new Size(746, 385);
                    imageT.Image = null;
                    imageT.Visible = true;///
                    titleLabel.Visible = false;///
                    startLabel.Location = new Point(274, 400);
                    startLabel.Visible = true;///
                    startLabel.Text = username;
                    howtoplaylabel.Visible = false;///
                    instructionlabel.Visible = true;///
                    nameinput.Visible = false;///
                    break;
                case 13://guytwo house scene
                    bankLabel.Location = new Point(400, 420);
                    bankLabel.BackColor = Color.LightBlue;
                    bankLabel.Text = "Bank";
                    bankLabel.Visible = true;
                    bankmoneyLabel.BackColor = Color.White;
                    bankmoneyLabel.Location = new Point(530, 410);
                    bankmoneyLabel.Visible = true;
                    workperfLabel.Location = new Point(400, 440);
                    workperfLabel.BackColor = Color.LightBlue;
                    workperfLabel.Text = "Work Performance";
                    workperfLabel.Visible = true;

                    workperfBar(520, 40);

                    hungerlabel.BackColor = Color.LightBlue;
                    entertainmentlabel.BackColor = Color.LightBlue;
                    loolabel.BackColor = Color.LightBlue;
                    hygienelabel.BackColor = Color.LightBlue;
                    hungerlabel.Location = new Point(120, 420);
                    entertainmentlabel.Location = new Point(120, 440);
                    loolabel.Location = new Point(120, 460);
                    hygienelabel.Location = new Point(120, 480);
                    hungerlabel.Size = new Size(120, 20);
                    entertainmentlabel.Size = new Size(120, 20);
                    loolabel.Size = new Size(120, 20);
                    hygienelabel.Size = new Size(120, 20);
                    hungerlabel.Visible = true;
                    hygienelabel.Visible = true;
                    loolabel.Visible = true;
                    entertainmentlabel.Visible = true;
                    hungerlabel.Text = "Hunger";
                    entertainmentlabel.Text = "Entertainment";
                    loolabel.Text = "Loo";
                    hygienelabel.Text = "Hygiene";

                    needsBar(250, 10);
                    needsBar(250, 40);
                    needsBar(250, 70);
                    needsBar(250, 100);

                    imageO.Visible = true;///
                    imageT.BackColor = Color.White;
                    imageT.Location = new Point(12, 5);
                    imageT.Size = new Size(746, 385);
                    imageT.Image = null;
                    imageT.Visible = true;///
                    titleLabel.Visible = false;///
                    startLabel.Location = new Point(274, 400);
                    startLabel.Visible = true;///
                    startLabel.Text = username;
                    howtoplaylabel.Visible = false;///
                    instructionlabel.Visible = true;///
                    nameinput.Visible = false;///
                    break;
                case 14:

                    break;
                case 15:

                    break;
                case 16:

                    break;
                case 17:

                    break;
                case 18:

                    break;
                case 19:

                    break;
            }

        }


        private void nameinput_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
