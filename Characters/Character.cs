using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalEffect.Characters
{
    public abstract class Character
    {
        protected int healthValue;
        protected int attackValue;
        protected int defenceValue;
        protected string className;

        public abstract int HealthValue { get; set; }
        public abstract int AttackValue { get; set; }
        public abstract int DefenceValue { get; set; }
        public abstract string ClassName { get; set; }

        public abstract int Attack();
        public abstract int Defense();
        public abstract int Wait();
    }
}
