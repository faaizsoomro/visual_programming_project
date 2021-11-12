using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace VP_Project
{
    public partial class Sokoban2 : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        string user="";
        string t = "";
        string[,] ground ={{"e","e","e","e","e","e","e","e","e","e"},
                       {"e","w","w","w","w","w","w","e","e","e"},
                       {"e","w","e","e","e","e","w","e","e","e"},
                       {"e","w","e","e","box1","e","w","w","e","e"},
                       {"e","w","e","e","w","t","t","w","w","w"},
                       {"e","w","w","e","box2","box3","t","box4","e","w"},
                       {"e","e","w","c","e","e","e","e","e","w"},
                       {"e","w","w","w","w","w","w","w","w","w"}
                          };
        int row;
        int col;
        int moves = 0;

        bool[] b = new bool[4];
        
        public Sokoban2()
        {
            InitializeComponent();
        }
        public Sokoban2(string u)
        {
            InitializeComponent();
            
        }

        private void Sokoban2_Load(object sender, EventArgs e)
        {
            label3.Text = "Player : " + user;
            label4.Text = "00:00:00";

            row = 6;
            col = 3;
            changePosition("box3", 5, 5);
            character.BackColor = System.Drawing.Color.Transparent;
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            btnRestart.BackColor = System.Drawing.Color.Transparent;
            btnExit.BackColor = System.Drawing.Color.Transparent;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            timer1.Start();
            stopwatch.Start();
            int x = col - 1;
            int y = col - 2;
            if (ground[row, x] != "w")
            {
                if (ground[row, x] == "box1")
                {
                    if (ground[row, y] != "box2" && ground[row, y] != "box3" && ground[row, y] != "box4" &&ground[row, y] != "w")
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
                    if (ground[row, y] != "box1" && ground[row, y] != "box3" && ground[row, y] != "box4" && ground[row, y] != "w")
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
                    if (ground[row, y] != "box1" && ground[row, y] != "box2" && ground[row, y] != "box4" && ground[row, y] != "w")
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
                    if (ground[row, y] != "box1" && ground[row, y] != "box2" && ground[row, y] != "box3" && ground[row, y] != "w")
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
            checkWin();
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            timer1.Start();
            stopwatch.Start();
            int x = row - 1;
            int y = row - 2;
            if (ground[x, col] != "w")
            {
                if (ground[x, col] == "box1")
                {
                    if (ground[y, col] != "box2" && ground[y, col] != "box3" && ground[y, col] != "box4" && ground[y, col] != "w")
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
                    if (ground[y, col] != "box1" && ground[y, col] != "box3" && ground[y, col] != "box4"  && ground[y, col] != "w")
                    {
                        character.Top -= 50;
                        box2.Top -= 50;
                        ground[row, col] = "e";
                        ground[x, col] = "c";
                        ground[y, col] = "box2";
                        row -= 1;
                        changePosition("box2", y, col);
                        moves++;
                    }
                }
                else if (ground[x, col] == "box3")
                {
                    if (ground[y, col] != "box1" && ground[y, col] != "box2" && ground[y, col] != "box4" &&  ground[y, col] != "w")
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
                else if (ground[x, col] == "box4")
                {
                    if (ground[y, col] != "box1" && ground[y, col] != "box2" && ground[y, col] != "box3" && ground[y, col] != "w")
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
                else
                {
                    character.Top -= 50;
                    ground[row, col] = "e";
                    ground[x, col] = "c";
                    row -= 1;
                    moves++;
                }
            }
            label1.Text = moves + " ";
            checkWin();
        }

        void changePosition(string bName ,int r,int c) {
            if (bName == "box1")
            {
                if ((r == 4 && c == 5) || (r == 4 && c == 6) || (r == 5 && c == 5) || (r == 5 && c == 6))
                {
                    b[0] = true;
                    this.box1.Image = global::VP_Project.Properties.Resources.fa131e99c85d29292f3e7490c286e24d__cartoon_game;
                }
                else
                {
                    b[0] = false;
                    this.box1.Image = global::VP_Project.Properties.Resources.box_clipart_wooden_box_11;
                }
            }
            if (bName == "box2")
            {
                if ((r == 4 && c == 5) || (r == 4 && c == 6) || (r == 5 && c == 5) || (r == 5 && c == 6))
                {
                    b[1] = true;
                    this.box2.Image = global::VP_Project.Properties.Resources.fa131e99c85d29292f3e7490c286e24d__cartoon_game;
                }
                else
                {
                    b[1] = false;
                    this.box2.Image = global::VP_Project.Properties.Resources.box_clipart_wooden_box_11;
                }
            }
            if (bName == "box3")
            {
                if ((r == 4 && c == 5) || (r == 4 && c == 6) || (r == 5 && c == 5) || (r == 5 && c == 6))
                {
                    b[2] = true;
                    this.box3.Image = global::VP_Project.Properties.Resources.fa131e99c85d29292f3e7490c286e24d__cartoon_game;
                }
                else
                {
                    b[2] = false;
                    this.box3.Image = global::VP_Project.Properties.Resources.box_clipart_wooden_box_11;
                }
            }
            if (bName == "box4")
            {
                if ((r == 4 && c == 5) || (r == 4 && c == 6) || (r == 5 && c == 5) || (r == 5 && c == 6))
                {
                    b[3] = true;
                    this.box4.Image = global::VP_Project.Properties.Resources.fa131e99c85d29292f3e7490c286e24d__cartoon_game;
                }
                else
                {
                    b[3] = false;
                    this.box4.Image = global::VP_Project.Properties.Resources.box_clipart_wooden_box_11;
                }
            }

            checkWin();
        }
        void checkWin()
        {
            if (b[0] == true && b[1] == true && b[2] == true && b[3] == true)
            {
                End obj =new End(user, moves, t);
                obj.Show();
                MessageBox.Show("You Won");
                this.Hide();
            }
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            timer1.Start();
            stopwatch.Start();
            int x = col + 1;
            int y = col + 2;
            if (ground[row, x] != "w")
            {
                if (ground[row, x] == "box1")
                {
                    if (ground[row, y] != "box2" && ground[row, y] != "box3" && ground[row, y] != "box4" && ground[row, y] != "w")
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
                    if (ground[row, y] != "box1" && ground[row, y] != "box3" && ground[row, y] != "box4"&& ground[row, y] != "w")
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
                    if (ground[row, y] != "box1" && ground[row, y] != "box2" && ground[row, y] != "box4"  && ground[row, y] != "w")
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
                    if (ground[row, y] != "box1" && ground[row, y] != "box2" && ground[row, y] != "box3" &&  ground[row, y] != "w")
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
                else
                {
                    character.Left += 50;
                    ground[row, col] = "e";
                    ground[row, x] = "c";
                    col += 1;
                    moves++;
                }
            }
            label1.Text = moves + " ";
            checkWin();
        }

        private void btnDown_Click(object sender, EventArgs e){
        timer1.Start();
            stopwatch.Start();
            int x = row + 1;
            int y = row + 2;
            if (ground[x, col] != "w")
            {
                if (ground[x, col] == "box1")
                {
                    if (ground[y, col] != "box2" && ground[y, col] != "box3" && ground[y, col] != "box4" && ground[y, col] != "w")
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
                    if (ground[y, col] != "box1" && ground[y, col] != "box3" && ground[y, col] != "box4" &&  ground[y, col] != "w")
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
                    if (ground[y, col] != "box1" && ground[y, col] != "box2" && ground[y, col] != "box4" &&  ground[y, col] != "w")
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
                    if (ground[y, col] != "box1" && ground[y, col] != "box2" && ground[y, col] != "box3" && ground[y, col] != "w")
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
            checkWin();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string s = "" + stopwatch.Elapsed;
            t = s.Substring(0, 8);
            label4.Text = t;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    btnLeft_Click(new object(), new EventArgs());
                    return true;

                case Keys.Up:
                    btnUP_Click(new object(), new EventArgs());
                    return true;

                case Keys.Down:
                    btnDown_Click(new object(), new EventArgs());
                    return true;

                case Keys.Right:
                    btnRight_Click(new object(), new EventArgs());
                    return true;



            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Sokoban2 newObj = new Sokoban2(user);
            newObj.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
