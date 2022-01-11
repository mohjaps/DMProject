using DMProject.Models.Principles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMProject.Models
{
    internal static class DatabaseCongfigurations
    {
        private static SqlConnection Connection()
        {
            return new SqlConnection("Data Source=.;Initial Catalog=FinalProejct;Integrated Security=True");
        }
        //Returns An Admin
        public static Admin GetAdmin(int id)
        {
            SqlConnection conn = Connection();
            string cmm = "Select Id, Username, Password From Admins Where Id = @Id";
            SqlCommand cmd = new SqlCommand(cmm, conn);
            cmd.Parameters.AddWithValue("@Id", id);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.Read())
                {
                    Admin admin = new Admin()
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString()
                    };
                    return admin;
                }
                else return null;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        //Returns All Players
        public static List<Player> GetPlayers()
        {
            SqlConnection conn = Connection();
            string cmm = "Select Id, Name, Age, Score, LastLogin From Players";
            SqlCommand cmd = new SqlCommand(cmm, conn);
            try
            {
                conn.Open();
                List<Player> Players = new List<Player>();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
                while (reader.Read())
                {
                    Player admin = new Player()
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Name = reader["Name"].ToString(),
                        Age = int.Parse(reader["Name"].ToString()),
                        Score = int.Parse(reader["Name"].ToString()),
                        LastLogin = DateTime.Parse(reader["Name"].ToString()),
                    };
                    Players.Add(admin);
                }
                return Players;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        //Returns A Player
        public static Player GetPlayer(int id)
        {
            SqlConnection conn = Connection();
            string cmm = "Select Id, Name, Age, Score, LastLogin From Players Where Id = @Id";
            SqlCommand cmd = new SqlCommand(cmm, conn);
            cmd.Parameters.AddWithValue("@Id", id);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.Read())
                {
                    Player playerPlus = new Player()
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Name = reader["Name"].ToString(),
                        Age = int.Parse(reader["Name"].ToString()),
                        Score = int.Parse(reader["Name"].ToString()),
                        LastLogin = DateTime.Parse(reader["Name"].ToString()),
                    };
                    return playerPlus;
                }
                else return null;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        //Inserts A Player
        public static int AddPlayer(Player player)
        {
            SqlConnection conn = Connection();
            string cmm = "Insert Into Players (Name, Age) Values (@Name, @Age)";
            SqlCommand cmd = new SqlCommand(cmm, conn);
            cmd.Parameters.AddWithValue("@Name", player.Name);
            cmd.Parameters.AddWithValue("@Age", player.Name);
            try
            {
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        //Deletes A Player
        public static int DeletePlayer(int Id)
        {
            SqlConnection conn = Connection();
            string cmm = "Delete From Players Where Id = @Id";
            SqlCommand cmd = new SqlCommand(cmm, conn);
            cmd.Parameters.AddWithValue("@Id", Id);
            try
            {
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        //Updates A Player
        public static int UpdatePlayer(Player player)
        {
            SqlConnection conn = Connection();
            string cmm = "Update Players Set Score = @Score, LastLogin = @LastLogin Where Id = @Id";
            SqlCommand cmd = new SqlCommand(cmm, conn);
            cmd.Parameters.AddWithValue("@Id", player.Id);
            cmd.Parameters.AddWithValue("@Score", player.Score);
            cmd.Parameters.AddWithValue("@LastLogin", player.LastLogin);
            try
            {
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
