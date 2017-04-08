using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiHuangBaike.Data
{
    public class Creature
    {
        public string Name { get; set; }

        public string EnName { get; set; }

        public string Picture { get; set; }

        public double Health { get; set; }

        public double HealthDST { get; set; }

        public double Attack { get; set; }

        public double AttackInterval { get; set; }

        public double AttackScope { get; set; }

        public double MoveSpeed { get; set; }

        public double RunSpeed { get; set; }

        public int Dangerous { get; set; }

        public double SanityEffect { get; set; }

        public bool IsActiveAttack { get; set; }

        public bool IsTeamWork { get; set; }

        public bool IsROG { get; set; }

        public bool IsSW { get; set; }

        public bool IsDST { get; set; }

        public string Goods { get; set; }

        public string Ability { get; set; }

        public string Introduction { get; set; }

        public string Console { get; set; }
    }
}
