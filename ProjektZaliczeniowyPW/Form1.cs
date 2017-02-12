using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektZaliczeniowyPW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int selected_item;
        int selected_character;
        int selected_characters_item;
        double actual_eq_weight;
        CharacterClass actualcharac;

        private void ShopCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Item item in Backend.Instance.Items)
            {
                ShopCombo.Items.Add(item.Name);
            }
            foreach(CharacterClass charac in Backend.Instance.Characters)
            {
                if(charac is Mage)
                {
                    Mage Temp = (Mage) charac;
                    CharactersBaseCombo.Items.Add(Temp.Name);
                }
                if(charac is Warior)
                {
                    Warior Temp = (Warior)charac;
                    CharactersBaseCombo.Items.Add(Temp.Name);
                }
            }
        }

        private void CharactersBaseCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_character = CharactersBaseCombo.SelectedIndex;
            CharacterClass charac = Backend.Instance.Characters[selected_character];
            actualcharac = Backend.Instance.Characters[selected_character];
            if (charac is Mage)
            {
                Mage Temp = (Mage)charac;
                NameBox.Text = Temp.Name;
                DescriptBox.Text = Temp.Description;
                LVLBox.Text = Temp.Lvl.ToString();
                PowerBox.Text = Temp.Power.ToString();
                LiftBox.Text = Temp.Lift.ToString();
                DefBox.Text = Temp.Defense.ToString();
                foreach(Item it in Temp.Items)
                {
                    ItemsListBox.Text += it.Name + " ; ";
                    CharactersItemCombo.Items.Add(it.Name);
                }
                actual_eq_weight = Temp.eq_weight();

            }
            if (charac is Warior)
            {
                Warior Temp = (Warior)charac;
                CharactersBaseCombo.Items.Add(Temp.Name);
                NameBox.Text = Temp.Name;
                DescriptBox.Text = Temp.Description;
                LVLBox.Text = Temp.Lvl.ToString();
                PowerBox.Text = Temp.Power.ToString();
                LiftBox.Text = Temp.Lift.ToString();
                DefBox.Text = Temp.Defense.ToString();
                foreach (Item it in Temp.Items)
                {
                    ItemsListBox.Text += it.Name + " ; ";
                }
                actual_eq_weight = Temp.eq_weight();
            }
        }
    }
}
