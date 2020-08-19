using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Reservation_ISD
{
    public class SqlMng
    {
        //string conStrings = "Server=DESKTOP-OT04Q7L\\SQLEXPRESS;Database=ISDLabProject;Integrated Security = SSPI";
        private static SqlMng sqlmng;
        static SqlConnection con;

        private SqlMng()
        {
            //con = new SqlConnection(conString);
        }

        public static SqlMng GetObject()
        {
            if (sqlmng == null)
            {
                sqlmng = new SqlMng();
                con = new SqlConnection("Server=10.0.9.100\\SQLEXPRESS;Database=ISDLabProject;Integrated Security = SSPI");
                return sqlmng;
            }
            return sqlmng;
        }

        //public void open()
        //{
        //    con.Open();
        //}

        //public void Close()
        //{
        //    con.Close();
        //}

        public void insertDB(string sp, string[] param, string[] value)
        {
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp;
            for (int i = 0; i < param.Length; i++)
            {
                command.Parameters.Add(new SqlParameter(param[i], value[i]));
            }
            command.ExecuteNonQuery();
            con.Close();
        }

        public void insertDB(string sp, string[] param, int[] value)
        {
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp;
            for (int i = 0; i < param.Length; i++)
            {
                command.Parameters.Add(new SqlParameter(param[i], value[i]));
            }
            command.ExecuteNonQuery();
            con.Close();
        }

        public Admin Login(string sp, string[] param, string[] val)
        {
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp;
            for (int i = 0; i < param.Length; i++)
            {
                command.Parameters.Add(new SqlParameter(param[i], val[i]));
            }
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    Admin a = new Admin(Convert.ToInt32(reader["a_id"]),
                                        Convert.ToString(reader["a_name"]),
                                        Convert.ToString(reader["a_pass"]),
                                        Convert.ToString(reader["a_email"]),
                                        Convert.ToChar(reader["a_status"]));
                    con.Close();
                    return a;
                }
            }
            con.Close();
            return new Admin();

        }


        public DataTable getTable(string sp)
        {
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
