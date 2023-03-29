namespace StackBattle
{
    internal class UnitFactory
    {
        public IUnit CreateLight()
        {
            return new LightInfantry();
        }
        public IUnit CreateHeavy()
        {
            return new HeavyInfantry();
        }
        public IUnit CreateKnight()
        {
            return new Knight();
        }
        public IUnit CreateArcher()
        {
            return new Archer();
        }
        public IUnit CreateHealer()
        {
            return new Healer();
        }
        public IUnit CreateWarlock()
        {
            return new Warlock();
        }

        public Army CreateRandomArmy(int price) 
        { 
            Army army = new();
            Random random = new((int)DateTime.Now.Ticks);
            
            int unitPrice = price / 5;
            while (price > 0)
            {
                int r = random.Next(0, 5);
                int p = Math.Min(price, unitPrice);
                int r1, r2, r3, r4, r5;
                r1 = random.Next(0, p);
                r2 = random.Next(0, p - r1);
                r3 = random.Next(0, p - r1 - r2);
                r4 = random.Next(0, p - r1 - r2 - r3);
                r5 = random.Next(0, p - r1 - r2 - r3 - r4);
                switch (r)
                {
                    case 0:
                        LightInfantry light = new(r1, r2, r3);
                        army.AddUnit(light);
                        price -= r1 + r2 + r3;
                        break;
                    case 1:
                        HeavyInfantry heavy = new(r1, r2, r3);
                        army.AddUnit(heavy);
                        price -= r1 + r2 + r3;
                        break;
                    case 2:
                        Knight knight = new(r1, r2, r3);
                        army.AddUnit(knight);
                        price -= r1 + r2 + r3;
                        break;
                    case 3:
                        Archer archer = new(r1, r2, r3, r4, r5);
                        army.AddUnit(archer);
                        price -= r1 + r2 + r3 + r4 + r5;
                        break;
                    case 4:
                        Healer healer = new(r1, r2, r3, r4, r5);
                        army.AddUnit(healer);
                        price -= r1 + r2 + r3 + r4 + r5;
                        break;
                    case 5:
                        Warlock warlock = new(r1, r2, r3, r4, r5);
                        army.AddUnit(warlock);
                        price -= r1 + r2 + r3 + r4 + r5;
                        break;
                }
            }

            return army;
        }
    }
}
