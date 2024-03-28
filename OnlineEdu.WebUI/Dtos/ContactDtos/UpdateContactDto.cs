using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.WebUI.Dtos.ContactDtos
{
    public class UpdateContactDto
    {
        public int ContactID { get; set; }
        public string MapUrl { get; set; }
        public string address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
