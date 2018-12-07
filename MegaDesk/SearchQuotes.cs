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
    /*Initializing the desktop material combo box 
     * list using the key-value pairs found in the 
     * enum data source can be completed by first 
     * populating a variable with a List<DesktopMaterial> type.
     * The challenge is when you GetValues from the enum
     * using Enum.GetValues you will need cast/convert to
     * type DesktopMaterial when running the built in ToList() method. 
     * Then this variable (let's name it materials) can be assigned to 
     * the DataSource of the combo box (let's name the combo box
     * desktopMaterialComboBox) like this: 
     * desktopMaterialComboBox.DataSource = materials;*/

    public partial class SearchQuotes : Form

    {
        public SearchQuotes()
        {
            InitializeComponent();
            //set default state
            //comboSurfaceMaterial.SelectedIndex = 0:

            //loadGrid();
        }
        

        private void SearchQuotes_Load(object sender, EventArgs e)

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

            List<string> surfaceMaterial = new List<string>();
            surfaceMaterial.Add("All");
            surfaceMaterial.Add("Oak");
            surfaceMaterial.Add("Laminate");
            surfaceMaterial.Add("Pine");
            surfaceMaterial.Add("Rosewood");
            surfaceMaterial.Add("Veneer");

            comboSurfaceMaterial.DataSource = surfaceMaterial;
            

            string[] columns;

            while (reader.EndOfStream == false)

            {
                string line = reader.ReadLine();
                columns = line.Split(',');
                quotes.Rows.Add(columns);
            }

            reader.Close();

            dataGridView1.DataSource = quotes;
        }

        private void cancelSearchButton_Click(object sender, EventArgs e)
        {

            Close();
        }
        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
        }


        private void comboSurfaceMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*ComboBox combo = (ComboBox)sender;
            if (comboSurfaceMaterial.SelectedIndex == 0)
            {
                //comboSurfaceMaterial.SelectedIndex = String.All;
                //LoadGrid();
            }
            else
            {
                //LoadGrid(combo.SelectedItem.ToString());
            }*/
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        
            

        private void FilterMat(object sender, EventArgs e)

        {
            dataGridView1.DataSource = null;

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

            string matCase = comboSurfaceMaterial.SelectedValue.ToString();
            switch (matCase)
            {
                case "Oak":
                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();

                        if (line.Contains("oak"))
                        {
                            columns = line.Split(',');
                            quotes.Rows.Add(columns);
                        }
                        else { }
                    }
                    reader.Close();
                    dataGridView1.DataSource = quotes;

                    break;

                case "Laminate":       
                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();

                        if (line.Contains("laminate"))

                        {
                            columns = line.Split(',');
                            quotes.Rows.Add(columns);
                        }
                        else { }
                    }

                    reader.Close();

                    dataGridView1.DataSource = quotes;
                    break;
                case "Pine":             
                   while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();

                        if (line.Contains("pine"))

                        {
                            columns = line.Split(',');
                            quotes.Rows.Add(columns);
                        }                   
                        else { }
                    }

                    reader.Close();

                    dataGridView1.DataSource = quotes;
                    break;               
                case "Rosewood":
                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();                       

                        if (line.Contains("rosewood"))

                        {
                            columns = line.Split(',');

                            quotes.Rows.Add(columns);

                        }

                        else { }

                    }
                    reader.Close();
                    dataGridView1.DataSource = quotes;
                    break;
                case "Veneer":
                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();

                        if (line.Contains("veneer"))
                        {

                            columns = line.Split(',');
                            quotes.Rows.Add(columns);
                        }
                        else { }
                    }

                    reader.Close();
                    dataGridView1.DataSource = quotes;
                    break;
                case "All":
                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();

                        columns = line.Split(',');

                        quotes.Rows.Add(columns);
                    }

                    reader.Close();
                    dataGridView1.DataSource = quotes;
                    break;
            }

        }

    }


}