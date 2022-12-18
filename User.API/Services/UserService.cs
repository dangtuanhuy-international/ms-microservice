using User.API.Data;
using User.API.Models;

namespace User.API.Services
{
    public class UserService : IUserService
    {

        private readonly DbContextClass _dbContext;

        public UserService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public Users AddUser(Users product)
        {
            var result = _dbContext.Users.Add(product);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public bool DeleteUser(int Id)
        {
            var filteredData = _dbContext.Users.Where(x => x.UserId == Id).FirstOrDefault();
            var result = _dbContext.Remove(filteredData);
            _dbContext.SaveChanges();
            return result != null ? true : false;
        }

        public Users GetUserById(int id)
        {
            return _dbContext.Users.Where(x => x.UserId == id).FirstOrDefault();
        }

        public IEnumerable<Users> GetUserList()
        {
            return _dbContext.Users.ToList();
        }

        public Users UpdateUser(Users product)
        {
            var result = _dbContext.Users.Update(product);
            _dbContext.SaveChanges();
            return result.Entity;
        }
    }
}
