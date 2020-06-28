using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financialManagement.Class
{
    class payer
    {
        public string payername { get; set; }
        public string contact { get; set; }
        public string frequent { get; set; }
        public string type { get; set; }


        static string myconnstrng = System.Configuration.ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public bool insert(payer p)
        {
            bool issucess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);


            try
            {
                string sql = "insert into payerpayee(name,contact,frequent,type) values(@name,@contact,@frequent,@type)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", p.payername.ToString());
                cmd.Parameters.AddWithValue("@contact", p.contact.ToString());
                cmd.Parameters.AddWithValue("@frequent", p.frequent.ToString());
                cmd.Parameters.AddWithValue("@type", p.type.ToString());
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    issucess = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return issucess;
        }

    public DataSet selectpayer()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataSet dt = new DataSet();

            try
            {
                string sql = "select * from payerpayee";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
