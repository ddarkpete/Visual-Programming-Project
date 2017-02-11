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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int items_combo_ind;

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            string itname_ = NameBox.Text;
            string itdescription = DecriptBox.Text;
            int lbonus_, pbonus_, dbonus_, weight_;
            bool lboncheck = Int32.TryParse(LiftBonusBox.Text, out lbonus_);
            bool pboncheck = Int32.TryParse(PowerBonusBox.Text, out pbonus_);
            bool dboncheck = Int32.TryParse(DefBonusBox.Text, out dbonus_);
            bool wcheck = Int32.TryParse(WeightBox.Text, out weight_);
            if((PantsRadio.Checked || HatRadio.Checked || GlovesRadio.Checked ||ShoesRadio.Checked
                || SpecialItRadio.Checked) && (MageItemRadio.Checked|| WariorItemRadio.Checked || BothItemRadio.Checked) 
                && itname_!= "" && itdescription != "" && lboncheck == true && pboncheck == true &&
                dboncheck == true && wcheck == true)
            {
                string type_;
                string reqiuire_;
                if(PantsRadio.Checked)
                {
                    type_ = "pants";
                }
                else if(HatRadio.Checked)
                {
                    type_ = "hat";
                }
                else if(GlovesRadio.Checked)
                {
                    type_ = "shoes";
                }
                else if (SpecialItRadio.Checked)
                {
                    type_ = "special";
                }
                else if (GlovesRadio.Checked)
                {
                    type_ = "gloves";
                }
                if(MageItemRadio.Checked)
                {
                    reqiuire_ = "mage";
                }
                else if (WariorItemRadio.Checked)
                {
                    reqiuire_ = "warior";
                }
                if (BothItemRadio.Checked)
                {
                    reqiuire_ = "both";
                }
                string propers_ = "Power + " + pbonus_.ToString() + " Lift + " + lbonus_.ToString()
                    + " Defense + " + dbonus_.ToString();

                Item TempItem = new Item(itname_, type_, itdescription, pbonus_, dbonus_,
                    lbonus_, reqiuire_,propers_,weight_);
                Backend.Instance.Items.Add(TempItem);
                ItemComboBox.Items.Add(itname_);
                NameBox.Clear();
                DecriptBox.Clear();
                PowerBonusBox.Clear();
                LiftBonusBox.Clear();
                DefBonusBox.Clear();
                WeightBox.Clear();
                string mess = "Added "+ itname_ +" correctly";
                MessageBox.Show(mess);


            }
            else
            {
                string mess = "Some fields are not filled correctly";
                MessageBox.Show(mess);
            }

        }

        private void ItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            items_combo_ind = ItemComboBox.SelectedIndex;
            NameEditBox.Text = Backend.Instance.Items[items_combo_ind].Name;
            DescriptEditBox.Text = Backend.Instance.Items[items_combo_ind].Description;
            PBonusEditBox.Text = Backend.Instance.Items[items_combo_ind].Powerbonus.ToString();
            LBonusEditBox.Text = Backend.Instance.Items[items_combo_ind].Liftbonus.ToString();
            DBonusEditBox.Text = Backend.Instance.Items[items_combo_ind].Defbonus.ToString();
            WeightEditBox.Text = Backend.Instance.Items[items_combo_ind].Weight.ToString();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string itname_ = NameEditBox.Text;
            string itdescription = DescriptEditBox.Text;
            int lbonus_, pbonus_, dbonus_, weight_;
            bool lboncheck = Int32.TryParse(LBonusEditBox.Text, out lbonus_);
            bool pboncheck = Int32.TryParse(PBonusEditBox.Text, out pbonus_);
            bool dboncheck = Int32.TryParse(DBonusEditBox.Text, out dbonus_);
            bool wcheck = Int32.TryParse(WeightEditBox.Text, out weight_);
            if ( itname_ != "" && itdescription != "" && lboncheck == true && pboncheck == true &&
                dboncheck == true && wcheck == true)
            {
                string type_;
                string reqiuire_;
                
                string propers_ = "Power + " + pbonus_.ToString() + " Lift + " + lbonus_.ToString()
                    + " Defense + " + dbonus_.ToString();

                Item TempItem = new Item(itname_, type_, itdescription, pbonus_, dbonus_,
                    lbonus_, reqiuire_, propers_, weight_);
                Backend.Instance.Items[items_combo_ind] = TempItem;
                ItemComboBox.Items[items_combo_ind] = itname_;
                NameEditBox.Clear();
                DescriptEditBox.Clear();
                PBonusEditBox.Clear();
                LBonusEditBox.Clear();
                DBonusEditBox.Clear();
                WeightEditBox.Clear();
                string mess = "Edited " + itname_ + " correctly";
                MessageBox.Show(mess);
            }
            else
            {
                string mess = "Some fields are not filled correctly";
                MessageBox.Show(mess);
            }
        }

        private void DeleteItButton_Click(object sender, EventArgs e)
        {
            Backend.Instance.Items.RemoveAt(items_combo_ind);
            ItemComboBox.Items.RemoveAt(items_combo_ind);
        }
    }
}
