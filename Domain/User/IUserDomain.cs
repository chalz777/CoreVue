using SSRNMFSSN.Data.Models;
using System.Collections.Generic;

namespace SSRNMFSSN.Domain
{
    public interface IUserDomain
    {
        /// <summary>
        /// User domain is used to for performing db functions relating to user
        /// </summary>    
        ICollection<User> GetAllUsers();

        User GetUserInfoByID(int userId);

        User GetUserInfoByEDIPI(string edipi);

    }
}
