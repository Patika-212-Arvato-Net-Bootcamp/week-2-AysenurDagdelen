using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w2homework.Core.Models;
using w2homework.Repository.IRepositories;

namespace w2homework.Repository.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        //Generic Repository harici ihtiyaç duyulabilecek methodlar oluşturuldu

        private readonly AppDbContext _appDbContext;
        public UserRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task AddUser(User user)
        {
            var newUser = new User()
            {
                IsActive = false,
                CreatedDate = user.CreatedDate,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Location = user.Location,
                Mail = user.Mail,
                Password = user.Password
            };
            await _appDbContext.Users.AddAsync(newUser);
        }

        public async Task<List<User>> GetUnconfirmedUsers()
        {
            return await _appDbContext.Users.Where(x => x.IsActive == false).ToListAsync();
        }
    }
}
