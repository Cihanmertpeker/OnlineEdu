using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Entity.Entities
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string MapUrl { get; set; }
        public string address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
