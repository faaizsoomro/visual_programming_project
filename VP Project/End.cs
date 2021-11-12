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
    public partial class End : Form
    {
        string user="";
        int moves=0;
        string time="";
        public End(string u,int m,string t)
        {
            InitializeComponent();
            user = u;
            moves = m;
            time = t;
        }

        private void End_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            btnRestart.BackColor = System.Drawing.Color.Transparent;
            btnExit.BackColor = System.Drawing.Color.Transparent;
            label1.Text = "Player: "+user;
            label2.Text = "Moves: " + moves;
            label3.Text = "Time: " + time;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Sokoban1 obj = new Sokoban1(user);
            obj.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Sokoban2 obj = new Sokoban2(user);
            obj.Show();
            this.Hide();
        }
    }
}
