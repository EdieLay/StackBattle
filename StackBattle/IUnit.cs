using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal interface IUnit
    {
        int Attack { get; } // логика в геттере: если хп = 0, то вернуть 0 (типа мёртвый юнит не может атаковать)
        int Defense { get; } 
        int HitPoints { get; } // нужно прописать логику в сеттере, что если хп < 0, то хп = 0
        void TakeDamage(int damage);
    }
}
