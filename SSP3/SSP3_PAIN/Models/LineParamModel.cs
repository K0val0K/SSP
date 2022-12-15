using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSP3_PAIN.Models
{
    public class LineParamModel
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Therd { get; set; }
        public int Four { get; set; }
        public LineParamModel(int First, int Second, int Therd, int Four)
        {
            this.First = First;
            this.Second = Second;
            this.Therd = Therd;
            this.Four = Four;


        }
    }
}
