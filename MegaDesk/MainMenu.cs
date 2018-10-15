using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void openAddQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote(this);
            //addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show();
            Hide();

        }

        private void openViewQuoteButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes allQuotesForm  = new ViewAllQuotes();
            allQuotesForm.Tag = this;
            allQuotesForm.Show(this);
            Hide();


        }

        private void openSearchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuoteForm = new SearchQuotes();
            searchQuoteForm.Tag = this;
            searchQuoteForm.Show(this);
            Hide();

        }


        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
