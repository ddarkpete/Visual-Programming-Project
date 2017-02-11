using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZaliczeniowyPW
{
     class Mage : CharacterClass
    {
        private string name;
        private int lvl;
        private List<Item> Items;

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
            for (int i = 0; i < this.Lvl; i++)
            {
                this.Lift += this.Lift * 0.05;
                this.Power += this.Power * 0.05;
                this.Defense += this.Defense * 0.05;
            }
        }

        public override void bonus_count()
        {
            for(int i =0; i < Items.Count; i++)
            {
                Power += Items[i].Powerbonus;
                Defense += Items[i].Defbonus;
                Lift += Items[i].Liftbonus;
            }
        }

        public Mage(string name_,string description_, int lvl_)
        {
            Id = CharacterClass.id_;
            CharacterClass.id_++;
            Description = description_;
            Name = name_;
            Items = new List<Item>();
            Lvl = lvl_;
            Lift = 80;
            Power = 110;
            Defense = 70;
            lvl_count();
        }
        Mage() { }
    }
}
