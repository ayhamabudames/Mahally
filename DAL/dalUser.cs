using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalUser
    {

        public static async Task<User_DTO> LoginAsync(string username, string password)
        {
            User_DTO user = null;


            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_Login", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlParameter pUserID = cmd.Parameters.Add("@UserID", SqlDbType.Int);
                pUserID.Direction = ParameterDirection.Output;

                SqlParameter pFullName = cmd.Parameters.Add("@FullName", SqlDbType.NVarChar, 120);
                pFullName.Direction = ParameterDirection.Output;

                SqlParameter pRole = cmd.Parameters.Add("@Role", SqlDbType.TinyInt);
                pRole.Direction = ParameterDirection.Output;

                SqlParameter pIsActive = cmd.Parameters.Add("@IsActive", SqlDbType.Bit);
                pIsActive.Direction = ParameterDirection.Output;

                SqlParameter pUpdatedAt = cmd.Parameters.Add("@UpdatedAt", SqlDbType.DateTime);
                pUpdatedAt.Direction = ParameterDirection.Output;

                SqlParameter pReturn = cmd.Parameters.Add("@Return", SqlDbType.Int);
                pReturn.Direction = ParameterDirection.ReturnValue;

                await con.OpenAsync();
                await cmd.ExecuteNonQueryAsync();

                if ((int)pReturn.Value == 1)
                {
                    user = new User_DTO
                        (
                            (int)pUserID.Value,
                            username,
                            (string)pFullName.Value,
                            (byte)pRole.Value,
                            (bool)pIsActive.Value,
                            (DateTime)pUpdatedAt.Value
                       );
                }
                else
                {
                    user = null;
                }
            }

            return user;
        }

        public static async Task<List<User_DTO>> GetAllActiveUsersAsync()
        {
            List<User_DTO> users = new List<User_DTO>();

            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_GetAllActiveUsers", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                await con.OpenAsync();

                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        int colUserID = reader.GetOrdinal("UserID");
                        int colName = reader.GetOrdinal("FullName");
                        int colUsername = reader.GetOrdinal("Username");
                        int colPassword = reader.GetOrdinal("PasswordHash");
                        int colRole = reader.GetOrdinal("Role");
                        int colIsActive = reader.GetOrdinal("IsActive");
                        int colUpdatedAt = reader.GetOrdinal("UpdatedAt");

                        while (await reader.ReadAsync())
                        {
                            users.Add(
                                new User_DTO(
                                        reader.GetInt32(colUserID),
                                        reader.GetString(colUsername),
                                        reader.GetString(colName),
                                        reader.GetByte(colRole),
                                        reader.GetBoolean(colIsActive),
                                        reader.GetDateTime(colUpdatedAt)
                                    )
                                );
                        }
                    }
                }
            }

            return users;
        }

        public static async Task<List<User_DTO>> GetAllUsersAsync()
        {
            List<User_DTO> users = new List<User_DTO>();

            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_GetAllUsers", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                await con.OpenAsync();

                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        int colUserID = reader.GetOrdinal("UserID");
                        int colName = reader.GetOrdinal("FullName");
                        int colUsername = reader.GetOrdinal("Username");
                        int colPassword = reader.GetOrdinal("PasswordHash");
                        int colRole = reader.GetOrdinal("Role");
                        int colIsActive = reader.GetOrdinal("IsActive");
                        int colUpdatedAt = reader.GetOrdinal("UpdatedAt");

                        while (await reader.ReadAsync())
                        {
                            users.Add(
                                new User_DTO(
                                        reader.GetInt32(colUserID),
                                        reader.GetString(colUsername),
                                        reader.GetString(colName),
                                        reader.GetByte(colRole),
                                        reader.GetBoolean(colIsActive),
                                        reader.GetDateTime(colUpdatedAt)
                                    )
                                );
                        }
                    }
                }
            }

            return users;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newUser"></param>
        /// /// <param name="passwordHash">Hashed Password</param>
        /// <returns>New User ID (if -1 it means no userd added / error) </returns>
        public static async Task<int> AddNewUser(User_DTO newUser, string passwordHash)
        {
            int newUserAddedID = -1;
            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_AddNewUser", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FullName", newUser.Name);
                cmd.Parameters.AddWithValue("@Username", newUser.Username);
                cmd.Parameters.AddWithValue("@Password", passwordHash);
                cmd.Parameters.AddWithValue("@Role", newUser.Role);

                SqlParameter pReturn = cmd.Parameters.Add("@Return", SqlDbType.Int);
                pReturn.Direction = ParameterDirection.ReturnValue;

                SqlParameter pNewUserID = cmd.Parameters.Add("@NewUserID", SqlDbType.Int);
                pNewUserID.Direction = ParameterDirection.Output;

                await con.OpenAsync();
                await cmd.ExecuteNonQueryAsync();

                if ((int)pReturn.Value == 1)
                {
                    newUserAddedID = (int)pNewUserID.Value;
                }
            }

            return newUserAddedID;
        }

        public static async Task<bool> UpdateUserInfoAsync(int userID, string fullName, byte role)
        {
            bool result = false;
            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_UpdateUser", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserID", userID);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Role", role);

                SqlParameter pReturn = cmd.Parameters.Add("@Return", SqlDbType.Int);
                pReturn.Direction = ParameterDirection.ReturnValue;

                await con.OpenAsync();
                await cmd.ExecuteNonQueryAsync();

                if ((int)pReturn.Value == 1)
                {
                    result = true;
                }
            }
            return result;
        }

        public static async Task<bool> UpdateUserPasswordAsync(int userID, string currentPasswordHash, string newPasswordHash)
        {
            bool result = false;
            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_UpdateUserPassword", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserID", userID);
                cmd.Parameters.AddWithValue("@NewPassword", newPasswordHash);
                cmd.Parameters.AddWithValue("@CurrentPasswordHash", currentPasswordHash);

                SqlParameter pReturn = cmd.Parameters.Add("@Return", SqlDbType.Int);
                pReturn.Direction = ParameterDirection.ReturnValue;

                await con.OpenAsync();
                await cmd.ExecuteNonQueryAsync();

                if ((int)pReturn.Value == 1)
                {
                    result = true;
                }
            }
            return result;
        }

        public static async Task<User_DTO> GetUserByIDAsync(int userID)
        {
            User_DTO user = new User_DTO();

            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_GetUserByID", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserID", userID);


                await con.OpenAsync();
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    if (reader.HasRows )
                    {
                        int colUserID = reader.GetOrdinal("UserID");
                        int colName = reader.GetOrdinal("FullName");
                        int colUsername = reader.GetOrdinal("Username");
                        int colPassword = reader.GetOrdinal("PasswordHash");
                        int colRole = reader.GetOrdinal("Role");
                        int colIsActive = reader.GetOrdinal("IsActive");
                        int colUpdatedAt = reader.GetOrdinal("UpdatedAt");

                        while (await reader.ReadAsync())
                        {

                            user = new User_DTO(
                                     reader.GetInt32(colUserID),
                                     reader.GetString(colUsername),
                                     reader.GetString(colName),
                                     reader.GetByte(colRole),
                                     reader.GetBoolean(colIsActive),
                                     reader.GetDateTime(colUpdatedAt)
                                 );
                        }
                    }
                    else
                    {
                        user = null;
                    }
                }
            }
            return user;
        }
   
        public static async Task<bool> ActivateUserAsync(int userID)
        {
            bool result =false;

            using(SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using(SqlCommand cmd = new SqlCommand("USP_ActivateUser", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserID", userID);

                SqlParameter pReturn = cmd.Parameters.Add("@Return",SqlDbType.Int);
                pReturn.Direction = ParameterDirection.ReturnValue;

                await con.OpenAsync();
                await cmd.ExecuteNonQueryAsync();

                if((int)pReturn.Value == 1)
                {
                    result = true;
                }

            }
            return result;
        }

        public static async Task<bool> DeactivateUserAsync(int userID)
        {
            bool result = false;

            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_DeactivateUser", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserID", userID);

                SqlParameter pReturn = cmd.Parameters.Add("@Return", SqlDbType.Int);
                pReturn.Direction = ParameterDirection.ReturnValue;

                await con.OpenAsync();
                await cmd.ExecuteNonQueryAsync();

                if ((int)pReturn.Value == 1)
                {
                    result = true;
                }

            }
            return result;
        }

        public static async Task<bool> IsUserExistByUsername(string Username)
        {
            bool result = false;

            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_IsUserExistByUsername", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", Username);

                SqlParameter pIsFound = cmd.Parameters.Add("@IsFound", SqlDbType.Bit);
                pIsFound.Direction = ParameterDirection.Output;

                SqlParameter pReturn = cmd.Parameters.Add("@Return", SqlDbType.Int);
                pReturn.Direction = ParameterDirection.ReturnValue;

                await con.OpenAsync();
                await cmd.ExecuteNonQueryAsync();

                if ((bool)pIsFound.Value)
                {
                    result = true;
                }

            }
            return result;
        }

        public static async Task<bool> IsUserExistByID(int UserID)
        {
            bool result = false;

            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_IsUserExistByUsername", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserID", UserID);

                SqlParameter pIsFound = cmd.Parameters.Add("@IsFound", SqlDbType.Bit);
                pIsFound.Direction = ParameterDirection.Output;

                SqlParameter pReturn = cmd.Parameters.Add("@Return", SqlDbType.Int);
                pReturn.Direction = ParameterDirection.ReturnValue;

                await con.OpenAsync();
                await cmd.ExecuteNonQueryAsync();

                if ((bool)pIsFound.Value)
                {
                    result = true;
                }

            }
            return result;
        }
    }
}
