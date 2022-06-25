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
    public class AdminService : IAdminService
    {
        private readonly IUserRepository _userRepository;
        private readonly IBootcampRepository _bootcampRepository;
        private readonly AppDbContext _context;

        public AdminService(IUserRepository userRepository, AppDbContext context, IBootcampRepository bootcampRepository)
        {
            _userRepository = userRepository;
            _context = context;
            _bootcampRepository = bootcampRepository;
        }

        //Bootcamp eklemek için
        public async Task AddBootcamp(Bootcamp bootcamp)
        {
            await _bootcampRepository.CreateAsync(bootcamp);
            await _context.SaveChangesAsync();
        }

        //Adminin yeni kayıt olmuş kullanıcıyı onaylaması için
        public async Task ConfirmUser(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            user.IsActive = true;
            await _context.SaveChangesAsync();
        }

        //Adminin yeni kayıt olup onaylanmamış kullanıcıları listelemesi için
        public async Task<List<User>> GetUnconfirmedUsers()
        {
            return await _userRepository.GetUnconfirmedUsers();
        }

        //Bootcamp'i iptal etmek için
        public async Task CancelBootcamp(int id)
        {
            var bootcamp = await _bootcampRepository.GetByIdAsync(id);
            bootcamp.IsActive = false;
            await _context.SaveChangesAsync();
        }

        //Id'si verilen kullanıcıyı silmek için
        public async Task RemoveUser(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.UserId == id);
            await _userRepository.RemoveAsync(user);
            await _context.SaveChangesAsync();
        }

        //Id'si verilen kullanıcıyı getirmek için
        public async Task<User> GetUserById(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }
    }
}
