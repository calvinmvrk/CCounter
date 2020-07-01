﻿using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ComboCounter.Classes
{
    class DBConnection
    {
        private const String SERVER = "localhost";
#if NEW_DB
        private const String DATABASE = "combo_counter";
#else
        private const String DATABASE = "project";
#endif
        private const String UID = "root";
        private const String PASSWORD = "root";
        private static MySqlConnection dbConn;

        private static DBConnection instance;


        /// <summary>
        /// Returns an instance of DBConnection if it has been created
        /// Creates a new instance using the private constructor and returns otherwise
        /// </summary>
        /// <returns></returns>
        public static DBConnection getInstance()
        {
            if (instance == null)
            {
                instance = new DBConnection();
            }
            return instance;
        }

        private DBConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder()
            {
                Server = SERVER,
                UserID = UID,
                Password = PASSWORD,
                Database = DATABASE,
                SslMode = MySqlSslMode.None
            };

            String connString = builder.ToString();
         
            dbConn = new MySqlConnection(connString);
            Application.ApplicationExit += (sender, args) =>
            {
                if (dbConn != null)
                {
                    dbConn.Dispose();
                    dbConn = null;
                }
            };
        }

#if NEW_DB
        /// <summary>
        /// insertUser takes the inputs and inserts the user information into the database 
        /// If it is successful it returns a new User otherwise it returns null
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="sex"></param>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        /// <param name="year"></param>
        /// <returns>If successful the new user, null otherwise</returns>
        public User insertUser(int id, String username, String password, String fName, String lName, String sex,
            int height, int weight, int year)
        {
            String query = "INSERT into " + DATABASE + ".user(user_id, username, password, first_name," +
                " last_name, sex, height, weight, birth_year) values (@id, @username, @password, @fname, @lname, @sex, @height, @weight, @year);";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();

            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("fname", fName);
            cmd.Parameters.AddWithValue("lname", lName);
            cmd.Parameters.AddWithValue("sex", sex);
            cmd.Parameters.AddWithValue("height", height);
            cmd.Parameters.AddWithValue("weight", weight);
            cmd.Parameters.AddWithValue("year", year);

            int success = cmd.ExecuteNonQuery();
            dbConn.Close();

            if (success == 1)
            {
                User newUser = new User(id, username, password, fName, lName, sex, height, weight, year);

                return newUser;
            }
            return null;

        }

#else

        /// <summary>
        /// insertUser takes the inputs and inserts the user information into the database 
        /// If it is successful it returns a new User otherwise it returns null
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="sex"></param>
        /// <param name="wClass"></param>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        /// <param name="age"></param>
        /// <returns>If successful the new user, null otherwise</returns>
        public User insertUser(int id, String username, String password, String fName, String lName, String sex,
            String wClass, String height, String weight, int age)
        {
            String query = "INSERT into " + DATABASE + ".users(id, username, password, fname, lname, sex, height, weight, " +
                "class, age) values (@id, @username, @password, @fname, @lname, @sex, @height, @weight, @class, @age);";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("fname", fName);
            cmd.Parameters.AddWithValue("lname", lName);
            cmd.Parameters.AddWithValue("sex", sex);
            cmd.Parameters.AddWithValue("height", height);
            cmd.Parameters.AddWithValue("weight", weight);
            cmd.Parameters.AddWithValue("class", wClass);
            cmd.Parameters.AddWithValue("age", age);

            int success = cmd.ExecuteNonQuery();
            dbConn.Close();

            if (success == 1)
            {
                User newUser = new User(id, username, password, fName, lName, sex, wClass, height, weight, age);

                return newUser;
            }
            return null;

        }

#endif

#if NEW_DB
        /// <summary>
        /// getLogin checks the login information against the information stored in the database
        /// If the login info is correct the user's information is pulled from the database and is returned
        /// If the login info is incorrect a null value is returned
        /// </summary>
        /// <param name="uName">The username provided in the login form</param>
        /// <param name="pWord">The password provided in the login form</param>
        /// <returns></returns>
        public User getLogin(string uName, string pWord)
        {
            String query = "SELECT username, password FROM " + DATABASE + ".user WHERE username=@username";

            MySqlCommand verifyCmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            verifyCmd.Parameters.AddWithValue("username", uName);

            MySqlDataReader reader = verifyCmd.ExecuteReader();

            bool isCorrect = false;

            while (reader.Read())
            {
                isCorrect = pWord == (reader["password"].ToString());
            }

            reader.Close();

            if (isCorrect)
            {
                String getUserQuery = "SELECT * FROM " + DATABASE + ".user WHERE username = @username";

                MySqlCommand getUserCmd = new MySqlCommand(getUserQuery, dbConn);

                getUserCmd.Parameters.AddWithValue("username", uName);
                MySqlDataReader userReader = getUserCmd.ExecuteReader();

                User newUser;

                if (userReader.Read())
                {
                    newUser = new User(
                        userReader.GetInt32("user_id"),
                        userReader.GetString("username"),
                        userReader.GetString("password"),
                        userReader.GetString("first_name"),
                        userReader.GetString("last_name"),
                        userReader.GetString("sex"),
                        userReader.GetInt32("height"),
                        userReader.GetInt32("weight"),
                        userReader.GetInt32("birth_year")
                        );
                    dbConn.Close();
                    return newUser;
                }
                dbConn.Close();
                return null;

            }
            dbConn.Close();
            return null;
        }
#else
        /// <summary>
        /// getLogin checks the login information against the information stored in the database
        /// If the login info is correct the user's information is pulled from the database and is returned
        /// If the login info is incorrect a null value is returned
        /// </summary>
        /// <param name="uName">The username provided in the login form</param>
        /// <param name="pWord">The password provided in the login form</param>
        /// <returns></returns>
        public User getLogin(string uName, string pWord)
        {
            String query = "SELECT username, password FROM " + DATABASE + ".users WHERE username=@username";

            MySqlCommand verifyCmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            verifyCmd.Parameters.AddWithValue("username", uName);

            MySqlDataReader reader = verifyCmd.ExecuteReader();

            bool isCorrect = false;

            while (reader.Read())
            {
                isCorrect = pWord == (reader["password"].ToString());
            }

            reader.Close();

            if (isCorrect)
            {
                String getUserQuery = "SELECT * FROM " + DATABASE + ".users WHERE username = @username";

                MySqlCommand getUserCmd = new MySqlCommand(getUserQuery, dbConn);

                getUserCmd.Parameters.AddWithValue("username", uName);
                MySqlDataReader userReader = getUserCmd.ExecuteReader();

                User newUser;

                if (userReader.Read())
                {
                    newUser = new User(
                        (int)userReader["id"],
                        uName,
                        userReader["password"].ToString(),
                        userReader["fname"].ToString(),
                        userReader["lname"].ToString(),
                        userReader["sex"].ToString(),
                        userReader["class"].ToString(),
                        userReader["height"].ToString(),
                        userReader["weight"].ToString(),
                        Int32.Parse(userReader["age"].ToString())
                        );
                    dbConn.Close();
                    return newUser;
                }
                dbConn.Close();
                return null;
                
            }
            dbConn.Close();
            return null;
        }

#endif

        public UserSettings CreateNewUserSettings(int UserID)
        {
            dbConn.Open();
            string Query = "INSERT INTO " + DATABASE + ".user_settings" +
                " (`fk_user_id`) VALUES (@userID);";

            MySqlCommand cmd = new MySqlCommand(Query, dbConn);

            cmd.Parameters.AddWithValue("userID", UserID);
            int success = cmd.ExecuteNonQuery();

            dbConn.Close();
            
            if (success >= 0)
            {
                return ReadUserSettings(UserID);
            }
            return new UserSettings();

        }

        public UserSettings ReadUserSettings(int userID) {

            dbConn.Open();

            string Query = "SELECT color_scheme, AscendingClock, TurnOffTimers, TurnOffVisualFeedback," +
                    "TurnOffHitSounds, TurnOffMissSounds FROM " + DATABASE + ".user_settings " +
                    "WHERE fk_user_id = @userID;";

            MySqlCommand readSettingsCmd = new MySqlCommand(Query, dbConn);
            readSettingsCmd.Parameters.AddWithValue("userID", userID);

            MySqlDataReader reader = readSettingsCmd.ExecuteReader();

            dbConn.Close();

            if (reader.HasRows)
            {
                UserSettings settings = new UserSettings(
                    reader.GetInt32("color_scheme"),
                    reader.GetBoolean("AscendingClock"),
                    reader.GetBoolean("TurnOffTimers"),
                    reader.GetBoolean("TurnOffVisualFeedback"),
                    reader.GetBoolean("TurnOffHitSound"),
                    reader.GetBoolean("TurnOffMissSound")
                    );
                return settings;
            }

            return new UserSettings();

        }

    }
}
