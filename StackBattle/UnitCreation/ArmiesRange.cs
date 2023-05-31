using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class ArmiesRange
    {
        public Army friendlyArmy;
        public Army enemyArmy;
        public List<int> fArea = new List<int>();
        public List<int> eArea = new List<int>();

        public ArmiesRange(Army friendlyArmy, Army enemyArmy)
        {
            this.friendlyArmy = friendlyArmy;
            this.enemyArmy = enemyArmy;
        }
    }
}
