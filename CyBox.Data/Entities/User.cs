using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyBox.Data.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
    }
}
