using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

// ## > search for this pattern to find comments for features, which might be build in in later versions
// #DEBUG > search for this pattern to find lines, which should be removed after debugging

namespace Adressbuch
{
    public partial class formViewContact : Form
    {
        public formViewContact()
        {
            InitializeComponent();
        }//

        // Show editing dialog when clicking "Editieren"
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            formEditContact showFormEditContact = new formEditContact();
            showFormEditContact.ShowDialog();
        }//

        // Connect to DB, create adapter, fill DataSet, fill DataGridView
        private void formViewContact_Load(object sender, EventArgs e)
        {
            dbConnection dbConn = new dbConnection();
            dbConn.InitDbConn();
            dbConn.TermDbConn();
            DataView view = new DataView();
            MySqlDataAdapter adapterPerson = new MySqlDataAdapter();
            try
            {
                // Select desired coloumns
                string sqlAdapterPerson = @"SELECT `PersonID`, `Anrede`, `Vorname`, `Nachname`, 
                                            `Strasse`, `Hausnummer`, `PLZ`, `Ort`,
                                            `Land`, `Telefonnummer`, `Mobilnnummer`, `Mail`,
                                            `Webseite`, `Geburtstag` FROM `person`";
                adapterPerson = new MySqlDataAdapter(sqlAdapterPerson, dbConn.dbConn);
                
            }
            catch (Exception ex)
            {
                string title = "Fehlermeldung:";
                MessageBox.Show(ex.Message, title);
            }

            // Create DataSet and Fill it using the adapters
            try
            {
                DataSet dataSetPerson = new DataSet();
                adapterPerson.Fill(dataSetPerson, "person");
                view = dataSetPerson.Tables["person"].DefaultView;
            }
            catch (Exception ex)
            {
                string title = "Fehlermeldung:";
                MessageBox.Show(ex.Message, title);
            }

            // Fill informations into the DataGridView
            dataGridViewContacts.DataSource = view;
            dbConn.TermDbConn();
        }//

        // Refresh DataGridView using "Aktualisieren"
        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            // Implementing method to call formViewContact_Load 
            //or make formViewContact_Load call a method that contains
            //current code of formViewContact_Load
        }//
    }
}
