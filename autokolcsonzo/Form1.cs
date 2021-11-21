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
   
        private void Form1_Load(object sender, EventArgs e)
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
           
           
           string msg = textRendsz.Text + ",";
            msg +=  textGyart.Text+ ",";
            msg += textTips.Text + ",";
            msg +=  textUzem.Text + ",";
            msg += listSzin.SelectedItem + ",";
            msg +=  forgalmi;
            MessageBox.Show(msg, "Eredmény");
                try
                {
                    using(StreamWriter sw = new StreamWriter("autokolcsonzo.txt"))
                    {
                        sw.WriteLine(msg);
                    }

                }
                catch 
                {
                    MessageBox.Show("Valami hiba történt kiírás közben","Hiba");
                }
                
            }
        }

        private void vissza_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("autokolcsonzo.txt"))
                {
                    string[] adat = sr.ReadLine().Split(",");
                    textRendsz.Text = adat[0];
                    textGyart.Text = adat[1];
                    textTips.Text = adat[2];
                    textUzem.Text = adat[3];
                    listSzin.SelectedItem = adat[4];
                    if (adat[5]== "igen")
                    {
                        radioIgen.Checked = true;
                    }
                    else
                    {
                        radioNem.Checked = false;
                    }

                }
            }
            catch
            {
                MessageBox.Show("Hiba a visszatöltés közben", "Hiba");
            }

        }
    }
}
