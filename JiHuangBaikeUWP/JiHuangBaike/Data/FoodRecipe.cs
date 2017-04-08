using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiHuangBaike.Data
{
    public class FoodRecipe
    {
        // 中文
        public string Name { get; set; }
        // 英文
        public string EnName { get; set; }
        // 血量
        public double Health { get; set; }
        // 饥饿
        public double Hunger { get; set; }
        // 精神
        public double Sanity { get; set; }
        // 保鲜
        public double Perish { get; set; }
        // 烹饪时间
        public double Cooktime { get; set; }
        // 优先
        public int Priority { get; set; }

        public string Need { get; set; }

        public string Introduction { get; set; }

        public string Image { get; set; }

        public string Recommend1 { get; set; }

        public string Recommend2 { get; set; }

        public string Recommend3 { get; set; }

        public string Recommend4 { get; set; }

        public string Console { get; set; }
    }
}
