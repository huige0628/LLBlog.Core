using Blog.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.Repository
{
    public class BlogRepository : IBlogRepository
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
