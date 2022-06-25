using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w2homework.Core.Models;

namespace w2homework.Service.IServices
{
    public interface IAdminService
    {
        //API tarafından çağrılacak servisler oluşturuldu
        Task AddBootcamp(Bootcamp bootcamp);
        Task CancelBootcamp(int id);
        Task RemoveUser(int id);
        Task<List<User>> GetUnconfirmedUsers();
        Task ConfirmUser(int id);
        Task<User> GetUserById(int id);
    
    }
}
