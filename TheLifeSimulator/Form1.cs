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
        SolidBrush mainCharacter = new SolidBrush(Color.Yellow);

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
        public void houseRec(int x, int y, int w, int h)
        {
            //creating method to create the needsbar
            Graphics Draw = this.CreateGraphics();
            Pen draw = new Pen(Color.Black, 3);
            SolidBrush fill = new SolidBrush(Color.Gray);
            Draw.DrawRectangle(draw, x, y, w, h);
            Draw.FillRectangle(fill, x, y, w, h);

        }
        public void furnitureRec(SolidBrush fill, int x, int y, int w, int h)
        {
            //creating method to create the needsbar
            Graphics Draw = this.CreateGraphics();
            Pen draw = new Pen(Color.Black, 2);
            Draw.DrawRectangle(draw, x, y, w, h);
            Draw.FillRectangle(fill, x, y, w, h);
        }
        public void furnitureCir(int x, int y, int w, int h)
        {
            //creating method to create the needsbar
            Graphics Draw = this.CreateGraphics();
            Pen draw = new Pen(Color.Black, 2);
            Draw.DrawEllipse(draw, x, y, w, h);
        }

        public void interactiveObjects(int x, int y, int w, int h)
        {
            //creating interactive furnitures
            Rectangle interactiveFur = new Rectangle(x, y, w, h); 

        }

        private void mainMenu_Paint(object sender, PaintEventArgs e)
        {
            if (scene == 10)
            {
                e.Graphics.FillRectangle(mainCharacter, drawX, drawY, 20, 20);
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
            Graphics Draw = this.CreateGraphics();

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
            }
            if (rightArrowDown == true)
            {
                drawX = drawX + 3;
            }
            if (upArrowDown == true)
            {
                drawY = drawY - 3;
            }
            if (downArrowDown == true)
            {
                drawY = drawY + 3;
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
                    Graphics onScreen = this.CreateGraphics(); //Sets up on-screen graphics 
                    Bitmap bm = new Bitmap(this.Width, this.Height); //bitmap area size of whole screen 
                    Graphics offScreen = Graphics.FromImage(bm); //Sets off-screen graphics to the bitmap 

                    this.BackColor = Color.AntiqueWhite;
                    Refresh();
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

                    Pen draw = new Pen(Color.Black, 3);
                    SolidBrush fill = new SolidBrush(Color.Black);
                    offScreen.DrawRectangle(draw, 0, 0, 12, 390);
                    offScreen.FillRectangle(fill, 0, 0, 12, 390);
                    offScreen.DrawRectangle(draw, 0, 0, 1044, 5);
                    offScreen.FillRectangle(fill, 0, 0, 1044, 5);

                    offScreen.DrawRectangle(draw, 758, 0, 12, 390);
                    offScreen.FillRectangle(fill, 758, 0, 12, 390);
                    offScreen.DrawRectangle(draw, 0, 390, 1044, 8);
                    offScreen.FillRectangle(fill, 0, 390, 1044, 8);

                    onScreen.DrawImage(bm, 0, 0);
                    offScreen.Clear(Color.Black);

                    //drawhouse
                    //Room 1

                    fill = new SolidBrush(Color.SaddleBrown);
                    furnitureRec(fill, 32, 5, 30, 40);
                    furnitureRec(fill, 212, 5, 30, 40);
                    fill = new SolidBrush(Color.SaddleBrown);
                    furnitureRec(fill, 47, 185, 180, 40);
                    fill = new SolidBrush(Color.Beige);
                    furnitureRec(fill, 82, 15, 50, 20);
                    furnitureRec(fill, 142, 15, 50, 20);

                    interactiveObjects(62, 45, 150, 120);//design/patterns needeed
                    fill = new SolidBrush(Color.Coral);
                    furnitureRec(fill, 62, 45, 150, 120);

                    interactiveObjects(62, 45, 150, 10);//Need to be colored
                    fill = new SolidBrush(Color.LightBlue);
                    furnitureRec(fill, 62, 45, 150, 10);

                    interactiveObjects(62, 55, 150, 80);
                    fill = new SolidBrush(Color.Coral);
                    furnitureRec(fill, 62, 55, 150, 80);
                    //Room 2
                    interactiveObjects(17, 290, 60, 100);
                    fill = new SolidBrush(Color.White);
                    furnitureRec(fill, 17, 290, 60, 100);

                    fill = new SolidBrush(Color.LightGray);
                    furnitureRec(fill, 22, 305, 50, 70);
                    fill = new SolidBrush(Color.White);
                    furnitureRec(fill, 202, 230, 60, 40);
                    fill = new SolidBrush(Color.LightGray);
                    furnitureRec(fill, 207, 245, 50, 20);

                    interactiveObjects(207, 350, 50, 30);
                    fill = new SolidBrush(Color.White);
                    furnitureRec(fill, 207, 350, 50, 30);

                    interactiveObjects(202, 380, 60, 10);
                    fill = new SolidBrush(Color.White);
                    furnitureRec(fill, 202, 380, 60, 10);

                    fill = new SolidBrush(Color.LightGray);
                    furnitureRec(fill, 212, 360, 40, 20);
                    fill = new SolidBrush(Color.White);
                    furnitureRec(fill, 230, 240, 4, 8);
                    furnitureRec(fill, 45, 300, 4, 8);
                    furnitureCir(207, 240, 4, 4);
                    furnitureCir(253, 240, 4, 4);
                    furnitureCir(22, 300, 4, 4);
                    furnitureCir(68, 300, 4, 4);
                    //Room 3
                    fill = new SolidBrush(Color.Linen);
                    furnitureRec(fill, 308, 340, 50, 50);
                    furnitureRec(fill, 358, 340, 50, 50);
                    furnitureRec(fill, 408, 340, 50, 50);
                    furnitureRec(fill, 458, 340, 50, 50);
                    furnitureRec(fill, 658, 340, 50, 50);
                    fill = new SolidBrush(Color.White);
                    furnitureRec(fill, 508, 340, 75, 50);
                    fill = new SolidBrush(Color.LightGray);
                    furnitureRec(fill, 513, 345, 65, 30);
                    furnitureCir(513, 380, 4, 4);
                    furnitureCir(574, 380, 4, 4);
                    fill = new SolidBrush(Color.White);
                    furnitureRec(fill, 544, 380, 4, 8);
                    fill = new SolidBrush(Color.Plum);
                    furnitureRec(fill, 583, 340, 75, 50);
                    furnitureCir(593, 350, 20, 10);
                    furnitureCir(628, 350, 20, 10);
                    furnitureCir(593, 375, 20, 10);
                    furnitureCir(628, 375, 20, 10);

                    fill = new SolidBrush(Color.White);
                    interactiveObjects(708, 340, 50, 50);
                    furnitureRec(fill, 708, 340, 50, 50);
                    
                    interactiveObjects(708, 330, 50, 10);
                    furnitureRec(fill, 708, 330, 50, 10);

                    fill = new SolidBrush(Color.Brown);
                    furnitureRec(fill, 468, 260, 30, 20);
                    furnitureRec(fill, 518, 260, 30, 20);
                    fill = new SolidBrush(Color.SandyBrown);
                    furnitureRec(fill, 458, 270, 100, 40);

                    //Room 4
                    fill = new SolidBrush(Color.LightSalmon);
                    interactiveObjects(483, 55, 60, 20);
                    furnitureRec(fill, 483, 55, 60, 20);

                    interactiveObjects(483, 155, 60, 20);
                    furnitureRec(fill, 483, 155, 60, 20);

                    fill = new SolidBrush(Color.LightSkyBlue);
                    interactiveObjects(493, 75, 50, 40);
                    furnitureRec(fill, 493, 75, 50, 40);

                    interactiveObjects(493, 115, 50, 40);
                    furnitureRec(fill, 493, 115, 50, 40);

                    fill = new SolidBrush(Color.DarkBlue);
                    interactiveObjects(523, 75, 20, 80);
                    furnitureRec(fill, 523, 75, 20, 80);

                    fill = new SolidBrush(Color.DimGray);
                    furnitureRec(fill, 363, 70, 20, 80);

                    fill = new SolidBrush(Color.Brown);
                    interactiveObjects(708, 55, 20, 20);
                    furnitureRec(fill, 708, 55, 20, 20);

                    fill = new SolidBrush(Color.White);
                    interactiveObjects(718, 25, 40, 80);
                    furnitureRec(fill, 718, 25, 40, 80);

                    fill = new SolidBrush(Color.Gray);
                    furnitureRec(fill, 733, 55, 15, 20);

                    //house scene
                    houseRec(12, 225, 255, 5);
                    houseRec(262, 5, 5, 80);
                    houseRec(262, 125, 5, 160);
                    houseRec(262, 330, 5, 60);
                    houseRec(308, 5, 5, 80);
                    houseRec(308, 225, 200, 5);
                    houseRec(558, 225, 200, 5);
                    houseRec(308, 125, 5, 265);

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
            }

        }


        private void nameinput_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
