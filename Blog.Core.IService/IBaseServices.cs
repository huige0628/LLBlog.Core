using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.IService
{
    public interface IBaseServices<TEntity> where TEntity : class
    {
        Task<TEntity> QueryById(object objId);
        Task<TEntity> QueryById(object objId, bool bInUserCache = false);
        Task<TEntity> QueryByIds(object[] objIds);
    }
}
