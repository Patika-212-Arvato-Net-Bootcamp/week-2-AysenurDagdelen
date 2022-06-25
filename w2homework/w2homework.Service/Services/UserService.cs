using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w2homework.Core.Models;
using w2homework.Repository;
using w2homework.Repository.IRepositories;
using w2homework.Service.IServices;

namespace w2homework.Service.Services
{
    //API tarafından çağrılacak servisler oluşturuldu
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly AppDbContext _context;

        public UserService(IUserRepository userRepository, AppDbContext context)
        {
            _userRepository = userRepository;
            _context = context;
        }

        //Yeni üye kaydı için
        public async Task AddUser(User user)
        {
            await _userRepository.AddUser(user);
            await _context.SaveChangesAsync();
        }
    }
}
