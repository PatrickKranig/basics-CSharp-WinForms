using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerade_Zahl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Zahl = Convert.ToInt32(textBox1.Text);
            if (Zahl % 2 == 0)
                //% = Modulo = Restwert einer GANZEN Teilung
                // Bsp: 3/2 = 1 Rest 1; 6/3 = 2 Rest0; 7/3 = 2 Rest 1
                //d.h. haben wir eine 1 (o.ä.) als Restwert, ist die Zahl laut Anmweisung NICHT durch 2 Teilbar -> andere Verwenduhng wären Primzahlen, Schaltjahre etc.
            {
                label2.Visible = true;
                label2.Text="JA\n ist durch 2 teilbar";
                //das \n steht für eine Escape Sequenz für einen Befehl/Code für Absatz; Wenn es als "\" Zeichen interpretiert werden soll (z.b. bei Kommandopfaden) schreibe einfach \\ und er registriert ein \
                label2.ForeColor = Color.Green;
            }
            else
            {
                label2.Visible = true;
                label2.Text = "Nein\n ist nicht durch 2 teilbar";
                label2.ForeColor = Color.Red;
            }
        }
    }
}
