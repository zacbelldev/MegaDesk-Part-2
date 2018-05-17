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

        private void calcQuoteButton_Click(object sender, EventArgs e)
        {
            DeskQuote quote = new DeskQuote();
            quote.Width = Convert.ToInt32(widthInput.Value);
            quote.Depth = Convert.ToInt32(depthInput.Value);
            quote.NumOfDrawers = Convert.ToInt32(drawersInput.Value);
            string surface = surfaceMaterialInput.SelectedValue.ToString();
            string rush = rushInput.SelectedValue.ToString();
            quote.CustName = custNameInput.Text;
            quote.QuoteDate = DateTime.Now;
            decimal finalQuote = 0.00M;
            try
            {
                //Calculate Final Quote
                finalQuote = quote.CalcTotalCost(quote.Width, quote.Depth, quote.NumOfDrawers, rush, surface);
                //Output text to form
                outputQuoteText.Text = finalQuote.ToString();
                // Output quote to file            
                string str = $"{quote.CustName},{quote.QuoteDate},{surface},{rush},{quote.Width},{quote.Depth},{quote.NumOfDrawers},{finalQuote}";
                if (!File.Exists("quotes.txt")) {
                    File.WriteAllText("quotes.txt", str);
                } else {
                    using (var tw = new StreamWriter("quotes.txt", true))
                    {
                        tw.WriteLine(str);
                    }
                }                
            }
            catch (Exception ex)
            {
                outputQuoteText.Text = ex.ToString();
                throw ex;
            }                        
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }























        private void custNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void widthInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void depthInput_ValueChanged(object sender, EventArgs e)
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

        private void rushInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void outputQuoteText_Click(object sender, EventArgs e)
        {

        }

    }
}

