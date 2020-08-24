using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OR记账
{
    public partial class Form2 : Form
    {
        int radioValue = 0;
        public Form2()
        {
            InitializeComponent();
            clean();
        }
        //新建
        private void button1_Click(object sender, EventArgs e)
        {
            int ID = 114514;
            //取得radiobutton的结果决定是收入还是支出
            if (radioButton1.Checked == true)
            {
                radioValue = 1;
            }
            else
            {
                radioValue = 0;
            }
            checkEmpty();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clean();
        }
        //清空
        public void clean()
        {
            textBox2.Text = " ";
            textBox1.Text = " ";
            textBox3.Text = " ";
            comboBox1.Text = " ";
        }
        public void checkEmpty()
        {
            if (textBox2.Text == " " || textBox1.Text == " " || textBox3.Text == " " || comboBox1.Text == " ")
                MessageBox.Show("您有未填的账目信息，请填写后提交");
        }    

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }  
}
