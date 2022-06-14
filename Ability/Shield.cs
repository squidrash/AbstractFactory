using System;
namespace HeroAbstractFactory.Ability
{
    public class Shield : IAbility
    {
        public string UseAbility()
        {
            return "Призывает щит";
        }
    }
}
