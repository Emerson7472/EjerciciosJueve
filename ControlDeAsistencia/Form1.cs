using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ControlAsistencias
{
    public partial class Form1 : Form
    {
        private DataTable attendanceTable;
        private string dataFilePath;

        public Form1()
        {
            InitializeComponent();
            dataFilePath = Path.Combine(Application.StartupPath, "asistencias.xml");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var estudiantes = new[] {
                "Jhon Jairo Reyes",
                "María García",
                "Carlos Pérez",
                "Ana López",
                "Enmanuel Rodroguez"
            };

            cbStudents.Items.Clear();
            cbStudents.Items.AddRange(estudiantes);
            if (cbStudents.Items.Count > 0) cbStudents.SelectedIndex = 0;

         
            attendanceTable = new DataTable("Asistencias");
            attendanceTable.Columns.Add("Id", typeof(int));
            attendanceTable.Columns.Add("Alumno", typeof(string));
            attendanceTable.Columns.Add("FechaHora", typeof(DateTime));
            attendanceTable.Columns.Add("Tipo", typeof(string));
            attendanceTable.PrimaryKey = new DataColumn[] { attendanceTable.Columns["Id"] };
            attendanceTable.Columns["Id"].AutoIncrement = true;
            attendanceTable.Columns["Id"].AutoIncrementSeed = 1;

            dgvRecords.DataSource = attendanceTable;

          
            if (File.Exists(dataFilePath))
            {
                try
                {
                    attendanceTable.ReadXml(dataFilePath);
                }
                catch
                {
   
                }
            }
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            AddRecord("Entrada");
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            AddRecord("Salida");
        }

        private void AddRecord(string tipo)
        {
            if (cbStudents.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un estudiante.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = attendanceTable.NewRow();
            row["Alumno"] = cbStudents.SelectedItem.ToString();
            row["FechaHora"] = DateTime.Now;
            row["Tipo"] = tipo;
            attendanceTable.Rows.Add(row);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                attendanceTable.WriteXml(dataFilePath, XmlWriteMode.WriteSchema);
                MessageBox.Show("Registros guardados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(dataFilePath))
            {
                MessageBox.Show("No hay un archivo de asistencias guardado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                attendanceTable.Clear();
                attendanceTable.ReadXml(dataFilePath);
                MessageBox.Show("Registros cargados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}