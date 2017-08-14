using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Test_WindowsFormsApp
{
    class Data_Code
    {
    }
    public class DB
    {
        string _connectionstring = @"Data Source=.;Initial Catalog=Sky_Cable;Integrated Security=True;Pooling=False";
        string _connectionstring1 = String.Format("Data Source=52.163.221.206;Initial Catalog=Sky_Cable;User Id=sa;Password=Akhilesh@123;");
        //"Data Source=SUDEEP-PC\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\login.mdf;Integrated Security=True";

        private SqlConnection myconnection()
        {
            SqlConnection con = new SqlConnection(_connectionstring1);
            return con;
        }

        public int InsertUpdateDelete(string query)
        {
            SqlConnection con = myconnection();
            con.Open();
            SqlCommand com = new SqlCommand(query, con);
            int result = com.ExecuteNonQuery();
            con.Close();
            return result;

        }
        public string enQry(string qr)
        {

            SqlConnection con = myconnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(qr, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                qr = dr["movie_name"].ToString();
            }
            return qr;
            con.Close();
        }
        public DataSet getData(string query)
        {
            SqlConnection con = myconnection();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            da.Fill(dt);
            return ds;

        }
        public DataTable getData2(string query)
        {
            SqlConnection con = myconnection();
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);
            return dt;
        }
        public SqlDataReader getDataDataRedr(string qry)
        {
            SqlCommand cmd;
            SqlConnection con = myconnection();
            con.Open();
            cmd = new SqlCommand(qry, con);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public Boolean CheckDuplicateRecord(String query)
        {
            Boolean flag = false;
            SqlConnection con = myconnection();
            con.Open();
            SqlCommand com = new SqlCommand(query, con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                flag = true;
            }
            dr.Close();
            con.Close();
            return flag;
        }
       /* public int Addusers(clsUsers obj)
        {

            SqlConnection con = myconnection();
            string query = "Insert into user_regi values('" + obj.UserName + "','" + obj.Password + "','" + obj.FirstName + "','" + obj.LastName + "'," + Convert.ToInt64(obj.ContactNumber) + ",'" + obj.Dob + "','" + obj.Gender + "','" + obj.EmailID + "','" + obj.Address + "')";

            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {

            }*/
        }
    }


