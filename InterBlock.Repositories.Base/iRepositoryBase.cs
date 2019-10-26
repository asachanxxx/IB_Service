using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.Repositories.Base
{
    public interface iRepositoryBase<T> where T : class
    {
        Task<T> FindOneRecord(int Id);
        Task<IEnumerable<T>> FindALLRecords();
        Task<int> SaveSingle(T Entity, int Action);
        Task<int> SaveMulti(T Entity, int Action);
        Task<bool> DeleteSingle(T Entity);
        Task<bool> DeleteSingle(int Id);
        Task<bool> DeleteMulti(IEnumerable<T> Entity);
        Task<bool> ModifySingle(T Entity);
    }
}
