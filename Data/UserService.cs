using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MQ_Assign.Data
{
    public class UserService
    {

        private readonly ApplicationDbContext _db;

        public UserService(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<User> GetUsers()
        {
            var uList = _db.users.ToList();
            return uList;
        }

        public string Create(User uc)
        {
            _db.users.Add(uc);
            _db.SaveChanges();
            return ("Saved sucessfully");
        }

        public User GetUserById(Guid id)
        {
            User u = _db.users.FirstOrDefault(s => s.id == id);
            return u;
        }

        public string UpdateUser(User objUser)
        {
            _db.users.Update(objUser);
            _db.SaveChanges();
            return ("Update Successfully");
        }

        public string DeleteUser(User objUser)
        {
            _db.Remove(objUser);
            _db.SaveChanges();
            return ("Delete Successfully");
        }



    }
}
