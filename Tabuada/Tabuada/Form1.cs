using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            // Aula Caculadora 
            //Declarando as variaveis

            int numero, resultado, i;
            i = 1;
            numero = int.Parse(textBoxNumero.Text);
            while (i <=10)
            {
                resultado = i * numero;
                listBox1.Items.Add(String.Concat(numero, " * ", i, " = ", resultado));
                i = i + 1;

            }

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            //Declarando o codio limpar textbox, listbox, 

            textBoxNumero.Text = " ";
            listBox1.Items.Clear();

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            //Declarando codigo sair

            Close();

        }
    }
}
