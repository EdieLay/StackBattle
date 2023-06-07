using System.Net.Http.Headers;

namespace StackBattle
{
    internal class UnitFactory
    {
        public IUnit CreateLight(int a, int b, int hp)
        {
            return new LightInfantry(a, b, hp);
        }
        public IUnit CreateHeavy(int a, int b, int hp)
        {
            return new HeavyInfantry(a, b, hp);
        }
        public IUnit CreateKnight(int a, int b, int hp)
        {
            return new Knight(a, b, hp);
        }
        public IUnit CreateArcher(int a, int b, int hp, int r, int s)
        {
            return new Archer(a, b, hp, r, s);
        }
        public IUnit CreateHealer(int a, int b, int hp, int r, int s)
        {
            return new Healer(a, b, hp, r, s);
        }
        public IUnit CreateWarlock(int a, int b, int hp, int r, int s)
        {
            return new Warlock(a, b, hp, r, s);
        }

        public IUnit CreateRandomUnit(ref int maxUnitPrice)
        {
            Random random = new((int)DateTime.Now.Ticks);
            int r;
            int rHitPoints, rAttack, rDefense, rRange = 0, rStrength = 0;

            rHitPoints = random.Next(1, maxUnitPrice);
            rAttack = random.Next(0, maxUnitPrice - rHitPoints);
            rDefense = random.Next(0, maxUnitPrice - rHitPoints - rAttack);

            if (maxUnitPrice < 3) r = random.Next(0, 3);
            else
            {
                r = random.Next(0, 6);
                if (r > 2)
                {
                    rRange = random.Next(1, maxUnitPrice - rHitPoints - rAttack - rDefense);
                    rStrength = random.Next(1, maxUnitPrice - rHitPoints - rAttack - rDefense - rRange + 1);
                    maxUnitPrice -= 2 * (rRange + rStrength);
                }
            }
            maxUnitPrice -= rAttack + rDefense + rHitPoints;

            switch (r)
            {
                case 0:
                    IUnit light = CreateLight(rAttack, rDefense, rHitPoints);
                    return light;
                case 1:
                    IUnit heavy = CreateHeavy(rAttack, rDefense, rHitPoints);
                    return heavy;
                case 2:
                    IUnit knight = CreateKnight(rAttack, rDefense, rHitPoints);
                    return knight;
                case 3:
                    IUnit archer = CreateArcher(rAttack, rDefense, rHitPoints, rRange, rStrength);
                    return archer;
                case 4:
                    IUnit healer = CreateHealer(rAttack, rDefense, rHitPoints, rRange, rStrength);
                    return healer;
                case 5:
                    IUnit warlock = CreateWarlock(rAttack, rDefense, rHitPoints, rRange, rStrength);
                    return warlock;
            }
            throw new Exception();
        }

        

        public Army CreateRandomArmy(int price) 
        { 
            Army army = new();
            Random random = new((int)DateTime.Now.Ticks);

            int unitPrice = random.Next(price / 20, price / 2);
            int maxUnitPrice;
            while (price > 0)
            {
                maxUnitPrice = Math.Min(unitPrice, price);
                price -= maxUnitPrice;
                IUnit unit = CreateRandomUnit(ref maxUnitPrice);
                army.AddUnit(unit);
                price += maxUnitPrice;
            }

            return army;
        }


        public IUnit CreateRandomUnit2(int unitprice)
        {
            Random random = new((int)DateTime.Now.Ticks);
            int unitType = random.Next(0, 7);
            if (unitType < 3 || unitprice < 6)
            {
                int hp = random.Next(1, unitprice);
                int attack = random.Next(1, unitprice - hp + 1);
                int defense = unitprice - hp - attack;
                if (unitprice < 6)
                    unitType = random.Next(0, 3);
                switch (unitType)
                {
                    case 0:
                        return new LightInfantry(attack, defense, hp);
                    case 1:
                        return new HeavyInfantry(attack, defense, hp);
                    case 2:
                        return new Knight(attack, defense, hp);
                }
            }
            else if (unitType < 6)
            {
                int sas = random.Next(1, (unitprice - 2) / 2);
                int sar = random.Next(1, (unitprice - sas * 2) / 2);
                int hp = random.Next(1, unitprice - (sas + sar) * 2);
                int attack = random.Next(1, unitprice - hp - (sas + sar) * 2 + 1);
                int def = unitprice - hp - attack - (sas + sar)* 2;
                switch (unitType)
                {
                    case 3:
                        return new Archer(attack, def, hp, sar, sas);
                    case 4:
                        return new Healer(attack, def, hp, sar, sas);
                    case 5:
                        return new Warlock(attack, def, hp, sar, sas);
                }
            }
            else
            {
                int hp = random.Next(1, unitprice + 1);
                int def = unitprice - hp;
                GulyayGorod gg = new GulyayGorod(hp, def, 0);
                return new GulyayGorodAdapter(gg);
            }
            throw new Exception();
        }

        public Army CreateRandomArmy2(int price)
        {
            Army army = new();
            Random random = new((int)DateTime.Now.Ticks);

            int ratio = Math.Max(1, price / 50);
            int priceLeft = price;
            int unitPrice;
            while (priceLeft > 0)
            {
                unitPrice = random.Next(Math.Max(price / 20, 3), priceLeft / ratio + 1);
                if (priceLeft - unitPrice < Math.Max(price / 20, 3))
                    unitPrice = priceLeft;
                priceLeft -= unitPrice;
                army.AddUnit(CreateRandomUnit2(unitPrice));
                if (ratio > 1)
                    ratio--;
            }
            //army.AddUnit(CreateRandomUnit2(priceLeft));

            return army;
        }
    }
}
