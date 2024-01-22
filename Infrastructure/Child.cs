using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Child
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public Mother Mother { get; set; }
        public int? MotherId { get; set; }
    }
}
