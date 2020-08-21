using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OR记账
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (Control a in this.Controls)
            {
                if(a is Panel)
                {
                    a.Visible = false;
                }
                if (a.Name == "panel1")
                    a.Visible = true;
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (Control a in this.Controls)
            {
                if (a is Panel)
                {
                    if (a.Name == "panel1")
                    {
                        a.Visible = true;
                    }
                    else
                    {
                        a.Visible = false;
                    }
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (Control a in this.Controls)
            {
                if (a is Panel)
                {
                    if (a.Name == "panel2")
                    {
                        a.Visible = true;
                    }
                    else
                    {
                        a.Visible = false;
                    }
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            foreach (Control a in this.Controls)
            {
                if (a is Panel)
                {
                    if (a.Name == "panel3")
                    {
                        a.Visible = true;
                    }
                    else
                    {
                        a.Visible = false;
                    }
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            foreach (Control a in this.Controls)
            {
                if (a is Panel)
                {
                    if (a.Name == "panel4")
                    {
                        a.Visible = true;
                    }
                    else
                    {
                        a.Visible = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
