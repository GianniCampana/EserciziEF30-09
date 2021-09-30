using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Classroom
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int MaxCapacity { get; set; }
        public bool IsVirtual { get; set; }
        public bool IsComputerized { get; set; }
        public bool? HasProjector { get; set; }
    }
}
