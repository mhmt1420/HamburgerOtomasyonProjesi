using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hamburgerOtomasyon
{
    public static class Temizleme
    {

        public static List<Form1.ControlCollection> ControlList = new List<Form1.ControlCollection>();
        public static void Temizle(Control.ControlCollection ControlList)
        {
            foreach (var item in ControlList)
            {
                if (item is CheckBox )
                {
                    ((CheckBox)item).Checked = false;
                }
                else if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if(item is RadioButton)
                {
                    ((RadioButton)item).Checked = false;
                }
                else if(item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
                else if(item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 1;
                }
                else if(item is ListBox)
                {
                    ((ListBox)item).Items.Clear();
                }
                else if (item is GroupBox)
                {

                    Temizle(((GroupBox)item).Controls);
                    
                }
                else if (item is FlowLayoutPanel)
                {
                    Temizle(((FlowLayoutPanel)item).Controls);
                }

            }
        }

    }
}
