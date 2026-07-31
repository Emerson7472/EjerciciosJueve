namespace RegistroDeClientes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
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
            txtNombre = new System.Windows.Forms.TextBox();
            txtTelefono = new System.Windows.Forms.TextBox();
            txtCorreo = new System.Windows.Forms.TextBox();
            btnAgregar = new System.Windows.Forms.Button();
            lstClientes = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(120, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(200, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(120, 70);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(200, 27);
            txtTelefono.TabIndex = 1;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new System.Drawing.Point(120, 110);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new System.Drawing.Size(200, 27);
            txtCorreo.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnAgregar.Location = new System.Drawing.Point(120, 150);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(200, 30);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Registrar Cliente";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.Location = new System.Drawing.Point(30, 200);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new System.Drawing.Size(400, 144);
            lstClientes.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.Location = new System.Drawing.Point(30, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 23);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label2.Location = new System.Drawing.Point(30, 73);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 23);
            label2.TabIndex = 1;
            label2.Text = "Teléfono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label3.Location = new System.Drawing.Point(30, 113);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 23);
            label3.TabIndex = 0;
            label3.Text = "Correo:";
            // 
            // Form1
            // 
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(460, 380);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstClientes);
            Controls.Add(btnAgregar);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Registro de Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}