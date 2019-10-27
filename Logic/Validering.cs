using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodcastProjekt.Logic
{
    public static class Validering
    {
        public static bool isEmptyTextBox(TextBox enTextBox) {
            bool isEmpty = false;
            if (enTextBox.Text.Trim().Equals("")) {
                isEmpty = true;
                MessageBox.Show("Detta textfält får inte vara tomt!");
                enTextBox.Focus();
            }
            return isEmpty;
        }
    }
    
}
