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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();            
        }

        private void custNameSearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = custNameSearchTextBox.Text;

            dataGridView1.Dock = DockStyle.Fill;

            //Read the data from text file
            string[] quoteData = File.ReadAllLines("quotes.txt");
            string[] headerData = new[] { "Customer Name, Date, Surface, Rush, Width, Depth, Drawers, Quote" };
            string[] headers = headerData[0].Split(',');

            //Create and populate DataTable
            DataTable table = new DataTable();

            foreach (string header in headers)
                table.Columns.Add(header, typeof(string), null);

            foreach (string quote in quoteData)
            {
                if (quote == searchTerm)
                    table.Rows.Add(quote.Split(','));
            }
                

            //Set the DataSource of DataGridView to the DataTable
            dataGridView1.DataSource = table;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }










        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void custNameSearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
