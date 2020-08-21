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
        int radioValue=0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //取得radiobutton的结果决定是收入还是支出
            if (radioButton1.Checked == true)
            {
                radioValue = 1;
            }
            else
            {
                radioValue = 0;
            }
            int ID=114514;
            Dao dao = new Dao();
            string getID = $"select Max(ID) ID from Table_3";
            IDataReader IDReader = dao.read(getID);

            while (IDReader.Read())
            {
                ID = int.Parse(IDReader["ID"].ToString());
                ++ID;
            }
            string sql = $"insert into table_3 values('{ID}','{dateTimePicker1.Value}','{textBox2.Text}','{comboBox1.Text}','{radioValue}','{textBox1.Text}','{textBox3.Text}')";
            int n = dao.Execute(sql);
            if (n > 0)
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clean();
        }
        public void clean()
        {
            textBox2.Text = " ";
            textBox1.Text = " ";
            textBox3.Text = " ";
            comboBox1.Text = " ";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
