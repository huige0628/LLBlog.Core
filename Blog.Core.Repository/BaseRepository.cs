using Blog.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, new()
    {
        public Task<TEntity> QueryById(object objId)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> QueryById(object objId, bool bInUserCache = false)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> QueryByIds(object[] objIds)
        {
            throw new NotImplementedException();
        }
    }
}
