using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Mensajeria
{
    public partial class Form1 : Form
    {
        Stack<string> EnvioPrioritario = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
            btnAgregar.Click += btnAgregar_Click;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           string pedido = tbNumPedido.Text.Trim();

            if (pedido == "")
            {
                MessageBox.Show("Ingrese el número de pedido.");
                return;
            }

            // Apilar el pedido prioritario
            EnvioPrioritario.Push(pedido);

            tbNumPedido.Clear();
            ActualizarListaPila();
        }

        private void ActualizarListaPila()
        {
            lbPrioritario.Items.Clear();
            foreach (var item in EnvioPrioritario)
            {
                lbPrioritario.Items.Add(item);
            }
        }
    }
}
