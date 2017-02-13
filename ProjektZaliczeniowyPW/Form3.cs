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
    public partial class Form3 : Form
    {

        int selected_index_global;

        public Form3()
        {
            InitializeComponent();
        }

        private void AddCharButton_Click(object sender, EventArgs e)
        {
            Backend.Instance.AddChar(this);
            if (Backend.Instance.MessageForm3 == true)
            {
                string mess = "Some fields are not filled correctly";
                MessageBox.Show(mess);
                Backend.Instance.MessageForm3 = false;
            }
            else
            {
                NameBox.Text = "";
                DescriptBox.Text = "";
                LVLBox.Text = "";
                string mess2 = "Added correctly";
                MessageBox.Show(mess2);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void EditCharacterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected_index = EditCharacterCombo.SelectedIndex;
            selected_index_global = selected_index;
           // Backend.Instance.Characters[selected_index];
            if(Backend.Instance.Characters[selected_index].Ch_type == "mage")// zawsze można to zmienić na jakieś pole string w obu klasach
            {
                Mage TempMage = (Mage)Backend.Instance.Characters[selected_index];
                NameEditBox.Text = TempMage.Name;
                DecriptEditBox.Text = TempMage.Description;
                LVLEditBox.Text = TempMage.Lvl.ToString();
            }
            else if(Backend.Instance.Characters[selected_index].Ch_type == "warior")
            {
                Warior TempWarior = (Warior)Backend.Instance.Characters[selected_index];
                NameEditBox.Text = TempWarior.Name;
                DecriptEditBox.Text = TempWarior.Description;
                LVLEditBox.Text = TempWarior.Lvl.ToString();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int level;
            bool Check = Int32.TryParse(LVLEditBox.Text, out level);
            if (Check && (DecriptEditBox.Text != "" || NameEditBox.Text != ""))
            {
                if (Backend.Instance.Characters[selected_index_global].Ch_type == "mage")// zawsze można to zmienić na jakieś pole string w obu klasach
                {
                    Mage TempMage = new Mage(NameEditBox.Text, DecriptEditBox.Text, level);
                    TempMage.lvl_count();
                    Backend.Instance.Characters[selected_index_global] = TempMage;
                }
                else if (Backend.Instance.Characters[selected_index_global].Ch_type == "warior")
                {
                    Warior TempWarior = new Warior(NameEditBox.Text, DecriptEditBox.Text, level);
                    TempWarior.lvl_count();
                    Backend.Instance.Characters[selected_index_global] = TempWarior;
                }
            }
            else
            {
                string mess = "Some fields are not filled correctly";
                MessageBox.Show(mess);
            }
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Backend.Instance.Characters.RemoveAt(selected_index_global);
            EditCharacterCombo.Items.RemoveAt(selected_index_global);
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
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void SaveAllButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string path = saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("{0}", Backend.Instance.Characters.Count);
            foreach (CharacterClass charc in Backend.Instance.Characters)
            {
                if(charc.Ch_type == "mage")
                {
                    Mage Temp = (Mage)charc;
                    sw.WriteLine("{0};{1};{2};{3}", Temp.Ch_type, Temp.Name, Temp.Description, Temp.Lvl);
                    sw.WriteLine("{0}", Temp.Items.Count);
                    foreach(Item it in Temp.Items)
                    {
                        sw.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7},{8};", it.Name, it.Type, it.Description, it.Powerbonus, it.Defbonus, it.Liftbonus, it.Require_chclass, it.Properties, it.Weight);
                    }
                }
                if (charc.Ch_type == "warior")
                {
                    Warior Temp = (Warior)charc;
                    sw.WriteLine("{0};{1};{2};{3}", Temp.Ch_type, Temp.Name, Temp.Description, Temp.Lvl);
                    sw.WriteLine("{0}", Temp.Items.Count);
                    foreach (Item it in Temp.Items)
                    {
                        sw.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7},{8};", it.Name, it.Type, it.Description, it.Powerbonus, it.Defbonus, it.Liftbonus, it.Require_chclass, it.Properties, it.Weight);
                    }
                }
            }
        }
        //W POZOSTALYCH FORMACH ONLOAD DANE TODO i Save/Read postaci
    }
}
