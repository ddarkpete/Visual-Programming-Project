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
            if(Backend.Instance.Characters[selected_index] is Mage)// zawsze można to zmienić na jakieś pole string w obu klasach
            {
                Mage TempMage = (Mage)Backend.Instance.Characters[selected_index];
                NameEditBox.Text = TempMage.Name;
                DecriptEditBox.Text = TempMage.Description;
                LVLEditBox.Text = TempMage.Lvl.ToString();
            }
            else if(Backend.Instance.Characters[selected_index] is Warior)
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
                if (Backend.Instance.Characters[selected_index_global] is Mage)// zawsze można to zmienić na jakieś pole string w obu klasach
                {
                    Mage TempMage = new Mage(NameEditBox.Text, DecriptEditBox.Text, level);
                    TempMage.lvl_count();
                    Backend.Instance.Characters[selected_index_global] = TempMage;
                }
                else if (Backend.Instance.Characters[selected_index_global] is Warior)
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
    }
}
