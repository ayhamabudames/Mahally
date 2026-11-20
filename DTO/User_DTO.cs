using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User_DTO
    {
        public enum enRole
        {
            Admin = 0,
            Cashier = 1,
        }
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public byte Role { get; set; }
        public enRole RoleInfo { get; set; }
        public bool IsActive { get; set; }
        public DateTime UpdatedAt { get; set; }

        public User_DTO(int userID, string username, string name, byte role, bool isActive, DateTime updatedAt)
        {
            UserID = userID;
            Username = username;
            Name = name;
            Role = role;
            RoleInfo = (enRole)role;
            IsActive = isActive;
            UpdatedAt = updatedAt;
        }

        public User_DTO(string username, string name, byte role)
        {
            Username = username;
            Name = name;
            Role = role;
            RoleInfo = (enRole)role;
        }

        public User_DTO()
        {
    
        }
    }
}
