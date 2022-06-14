using System;
using HeroAbstractFactory.HeroesFactory;

namespace HeroAbstractFactory.Ultimate
{
    public class Healing : IUltimate
    {
        private readonly double HP;
        public Healing(AbstractHero hero)
        {
            HP = hero.HP * 0.4;
        }
        public string UseUltimate()
        {
            return $"Герой востанавливает {HP} НР";
        }
    }
}
