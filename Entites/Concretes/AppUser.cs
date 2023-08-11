using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace Entites.Concretes
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

    }
}






// bu işlemleri, bir kullanıcı hesap oluştururken orada adını soyadını girecek ama Identity tablolarında bu özellikler yok (AspNetUsers'ta yok). Bunları özel olarak eklemiş olduk buraya, artık olacak.