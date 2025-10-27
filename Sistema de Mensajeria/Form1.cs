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
       
        // PILA para pedidos prioritarios (LIFO)
        // La estructura Stack sigue el principio "Último en entrar, primero en salir".
        // Ideal para manejar envíos urgentes que deben procesarse antes que los regulares.
        Stack<string> EnvioPrioritario = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            // Verificar que el usuario haya ingresado un número de pedido
            if (string.IsNullOrWhiteSpace(tbNumPedido.Text))
            {
                MessageBox.Show("Ingrese el número de pedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (cbEnvioPrioritario.Checked)
                {
                    // --- USO DE LA PILA ---
                    // Se utiliza el método Push() para agregar un nuevo pedido al tope de la pila.
                    // Esto significa que será el primero en ser despachado (LIFO).
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
        // Método para actualizar visualmente la pila de pedidos prioritarios en el ListBox
        private void ActualizarListaPila()
        {
            lbPrioritario.Items.Clear();
            foreach (var item in EnvioPrioritario)
            {
                lbPrioritario.Items.Add(item);
            }
        }
        // Método para actualizar la cola de envíos regulares
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
            // --- DESPACHO DE LA PILA ---
            // Si hay pedidos prioritarios, se procesan primero.
            // El método Pop() elimina y devuelve el elemento que está en el tope de la pil

            if (EnvioPrioritario.Count > 0)
            {
                pedidoDespachado = EnvioPrioritario.Pop(); // Saca el último pedido agregado
                lbPrioritario.Items.Remove(pedidoDespachado);
                MessageBox.Show($"¡Despachando Prioritario! (PILA): {pedidoDespachado}", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Si no hay pedidos prioritarios, se procesan los regulares (COLA)
            else if (EnvioRegular.Count > 0)
            {
                pedidoDespachado = EnvioRegular.Dequeue();
                lbRegular.Items.Remove(pedidoDespachado);
                MessageBox.Show($"Despachando Regular (COLA): {pedidoDespachado}", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Si no hay pedidos pendientes
            else
            {
                MessageBox.Show("No hay pedidos pendientes para despachar.", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
