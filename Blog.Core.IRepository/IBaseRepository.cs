using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.IRepository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> QueryById(object objId);
        Task<TEntity> QueryById(object objId,bool bInUserCache =false);
        Task<TEntity> QueryByIds(object[] objIds);
    }
}
