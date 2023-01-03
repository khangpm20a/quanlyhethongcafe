using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DATACon
    {
        private string connectionString = @"Data Source=DESKTOP-BNVVC18\SQLEXPRESS;Initial Catalog=QLCFF;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        private DataTable table;
        private string str = "";

        public DATACon()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                return;
            }
            finally
            {
                connection.Close();

            }
        }

        public DataTable selectData(string sql, List<PRS> parameters)
        {
            try
            {
                connection.Open();
                command = new SqlCommand(str, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = sql;
                foreach (var p in parameters) { command.Parameters.AddWithValue(p.Key, p.Value); }
                table = new DataTable();
                table.Load(command.ExecuteReader());
                return table;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                connection?.Close();
            }
        }
        public DataTable selectData(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            connection?.Close();

        }
        public DataRow Select(string str)
        {
            try
            {
                connection.Open();

                command = new SqlCommand(str, connection);
                table = new DataTable();
                table.Load(command.ExecuteReader());
                return table.Rows[0];

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public int Execute(string str, List<PRS> PRSs)
        {
            try
            {
                connection.Open();
                command = new SqlCommand(str, connection);
                command.CommandType = CommandType.StoredProcedure;
                foreach (var p in PRSs)
                {
                    command.Parameters.AddWithValue(p.Key, p.Value);
                }

                var re = command.ExecuteNonQuery();
                return (int)re;
            }
            catch (Exception ex)
            {
                return -100;
            }
            finally
            {
                connection.Close();
            }
        }
        public int Execute(string str)
        {
            try
            {
                connection.Open();
                command = new SqlCommand(str, connection);
                command.CommandType = CommandType.StoredProcedure;
                var re = command.ExecuteNonQuery();
                return (int)re;
            }
            catch (Exception ex)
            {
                return -100;
            }
            finally
            {
                connection.Close();
            }
        }


    }
}

