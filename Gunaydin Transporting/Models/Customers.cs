using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunaydinTransporting.web.Models
{
    public class Customers
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string E_mail { get; set; }
        public string Password { get; set; }
        public float Cost { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime TimeOfEnter { get; set; }
        public DateTime TimeOfQuit { get; set; }
    }
}
