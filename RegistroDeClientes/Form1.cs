using System;
using System.Windows.Forms;

namespace RegistroDeClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || 
                string.IsNullOrWhiteSpace(telefono) || 
                string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Campos incompletos", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!correo.Contains("@") || !correo.Contains("."))
            {
                MessageBox.Show("Ingresa un correo electrónico válido (debe contener '@' y un dominio).", 
                    "Correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreo.Focus();
                return;
            }

            string clienteInfo = $"{nombre}  |  Tel: {telefono}  |  Email: {correo}";
            lstClientes.Items.Add(clienteInfo);

            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            txtNombre.Focus();
        }
    }
}