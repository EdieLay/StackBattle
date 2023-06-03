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
            int unitType = random.Next(0, 6);
        }

        public Army CreateRandomArmy2(int price)
        {
            Army army = new();
            Random random = new((int)DateTime.Now.Ticks);

            int priceLeft = price;
            int unitPrice;
            while (priceLeft > Math.Max(4, price / 20))
            {
                unitPrice = random.Next(priceLeft / 25, priceLeft / 3);
                priceLeft -= unitPrice;
                army.AddUnit(CreateRandomUnit2(unitPrice));
            }
            army.AddUnit(CreateRandomUnit2(priceLeft));

            return army;
        }
    }
}
