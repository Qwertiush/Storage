using MySql.Data.MySqlClient;
using System.Data;

namespace Storage
{
    internal class StorageDataBase
    {
        private const string ConnectionString = "Server=localhost;Database=storage;Uid=root;Pwd=;";

        public void AddItemToDatabase(string name, string code)
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            MySqlCommand cmd;

                connection.Open();
                try
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "INSERT INTO items(Name, Code, Status) VALUES(@name,@code,@status)";
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@status", 1);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.Write(ex.ToString());
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }

        }
        public bool CheckIfItemExists(string barCode)
        {
            MySqlConnection con = new MySqlConnection(ConnectionString);
            MySqlCommand cmd;

            bool result = false;

            con.Open();
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM items WHERE code = @code;";
                cmd.Parameters.AddWithValue("@code", barCode);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }

            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();

                }
            }
            return result;
        }

        public void UpdateItemInfo(string code, int status, string path, bool returned)
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            MySqlCommand cmd;

            string command = "UPDATE items SET status = @status, pathtosignature = @path, returned = @emty WHERE code = @code;";
            if (returned)
            {
                command = "UPDATE items SET status = @status, returned = @path WHERE code = @code;";
            }
            

            connection.Open();
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = command;
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@path", path);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@emty", "");
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public string CheckItemsStatus(string code)
        {
            MySqlConnection con = new MySqlConnection(ConnectionString);
            MySqlCommand cmd;

            string result = "2";

            con.Open();
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM items WHERE code = @code;";
                cmd.Parameters.AddWithValue("@code", code);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    result = reader["status"].ToString();
                }

            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();

                }
            }
            return result;
        }

        public void ShowDatabase(DataGridView dgv)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(ConnectionString);
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM items;", con);

                con.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds,"items");
                dgv.DataSource = ds.Tables["items"];

                con.Close();

            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }

        }

        public void SearchNameOrBarcode(string name, int statusIndex, DataGridView dgv)
        {
            string command;

            switch (statusIndex)
            {
                case 0: command = "SELECT * FROM items WHERE (name LIKE @name OR code LIKE @name)"; break;
                case 1: command = "SELECT * FROM items WHERE (name LIKE @name OR code LIKE @name) AND Status = 1;"; break;
                case 2: command = "SELECT * FROM items WHERE (name LIKE @name OR code LIKE @name) AND Status = 0;"; break;
                    default: command = "SELECT * FROM items"; break;
            }

            try
            {
                MySqlConnection con = new MySqlConnection(ConnectionString);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command, con);
                adapter.SelectCommand.Parameters.AddWithValue("@name","%" + name + "%");

                con.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "items");
                dgv.DataSource = ds.Tables["items"];

                con.Close();

            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }
    }
}
