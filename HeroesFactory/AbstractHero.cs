using System;
namespace HeroAbstractFactory.HeroesFactory
{
    public abstract class AbstractHero
    {
        public int HP { get; set; }
        public int Damage { get; set; }
        public int CritChance { get; set; }
    }
}
