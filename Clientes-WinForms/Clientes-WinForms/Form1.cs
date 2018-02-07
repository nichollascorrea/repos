using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clientes_WinForms.Classes;


namespace Clientes_WinForms
{


    public partial class Form1 : Form
    {
        static List<Cadastro> cadastro = new List<Cadastro>();

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string telefone = maskedTextBox1.Text;
            string email = textBox2.Text;

            //Cadastro pessoa = new Cadastro(nome, telefone, email);
            try
            {
                cadastro.Add(new Cadastro(nome, telefone, email));
            }
            catch (Exception x)
            {
                MessageBox.Show("Ocorreu o erro" + x.Message);
            }

            MessageBox.Show("Cliente adicionado");

            textBox1.Clear();
            maskedTextBox1.Clear();
            textBox2.Clear();


            textBox3.Clear();

            textBox3.Text = "Resultado";

            for (int i = 0; i < cadastro.Count; i++)
            {
                textBox3.AppendText(cadastro[i].Nome + " " + cadastro[i].Telefone + " " + cadastro[i].Email);

            }


        }


    }
}
