using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MQ_Assign.Data
{
    public class BlogService
    {

        private readonly ApplicationDbContext _db;

        public BlogService(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<Blog> GetBlogs()
        {
            var bList = _db.blogs.ToList();
            return bList;
        }

        public string Create(Blog bl)
        {
            _db.blogs.Add(bl);
            _db.SaveChanges();
            return ("Saved sucessfully");
        }

        public Blog GetBlogById(Guid id)
        {
            Blog b = _db.blogs.FirstOrDefault(s => s.id == id);
            return b;
        }

        public string UpdateBlog(Blog objBlog)
        {
            _db.blogs.Update(objBlog);
            _db.SaveChanges();
            return ("Update Successfully");
        }

        public string DeleteBlog(Blog objBlog)
        {
            _db.Remove(objBlog);
            _db.SaveChanges();
            return ("Delete Successfully");
        }


    }
}
