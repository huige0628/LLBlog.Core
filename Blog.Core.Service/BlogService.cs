using Blog.Core.IRepository;
using Blog.Core.IService;
using Blog.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.Service
{
    public class BlogService : IBlogService
    {
        private IBlogRepository _blogRepository = new BlogRepository();
        public int Sum(int x, int y)
        {
           return  _blogRepository.Sum(x, y);
        }
    }
}
