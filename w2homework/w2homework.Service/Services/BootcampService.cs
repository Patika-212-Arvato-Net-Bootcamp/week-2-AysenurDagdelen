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
    public class BootcampService : IBootcampService
    {
        private readonly IBootcampRepository _bootcampRepository;
        private readonly IUserRepository _userRepository;
        private readonly AppDbContext _appDbContext;

        public BootcampService(IBootcampRepository bootcampRepository, IUserRepository userRepository, AppDbContext appDbContext)
        {
            _bootcampRepository = bootcampRepository;
            _userRepository = userRepository;
            _appDbContext = appDbContext;
        }

        //Aktif veya pasif bootcamp'leri listelemek için
        public async Task<List<Bootcamp>> GetBootcampsByActiveFilter(bool isActive)
        {
            return await _bootcampRepository.GetBootcampsByActiveFilter(isActive);
        }

        //Id'ye göre bootcamp getirmek için
        public async Task<Bootcamp> GetBootcampById(int id)
        {
            return await _bootcampRepository.GetByIdAsync(id);
        }

        //Tüm bootcamp'leri listelemek için
        public async Task<List<Bootcamp>> GetBootcamps()
        {
            return await _bootcampRepository.GetAllAsync();
        }

        //Id'si verilen kullanıcıyı Id'si verilen bootcamp'in katılımcı listesine eklemek için
        public async Task JoinBootcamp(int bootcampId, int userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            _appDbContext.Bootcamps.FirstOrDefault(x => x.BootcampId == bootcampId).JoinedUsers.Add(user);
            
            await _appDbContext.SaveChangesAsync();
        }
    }
}
