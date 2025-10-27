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
        //Se agrega la cola para los envios regulares
        Queue<string> EnvioRegular = new Queue<string>();

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
                    EnvioRegular.Enqueue(tbNumPedido.Text);
                    tbNumPedido.Clear();
                    ActualizarCola();
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
        private void ActualizarCola()
        {
            lbRegular.Items.Clear();
            foreach (var item in EnvioRegular)
            {
                lbRegular.Items.Add(item);
            }
        }

        private void btnDespachar_Click(object sender, EventArgs e)
        {
            string pedidoDespachado = "";


            if (EnvioPrioritario.Count > 0)
            {
                pedidoDespachado = EnvioPrioritario.Pop();
                lbPrioritario.Items.Remove(pedidoDespachado);
                MessageBox.Show($"¡Despachando Prioritario! (PILA): {pedidoDespachado}", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (EnvioRegular.Count > 0)
            {
                pedidoDespachado = EnvioRegular.Dequeue();
                lbRegular.Items.Remove(pedidoDespachado);
                MessageBox.Show($"Despachando Regular (COLA): {pedidoDespachado}", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("No hay pedidos pendientes para despachar.", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
