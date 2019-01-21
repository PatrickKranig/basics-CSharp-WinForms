using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //muss dazugeschrieben werden damit wir einen Namespace/Bibliotheken von IO benutzen können
//IO steht für Input/Output

namespace DateienSpeichern
{
    //https://www.youtube.com/watch?v=KjP9v7xPUQE
    //https://www.lernmoment.de/csharp-programmieren/die-klasse-file/
    //https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/file-system/how-to-write-to-a-text-file
    //Alternative: https://www.youtube.com/watch?v=AT0-BSGEya4


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Dateiname in variable speichern:
            // string DateiName = @"Testdaten\Werktage.txt"; //Alternativ
            /* Mit dem @ werden alle Zeichen die als “Escape-Sequenz” interpretiert werden, wie zum Beispiel das \, als normales
             * Zeichen verwendet. Alternativ könntest du auch "C:\\temp\\test.txt" schreiben.
             * */

            //Array deklarieren
            string[] Array = new string[20]; //neues array von der länge 20 generieren
            Array[0] = "1. wert"; //lege den 1. wert des arrays fest
            Array[1] = "2. wert"; //lege den 2. wert des arrays fest

            //datei schreiben
            File.WriteAllLines(@"test.txt", Array); //schreibt nur arrays!

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //irgendwas mir File.ReadAllLines
                      
            
        }
    }
}
