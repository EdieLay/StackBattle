using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal interface IHealable
    {
        int MaxHP { get; set; }
        void Heal(int hp);
    }
}
