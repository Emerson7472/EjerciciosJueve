using System;
using System.Windows.Forms;
 
 namespace ConversorDeUnidades
 {
     public partial class Conversor : Form
     {
         public Conversor()
         {
             InitializeComponent();
         }
 
         private void Form1_Load(object sender, EventArgs e)
         {
             if (cmbOpciones.Items.Count == 0)
             {
                 cmbOpciones.Items.Add("Kilometros a Millas");
                 cmbOpciones.Items.Add("Millas a Kilometros");
                 cmbOpciones.Items.Add("Celsius a Fahrenheit");
                 cmbOpciones.Items.Add("Fahrenheit a Celsius");
                 
                 cmbOpciones.SelectedIndex = 0; 
             }
         }
 
         private void btnConvertir_Click(object sender, EventArgs e)
         {
             if (!double.TryParse(txtValor.Text, out double valorIngresado))
             {
                 lblResultado.Text = "Error: Ingrese un valor numérico válido.";
                 return;
             }
 
             if (cmbOpciones.SelectedItem == null)
             {
                 lblResultado.Text = "Error: Seleccione un tipo de conversión.";
                 return;
             }
 
             string opcion = cmbOpciones.SelectedItem.ToString();
             double resultado = 0;
 
             switch (opcion)
             {
                 case "Kilometros a Millas":
                     resultado = valorIngresado * 0.621371;
                     lblResultado.Text = $"Resultado: {valorIngresado} km = {resultado:F2} millas";
                     break;
 
                 case "Millas a Kilometros":
                     resultado = valorIngresado / 0.621371;
                     lblResultado.Text = $"Resultado: {valorIngresado} millas = {resultado:F2} km";
                     break;
 
                 case "Celsius a Fahrenheit":
                     resultado = (valorIngresado * 9 / 5) + 32;
                     lblResultado.Text = $"Resultado: {valorIngresado} °C = {resultado:F2} °F";
                     break;
 
                 case "Fahrenheit a Celsius":
                     resultado = (valorIngresado - 32) * 5 / 9;
                     lblResultado.Text = $"Resultado: {valorIngresado} °F = {resultado:F2} °C";
                     break;
 
                 default:
                     lblResultado.Text = "Opción no válida.";
                     break;
             }
         }

         private void btnSalir_Click(object sender, EventArgs e)
         {
             Application.Exit();
         }
     }
 }