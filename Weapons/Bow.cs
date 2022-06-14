using System;
using HeroAbstractFactory.HeroesFactory;

namespace HeroAbstractFactory.Weapons
{
    public class Bow :IWeapon
    {
        private readonly int Damage;
        private readonly int CritChance;
        public Bow(AbstractHero hero)
        {
            Damage = hero.Damage;
            CritChance = hero.CritChance;
        }
        public string Hit()
        {
            var rnd = new Random();
            var crit = rnd.Next(1, 100);
            if (crit <= CritChance)
            {
                return $"выстрел нанес критический урон — {Damage * 1.5}";
            }
            return $"выстрел нанес {Damage} урона";
        }
    }
}
