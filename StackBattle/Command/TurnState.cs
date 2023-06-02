using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    // после хода сохраняются все хп, юниты с 0 хп помещаются в DeadUnits в порядке от начала армии с их индексом
    // восстановление происходит в порядке очереди, поэтому каждый встанет на своё место
    internal class TurnState
    {
        public List<IUnit> UnitList { get; set; } = new();
        public List<int> UnitsHP { get; set; } = new();
        public List<(Stack<Buffs> Buffs, int Position)> UnitBuffs { get; set; } = new(); // если юнит is AbstractBuff, то записываем его текущие баффы сюда
        public TurnState(List<IUnit> unitList)
        {
            for (int i = 0; i < unitList.Count; i++)
            {
                UnitList.Add(unitList[i]);
                UnitsHP.Add(unitList[i].HitPoints);
                if (unitList[i] is AbstractBuff buffunit)
                {
                    GetBuffs(buffunit, i);
                }
            }
        }

        void GetBuffs(AbstractBuff buffunit, int pos)
        {
            Stack<Buffs> buffs = new();
            IBuffable tempunit = buffunit as IBuffable;
            while (tempunit is AbstractBuff bunit)
            {
                if (bunit is HelmetBuff)
                {
                    buffs.Push(Buffs.Helmet);
                    tempunit = bunit.GetBuffable();
                    continue;
                }
                if (bunit is HorseBuff)
                {
                    buffs.Push(Buffs.Horse);
                    tempunit = bunit.GetBuffable();
                    continue;
                }
                if (bunit is ShieldBuff)
                {
                    buffs.Push(Buffs.Shield);
                    tempunit = bunit.GetBuffable();
                    continue;
                }
            }
            UnitBuffs.Add((buffs, pos));
        }
    }
}
