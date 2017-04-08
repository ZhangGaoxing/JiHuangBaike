using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiHuangBaike.Data
{
    public class GoodEquipment
    {
        public string Picture { get; set; }

        public string Name { get; set; }

        public string EnName { get; set; }

        public double Attack { get; set; }

        public string Durability { get; set; }

        public double Wet { get; set; }

        public double Heat { get; set; }

        public double Sanity { get; set; }

        public double Defense { get; set; }

        public double Hunger { get; set; }

        public bool IsROG { get; set; }

        public bool IsSW { get; set; }

        public bool IsDST { get; set; }

        public string Introduction { get; set; }

        public string Console { get; set; }
    }
}
