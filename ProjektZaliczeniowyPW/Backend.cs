using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZaliczeniowyPW
{
    class Backend
    {
        private static Backend instance;

        private Backend() { }

        public static Backend Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Backend();
                }
                return instance;
            }
        }
        public List<CharacterClass> Characters = new List<CharacterClass>();
        public List<Item> Items = new List<Item>();

        public bool MessageForm3 = false;

        public void AddChar(Form3 Formobject)
        {
            string _name = Formobject.NameBox.Text;
            string _descript = Formobject.DescriptBox.Text;
            int _lvl;
            bool parseCheck = Int32.TryParse(Formobject.LVLBox.Text,out _lvl);
            if(parseCheck)
            {
                if((Formobject.MageRadio.Checked || Formobject.MageRadio.Checked) && (_name != "" 
                    || _descript !=""))
                {
                    if(Formobject.MageRadio.Checked)
                    {
                        Mage TempMage = new Mage(_name,_descript,_lvl);
                        TempMage.lvl_count();
                        Characters.Add(TempMage);
                        Formobject.EditCharacterCombo.Items.Add(TempMage.Name);
                    }
                    if (Formobject.WariorRadio.Checked)
                    {
                        Warior TempWarior = new Warior(_name, _descript, _lvl);
                        TempWarior.lvl_count();
                        Characters.Add(TempWarior);
                        Formobject.EditCharacterCombo.Items.Add(TempWarior.Name);
                    }
                }
                else
                {
                    MessageForm3 = true;
                }

            }
            else
            {
                MessageForm3 = true;
            }

        }
    
    }
}
