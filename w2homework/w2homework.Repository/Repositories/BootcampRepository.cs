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
    public class BootcampRepository : GenericRepository<Bootcamp>, IBootcampRepository
    {
        //Generic Repository harici ihtiyaç duyulabilecek methodlar oluşturuldu

        private readonly AppDbContext _appDbContext;
        public BootcampRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Bootcamp>> GetBootcampsByActiveFilter(bool isActive)
        {
            return await _appDbContext.Bootcamps.Where(x => x.IsActive == isActive).ToListAsync();
        }
    }
}
