namespace ControlAsistencias
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new System.Windows.Forms.Label();
            cbStudents = new System.Windows.Forms.ComboBox();
            lblStudents = new System.Windows.Forms.Label();
            lblRecords = new System.Windows.Forms.Label();
            btnEntrada = new System.Windows.Forms.Button();
            btnSalida = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            btnCargar = new System.Windows.Forms.Button();
            dgvRecords = new System.Windows.Forms.DataGridView();
            btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblTitle.Location = new System.Drawing.Point(16, 14);
            lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(188, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Control de asistencia";
            // 
            // cbStudents
            // 
            cbStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbStudents.FormattingEnabled = true;
            cbStudents.Location = new System.Drawing.Point(20, 89);
            cbStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbStudents.Name = "cbStudents";
            cbStudents.Size = new System.Drawing.Size(319, 28);
            cbStudents.TabIndex = 1;
            // 
            // lblStudents
            // 
            lblStudents.AutoSize = true;
            lblStudents.Location = new System.Drawing.Point(16, 65);
            lblStudents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new System.Drawing.Size(84, 20);
            lblStudents.TabIndex = 2;
            lblStudents.Text = "Estudiantes";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Location = new System.Drawing.Point(16, 146);
            lblRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new System.Drawing.Size(70, 20);
            lblRecords.TabIndex = 3;
            lblRecords.Text = "Registros";
            // 
            // btnEntrada
            // 
            btnEntrada.Location = new System.Drawing.Point(365, 26);
            btnEntrada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new System.Drawing.Size(127, 38);
            btnEntrada.TabIndex = 5;
            btnEntrada.Text = "Marcar Entrada";
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnSalida
            // 
            btnSalida.Location = new System.Drawing.Point(365, 89);
            btnSalida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new System.Drawing.Size(127, 38);
            btnSalida.TabIndex = 6;
            btnSalida.Text = "Marcar Salida";
            btnSalida.UseVisualStyleBackColor = true;
            btnSalida.Click += btnSalida_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(500, 89);
            btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(127, 38);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new System.Drawing.Point(500, 26);
            btnCargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new System.Drawing.Size(127, 38);
            btnCargar.TabIndex = 8;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // dgvRecords
            // 
            dgvRecords.AllowUserToAddRows = false;
            dgvRecords.AllowUserToDeleteRows = false;
            dgvRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Location = new System.Drawing.Point(20, 185);
            dgvRecords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dgvRecords.Name = "dgvRecords";
            dgvRecords.ReadOnly = true;
            dgvRecords.RowHeadersWidth = 51;
            dgvRecords.Size = new System.Drawing.Size(517, 462);
            dgvRecords.TabIndex = 9;
            // 
            // btnSalir
            // 
            btnSalir.Location = new System.Drawing.Point(557, 629);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(70, 51);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(653, 692);
            Controls.Add(btnSalir);
            Controls.Add(dgvRecords);
            Controls.Add(btnCargar);
            Controls.Add(btnGuardar);
            Controls.Add(btnSalida);
            Controls.Add(btnEntrada);
            Controls.Add(lblRecords);
            Controls.Add(lblStudents);
            Controls.Add(cbStudents);
            Controls.Add(lblTitle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Text = "Control de Asistencias";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnSalir;

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbStudents;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dgvRecords;
    }
}

