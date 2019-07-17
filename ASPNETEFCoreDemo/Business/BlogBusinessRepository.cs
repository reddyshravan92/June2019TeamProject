using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using Models;
using Contracts;


namespace Business
{
    public class BlogBusinessRepository : IBlogBusinessRepository
    {
        private readonly IBlogDataRepository _dataRepository;

        public BlogBusinessRepository(IBlogDataRepository blogDataRepository)
        {
            this._dataRepository = blogDataRepository;
        }

        public void AddBlog(Blog entity)
        {
            //You can add some additional validatio or some logic
            entity.CreatedDt = DateTime.Now;
            entity.CreatedBy = "Satya";
            _dataRepository.AddBlog(entity);
        }

        public void DeleteBlog(int id)
        {
            _dataRepository.DeleteBlog(id);
        }

        public Blog GetBlogById(int id)
        {
            return _dataRepository.GetBlogById(id);
        }

        public List<Blog> GetBlogs()
        {
            return _dataRepository.GetBlogs();
        }

        public void UpdateBlog(Blog entity)
        {
            entity.UpdatedDt = DateTime.Now;
            entity.UpdatedBy = "Satya";
            _dataRepository.UpdateBlog(entity);
        }
    }
}
