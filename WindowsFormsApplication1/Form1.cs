using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            int licznik, mianownik, cala;
            Suma(out licznik, out mianownik, out cala);

            textBox5.Text = licznik.ToString();
            textBox6.Text = mianownik.ToString();
            textBox7.Text = cala.ToString();
        }

        private void Suma(out int licznik, out int mianownik, out int cala)
        {
            int licznik1, licznik2, mianownik1, mianownik2;
            Zmienne(out licznik1, out licznik2, out mianownik1, out mianownik2);
            
            if (mianownik1 == mianownik2)
            {
                licznik = (licznik1 + licznik2);
                mianownik = (mianownik1);

            }
            else
            {
                licznik = ((licznik1 * mianownik2) + (licznik2 * mianownik1));
                mianownik = (mianownik1*mianownik2);

            }

            cala = 0;

            if (licznik > mianownik)
            {
                cala = licznik / mianownik;
                licznik = licznik - mianownik;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int licznikR, mianownikR;
            Roznica(out licznikR , out mianownikR );


            textBox5.Text = licznikR.ToString();
            textBox6.Text = mianownikR.ToString();

        }

        private void Roznica(out int licznikR, out int mianownikR)
        {
            int licznik1, licznik2, mianownik1, mianownik2;
            Zmienne(out licznik1, out licznik2, out mianownik1, out mianownik2);

            if (mianownik1 == mianownik2)
            {
                licznikR = (licznik1 - licznik2);
                mianownikR = mianownik1;

            }
            else
            {
                licznikR = mianownik1 * mianownik2;
                mianownikR = ((licznik1 * mianownik2) - (licznik2 * mianownik1));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int licznikIcz, mianownikIcz;
            Iloczyn(out licznikIcz, out mianownikIcz);

            textBox5.Text = licznikIcz.ToString();
            textBox6.Text = mianownikIcz.ToString();

        }

        private void Iloczyn(out int licznikIcz, out int mianownikIcz)
        {
            int licznik1, licznik2, mianownik1, mianownik2;
            Zmienne(out licznik1, out licznik2, out mianownik1, out mianownik2);

            licznikIcz = (licznik1 * licznik2);
            mianownikIcz = (mianownik1 * mianownik2);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int licznikIRaz, mianownikIRaz;
            Iloraz(out licznikIRaz, out mianownikIRaz);

            textBox5.Text = licznikIRaz.ToString();
            textBox6.Text = mianownikIRaz.ToString();


        }

        private void Iloraz(out int licznikIRaz, out int mianownikIRaz)
        {
            int licznik1, licznik2, mianownik1, mianownik2;
            Zmienne(out licznik1, out licznik2, out mianownik1, out mianownik2);

            licznikIRaz = (licznik1 * mianownik2);
            mianownikIRaz = (licznik2 * mianownik1);
        }

        public void Zmienne(out int licznik1, out int licznik2, out int mianownik1, out int mianownik2)
        {
            licznik1 = int.Parse(textBox1.Text);
            licznik2 = int.Parse(textBox3.Text);
            mianownik1 = int.Parse(textBox2.Text);
            mianownik2 = int.Parse(textBox4.Text);
        }

        /* public void jedenIWiecej(int licznik, int mianownik, out int cala)
        {     
                            
        } */
        
    }
 }
