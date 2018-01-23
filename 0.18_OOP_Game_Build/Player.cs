namespace _0._18_OOP_Game_Build
{
    class Player : Character
    {
        //Constructors
        public Player(string name, Specialization spec)
        {
            this.Name = name;
            this.Role = spec;
            this.IsAlive = true;
            this.Health = 100;
            this.Level = 1;
            this.AttackPower = 10;
            this.CritChance = 0.10;
        }

        public Specialization Role { get; set; }
        public string Name { get; set; }

        public enum Specialization
        {
            HorseMange,
            TrollCat,
            KnightTemplator,
            Demogorg,
            Vampire,
            BovineFrog
        }
        public enum Action
        {
            Attack,
            Run,
            Hide
        }

    }
}