using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w2homework.Core.Models;

namespace w2homework.Repository.IRepositories
{
    public interface IBootcampRepository : IGenericRepository<Bootcamp>
    {
        //Generic Repository harici ihtiyaç duyulabilecek methodlar oluşturuldu
        Task<List<Bootcamp>> GetBootcampsByActiveFilter(bool isActive);
    }
}
