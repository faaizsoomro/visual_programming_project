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
    
    public partial class Start : Form
    {
        
        string user = "";
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
            label7.BackColor = System.Drawing.Color.Transparent;
            label8.BackColor = System.Drawing.Color.Transparent;
            
            btnStart.BackColor = System.Drawing.Color.Transparent;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            user = this.textBox1.Text;
            if (user == "")
            {
                label8.Text = "Please Enter Name";
            }
            else
            {
                this.Hide() ;
                Sokoban1 obj = new Sokoban1(user);
                obj.Show();        
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
                btnStart_Click(new object(), new EventArgs());
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
