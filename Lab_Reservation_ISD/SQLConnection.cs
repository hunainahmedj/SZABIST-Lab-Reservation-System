using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Reservation_ISD
{
    class SQLConnection
    {
        SqlConnection Con;
        Student _student;
        public String ConnStr = "Server=10.0.9.100\\SQLEXPRESS;Database=ISDLabProject;Integrated Security=SSPI;";

        public SQLConnection()
        {
            Con = new SqlConnection(ConnStr);
        }

        public SqlConnection GetSql()
        {
            return Con;
        }

        public void ProcessDB(string sp_Name, string[] param, object[] value)
        {
            Con.Open();
            SqlCommand Command = Con.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = sp_Name;
            for (int i = 0; i < param.Length; i++)
            {
                Command.Parameters.Add(new SqlParameter(param[i], value[i]));
            }
            Command.ExecuteNonQuery();
            Con.Close();
        }

        public Student Login(string sp_Name, string[] param, string[] value)
        {
            _student = new Student();
            Con.Open();
            SqlCommand Command = Con.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = sp_Name;
            for (int i = 0; i < param.Length; i++)
            {
                Command.Parameters.Add(new SqlParameter(param[i], value[i]));
            }
            SqlDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {

                _student.ID = Int32.Parse(reader["std_id"].ToString());
                _student.RegID = reader["std_regID"].ToString();
                _student.FName = reader["std_fName"].ToString();
                _student.LName = reader["std_lName"].ToString();
                _student.Password = reader["std_pass"].ToString();
                _student.Status = reader["std_status"].ToString();

            }
            if (_student != null)
            {
                Con.Close();
                return _student;
            } 
            else
            {
                return _student = null;
            }
        }

        public Reservation checkReservation(string spName, string[] param, object[] value)
        {
            Reservation _reservation = new Reservation();
            Con.Open();
            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = spName;
            for (int i = 0; i < param.Length; i++)
            {
                cmd.Parameters.Add(new SqlParameter(param[i], value[i]));
            }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                _reservation.Date = (DateTime)reader["r_date"];
                _reservation.Slot = (int)reader["s_id"];
                _reservation.Device = (int)reader["d_id"];
            }
            Con.Close();
            return _reservation;

        }


        public int Get_Count(string spName, string[] param, Object[] value)
        {
            int count = 0;
            Con.Open();
            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = spName;
            for (int i = 0; i < param.Length; i++)
            {
                cmd.Parameters.Add(new SqlParameter(param[i], value[i]));
            }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                count = Convert.ToInt32(reader[0].ToString());
            }
            Con.Close();
            return count;
        }



        public DataTable GetViews(string spName)
        {

            Con.Open();
            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = spName;
            DataTable _dataTable = new DataTable();
            SqlDataAdapter _sqlDataAdapter = new SqlDataAdapter(cmd);
            _sqlDataAdapter.Fill(_dataTable);
            Con.Close();
            return _dataTable;

        }

        public DataTable GetViews(string spName, string[] param, object[] value)
        {

            Con.Open();
            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = spName;
            for (int i = 0; i < param.Length; i++)
            {
                cmd.Parameters.Add(new SqlParameter(param[i], value[i]));
            }
            DataTable _dataTable = new DataTable();
            SqlDataAdapter _sqlDataAdapter = new SqlDataAdapter(cmd);
            _sqlDataAdapter.Fill(_dataTable);
            Con.Close();
            return _dataTable;

        }
    }
}
