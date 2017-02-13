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
        Item actualitem;

        private void ShopCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShopItPropBox.Clear();
            ShopItTypeBox.Clear();
            selected_item = ShopCombo.SelectedIndex;
            actualitem = Backend.Instance.Items[selected_item];
            ShopItPropBox.Text = actualitem.Properties;
            ShopItTypeBox.Text = actualitem.Type;

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
            NameBox.Clear();
            DescriptBox.Clear();
            LVLBox.Clear();
            PowerBox.Clear();
            LiftBox.Clear();
            DefBox.Clear();
            ItemsListBox.Clear();
            CharactersItemCombo.Items.Clear();
            selected_character = CharactersBaseCombo.SelectedIndex;
            CharacterClass charac = Backend.Instance.Characters[selected_character];
            actualcharac = Backend.Instance.Characters[selected_character];
            if (charac.Ch_type == "mage")
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
            if (charac.Ch_type == "warior")
            {
                Warior Temp = (Warior)charac;
                //CharactersBaseCombo.Items.Add(Temp.Name);
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

        private void CharactersItemCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_characters_item = CharactersItemCombo.SelectedIndex;
        }

        private void DropItemButton_Click(object sender, EventArgs e)
        {
            if(Backend.Instance.Characters[selected_character].Ch_type =="mage" )
            {
                Mage Temp = (Mage)Backend.Instance.Characters[selected_character];
                Temp.Items.RemoveAt(selected_characters_item);
                CharactersItemCombo.Items.RemoveAt(selected_characters_item);
                actual_eq_weight = Temp.eq_weight();
                Backend.Instance.Characters[selected_character] = Temp;
            }
            else if (Backend.Instance.Characters[selected_character].Ch_type == "warior" )
            {
                Warior Temp = (Warior)Backend.Instance.Characters[selected_character];
                Temp.Items.RemoveAt(selected_characters_item);
                CharactersItemCombo.Items.RemoveAt(selected_characters_item);
                actual_eq_weight = Temp.eq_weight();
                Backend.Instance.Characters[selected_character] = Temp;
            }
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            if (Backend.Instance.Characters[selected_character].Ch_type == "mage")
            {
                Mage Temp = (Mage)Backend.Instance.Characters[selected_character];
                
                this.chart1.Series["PPoints"].Points.AddXY(Temp.Name, Temp.Power);
                this.chart1.Series["PPoints After"].Points.AddXY(Temp.Name, Temp.Power + actualitem.Powerbonus);
                this.chart1.Series["LPoints"].Points.AddXY(Temp.Name, Temp.Lift);
                this.chart1.Series["LPoints After"].Points.AddXY(Temp.Name, Temp.Lift + actualitem.Liftbonus);
                this.chart1.Series["DPoints"].Points.AddXY(Temp.Name, Temp.Defense);
                this.chart1.Series["DPoints After"].Points.AddXY(Temp.Name, Temp.Defense + actualitem.Defbonus);


            }
            else if (Backend.Instance.Characters[selected_character].Ch_type == "warior")
            {
                Warior Temp = (Warior)Backend.Instance.Characters[selected_character];
                this.chart1.Series["PPoints"].Points.AddXY(Temp.Name, Temp.Power);
                this.chart1.Series["PPoints After"].Points.AddXY(Temp.Name, Temp.Power + actualitem.Powerbonus);
                this.chart1.Series["LPoints"].Points.AddXY(Temp.Name, Temp.Lift);
                this.chart1.Series["LPoints After"].Points.AddXY(Temp.Name, Temp.Power + actualitem.Liftbonus);
                this.chart1.Series["DPoints"].Points.AddXY(Temp.Name, Temp.Defense);
                this.chart1.Series["DPoints After"].Points.AddXY(Temp.Name, Temp.Power + actualitem.Defbonus);
            }
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (Backend.Instance.Characters[selected_character].Ch_type == "mage" && (actualitem.Require_chclass == "mage" || actualitem.Require_chclass == "both"))
            {
                Mage Temp = (Mage)Backend.Instance.Characters[selected_character];
                bool contains = Temp.Items.Any(p => p.Type == actualitem.Type);
                if(contains == false && (actual_eq_weight + actualitem.Weight <= Temp.Lift))
                {
                    Temp.Items.Add(actualitem);
                    Temp.bonus_count();
                    actual_eq_weight += actualitem.Weight;
                }
                else
                {
                    string mess = "Item to heavy or having an item of same type already";
                    MessageBox.Show(mess);
                }
            }
            else if (Backend.Instance.Characters[selected_character].Ch_type == "warior" && (actualitem.Require_chclass == "warior" || actualitem.Require_chclass == "both"))
            {
                Warior Temp = (Warior)Backend.Instance.Characters[selected_character];
                bool contains = Temp.Items.Any(p => p.Type == actualitem.Type);
                if (contains == false && (actual_eq_weight + actualitem.Weight <= Temp.Lift))
                {
                    Temp.Items.Add(actualitem);
                    Temp.bonus_count();
                    actual_eq_weight += actualitem.Weight;
                }
                else
                {
                    string mess = "Item to heavy or having an item of same type already";
                    MessageBox.Show(mess);
                }
            }
            else
            {
                string mess = "This character cant hold this item";
                MessageBox.Show(mess);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
