using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_And_Ladder
{
   
    
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }
        
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void chkAI_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAI.Checked)
            {
                txtPlayer2.Hide();
                lblPlayer2.Hide();
            }
            else
            {
                txtPlayer2.Show();
                lblPlayer2.Show();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            GameBoard f1 = new GameBoard();
            f1.Show();
            this.Hide();
        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }
    }
}
