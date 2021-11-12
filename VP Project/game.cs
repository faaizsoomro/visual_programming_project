using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Project
{
    public partial class game : Form
    {
      string[,] ground={{"e","e","e","e","e","e","e","e","e"},
                       {"e","e","e","w","w","w","w","w","e"},
                       {"e","w","w","w","e","e","e","w","e"},
                       {"e","w","t","e","box3","c","e","w","e"},
                       {"e","w","w","w","e","box2","t","w","e"},
                       {"e","w","t","w","w","box1","e","w","e"},
                       {"e","w","e","w","e","t","e","w","w"},
                       {"e","w","box7","e","box4","box5","box6","t","w"},
                       {"e","w","e","e","e","t","e","e","w"},
                       {"e","w","w","w","w","w","w","w","w"}};
        int row;
        int col;
        int moves = 0;

        bool[] b = new bool[7];
        

        public game()
        {
            InitializeComponent();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            
            int x = col - 1;
            int y = col - 2;
            if (ground[row, x] != "w")
            {
                if (ground[row, x] == "box1")
                {
                    if (ground[row, y] != "box2" && ground[row, y] != "box3" && ground[row, y] != "box4" && ground[row, y] != "box5" && ground[row, y] != "box6" && ground[row, y] != "box7" && ground[row, y] != "w")
                    {
                        character.Left -= 50;
                        box1.Left -= 50;
                        ground[row, col] = "e";
                        ground[row, x] = "c";
                        ground[row, y] = "box1";
                        col -= 1;
                        changePosition("box1", row, y);
                        moves++;
                    }
                }
                else if (ground[row, x] == "box2")
                {
                    if (ground[row, y] != "box1" && ground[row, y] != "box3" && ground[row, y] != "box4" && ground[row, y] != "box5" && ground[row, y] != "box6" && ground[row, y] != "box7" && ground[row, y] != "w")
                    {
                        character.Left -= 50;
                        box2.Left -= 50;
                        ground[row, col] = "e";
                        ground[row, x] = "c";
                        ground[row, y] = "box2";
                        col -= 1;
                        changePosition("box2", row, y);
                        moves++;
                    }
                }
                else if (ground[row, x] == "box3")
                {
                    if (ground[row, y] != "box1" && ground[row, y] != "box2" && ground[row, y] != "box4" && ground[row, y] != "box5" && ground[row, y] != "box6" && ground[row, y] != "box7" && ground[row, y] != "w")
                    {
                        character.Left -= 50;
                        box3.Left -= 50;
                        ground[row, col] = "e";
                        ground[row, x] = "c";
                        ground[row, y] = "box3";
                        col -= 1;
                        changePosition("box3", row, y);
                        moves++;
                    }
                }
                else if (ground[row, x] == "box4")
                {
                    if (ground[row, y] != "box1" && ground[row, y] != "box2" && ground[row, y] != "box3" && ground[row, y] != "box5" && ground[row, y] != "box6" && ground[row, y] != "box7" && ground[row, y] != "w")
                    {
                        character.Left -= 50;
                        box4.Left -= 50;
                        ground[row, col] = "e";
                        ground[row, x] = "c";
                        ground[row, y] = "box4";
                        col -= 1;
                        changePosition("box4", row, y);
                        moves++;
                    }
                }
                else if (ground[row, x] == "box5")
                {
                    if (ground[row, y] != "box1" && ground[row, y] != "box2" && ground[row, y] != "box3" && ground[row, y] != "box4" && ground[row,y] != "box6" && ground[row, y] != "box7" && ground[row, y] != "w")
                    {
                        character.Left -= 50;
                        box5.Left -= 50;
                        ground[row, col] = "e";
                        ground[row, x] = "c";
                        ground[row, y] = "box5";
                        col -= 1;
                        changePosition("box5", row, y);
                        moves++;
                    }
                }
                else if (ground[row, x] == "box6")
                {
                    if (ground[row, y] != "box1" && ground[row, y] != "box2" && ground[row, y] != "box3" && ground[row, y] != "box4" && ground[row, y] != "box5" && ground[row, y] != "box7" && ground[row, y] != "w")
                    {
                        character.Left -= 50;
                        box6.Left -= 50;
                        ground[row, col] = "e";
                        ground[row, x] = "c";
                        ground[row, y] = "box6";
                        col -= 1;
                        changePosition("box6", row, y);
                        moves++;
                    }
                }
                else if (ground[row, x] == "box7")
                {
                    if (ground[row, y] != "box1" && ground[row, y] != "box2" && ground[row, y] != "box3" && ground[row, y] != "box4" && ground[row, y] != "box5" && ground[row, y] != "box6" && ground[row, y] != "w")
                    {
                        character.Left -= 50;
                        box7.Left -= 50;
                        ground[row, col] = "e";
                        ground[row, x] = "c";
                        ground[row, y] = "box7";
                        col -= 1;
                        changePosition("box7", row, y);
                        moves++;
                    }
                }
                else
                {
                    character.Left -= 50;
                    ground[row, col] = "e";
                    ground[row, x] = "c";
                    col -= 1;
                    moves++;
                }
            }
            label1.Text = moves + " ";
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            int x = row - 1;
            int y = row - 2;
            if (ground[x, col] != "w")
            {
                if (ground[x, col] == "box1")
                {
                    if (ground[y, col] != "box2" && ground[y, col] != "box3" && ground[y, col] != "box4" && ground[y, col] != "box5" && ground[y, col] != "box6" && ground[y, col] != "box7" && ground[y, col] != "w")
                    {
                        character.Top -= 50;
                        box1.Top -= 50;
                        ground[row, col] = "e";
                        ground[x, col] = "c";
                        ground[y, col] = "box1";
                        row -= 1;
                        changePosition("box1", y, col);
                        moves++;
                    }
                }
                else if (ground[x, col] == "box2")
                {
                    if (ground[y, col] != "box1" && ground[y, col] != "box3" && ground[y, col] != "box4" && ground[y, col] != "box5" && ground[y, col] != "box6" && ground[y, col] != "box7" && ground[y, col] != "w")
                    {
                        character.Top -= 50;
                        box2.Top -= 50;
                        ground[row, col] = "e";
                        ground[x,col] = "c";
                        ground[y, col] = "box2";
                        row -= 1;
                        changePosition("box2", y, col);
                        moves++;
                    }
                }
                else if (ground[x,col] == "box3")
                {
                    if (ground[y, col] != "box1" && ground[y, col] != "box2" && ground[y, col] != "box4" && ground[y, col] != "box5" && ground[y, col] != "box6" && ground[y, col] != "box7" && ground[y, col] != "w")
                    {
                        character.Top -= 50;
                        box3.Top -= 50;
                        ground[row, col] = "e";
                        ground[x, col] = "c";
                        ground[y, col] = "box3";
                        row -= 1;
                        changePosition("box3", y, col);
                        moves++;
                    }
                }
                else if (ground[x,col] == "box4")
                {
                    if (ground[y, col] != "box1" && ground[y, col] != "box2" && ground[y, col] != "box3" && ground[y, col] != "box5" && ground[y, col] != "box6" && ground[y, col] != "box7" && ground[y, col] != "w")
                    {
                        character.Top -= 50;
                        box4.Top -= 50;
                        ground[row, col] = "e";
                        ground[x, col] = "c";
                        ground[y, col] = "box4";
                        row -= 1;
                        changePosition("box4", y, col);
                        moves++;
                    }
                }
                else if (ground[x,col] == "box5")
                {
                    if (ground[y, col] != "box1" && ground[y, col] != "box2" && ground[y, col] != "box3" && ground[y, col] != "box4" && ground[y, col] != "box6" && ground[y, col] != "box7" && ground[y, col] != "w")
                    {
                        character.Top -= 50;
                        box5.Top -= 50;
                        ground[row, col] = "e";
                        ground[x, col] = "c";
                        ground[y, col] = "box5";
                        row -= 1;
                        changePosition("box5", y, col);
                        moves++;
                    }
                }
                else if (ground[x,col] == "box6")
                {
                    if (ground[y, col] != "box1" && ground[y, col] != "box2" && ground[y, col] != "box3" && ground[y, col] != "box4" && ground[y, col] != "box5" && ground[y, col] != "box7" && ground[y, col] != "w")
                    {
                        character.Top -= 50;
                        box6.Top -= 50;
                        ground[row, col] = "e";
                        ground[x, col] = "c";
                        ground[y, col] = "box6";
                        row -= 1;
                        changePosition("box6", y, col);
                        moves++;
                    }
                }
                else if (ground[x,col] == "box7")
                {
                    if (ground[row, y] != "box1" && ground[y, col] != "box2" && ground[y, col] != "box3" && ground[y, col] != "box4" && ground[y, col] != "box5" && ground[y, col] != "box6" && ground[y, col] != "w")
                    {
                        character.Top -= 50;
                        box7.Top -= 50;
                        ground[row, col] = "e";
                        ground[x, col] = "c";
                        ground[y, col] = "box7";
                        row -= 1;
                        changePosition("box7", y, col);
                        moves++;
                    }
                }
                else
                {
                    character.Top -= 50;
                    ground[row, col] = "e";
                    ground[x,col] = "c";
                    row -= 1;
                    moves++;
                }
            }
            label1.Text = moves + " ";
            
        }

        private void btnRight_Click(object sender, EventArgs e)
        {   int x = col + 1;
            int y = col + 2;
            if (ground[row, x] != "w")
            {
                if (ground[row, x] == "box1")
                {
                    if (ground[row, y] != "box2" && ground[row, y] != "box3" && ground[row, y] != "box4" && ground[row, y] != "box5" && ground[row, y] != "box6" && ground[row, y] != "box7" && ground[row, y] != "w")
                    {
                        character.Left += 50;
                        box1.Left += 50;
                        ground[row, col] = "e";
                        ground[row, x] = "c";
                        ground[row, y] = "box1";
                        col += 1;
                        changePosition("box1", row, y);
                        moves++;
                    }
                }
                else if (ground[row, x] == "box2")
                {
                    if (ground[row, y] != "box1" && ground[row, y] != "box3" && ground[row, y] != "box4" && ground[row, y] != "box5" && ground[row, y] != "box6" && ground[row, y] != "box7" && ground[row, y] != "w")
                    {
                        character.Left += 50;
                        box2.Left += 50;
                        ground[row, col] = "e";
                        ground[row, x] = "c";
                        ground[row, y] = "box2";
                        col += 1;
                        changePosition("box2", row, y);
                        moves++;
                    }
                }
                else if (ground[row, x] == "box3")
                {
                    if (ground[row, y] != "box1" && ground[row, y] != "box2" && ground[row, y] != "box4" && ground[row, y] != "box5" && ground[row, y] != "box6" && ground[row, y] != "box7" && ground[row, y] != "w")
                    {
                        character.Left += 50;
                        box3.Left += 50;
                        ground[row, col] = "e";
                        ground[row, x] = "c";
                        ground[row, y] = "box3";
                        col += 1;
                        changePosition("box3", row, y);
                        moves++;
                    }
                }
                else if (ground[row, x] == "box4")
                {
                    if (ground[row, y] != "box1" && ground[row, y] != "box2" && ground[row, y] != "box3" && ground[row, y] != "box5" && ground[row, y] != "box6" && ground[row, y] != "box7" && ground[row, y] != "w")
                    {
                        character.Left += 50;
                        box4.Left += 50;
                        ground[row, col] = "e";
                        ground[row, x] = "c";
                        ground[row, y] = "box4";
                        col += 1;
                        changePosition("box4", row, y);
                        moves++;
                    }
                }
                else if (ground[row, x] == "box5")
                {
                    if (ground[row, y] != "box1" && ground[row, y] != "box2" && ground[row, y] != "box3" && ground[row, y] != "box4" && ground[row, y] != "box6" && ground[row, y] != "box7" && ground[row, y] != "w")
                    {
                        character.Left += 50;
                        box5.Left += 50;
                        ground[row, col] = "e";
                        ground[row, x] = "c";
                        ground[row, y] = "box5";
                        col += 1;
                        changePosition("box5", row, y);
                        moves++;
                    }
                }
                else if (ground[row, x] == "box6")
                {
                    if (ground[row, y] != "box1" && ground[row, y] != "box2" && ground[row, y] != "box3" && ground[row, y] != "box4" && ground[row, y] != "box5" && ground[row, y] != "box7" && ground[row, y] != "w")
                    {
                        character.Left += 50;
                        box6.Left += 50;
                        ground[row, col] = "e";
                        ground[row, x] = "c";
                        ground[row, y] = "box6";
                        col += 1;
                        changePosition("box6", row, y);
                        moves++;
                    }
                }
                else if (ground[row, x] == "box7")
                {
                    if (ground[row, y] != "box1" && ground[row, y] != "box2" && ground[row, y] != "box3" && ground[row, y] != "box4" && ground[row, y] != "box5" && ground[row, y] != "box6" && ground[row, y] != "w")
                    {
                        character.Left += 50;
                        box7.Left += 50;
                        ground[row, col] = "e";
                        ground[row, x] = "c";
                        ground[row, y] = "box7";
                        col += 1;
                        changePosition("box7", row, y);
                        moves++;
                    }
                }
                else {
                    character.Left += 50;
                    ground[row, col] = "e";
                    ground[row, x] = "c";
                    col += 1;
                    moves++;
                }
            }
            label1.Text = moves + " ";
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int x = row + 1;
            int y = row + 2;
            if (ground[x, col] != "w")
            {
                if (ground[x, col] == "box1")
                {
                    if (ground[y, col] != "box2" && ground[y, col] != "box3" && ground[y, col] != "box4" && ground[y, col] != "box5" && ground[y, col] != "box6" && ground[y, col] != "box7" && ground[y, col] != "w")
                    {
                        character.Top += 50;
                        box1.Top += 50;
                        ground[row, col] = "e";
                        ground[x, col] = "c";
                        ground[y, col] = "box1";
                        row += 1;
                        changePosition("box1", y, col);
                        moves++;
                    }
                }
                else if (ground[x, col] == "box2")
                {
                    if (ground[y, col] != "box1" && ground[y, col] != "box3" && ground[y, col] != "box4" && ground[y, col] != "box5" && ground[y, col] != "box6" && ground[y, col] != "box7" && ground[y, col] != "w")
                    {
                        character.Top += 50;
                        box2.Top += 50;
                        ground[row, col] = "e";
                        ground[x, col] = "c";
                        ground[y, col] = "box2";
                        row += 1;
                        changePosition("box2", y, col);
                        moves++;
                    }
                }
                else if (ground[x, col] == "box3")
                {
                    if (ground[y, col] != "box1" && ground[y, col] != "box2" && ground[y, col] != "box4" && ground[y, col] != "box5" && ground[y, col] != "box6" && ground[y, col] != "box7" && ground[y, col] != "w")
                    {
                        character.Top += 50;
                        box3.Top += 50;
                        ground[row, col] = "e";
                        ground[x, col] = "c";
                        ground[y, col] = "box3";
                        row += 1;
                        changePosition("box3", y, col);
                        moves++;
                    }
                }
                else if (ground[x, col] == "box4")
                {
                    if (ground[y, col] != "box1" && ground[y, col] != "box2" && ground[y, col] != "box3" && ground[y, col] != "box5" && ground[y, col] != "box6" && ground[y, col] != "box7" && ground[y, col] != "w")
                    {
                        character.Top += 50;
                        box4.Top += 50;
                        ground[row, col] = "e";
                        ground[x, col] = "c";
                        ground[y, col] = "box4";
                        row += 1;
                        changePosition("box4", y, col);
                        moves++;
                    }
                }
                else if (ground[x, col] == "box5")
                {
                    if (ground[y, col] != "box1" && ground[y, col] != "box2" && ground[y, col] != "box3" && ground[y, col] != "box4" && ground[y, col] != "box6" && ground[y, col] != "box7" && ground[y, col] != "w")
                    {
                        character.Top += 50;
                        box5.Top += 50;
                        ground[row, col] = "e";
                        ground[x, col] = "c";
                        ground[y, col] = "box5";
                        row += 1;
                        changePosition("box5", y, col);
                        moves++;
                    }
                }
                else if (ground[x, col] == "box6")
                {
                    if (ground[y, col] != "box1" && ground[y, col] != "box2" && ground[y, col] != "box3" && ground[y, col] != "box4" && ground[y, col] != "box5" && ground[y, col] != "box7" && ground[y, col] != "w")
                    {
                        character.Top += 50;
                        box6.Top += 50;
                        ground[row, col] = "e";
                        ground[x, col] = "c";
                        ground[y, col] = "box6";
                        row += 1;
                        changePosition("box6", y, col);
                        moves++;
                    }
                }
                else if (ground[x, col] == "box7")
                {
                    if (ground[row, y] != "box1" && ground[y, col] != "box2" && ground[y, col] != "box3" && ground[y, col] != "box4" && ground[y, col] != "box5" && ground[y, col] != "box6" && ground[y, col] != "w")
                    {
                        character.Top += 50;
                        box7.Top += 50;
                        ground[row, col] = "e";
                        ground[x, col] = "c";
                        ground[y, col] = "box7";
                        row += 1;
                        changePosition("box7", y, col);
                        moves++;
                    }
                }
                else
                {
                    character.Top += 50;
                    ground[row, col] = "e";
                    ground[x, col] = "c";
                    row += 1;
                    moves++;
                }
            }
            label1.Text = moves + " ";
            
        }

        private void game_Load(object sender, EventArgs e)
        {
            row = 3;
            col = 5;
            changePosition("box4",7,4);

                label1.Text = character.Left + " ";
        }

        void changePosition(string bName, int r, int c)
        {
            if (bName == "box4") {
                if ((r == 3 && c == 2) || (r == 4 && c == 6) || (r == 6 && c == 5) || (r == 5 && c == 2) || (r == 7 && c == 4) || (r == 7 && c == 7) || (r == 8 && c == 5))
                {
                    label2.Text=
                }
                else {
                    
                }
            }
            


            /*
            if (ground[3, 2] == "box1" ||ground[3, 2] == "box2" ||ground[3, 2] == "box3" ||ground[3, 2] == "box4" ||ground[3, 2] == "box5" ||ground[3, 2] == "box6" ||ground[3, 2] == "box7" )
            {
                b[0] = true;
            }
            if (ground[4, 6] == "box1" || ground[4, 6] == "box2" || ground[4, 6] == "box3" || ground[4, 6] == "box4" || ground[4, 6] == "box5" || ground[4, 6] == "box6" || ground[4, 6] == "box7")
            {
                b[1] = true;
            }
            if (ground[6, 5] == "box1" || ground[6, 5] == "box2" || ground[6, 5] == "box3" || ground[6, 5] == "box4" || ground[6, 5] == "box5" || ground[6, 5] == "box6" || ground[6, 5] == "box7")
            {
                b[2] = true;
            }
            if (ground[5, 2] == "box1" || ground[5, 2] == "box2" || ground[5, 2] == "box3" || ground[5, 2] == "box4" || ground[5, 2] == "box5" || ground[5, 2] == "box6" || ground[5, 2] == "box7")
            {
                b[3] = true;
            }
            if (ground[7, 4] == "box1" || ground[7, 4] == "box2" || ground[7, 4] == "box3" || ground[7, 4] == "box4" || ground[7, 4] == "box5" || ground[7, 4] == "box6" || ground[7, 4] == "box7")
            {
                b[4] = true;
            }
            if (ground[7, 7] == "box1" ||ground[7, 7] == "box2" ||ground[7, 7] == "box3" ||ground[7, 7] == "box4" ||ground[7, 7] == "box5" ||ground[7, 7] == "box6" ||ground[7, 7] == "box7" )
            {
                b[5] = true;
            }
            if (ground[8, 5] == "box1" || ground[8, 5] == "box2" || ground[8, 5] == "box3" || ground[8, 5] == "box4" || ground[8, 5] == "box5" || ground[8, 5] == "box6" || ground[8, 5] == "box7")
            {
                b[6] = true;
            }*/
            

        }
        void checkWin()
        {
            if (b[0] == true && b[1] == true && b[2] == true && b[3] == true && b[4] == true && b[5] == true && b[6] == true)
            {
                MessageBox.Show("WIn");
            }
        }

        private void target3_Click(object sender, EventArgs e)
        {

        }

        private void target1_Click(object sender, EventArgs e)
        {

        }

        private void game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Left)) {

                int top = character.Top;
                int left = character.Left;
                if (top == 100 && left >= 250 && left <= 300)
                    character.Left -= 50;
                else if (top == 150 && left >= 150 && left <= 300)
                    character.Left -= 50;
                else if (top == 200 && left >= 250 && left <= 300)
                    character.Left -= 50;
                else if (top == 250 && left >= 300 && left <= 300)
                    character.Left -= 50;
                else if (top == 300 && left >= 250 && left <= 300)
                    character.Left -= 50;
                else if (top == 350 && left >= 150 && left <= 350)
                    character.Left -= 50;
                else if (top == 400 && left >= 150 && left <= 350)
                    character.Left -= 50;
                //if (character.Left != 50)
                //  character.Left -= 50;

                label1.Text = character.Left + " ";

                Console.WriteLine("Left Key Pressed");
            
            }

            if (e.KeyCode.Equals(Keys.Right))


            {

                Console.WriteLine("Left Key Pressed");
                int top = character.Top;
                int left = character.Left;

                if (top == 100 && left >= 200 && left <= 250)
                    character.Left += 50;
                else if (top == 150 && left >= 100 && left <= 250)
                    character.Left += 50;
                else if (top == 200 && left >= 200 && left <= 250)
                    character.Left += 50;
                else if (top == 250 && left >= 250 && left <= 250)
                    character.Left += 50;
                else if (top == 300 && left >= 200 && left <= 250)
                    character.Left += 50;
                else if (top == 350 && left >= 100 && left <= 300)
                    character.Left += 50;
                else if (top == 400 && left >= 100 && left <= 300)
                    character.Left += 50;
                label1.Text = character.Left + " ";
                label2.Text = character.Top + " ";
  


            }
            
        }
        public void checkboxs() {

            


        
        }

        private void game_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void character_Click(object sender, EventArgs e)
        {

        }
    }


}
