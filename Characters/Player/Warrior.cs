using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalEffect.Characters.Player
{
    public class Warrior : Character
    {
        private new string className = "Wojownik";
        private new int healthValue = 100;
        private new int attackValue = 10;
        private new int defenceValue = 15;

        public override int HealthValue 
        {
            get { return healthValue; }
            set { healthValue = value; }
        }
        public override int AttackValue
        {
            get { return attackValue; }
            set { attackValue = value; }
        }
        public override int DefenceValue
        {
            get { return defenceValue; }
            set { defenceValue = value; }
        }

        public override string ClassName
        {
            get { return className; }
            set { className = "Wojownik"; }
        }

        public Warrior()
        {
           
        }

        public override int Attack()
        {
            throw new NotImplementedException();
        }

        public override int Defense()
        {
            throw new NotImplementedException();
        }

        public override int Wait()
        {
            throw new NotImplementedException();
        }
    }
}
