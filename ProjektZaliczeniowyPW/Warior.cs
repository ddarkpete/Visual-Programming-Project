using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZaliczeniowyPW
{
    class Warior : CharacterClass
    {
        private string name;
        private int lvl;
        public List<Item> Items;
        

        //public static int id_ = 0;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Lvl
        {
            get
            {
                return lvl;
            }

            set
            {
                lvl = value;
            }
        }

        public override void lvl_count()
        {
            for(int i = 0; i < Lvl; i++)
            {
                Lift += Lift * 0.05;
                Power += Power * 0.05;
                Defense += Defense * 0.05;
            }
        }
        public override void bonus_count()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Power += Items[i].Powerbonus;
                Defense += Items[i].Defbonus;
                Lift += Items[i].Liftbonus;
            }
        }

        public double eq_weight()
        {
            double sum = 0;
            foreach (Item it in this.Items)
            {
                sum += it.Weight;
            }
            return sum;
        }

        public Warior(string name_,string description_ , int lvl_)
        {
            Id = CharacterClass.id_;
            CharacterClass.id_++;
            Name = name_;
            Description = description_;
            Items = new List<Item>();
            Lvl = lvl_;
            Lift = 120;
            Power = 90;
            Defense = 95;
            lvl_count();
        }

        Warior() { }


    }
}
