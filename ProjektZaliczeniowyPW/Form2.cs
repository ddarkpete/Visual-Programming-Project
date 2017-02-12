using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                string type_ = "";
                string reqiuire_ ="";
                if(PantsRadio.Checked)
                {
                    type_ = "pants";
                }
                else if(HatRadio.Checked)
                {
                    type_ = "hat";
                }
                else if(ShoesRadio.Checked)
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
                string type_="";
                string reqiuire_="";
                
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void SaveItemsButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string path = saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("{0}",Backend.Instance.Items.Count);
            foreach(Item it in Backend.Instance.Items)
            {
                sw.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7},{8};",it.Name,it.Type,it.Description,it.Powerbonus,it.Defbonus,it.Liftbonus,it.Require_chclass,it.Properties,it.Weight);
     //(string name_, string type_, string descrip_, double powerb_, double defb_, double liftb_, string requir_, string propers_, int weight_)


            }
            sw.Close();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string path = openFileDialog1.FileName;
            StreamReader sr = new StreamReader(path);
            string no =  sr.ReadLine();
            int noo;
            Int32.TryParse(no, out noo);
            for(int i =0; i <noo;i++)
            {
                string data = sr.ReadLine();
                string[] split = data.Split(';');
                double powerb, defb, liftb;
                int weight;
                Double.TryParse(split[3], out powerb);
                Double.TryParse(split[4], out defb);
                Double.TryParse(split[5], out liftb);
                Int32.TryParse(split[8], out weight);
                Item Temp = new Item(split[0],split[1],split[2],powerb,defb,liftb,split[6],split[7],weight);
                Backend.Instance.Items.Add(Temp);
            }
            sr.Close();
        }

        private void LoadItemsButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
