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
        //private Form _mainMenu;

        public AddQuote(Form mainMenu)
        {
            InitializeComponent();

            //_mainMenu = mainMenu;
            
            var materials = new List<Desk.DesktopMaterial>();

            materials = Enum.GetValues(typeof(Desk.DesktopMaterial)).Cast<Desk.DesktopMaterial>().ToList();
            MaterialInput.DataSource = materials;
        }

        private void cancelQuotesButton_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void GetQuoteButton_Click(object sender, EventArgs e)
        {
            String matToString = MaterialInput.Text;
            decimal ShipmentNum = Convert.ToDecimal(ShippingInput.Text);
            string NameText = NameInput.Text;
            decimal MaterialNum;
            StreamWriter qfile;
               
            if (matToString.Equals("oak"))
            {
                MaterialNum = 1;

            }
            else if (matToString.Equals("roseWood"))
            {
                MaterialNum = 2;
            }
            else if (matToString.Equals("venner"))
            {
                MaterialNum = 3;
            }
            else if (matToString.Equals("pine"))
            {
                MaterialNum = 4;
            }
            else if (matToString.Equals("laminate"))
            {
                MaterialNum = 5;
            }
            else
            {
                MaterialNum = 1; 
            }
        }
    }
}
