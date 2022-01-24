
using System.Collections.Generic;

namespace SSRNMFSSN.Domain
{
    public interface IDomain<TDto, TEntity> where TDto : class where TEntity : class
    {
        TDto Get(int id);
        ICollection<TDto> GetAll();
        TDto Create(TDto dto);
        TDto Update(int id, TDto dto);
        bool Delete(int id);
    }
}
