using DMProject.Models.Principles;
using DMProject.Models.View_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMProject.Models
{
    internal static class DatabaseCongfigurations
    {
        static SqlConnection conn = Connection();
        private static SqlConnection Connection()
        {
            return new SqlConnection("Data Source=.;Initial Catalog=FinalProejct;Integrated Security=True");
        }
        //Returns An Admin
        public static Admin GetAdmin(string username)
        {
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
                        Age = int.Parse(reader["Age"].ToString()),
                        Score = int.Parse(reader["Score"].ToString()),
                        LastLogin = DateTime.Parse(reader["LastLogin"].ToString()),
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
            string cmm = "Insert Into Rounds (PlayerUsername, totalQuestions, solvedQuestions, selectedTables, timeConsumed, correct, wrong, Score, RoundDateTime) Values (@PlayerUsername, @totalQuestions, @solvedQuestions, @selectedTables, @timeConsumed, @correct, @wrong, @Score, @RoundDateTime)";
            SqlCommand cmd = new SqlCommand(cmm, conn);
            cmd.Parameters.AddWithValue("@PlayerUsername", round.PlayerUsername);
            cmd.Parameters.AddWithValue("@totalQuestions", round.totalQuestions);
            cmd.Parameters.AddWithValue("@solvedQuestions", round.solvedQuestions);
            cmd.Parameters.AddWithValue("@selectedTables", round.selectedTables);
            cmd.Parameters.AddWithValue("@timeConsumed", round.timeConsumed);
            cmd.Parameters.AddWithValue("@correct", round.correct);
            cmd.Parameters.AddWithValue("@wrong", round.wrong);
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
        //Gets Count Of Rounds Of A Specific User
        public static int RoundsCount(string username)
        {
            string comm = "Select Count(Id) As \"total\" From Rounds Where PlayerUsername = @PlayerUsername";
            SqlCommand sqlCommand = new SqlCommand(comm, conn);
            sqlCommand.Parameters.AddWithValue("@PlayerUsername", username);
            try
            {
                conn.Open();
                int result = -1;
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                    result = int.Parse(reader["total"].ToString());
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
        }        //Gets Count Of Rounds Of A Specific User
        public static int RoundsTotalScore(string username)
        {
            string comm = "Select Sum(Score) As \"Sum\" From Rounds Where PlayerUsername = @PlayerUsername";
            SqlCommand sqlCommand = new SqlCommand(comm, conn);
            sqlCommand.Parameters.AddWithValue("@PlayerUsername", username);
            try
            {
                conn.Open();
                int result = -1;
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                    result = int.Parse(reader["Sum"].ToString());
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
        
        public static BindingList<RoundView> GetRoundView()
        {
            string comm = "Select Name, \"Number Of Questions\", \"Round Score\", \"Total Time Consumed\", \"Round Time\"From ShowRounds";
            SqlCommand sqlCommand = new SqlCommand(comm, conn);
            try
            {
                conn.Open();
                BindingList<RoundView> result = new BindingList<RoundView>();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    RoundView RV = new RoundView()
                    {
                        Name = reader["Name"].ToString(),
                        totalQuestions = int.Parse(reader["Number Of Questions"].ToString()),
                        RoundScore = reader["Round Score"].ToString(),
                        TotalTimeConsumed = reader["Total Time Consumed"].ToString(),
                        RoundDateTime = DateTime.Parse(reader["Round Time"].ToString()),
                    };
                    result.Add(RV);
                }
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
