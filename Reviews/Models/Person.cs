using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Job { get; set; }

        public string Image { get; set; }

        public string Text { get; set; }
    }
}
