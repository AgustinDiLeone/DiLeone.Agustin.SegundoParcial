namespace WinForms
{
    partial class FrmManejoCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnAceptar = new Button();
            BtnCancelar = new Button();
            TxtNombre = new TextBox();
            TxtCuit = new TextBox();
            TxtUbicacion = new TextBox();
            CmbTipo = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 34);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre / Empresa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 94);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Cuit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 164);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Ubicacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 227);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 3;
            label4.Text = "Tipo de cliente";
            // 
            // BtnAceptar
            // 
            BtnAceptar.Location = new Point(22, 296);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(142, 34);
            BtnAceptar.TabIndex = 4;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(195, 296);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(141, 34);
            BtnCancelar.TabIndex = 5;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(55, 52);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(254, 23);
            TxtNombre.TabIndex = 6;
            // 
            // TxtCuit
            // 
            TxtCuit.Location = new Point(55, 112);
            TxtCuit.Name = "TxtCuit";
            TxtCuit.Size = new Size(254, 23);
            TxtCuit.TabIndex = 7;
            // 
            // TxtUbicacion
            // 
            TxtUbicacion.Location = new Point(55, 182);
            TxtUbicacion.Name = "TxtUbicacion";
            TxtUbicacion.Size = new Size(254, 23);
            TxtUbicacion.TabIndex = 8;
            // 
            // CmbTipo
            // 
            CmbTipo.FormattingEnabled = true;
            CmbTipo.Location = new Point(55, 245);
            CmbTipo.Name = "CmbTipo";
            CmbTipo.Size = new Size(254, 23);
            CmbTipo.TabIndex = 9;
            // 
            // FrmAgregarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 359);
            Controls.Add(CmbTipo);
            Controls.Add(TxtUbicacion);
            Controls.Add(TxtCuit);
            Controls.Add(TxtNombre);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAceptar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAgregarCliente";
            Text = "FrmAgregar";
            Load += FrmAgregarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnAceptar;
        private Button BtnCancelar;
        private TextBox TxtNombre;
        private TextBox TxtCuit;
        private TextBox TxtUbicacion;
        private ComboBox CmbTipo;
    }
}