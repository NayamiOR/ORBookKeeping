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
            Table();
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
            new Form2().ShowDialog();
        }
        //从数据库读取数据并显示
        public void Table()
        {
            this.dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = "select * from Table_3";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(),dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
    }
}
