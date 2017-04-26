using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

/*
        Adressbuch - Ein einfaches Tool zum erfassen und verwalten von Adressdaten.
        Entwickelt im Rahmen des LF 6 Projektes "Erstes C# Programm mit DB Anbindung"
        Autoren: Diego Lago Lago (Source Code), Niklas Engel (GUI) und Lukas Weirich (SQL Programmierung
        Version: 0.1        Datum: 12.04.2017
*/

// ## > search for this pattern to find comments for features, which might be build in in later versions
// #DEBUG > search for this pattern to find lines, which should be removed after debugging
namespace Adressbuch
{
    public class dbConnection
    {
        private string dbConnString;
        public MySqlConnection dbConn = new MySqlConnection();
        private bool FDbConn = false;

        public void InitDbConn()
        {
            if (FDbConn == false)
            {
                try
                {
                    dbConnString = @"SERVER=localhost;DATABASE=adressbuch;UID=root;";
                    dbConn = new MySqlConnection(dbConnString);
                    dbConn.Open();
                    FDbConn = true;
                }
                catch (Exception ex)
                {
                    string title = "Fehlermeldung";
                    MessageBox.Show(ex.Message, title);
                }
            }
        }

        public void TermDbConn()
        {
            dbConn.Close();
            FDbConn = false;
        }
    }
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formViewContact());
        }
    }
}
