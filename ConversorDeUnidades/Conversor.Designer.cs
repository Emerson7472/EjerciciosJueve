namespace ConversorDeUnidades;

partial class Conversor
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        txtValor = new System.Windows.Forms.TextBox();
        cmbOpciones = new System.Windows.Forms.ComboBox();
        lblResultado = new System.Windows.Forms.Label();
        btnConvertir = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        btnSalir = new System.Windows.Forms.Button();
        label3 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // txtValor
        // 
        txtValor.Location = new System.Drawing.Point(235, 191);
        txtValor.Name = "txtValor";
        txtValor.Size = new System.Drawing.Size(213, 27);
        txtValor.TabIndex = 0;
        // 
        // cmbOpciones
        // 
        cmbOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbOpciones.FormattingEnabled = true;
        cmbOpciones.Items.AddRange(new object[] { "Kilometros a Millas", "Millas a Kilometros", "Celsius a Fahrenheit", "Fahrenheit a Celsius" });
        cmbOpciones.Location = new System.Drawing.Point(210, 128);
        cmbOpciones.Name = "cmbOpciones";
        cmbOpciones.Size = new System.Drawing.Size(179, 28);
        cmbOpciones.TabIndex = 1;
        cmbOpciones.Click += Form1_Load;
        // 
        // lblResultado
        // 
        lblResultado.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblResultado.Location = new System.Drawing.Point(12, 249);
        lblResultado.Name = "lblResultado";
        lblResultado.Size = new System.Drawing.Size(776, 39);
        lblResultado.TabIndex = 2;
        lblResultado.Text = "Resultado:";
        // 
        // btnConvertir
        // 
        btnConvertir.BackColor = System.Drawing.Color.Lime;
        btnConvertir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnConvertir.Location = new System.Drawing.Point(27, 394);
        btnConvertir.Name = "btnConvertir";
        btnConvertir.Size = new System.Drawing.Size(94, 44);
        btnConvertir.TabIndex = 3;
        btnConvertir.Text = "Convertir";
        btnConvertir.UseVisualStyleBackColor = false;
        btnConvertir.Click += btnConvertir_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(235, 23);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(291, 44);
        label1.TabIndex = 4;
        label1.Text = "Conversión de Unidades";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(12, 185);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(217, 36);
        label2.TabIndex = 5;
        label2.Text = "Ingrese un Valor:";
        // 
        // btnSalir
        // 
        btnSalir.BackColor = System.Drawing.Color.Red;
        btnSalir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnSalir.Location = new System.Drawing.Point(672, 394);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new System.Drawing.Size(101, 44);
        btnSalir.TabIndex = 6;
        btnSalir.Text = "Salir";
        btnSalir.UseVisualStyleBackColor = false;
        btnSalir.Click += btnSalir_Click;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(12, 122);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(192, 36);
        label3.TabIndex = 7;
        label3.Text = "Elija una opcion:";
        // 
        // Conversor
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.ActiveCaption;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label3);
        Controls.Add(btnSalir);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(btnConvertir);
        Controls.Add(lblResultado);
        Controls.Add(cmbOpciones);
        Controls.Add(txtValor);
        ForeColor = System.Drawing.Color.Black;
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        MaximizeBox = false;
        Text = "Conversión";
        Click += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Button btnSalir;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button btnConvertir;

    private System.Windows.Forms.TextBox txtValor;
    private System.Windows.Forms.ComboBox cmbOpciones;
    private System.Windows.Forms.Label lblResultado;

    #endregion
}