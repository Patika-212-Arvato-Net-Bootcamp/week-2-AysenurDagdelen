using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w2homework.Core.Models;

namespace w2homework.Service.IServices
{
    public interface IBootcampService
    {
        //API tarafından çağrılacak servisler oluşturuldu
        Task<List<Bootcamp>> GetBootcamps();
        Task<Bootcamp> GetBootcampById(int id);
        Task JoinBootcamp(int bootcampId, int userId);
        Task<List<Bootcamp>> GetBootcampsByActiveFilter(bool isActive);
       
    }
}
