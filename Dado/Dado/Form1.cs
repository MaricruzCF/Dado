using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dado
{
    public partial class Form1 : Form
    {
        Dado dado;
        public Form1()
        {
            dado = new Dado();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dado.lanzar().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int[] lados = new int[6];

            for (int i = 0; i < 100; i++)
            {
                int cara = dado.lanzar();
                lados [cara-1]++;
            }
            for(int i = 0; i < lados.Length; i++)
            {
                textBox1.Text +=("["+(i+1)+"]"+lados[i]+Environment.NewLine).ToString();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int[] lados1 = new int[6];
            int[] lados2 = new int[6];
            
            for (int i = 0; i < 100; i++)
            {
                int cara1 = dado.lanzar();
                int cara2 = dado.lanzar();

                lados1[cara1 - 1]++;
                lados2[cara2 - 1]++;

            }
            for (int i = 0; i < lados1.Length; i++)
            {
                textBox1.Text += ("[" + (i + 1) + "]" +" Cara1  ("+ lados1[i] + ") Cara2  (" + lados2[i] +")"+ Environment.NewLine).ToString();
            }
        }
    }
}
