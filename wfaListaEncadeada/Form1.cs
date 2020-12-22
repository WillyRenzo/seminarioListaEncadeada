using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaListaEncadeada
{
    public partial class Form1 : Form
    {
        ListaEncadeada lista = new ListaEncadeada();

        public Form1()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_exibir_MouseClick(object sender, MouseEventArgs e)
        {
            txt_lista.Text = "";
            if (lista.cabeca != null)
            {
                NohLista temp = lista.cabeca;
                while (temp != null)
                {
                    txt_lista.AppendText(Convert.ToString(temp.getData()) + " ");
                    Console.Write(temp.getData() + " ");
                    temp = temp.getNext();
                }
            }
            else
            {
                txt_lista.Text = "Lista vazia.";
            }
        }

        private void btn_insereInicio_MouseClick(object sender, MouseEventArgs e)
        {
            int valor = 0;
            try
            {
                valor = Convert.ToInt32(txt_insereInicio.Text);
                lista.insereInicio(valor);
                txt_insereInicio.Text = "";
            }catch(Exception err)
            {
                MessageBox.Show("O valor inserido não é valido.");
            }
            
        }

        private void btn_insereFinal_Click(object sender, EventArgs e)
        {

        }

        private void btn_insereFinal_MouseClick(object sender, MouseEventArgs e)
        {
            int valor = 0;
            try
            {
                valor = Convert.ToInt32(txt_insereFinal.Text);
                lista.insereFim(valor);
                txt_insereFinal.Text = "";
            }
            catch(Exception err)
            {
                MessageBox.Show("O valor inserido não é valido.");
            }

        }

        private void btn_removeInicio_Click(object sender, EventArgs e)
        {

        }

        private void btn_removeInicio_MouseClick(object sender, MouseEventArgs e)
        {
            if(lista.cabeca != null)
            {
                lista.retiraInicio();
            }
            else
            {
                MessageBox.Show("Lista vazia");
            }


        }

        private void btn_removeFinal_MouseClick(object sender, MouseEventArgs e)
        {
            if(lista.cabeca != null)
            {
                lista.retiraFim();
            }
            else
            {
                MessageBox.Show("Lista vazia");
            }
            
        }

        private void txt_lista_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
