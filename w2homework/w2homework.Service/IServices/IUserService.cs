using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w2homework.Core.Models;

namespace w2homework.Service.IServices
{
    public interface IUserService
    {
        //API tarafından çağrılacak servisler oluşturuldu
        Task AddUser(User user);
    }
}
