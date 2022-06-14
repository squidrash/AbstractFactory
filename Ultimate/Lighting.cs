using System;
using HeroAbstractFactory.HeroesFactory;

namespace HeroAbstractFactory.Ultimate
{
    public class Lighting :IUltimate
    {
        private readonly double Damage;
        public Lighting(AbstractHero hero)
        {
            Damage = hero.Damage;
        }

        public string UseUltimate()
        {
            return $"маг вызывает молнию, которая наносит {Damage * 3} урона";
        }
    }
}
