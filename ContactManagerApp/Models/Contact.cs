using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagerApp.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{Name,-20} | {Phone,-12} | {Email,-30}";
        }
    }
}
