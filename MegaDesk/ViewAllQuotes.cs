using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void cancelViewButton_Click(object sender, EventArgs e)
        {

            var mainMenu = new MainMenu();
            mainMenu.Show();
            Close();

        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {

            StreamReader reader = new StreamReader("quotes.txt");
            DataTable quotes = new DataTable();

            string Date = "Date";
            string Name = "Name";
            string Quote = "Quote";
            string Material = "Material";

            
            quotes.Columns.Add(Date);
            quotes.Columns.Add(Name);
            quotes.Columns.Add(Quote);
            quotes.Columns.Add(Material);


            string[] columns;
            while (reader.EndOfStream == false)

            {
                string line = reader.ReadLine();
                columns = line.Split(',');
                quotes.Rows.Add(columns);
            }

            reader.Close();

            dataGridView2.DataSource = quotes;

        }


        /* private void loadGrid()
        {
            DataGridViewCellValidatingEventArgs quoteFile = @"";
            using (StreamReader reader = new StreamReader(quotesFile))
            {
                //loadexisting quotes
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskQuotes = JasonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                dataGridView2.DataSource = deskQuotes.Select(d => new
                {
                    DateTime = d.Date,
                    Customer = d.Name,
                    Depth = d.Desk.depth,
                    Width = d.Desk.width,
                    Drawers = d.Desk.NumberOfDrawers,
                    SurfaceMaterial = d.Desk.Material,
                    DeliveryType = d.Shipping,
                    QuoteAmount = d.Price

                }).ToList();
                }
            }*/
        
    }
}

