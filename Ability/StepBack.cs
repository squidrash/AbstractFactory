using System;
namespace HeroAbstractFactory.Ability
{
    public class StepBack : IAbility
    {
        public string UseAbility()
        {
            return "персонаж отпрыгнул назад";
        }
    }
}
