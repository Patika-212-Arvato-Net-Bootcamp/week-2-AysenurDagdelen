using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w2homework.Core.Models
{
    public class Bootcamp
    {
        public int BootcampId { get; set; }
        public string BootcampName { get; set; }
        public bool IsSponsored { get; set; }
        public int CategoryId { get; set; }
        public bool IsActive { get; set; } //Bootcamp'in aktif olup olmadığının kontrolü

        public Category Category { get; set; }
        public List<User> JoinedUsers { get; set; } //Bootcamp'e katılan kullanıcılar

    }
}
