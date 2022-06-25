using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w2homework.Core.Models;

namespace w2homework.Repository.IRepositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        //Generic Repository harici ihtiyaç duyulabilecek methodlar oluşturuldu
        Task AddUser(User user);
        Task<List<User>> GetUnconfirmedUsers();
    }
}
