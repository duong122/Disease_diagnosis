using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuanDoanBenh
{
    internal class KetNoi
    {
        private string strCon = "Data Source=DUONG\\SQLEXPRESS;Initial Catalog=MedicalDatabase;Integrated Security=True";
        private SqlConnection conn;

        public KetNoi()
        {
            conn = new SqlConnection(strCon);
        }
        public DataSet LayDuLieu(string query)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(ds);
                return ds;
            }
            catch
            {
                return null!;
            }
        }
        public bool ThucThi(string query)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                return r > 0;
            }
            catch(SqlException exeption)
            {
                System.Diagnostics.Debug.WriteLine(exeption.StackTrace);
                return false;
            }

        }
        public bool ThucThiDuyNhat(string query)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int count = (int)cmd.ExecuteScalar();
                conn.Close();
                return count > 0;
            }
            catch
            {
                return false;
            }
        }

    }
}
