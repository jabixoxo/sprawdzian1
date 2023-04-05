using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void txtSzyfr_TextChanged(object sender, EventArgs e)
        {

        }

        private void nUpDn_ValueChanged(object sender, EventArgs e)
        {
            decimal l = nUpDn.Value;
            int liczba = 0;
            liczba = Decimal.ToInt32(l);
        }
        
        private void chckMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chckDuze_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chckLiczby_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSzyfr_Click(object sender, EventArgs e)
        {
            decimal l = nUpDn.Value;
            int liczba = 0;
            liczba = Decimal.ToInt32(l);
            char c = Convert.ToChar(liczba);
            string tekst = txtSzyfr.Text;
            string wynik = "";
            /*1*/
            /* if (chckMale.Checked)
    {
                 string tekst = txtSzyfr.Text;
                 string nowyciag = "";
                 for (int i = 0; i < tekst.Length;i++)
                 {
                    if (tekst[i] >= 'a' && tekst[i] <= 'q')
                     {
                         char t = tekst[i];
                         char nier = tekst[i];
                         char takn = (char)liczba;
                         char znakc = (char)(nier + takn);
                         nowyciag = nowyciag + char.ToString(znakc);
                     }
                    else if (tekst[i] > 'q' && tekst[i] <= 'z')
                     {
                         int liczbasun = 'z' - (tekst[i] + liczba);

                         char takn = (char)(liczbasun);
                         char nier = 'z';
                         char znakc = (char)( takn + nier);
                         nowyciag = nowyciag + char.ToString(znakc);
                     }
                    else
                     nowyciag = nowyciag + tekst[i];
                 }

                 MessageBox.Show(nowyciag);
             }
             if (chckDuze.Checked)
             {
                 string tekst = txtSzyfr.Text;
                 string nowyciag = "";
                 for (int i = 0; i < tekst.Length; i++)
                 {
                     if (tekst[i] >= 'A' && tekst[i] <= 'Q')
                     {
                         char t = tekst[i];
                         char nier = tekst[i];
                         char takn = (char)liczba;
                         char znakc = (char)(nier + takn);
                         nowyciag = nowyciag + char.ToString(znakc);
                     }
                     else if (tekst[i] > 'Q' && tekst[i] <= 'Z')
                     {
                         int liczbasun = 'Z' - (tekst[i] + liczba);

                         char takn = (char)(liczbasun);
                         char nier = 'Z';
                         char znakc = (char)(takn + nier);
                         nowyciag = nowyciag + char.ToString(znakc);
                     }
                     else
                         nowyciag = nowyciag + tekst[i];
                 }
             }
             if (chckLiczby)
            */

            for (int i =0; i < tekst.Length; i++)
            {
                if ('A' <= tekst[i] && tekst[i] <='Z')
                {
                    if (chckDuze.Checked)
                    {
                        wynik = wynik + zaszyfrowanie(tekst[i], liczba);
                    }
                    else
                        wynik = wynik + '*';
                }
             if ('a' <= tekst[i] && tekst[i] <= 'z')
                {
                    if (chckMale.Checked)
                    {
                        wynik = wynik + zaszyfrowanie1(tekst[i], liczba);
                    }
                    else
                        wynik = wynik + '*';
                }
              
               if (0 < tekst[i] && tekst[i] <= 9)
                {
                    if (chckLiczby.Checked)
                    {
                        wynik = wynik + zaszyfrowanie2(tekst[i], liczba);
                    }
                    else
                        wynik = wynik + '*';
                }
       
            }
            MessageBox.Show(wynik);
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSzyfr.Text = "";
        }
        char zaszyfrowanie(char cah, int k)
        {
            int i = 0;
            string s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            while (s[i] != cah)
            {
                i++;
            }
            return s[(i + k) % 26];
        }
        char zaszyfrowanie1(char cah, int k)
        {
            int i = 0;
            string s = "abcdefghijklmnopqrstuvwxyz";
            while (s[i] != cah)
            {
                i++;
            }
            return s[(i + k) % 26];
        }
        char zaszyfrowanie2(char c, int k)
        {
            int i = 0;
            string s = "123456789";
            while (s[i] != c)
            {
                i++;
            }
            return s[(i + k) % 10];
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
