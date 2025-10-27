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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(tbNumPedido.Text))
            {
                MessageBox.Show("Ingrese el número de pedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (cbEnvioPrioritario.Checked)
                {
                    // Apilar el pedido prioritario
                    EnvioPrioritario.Push(tbNumPedido.Text);
                    tbNumPedido.Clear();
                    ActualizarListaPila();
                    return;
                }
                else
                {
                    // Agregar el pedido regular al final de la pila
                    lbRegular.Items.Add(tbNumPedido.Text);
                    tbNumPedido.Clear();
                    ActualizarListaPila();
                    return;
                }
            }
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
