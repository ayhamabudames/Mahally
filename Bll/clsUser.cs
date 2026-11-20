using Bll.Utilities;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class clsUser
    {
        public static async Task<User_DTO> LoginAsync(string username, string password)
        {
            return await dalUser.LoginAsync(username, clsUtilities.ComputeHash256(password));
        }

        public static async Task<List<User_DTO>> GetAllUsersAsync()
        {
            return await dalUser.GetAllUsersAsync();
        }

        public static async Task<List<User_DTO>> GetAllActiveUsersAsync()
        {
            return await dalUser.GetAllActiveUsersAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newUser"></param>
        /// <param name="passwordHash"></param>
        /// <returns>New User ID (if -1 it means no userd added / error) </returns>
        public static async Task<int> AddNewUser(User_DTO newUser, string password)
        {
            return await dalUser.AddNewUser(newUser, clsUtilities.ComputeHash256(password));
        }

        public static async Task<bool> UpdateUserInfoAsync(int userID, string fullName, byte role)
        {
            return await dalUser.UpdateUserInfoAsync(userID, fullName, role);
        }

        public static async Task<bool> UpdateUserPasswordAsync(int userID, string currentPassword, string newPassword)
        {
            return await dalUser.
                UpdateUserPasswordAsync(userID,
                                        clsUtilities.ComputeHash256(currentPassword),
                                        clsUtilities.ComputeHash256(newPassword));
        }

        public static async Task<User_DTO> GetUserByIDAsync(int userID)
        {
            return await dalUser.GetUserByIDAsync(userID);
        }

        public static async Task<bool> ActivateUserAsync(int userID)
        {
            return await dalUser.ActivateUserAsync(userID);
        }

        public static async Task<bool> DeactivateUserAsync(int userID)
        {
            return await dalUser.DeactivateUserAsync(userID);
        }

        public static async Task<bool> IsUserExistByUsername(string Username)
        {
            return await dalUser.IsUserExistByUsername(Username);
        }

        public static async Task<bool> IsUserExistByID(int UserID)
        {
            return await dalUser.IsUserExistByID(UserID);
        }

    }
}
