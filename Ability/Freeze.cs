using System;
namespace HeroAbstractFactory.Ability
{
    public class Freeze :IAbility
    {

        public string UseAbility()
        {
            return "Маг произносит простое заклинание и противник не может двигаться какое-то время";
        }
    }
}
