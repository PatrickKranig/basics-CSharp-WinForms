using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMD_Befehl_ausführen_lassen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process(); // Process Class - Ermöglicht den Zugriff auf lokale Prozesse und Remoteprozesse und das Starten und Anhalten lokaler Systemprozesse.
            //erzeugt ein Object process mit der Methode Process
            //man braucht halt ein Objekt(das sich die eingestellten Eigenschaften merkt), um die Befehle ausführen zu können :)
            // process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden; //versteckt das cmd fenster und führt den Code im Hinterrgrund aus
            process.StartInfo.FileName = "cmd.exe"; //starten der cmd anwendung (Arbeitet mit den Windows Umgebungsvariablen
            // string cmd = "/C netstat -a"; // speichert das Kommando in eine Variable
            process.StartInfo.Arguments = "/C netstat -a"; //man kann es direkt übergeben oder in einer string variable
            process.Start(); //starte die cmd
            Console.WriteLine();
        }
    }
}
