using Praktika.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika.Models
{



    public class Root:NotificationService
    {
        private string? name1;

        public int id { get; set; }
        public string? name { get => name1; set => name1 = value; }
        public string? username { get; set; }
        public string? email { get; set; }
        public Address? address { get; set; }
        public string? website { get; set; }
        public Company? company { get; set; }

        public override string ToString()
        {
            return $"{name} {username}";
        }
    }
}
