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

            //Populate the dropdown for surface materials
            var materials = new List<Desk.Surface>();
            materials = Enum.GetValues(typeof(Desk.Surface)).Cast<Desk.Surface>().ToList();
            surfaceMaterialInput.DataSource = materials;

            //Populate the dropdown for rush
            var rush = new List<DeskQuote.RushDays>();
            rush = Enum.GetValues(typeof(DeskQuote.RushDays)).Cast<DeskQuote.RushDays>().ToList();
            rushInput.DataSource = rush;
        }

        //custNameInput
        //cancelButton
        //widthInput
        //depthInput
        //calcQuoteButton
        //drawersInput
        //surfaceMaterialInput
        //rushInput
        //outputQuoteText

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
            //Desk desk = new Desk();
            //desk.Width = int.Parse(widthInput.Value);
            //desk.Depth = int.Parse(depthInput.Value);
            //desk.NumOfDrawers = int.Parse(drawersInput.Value);
            //desk.Surface = surfaceMaterialInput.ValueMember;
            //DeskQuote quote = new DeskQuote();
            //quote.RushDays = 
            //finalQuote = quote.CalcTotalCost(desk.Width, desk.Depth, desk.NumOfDrawers, quote.RushDays, desk.Surface);
            //outputQuoteText.Text = finalQuote;
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

        private void rushInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void outputQuoteText_Click(object sender, EventArgs e)
        {

        }
    }
}

