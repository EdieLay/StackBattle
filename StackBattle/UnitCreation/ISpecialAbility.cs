using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal interface ISpecialAbility
    {
        int Range { get; set; }
        int Strength { get; set; }
        void Action(ArmiesRange armies);
    }
}
