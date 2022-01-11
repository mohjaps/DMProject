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
        public static Admin GetAdmin(string username)
        {
            SqlConnection conn = Connection();
            string cmm = "Select Username, Password From Admins Where Username = @Username";
            SqlCommand cmd = new SqlCommand(cmm, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.Read())
                {
                    Admin admin = new Admin()
                    {
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString()
                    };
                    return admin;
                }
                else return null;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
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
            string cmm = "Select Username, Name, Age, Score, LastLogin From Players";
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
                        Username = reader["Username"].ToString(),
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
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        //Returns A Player
        public static Player GetPlayer(string username)
        {
            SqlConnection conn = Connection();
            string cmm = "Select Username, Name, Age, Score, LastLogin From Players Where Username = @Username";
            SqlCommand cmd = new SqlCommand(cmm, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.Read())
                {
                    Player playerPlus = new Player()
                    {
                        Username = reader["Username"].ToString(),
                        Name = reader["Name"].ToString(),
                        Age = int.Parse(reader["Age"].ToString()),
                        Score = int.Parse(reader["Score"].ToString()),
                        LastLogin = DateTime.Parse(reader["LastLogin"].ToString()),
                    };
                    return playerPlus;
                }
                else return null;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
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
            string cmm = "Insert Into Players (Username, Name, Age) Values (@Username, @Name, @Age)";
            SqlCommand cmd = new SqlCommand(cmm, conn);
            cmd.Parameters.AddWithValue("@Username", player.Username);
            cmd.Parameters.AddWithValue("@Name", player.Name);
            cmd.Parameters.AddWithValue("@Age", player.Age);
            try
            {
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        //Deletes A Player
        public static int DeletePlayer(string Username)
        {
            SqlConnection conn = Connection();
            string cmm = "Delete From Players Where Username = @Username";
            SqlCommand cmd = new SqlCommand(cmm, conn);
            cmd.Parameters.AddWithValue("@Username", Username);
            try
            {
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
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
            string cmm = "Update Players Set Score = @Score, LastLogin = @LastLogin Where Username = @Username";
            SqlCommand cmd = new SqlCommand(cmm, conn);
            cmd.Parameters.AddWithValue("@Username", player.Username);
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
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        //Inserts A Round
        public static int AddRound(Round round)
        {
            SqlConnection conn = Connection();
            string cmm = "Insert Into Rounds (PlayerUsername, Score, RoundDateTime) Values (@PlayerUsername, @Score, @RoundDateTime)";
            SqlCommand cmd = new SqlCommand(cmm, conn);
            cmd.Parameters.AddWithValue("@PlayerUsername", round.PlayerUsername);
            cmd.Parameters.AddWithValue("@Score", round.Score);
            cmd.Parameters.AddWithValue("@RoundDateTime", round.RoundDateTime);
            try
            {
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
