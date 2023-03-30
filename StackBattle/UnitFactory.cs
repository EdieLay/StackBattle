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

            if (maxUnitPrice < 3) r = random.Next(0, 2);
            else
            {
                r = random.Next(0, 5);
                if (r > 2)
                {
                    rRange = random.Next(1, maxUnitPrice - rHitPoints - rAttack - rDefense);
                    rStrength = random.Next(1, maxUnitPrice - rHitPoints - rAttack - rDefense - rRange);
                    maxUnitPrice -= rRange + rStrength; 
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
            
            int unitPrice = price / 5;
            while (price > 0)
            {
                int maxUnitPrice = Math.Min(unitPrice, price);
                price -= maxUnitPrice;
                IUnit unit = CreateRandomUnit(ref maxUnitPrice);
                army.AddUnit(unit);
                price += maxUnitPrice;
            }

            return army;
        }
    }
}
