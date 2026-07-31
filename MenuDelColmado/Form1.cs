using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colmado
{
    public partial class Form1 : Form
    {
        private Dictionary<string, double> menuColmado = new Dictionary<string, double>()
        {
            { "Refresco de Botella (2 Litros)", 100.00 },
            { "Refresco Pequeño (Fresa/Uva/Limonada)", 35.00 },
            { "Empanada de Queso / Pollo", 60.00 },
            { "Fritura / Pica Pollo (Servicio)", 220.00 },
            { "Papitas / Frituras de Falsa", 25.00 },
            { "Cerveza Vestida de Novia (Grande)", 180.00 }
        };

        public Form1()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void CargarProductos()
        {
            cmbProductos.Items.Clear();
            foreach (var producto in menuColmado.Keys)
            {
                cmbProductos.Items.Add(producto);
            }
            cmbProductos.SelectedIndex = 0; // Selecciona el primero por defecto
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // 1. Validar la cantidad
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Pon una cantidad válida, mi hermano.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string productoSeleccionado = cmbProductos.SelectedItem.ToString();
            double precioUnidad = menuColmado[productoSeleccionado];

            // 3. Subtotal
            double subtotal = precioUnidad * cantidad;
            double totalFinal = subtotal;

            if (rbTarjeta.Checked)
            {
                totalFinal = subtotal * 1.05;
            }

            lblTotal.Text = $"Producto: {productoSeleccionado}\n" +
                            $"Cantidad: {cantidad}\n" +
                            $"Precio c/u: RD$ {precioUnidad:N2}\n" +
                            $"----------------------------------\n" +
                            $"TOTAL A PAGAR: RD$ {totalFinal:N2}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lvlCantidad_Click(object sender, EventArgs e)
        {

        }
    }
}
