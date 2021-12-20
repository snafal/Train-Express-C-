using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Railway_express
{
    public class DBmanager
    {
        public static SqlConnection sqlCon;
        public static SqlCommand cmd;
        public static SqlDataAdapter sqlDa;

        public static SqlConnection getSqlConnection()
        {
            sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
            return sqlCon;
        }

        public static SqlDataReader readAndGet(string cmnd)
        {
            try
            {
                getSqlConnection();
                sqlCon.Open();
                cmd = new SqlCommand(cmnd, sqlCon);
                SqlDataReader sqlrd = cmd.ExecuteReader();
                return sqlrd;
            }
            catch (SqlException)
            {
                //
            }

            return null;

        }

        public static string getValue(string comd, string txt, int i, int j)
        {
            try
            {
                getSqlConnection();
                sqlCon.Open();
                cmd = new SqlCommand(comd, sqlCon);
                SqlDataReader sqlRd = cmd.ExecuteReader();
                string value = null;

                if (sqlRd.HasRows)
                {
                    while (sqlRd.Read())
                    {
                        if (sqlRd[i].ToString() == txt)
                        {
                            value = sqlRd[j].ToString();
                            break;
                        }
                    }
                }

                return value;
            }
            catch (SqlException)
            {
                //
            }

            return null;
        }

        public static string getRoll(string comd, string username, string password)
        {
            try
            {
                getSqlConnection();
                sqlCon.Open();
                cmd = new SqlCommand(comd, sqlCon);
                SqlDataReader sqlRd = cmd.ExecuteReader();
                string value = null;

                if (sqlRd.HasRows)
                {
                    while (sqlRd.Read())
                    {
                        if (sqlRd[3].ToString() == username && sqlRd[4].ToString() == password)
                        {
                            value = sqlRd[2].ToString();
                            break;
                        }
                    }
                }

                return value;
            }
            catch (SqlException)
            {
                //
            }

            return null;
        }

        public static int insrtUpdteDelt(string command)
        {
            int i = 0;
            try
            {
                getSqlConnection();
                sqlCon.Open();
                cmd = new SqlCommand(command, sqlCon);
                i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (SqlException)
            {
                //
            }

            return i;
        }

        [Obsolete]
        public static int insrtUpdteDelt(string command, string parameter, byte[] arr)
        {
            try
            {
                getSqlConnection();
                sqlCon.Open();
                cmd = new SqlCommand(command, sqlCon);
                cmd.Parameters.Add(parameter, arr);
                int i = cmd.ExecuteNonQuery();
                sqlCon.Close();
                return i;
            }
            catch (SqlException)
            {
                //
            }

            return 0;
        }

        public static int chek(string command)
        {
            int i = 0;
            try
            {
                getSqlConnection();
                sqlCon.Open();
                sqlDa = new SqlDataAdapter(command, sqlCon);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                if (dt.Rows.Count < 1)
                {
                    i = 0;
                }
                else
                {
                    i = 1;
                }
                sqlCon.Close();
                return i;
            }
            catch (SqlException)
            {
                //
            }

            return i;
        }

        public static DataTable getdata(string cmd)
        {
            try
            {
                getSqlConnection();
                sqlCon.Open();
                sqlDa = new SqlDataAdapter(cmd, sqlCon);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                sqlCon.Close();
                return dt;
            }
            catch (SqlException)
            {
                //
            }

            return null;
        }
    }
}
