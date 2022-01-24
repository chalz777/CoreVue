using SSRNMFSSN.Repository;
using AutoMapper;
using Core.Mapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SSRNMFSSN.Data.Models;
using SSRNMFSSN.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SSRNMFSSN.Domain
{
    public abstract class BaseDomain<TDto, TEntity, TRepo> : IDomain<TDto, TEntity> where TDto : EFModel where TEntity : class where TRepo : IRepository<TEntity>
    {
        public IMapper Mapper { get; set; }
        public SSRNMFSSNContext Database { get; set; }
        public ILogger<TEntity> Logger { get; set; }
        protected readonly IRepository<TEntity> _repo;

        protected BaseDomain(TRepo repo, DbContext dbContext)
        {
            Database = (SSRNMFSSNContext)dbContext;
            Mapper = MapperFactory.Mapper;
            _repo = repo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        protected TDto MapToDto(TEntity entity)
        {
            return entity == null ? null : Mapper.Map<TEntity, TDto>(entity);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        protected ICollection<TDto> MapToDto(IEnumerable<TEntity> entities)
        {
            return !entities.Any() ? new List<TDto>() : Mapper.Map<ICollection<TDto>>(entities);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        protected TEntity MapToEntity(TDto dto)
        {
            return Mapper.Map<TDto, TEntity>(dto);
        }

        protected virtual TDto MapToEntityDto(TEntity entity)
        {
            return Mapper.Map<TEntity, TDto>(entity);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        protected IEnumerable<TEntity> MapToEntity(IEnumerable<TDto> dtos)
        {
            return Mapper.Map<ICollection<TEntity>>(dtos);
        }


        protected User GetUserByEdipi(string edipi)
        {
            return new UserDomain(new UserRepository(Database), Database).GetUserByEDIPI(edipi);
        }

        //protected User GetCurrentUser()
        //{
        //    var user = new UserDomain(new UserRepository(Database), Database).GetUserByEDIPI(GetCurrentUserEdipi());

        //    if (user == null)
        //    {
        //        throw new Exception("You don't exist");
        //    }

        //    return user;
        //}

        public virtual ICollection<TDto> GetAll()
        {
            IEnumerable<TEntity> returnMe = _repo.GetAll();

            if (returnMe != null)
            {
                return MapToDto(returnMe);
            }
            else
            {
                return null;
            }
        }

        public virtual TDto Get(int id)
        {
            return MapToDto(_repo.GetById(id));
        }

        public async Task<TEntity> GetEntityByintAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public IEnumerable<TEntity> GetAllEntity()
        {
            return _repo.GetAll();
        }
        public async Task<IEnumerable<TEntity>> GetAllEntityAsync()
        {
            return await _repo.GetAllAsync();
        }

        public void RemoveEntity(TEntity entity)
        {
            _repo.Remove(entity);
            return;
        }

        public virtual TDto Create(TDto dto)
        {
            if (dto != null)
            {
                return MapToDto(_repo.Add(MapToEntity(dto)));
            }
            return null;
        }

        public virtual TDto Update(int id, TDto dto)
        {
            if (dto != null)
            {
                if (id != dto.Id)
                {
                    return null;
                }

                return MapToDto(_repo.Save(MapToEntity(dto), id));
            }
            return null;
        }

        public virtual bool Delete(int id)
        {
            try
            {
                _repo.Remove(_repo.GetById(id));
                _repo.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Logger.Log(LogLevel.Error, 1, id, e, (domain, exception) => exception.Message);
            }
            return false;
        }

    }
}
