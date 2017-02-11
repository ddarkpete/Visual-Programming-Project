using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZaliczeniowyPW
{
    class Item
    {
        static int idd = 0;

        private int id;
        private string name;
        private string type;
        private string description;
        private double powerbonus;
        private double defbonus;
        private double liftbonus;
        private string require_chclass;
        private string properties;
        private int weight;

        public int Id
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

        

        public string Require_chclass
        {
            get
            {
                return require_chclass;
            }

            set
            {
                require_chclass = value;
            }
        }

        public string Properties
        {
            get
            {
                return properties;
            }

            set
            {
                properties = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

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

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public double Powerbonus
        {
            get
            {
                return powerbonus;
            }

            set
            {
                powerbonus = value;
            }
        }

        public double Defbonus
        {
            get
            {
                return defbonus;
            }

            set
            {
                defbonus = value;
            }
        }

        public double Liftbonus
        {
            get
            {
                return liftbonus;
            }

            set
            {
                liftbonus = value;
            }
        }

        public Item(string name_, string type_,string descrip_ , double powerb_ , double defb_, 
            double liftb_,string requir_,string propers_, int weight_ )
        {
            Id = Item.idd;
            Item.idd++;
            Name = name_;
            Type = type_;
            Description = descrip_;
            Powerbonus = powerb_;
            Defbonus = defb_;
            Liftbonus = liftb_;
            Require_chclass = requir_;
            Properties = propers_;
            Weight = weight_;

        }
        //private int id;
        //private string name;
        //private string type;
        //private string description;
        //private double powerbonus;
        //private double defbonus;
        //private double liftbonus;
        //private string require_chclass;
        //private string properties;
        //private int weight;
    }
}
