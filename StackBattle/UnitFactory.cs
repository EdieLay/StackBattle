using System;
using System.Net.Http.Headers;

namespace StackBattle
{
    internal class UnitFactory
    {
        Random random = new((int)DateTime.Now.Ticks);
        int armyNum;
        Army army;
        string id;
        public UnitFactory(bool isFirstArmyBeingEdited, Army army) 
        {
            armyNum = isFirstArmyBeingEdited ? 1 : 2;
            this.army = army;
            army.NextIndex = 1;
            id = String.Empty;
        }
        public IUnit CreateLight(int unitprice)
        {
            int sar = 1;
            int sas = random.Next(1, (unitprice - sar * 2) / 2);
            int hp = random.Next(1, unitprice - (sas + sar) * 2);
            int attack = random.Next(1, unitprice - hp - (sas + sar) * 2 + 1);
            int defense = unitprice - hp - attack - (sas + sar) * 2;
            return new LightInfantry(attack, defense, hp, sas, id);
        }
        public IUnit CreateHeavy(int unitprice)
        {
            int hp = random.Next(1, unitprice);
            int attack = random.Next(1, unitprice - hp + 1);
            int defense = unitprice - hp - attack;
            return new HeavyInfantry(attack, defense, hp, id);
        }
        public IUnit CreateKnight(int unitprice)
        {
            int hp = random.Next(1, unitprice);
            int attack = random.Next(1, unitprice - hp + 1);
            int defense = unitprice - hp - attack;
            return new Knight(attack, defense, hp, id);
        }
        public IUnit CreateArcher(int unitprice)
        {
            int sar = random.Next(1, (unitprice - 2) / 2);
            int sas = random.Next(1, (unitprice - sar * 2) / 2);
            int hp = random.Next(1, unitprice - (sas + sar) * 2);
            int attack = random.Next(1, unitprice - hp - (sas + sar) * 2 + 1);
            int defense = unitprice - hp - attack - (sas + sar) * 2;
            return new ArcherProxy(new Archer(attack, defense, hp, sar, sas, id));
        }
        public IUnit CreateHealer(int unitprice)
        {
            int sas = random.Next(1, (unitprice - 2) / 2);
            int sar = random.Next(1, (unitprice - sas * 2) / 2);
            int hp = random.Next(1, unitprice - (sas + sar) * 2);
            int attack = random.Next(1, unitprice - hp - (sas + sar) * 2 + 1);
            int defense = unitprice - hp - attack - (sas + sar) * 2;
            return new Healer(attack, defense, hp, sar, sas, id);
        }
        public IUnit CreateWarlock(int unitprice)
        {
            int sas = random.Next(1, (unitprice - 2) / 2);
            int sar = random.Next(1, (unitprice - sas * 2) / 2);
            int hp = random.Next(1, unitprice - (sas + sar) * 2);
            int attack = random.Next(1, unitprice - hp - (sas + sar) * 2 + 1);
            int defense = unitprice - hp - attack - (sas + sar) * 2;
            return new Warlock(attack, defense, hp, sar, sas, id);
        }

        public IUnit CreateGulyayGorod(int unitprice)
        {
            int hp = random.Next(1, unitprice + 1);
            int def = unitprice - hp;
            GulyayGorod gg = new GulyayGorod(hp, def, 0);
            return new GulyayGorodAdapter(gg, id);
        }

        public IUnit CreateRandomUnit(int unitprice)
        {
            UnitType unitType = (UnitType)random.Next(0, 7);
            id = $"{armyNum}#{army.NextIndex++}";
            switch (unitType)
            {
                case UnitType.LightInfantry:
                    return CreateLight(unitprice);
                case UnitType.HeavyInfantry:
                    return CreateHeavy(unitprice);
                case UnitType.Knight:
                    return CreateKnight(unitprice);
                case UnitType.Archer:
                    return CreateArcher(unitprice);
                case UnitType.Healer:
                    return CreateHealer(unitprice);
                case UnitType.Warlock:
                    return CreateWarlock(unitprice);
                case UnitType.GulyayGorod:
                    return CreateGulyayGorod(unitprice);
            }
            throw new Exception();
        }

        public void CreateRandomArmy(int price)
        {
            army.Units.Clear();

            int ratio = Math.Max(1, price / 50);
            int priceLeft = price;
            int unitPrice;
            while (priceLeft > 0)
            {
                unitPrice = random.Next(Math.Max(price / 20, 3), priceLeft / ratio + 1);
                if (priceLeft - unitPrice < Math.Max(price / 20, 3))
                    unitPrice = priceLeft;
                priceLeft -= unitPrice;
                army.AddUnit(CreateRandomUnit(unitPrice));
                if (ratio > 1)
                    ratio--;
            }
        }
    }
}
