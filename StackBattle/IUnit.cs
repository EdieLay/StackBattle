using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal interface IUnit
    {
        int Attack { get; set; }
        int Defense { get; set; }
        int HitPoints { get; set; }
        void TakeDamage(int damage);
    }
}
