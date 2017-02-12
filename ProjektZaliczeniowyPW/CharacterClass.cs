using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZaliczeniowyPW
{
    abstract class CharacterClass
    {
        protected int id;
        protected string description;
        protected double power;
        protected double defense;
        protected double lift;

        public static int id_;

        protected int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public double Power
        {
            get
            {
                return power;
            }

            set
            {
                power = value;
            }
        }

        public double Defense
        {
            get
            {
                return defense;
            }

            set
            {
                defense = value;
            }
        }

        public double Lift
        {
            get
            {
                return lift;
            }

            set
            {
                lift = value;
            }
        }
        public abstract void lvl_count();
        public abstract void bonus_count();
    }
}
