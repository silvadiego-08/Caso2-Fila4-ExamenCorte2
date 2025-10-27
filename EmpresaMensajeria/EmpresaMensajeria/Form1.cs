using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaMensajeria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Pila (Stack) para los pedidos urgentes → LIFO (último en entrar, primero en salir)

        Stack<string> Urgentes = new Stack<string>();
        // Cola (Queue) para los pedidos regulares → FIFO (primero en entrar, primero en salir)

        Queue<string> Regulares = new Queue<string>();

        private void btnAgregar_Click(object sender, EventArgs e)

        {
            // Obtiene el texto ingresado en el cuadro de texto

            string producto = tbProducto.Text.ToLower();
            // Verifica que el usuario haya ingresado un producto

            if (string.IsNullOrEmpty(producto))
            {
                MessageBox.Show("Ingrese un producto antes de agregar.");
                return;
            }
            // Si la casilla de urgente está marcada, agrega el producto a la pila de urgentes

            if (chUrgente.Checked)
            {
                Urgentes.Push(producto);
                MostrarUrgentes();
            }
            // Si no está marcada, se agrega a la cola de regulares

            else
            {
                Regulares.Enqueue(producto);
                
                mostrarRegulares();
            }

            tbProducto.Clear();
            tbProducto.Focus();
        }

        private void chUrgente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chUrgente_Click(object sender, EventArgs e)
        {

        }

        private void mostrarRegulares()
        {
            // Si hay elementos en la cola, los muestra uno debajo del otro

            if (Regulares.Count > 0)
                lbRegulares.Text = string.Join(Environment.NewLine, Regulares);
            else
                lbRegulares.Text = "(sin pedidos regulares)";
        }

        private void MostrarUrgentes()
        {
            // Si hay elementos en la pila, los muestra uno debajo del otro

            if (Urgentes.Count > 0)
                lbUrgentes.Text = string.Join(Environment.NewLine, Urgentes);
            else
                lbUrgentes.Text = "(sin pedidos urgentes)";
        }

        private void btnDespachar_Click(object sender, EventArgs e)
        {
            // Si hay urgentes, se atiende primero la pila
            if (Urgentes.Count > 0)
            {
                string atendido = Urgentes.Pop();
                MessageBox.Show($"Se despachó urgente: {atendido}");
                MostrarUrgentes(); // actualiza el label
            }
            // Si no hay urgentes, atiende un regular
            else if (Regulares.Count > 0)
            {
                string atendido = Regulares.Dequeue();
                MessageBox.Show($"Se despachó regular: {atendido}");
                mostrarRegulares(); // actualiza el label
            }
            else
            {
                MessageBox.Show("No hay productos por despachar.");
            }

        }
        
    }
}
