using System.Linq;
using System.Collections.Generic;
using Core.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using SSRNMFSSN.Data.Models;
using SSRNMFSSN.Repository;

namespace SSRNMFSSN.Repository
{
    public class UserRepository : Repository<User>, IUserRepository

    {
        public UserRepository(SSRNMFSSNContext context)
            : base(context)
        { }

        public SSRNMFSSNContext UserContext
        {
            get { return _dbContext as SSRNMFSSNContext; }
        }

        public IQueryable<User> All()
        {
            return UserContext.Users;
        }

        public override IEnumerable<User> GetAll()
        {
            return UserContext.Users
                .ToList();
        }

        public List<User> GetAllAdminAndLeads()
        {
            IQueryable<User> entities = from user in UserContext.Users
                                        where user.RoleId == 1
                                        select user;

            return entities.ToList();

            //Leads
            //Code 10/01/70 - Jolene Denning
            //Code 20 - Dorothy Perdue
            //Code 30 - Wendy Wohlford
            //Code 40 - Caroline Evanger

            //Other Admin
            //Code 101: Lindsay Wade
            //Code 10: Benny Torres
            //Code 01: Chris Hankins
            //Code 102:  Carlene Jensen
            //Code 20: Nancy Hinojosa
            //Code 30: Victoria Parker
            //Code 40: Theresa Hale
        }

        public User GetByEdipi(string edipi)
        {
            return (from user in UserContext.Users
                    where user.Edipi == edipi
                    select user).FirstOrDefault();
        }

    }
}