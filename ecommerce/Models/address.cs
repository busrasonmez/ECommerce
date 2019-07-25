using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.Models
{
    public class address
    {
        public int Id { get; set; }
        public user user { get; set; }
        public string OpenAddress { get; set; }
    }
}
