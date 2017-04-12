using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
