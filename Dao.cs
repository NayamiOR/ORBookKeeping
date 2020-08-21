using System.Data.SqlClient;

namespace OR记账
{
    class Dao
    {
        SqlConnection sc;
        public SqlConnection connect()
        {
            string str = @"Data Source=WIN-9K9BN29CRV8;Initial Catalog=BookKeeping;Integrated Security=True";
            SqlConnection sc = new SqlConnection(str);
            sc.Open();
            return sc;
        }
        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }
        public int Execute(string sql)//更新
        {
            return command(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(string sql)//读取
        {
            return command(sql).ExecuteReader();
        }
        public void DaoClose()
        {
            sc.Close();//关闭
        }
    }
}
