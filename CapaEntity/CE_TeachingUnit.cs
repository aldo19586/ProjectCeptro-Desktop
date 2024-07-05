using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntity
{
    public class CE_TeachingUnit
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public string Credit { get; set; }
        public int Hours { get; set; }
        public string Conditions { get; set; }
        public int? SpecialtyId { get; set; }
    }
}
