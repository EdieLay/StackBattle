using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle.Command
{
    // после хода сохраняются все хп, юниты с 0 хп помещаются в DeadUnits в порядке от начала армии с их индексом
    // восстановление происходит в порядке очереди, поэтому каждый встанет на своё место
    internal class TurnState
    {
        List<int> UnitsHP = new List<int>();
        Queue<(IUnit, int)> DeadUnits = new Queue<(IUnit, int)>();
    }
}
