using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        static public int licznik1 = int.Parse(textBox1.Text);
        int licznik2 = int.Parse(textBox3.Text);
        int mianownik1 = int.Parse(textBox2.Text);
        int mianownik2 = int.Parse(textBox4.Text);

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
            
        }

     
        private void button1_Click(object sender, EventArgs e)
        {

            

            if (mianownik1 == mianownik2)
            {
                textBox5.Text = (licznik1 + licznik2).ToString();
                textBox6.Text = (mianownik1).ToString();

            }
            else
            {
                textBox6.Text = (mianownik1*mianownik2).ToString();
                textBox5.Text = ((licznik1*mianownik2) + (licznik2*mianownik1)).ToString();
            }

            
        }
    }
}
