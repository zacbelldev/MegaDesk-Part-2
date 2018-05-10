using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_Zac_Bell
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void custNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void widthInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void depthInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void calcQuoteButton_Click(object sender, EventArgs e)
        {

        }

        private void drawersInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void surfaceMaterialInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rushInput_Enter(object sender, EventArgs e)
        {

        }
    }
}
