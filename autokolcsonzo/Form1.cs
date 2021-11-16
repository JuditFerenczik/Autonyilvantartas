using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autokolcsonzo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listSzin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            int hossz = textRendsz.Text.Length;
             
          
            if (textRendsz.Text == "")
            {
                MessageBox.Show("A rendszám nem lehet üres!", "Hiba");
            }else if (hossz !=6)
            {
                MessageBox.Show("A rendszámnak 6 karakternek kell lennie!", "Hiba");
            }
            else if (!int.TryParse(textRendsz.Text.Substring(hossz-3), out number))
            {
                MessageBox.Show("Utolsó 3 karakternek számnak kell lennie!", "Hiba");
            }else if (textGyart.Text == "")
            {
                MessageBox.Show("A gyártmány nem lehet üres!", "Hiba");
            }
            else if (textTips.Text == "")
            {
                MessageBox.Show("A típus nem lehet üres!", "Hiba");
            }
            else if (!DateTime.TryParse(textUzem.Text, out DateTime dt))
            {
                MessageBox.Show("A dátum formátum nem megfelelő", "Hiba");
            }
            else if ( dt > DateTime.Now)
            {
                MessageBox.Show("Nem veszünk a jövőből autót", "Hiba");
            }
            else if ( DateTime.Now.Year-dt.Year > 300)
            {
                MessageBox.Show("Én egy kicsit idősnek érzem ezt az autót", "Hiba");
            }
            else if (!radioIgen.Checked && !radioNem.Checked)
            {
                MessageBox.Show("Az érvényes forgalmi nem lehet üres!", "Hiba");
            }

            else if (listSzin.SelectedIndex == -1)
            {
                MessageBox.Show("Az auto színe nem lehet üres!", "Hiba");
            }


            else
            {
                string forgalmi;
                if (radioIgen.Checked)
                {
                    forgalmi = "igen";
                }
                else
                {
                    forgalmi = "nem";
                }
           
                string msg = "Az auto \n";
            msg += "rendszáma: " + textRendsz.Text + number + "\n";
            msg += "gyártmánya: " + textGyart.Text+ "\n";
            msg += "típusa: " + textTips.Text + "\n";
            msg += "üzembehelyezésének dátuma: " + textUzem.Text + "\n";
            msg += "színe: "  + listSzin.SelectedItem + "\n";
            msg += "Van e rajta érvényes forgalmi: " + forgalmi+"\n";
            MessageBox.Show(msg, "Eredmény");
                File.AppendAllText("Autok.txt", msg);
            }
        }
    }
}
