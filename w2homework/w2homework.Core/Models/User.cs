using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w2homework.Core.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Mail { get; set; }
        public string Location { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; } //Yeni üyelikte default olarak false atanmak üzere oluşturuldu

        public List<Bootcamp> JoinedBootcamps { get; set; }
    }
}
