using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Building : BaseEntity
    {
        public string Name { get; set; }
        public int HumanCount { get; set; }
        public int FloorCount { get; set; }
        public int CityId { get; set; }
        public int StreetId { get; set; }
    }
}
