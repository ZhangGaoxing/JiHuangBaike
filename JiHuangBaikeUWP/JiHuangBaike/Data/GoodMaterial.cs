using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiHuangBaike.Data
{
    public class GoodMaterial
    {
        public string Picture { get; set; }

        public string Name { get; set; }

        public string EnName { get; set; }

        public string[] Science { get; set; }

        public string[] Creature { get; set; }

        public bool IsROG { get; set; }

        public bool IsSW { get; set; }

        public bool IsDST { get; set; }

        public string Introduction { get; set; }

        public string Console { get; set; }
    }
}
