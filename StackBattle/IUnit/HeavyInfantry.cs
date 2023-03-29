﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class HeavyInfantry : AbstractUnit
    {
        public HeavyInfantry()
        {
            Attack = 0;
            Defense = 0;
            HitPoints = 0;
        }
        public HeavyInfantry(int attack, int defense, int hitPoints)
        {
            Attack = attack;
            Defense = defense;
            HitPoints = hitPoints;
        }
    }
}