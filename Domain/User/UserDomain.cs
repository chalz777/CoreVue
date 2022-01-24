using SSRNMFSSN.Repository;
using Core.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SSRNMFSSN.Data.Models;
using SSRNMFSSN.Data.Models.DTO;
using System.Collections.Generic;
using System.Linq;

namespace SSRNMFSSN.Domain
{
    public class UserDomain : BaseDomain<UserDto, User, IUserRepository>
    {
        public UserDomain(IUserRepository repo, SSRNMFSSNContext db) : base(repo, db)
        {
        }

        public ICollection<UserDto> GetAllUsers()
        {
            return Mapper.Map<ICollection<UserDto>>(_repo.GetAll());
        }


        public User GetUserByEDIPI(string edipi)
        {
            return ((UserRepository)_repo).GetByEdipi(edipi);
        }

        public UserDto GetUserInfoByID(int userId = 0)
        {
            return MapToDto(_repo.GetById(userId));
        }

        public List<UserDto> GetUsersByName(string query)
        {
            return GetAllUsers()
                .Where(x =>
                {
                    var name = x.FirstName
                    + " "
                    + x.MiddleInitial
                    + " "
                    + x.LastName;

                    name = name.ToLower();

                    return name.Contains(query.ToLower());
                })
                .ToList();
        }



        public ICollection<User> GetAllAdminAndLeads()
        {
            return ((UserRepository)_repo).GetAllAdminAndLeads();
        }

        public bool IsAdmin(string edipi)
        {
            return false;
            //return IsAdmin(GetCurrentUser());
        }

        public bool IsAdmin(User user)
        {
            return false;
            //return user.UserRoles.Any(x => x.Role.Name == "ADMIN");
        }
    }
}
