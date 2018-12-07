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

    public partial class AddQuote : Form

    {

        public AddQuote()

        {

            InitializeComponent();

            var materials = new List<Desk.DesktopMaterial>();

            materials = Enum.GetValues(typeof(Desk.DesktopMaterial))
                .Cast<Desk.DesktopMaterial>()
                .ToList();
            MaterialInput.DataSource = materials;

        }

        private void cancelQuotesButton_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void FileQuotes(DeskQuote deskQuote)
        {
            string quotesFile = "quotes.txt";

            using (StreamWriter writer = new StreamWriter(quotesFile, true))
            {
                writer.WriteLine( 
                $"{deskQuote.Date}," +
                $"{deskQuote.Name}," +
                $"{deskQuote.Desk.depth}," +
                $"{deskQuote.Desk.width}," +
                $"{deskQuote.Desk.NumberOfDrawers}," +
                $"{deskQuote.materialIn}," +
                $"{deskQuote.Shipping}," +
                $"{deskQuote.Price}," );
         
            }

        }

        private void GetQuoteButton_Click(object sender, EventArgs e)
        {
            String strMaterial = MaterialInput.Text;
            decimal widthNum = WidthSize.Value;
            decimal depthNum = DepthSize.Value;
            decimal drawerNum = DrawerNum.Value;
            decimal shippingNum = Convert.ToDecimal(ShippingInput.Text);
            string NameText = NameInput.Text;
            decimal MaterialNum;
            StreamWriter writer;

            if (strMaterial == "oak")
            {
                MaterialNum = 1;
            }
            else if (strMaterial == "laminate")
            {
                MaterialNum = 2;
            }
            else if (strMaterial == "pine")
            {
                MaterialNum = 3;
            }
            else if (strMaterial == "rosewood")

            {
                MaterialNum = 4;
            }
            else if (strMaterial == "veneer")
            {
                MaterialNum = 5;
            }
            else
            {
                MaterialNum = 1;
            }


            if (NameText == "" || NameText.All(char.IsDigit)) { 

            label1.Text = "Please enter valid name";

        }
                else
            {

                try

                {
                    Desk newDesk = new Desk(widthNum, depthNum, drawerNum, MaterialNum);
                    DeskQuote newQuote = new DeskQuote(newDesk, NameText, shippingNum);

                    writer = new StreamWriter("quotes.txt", true);
                    writer.Write(newQuote.Date.ToString("MM/dd/yyyy") + ", " +
                        newQuote.Name + ", " + newQuote.Price + ", " + strMaterial + "\n");
                    writer.Close();

                    MessageBox.Show(label2.Text = "Table Quote Created");
                    label1.Text = "";
                }               
                catch           
                {
                    label2.Text = "Table not created!";                   
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ShippingInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }
    }
}