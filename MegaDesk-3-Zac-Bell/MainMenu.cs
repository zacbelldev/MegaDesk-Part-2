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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void openAddNewQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void viewQuotesButton_Click(object sender, EventArgs e)
        {
            DisplayQuote addNewQuoteForm = new DisplayQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void searchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes addNewQuoteForm = new SearchQuotes();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
