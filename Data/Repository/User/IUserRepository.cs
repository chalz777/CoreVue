using System;
using System.Linq;
using System.Collections.Generic;
using SSRNMFSSN.Data.Models;
using SSRNMFSSN.Repository.Interfaces;

namespace Core.Repository.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        IQueryable<User> All();
        List<User> GetAllAdminAndLeads();

    }
}