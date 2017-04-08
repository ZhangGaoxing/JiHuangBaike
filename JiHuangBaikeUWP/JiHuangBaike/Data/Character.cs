using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiHuangBaike.Data
{
    public class Character
    {
        // 姓名
        public string Name { get; set; }
        // 英文
        public string EnName { get; set; }
        // 生命
        public int Health { get; set; }
        // 饥饿
        public int Hunger { get; set; }
        // 精神
        public int Sanity { get; set; }
        // 伤害
        public double Damage { get; set; }
        // 座右铭
        public string Motto { get; set; }
        // 简介
        public string Introduction { get; set; }
        // 描述
        public string Description { get; set; }
        // 图片
        public string Image { get; set; }
    }
}
