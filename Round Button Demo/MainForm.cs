using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Round_Button_Demo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello EJ. I am a computer program! How do you find me?", "HI!", MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hello Xianne Mae. Am I interesting?", "GREETINGS!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("THANK YOU VERY MUCH", "APPRECIATED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" :'( ", "SAD!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void circularButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
