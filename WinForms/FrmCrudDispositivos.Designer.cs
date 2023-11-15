namespace WinForms
{
    partial class FrmCrudDispositivos
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
            BtnVolver = new Button();
            lblCliente = new Label();
            SuspendLayout();
            // 
            // lstBox
            // 
            lstBox.Location = new Point(42, 106);
            lstBox.Size = new Size(395, 304);
            // 
            // BtnVolver
            // 
            BtnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnVolver.Location = new Point(42, 433);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(713, 37);
            BtnVolver.TabIndex = 2;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = true;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCliente.Location = new Point(42, 25);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(50, 19);
            lblCliente.TabIndex = 10;
            lblCliente.Text = "label1";
            // 
            // FrmCrudDispositivos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 492);
            Controls.Add(lblCliente);
            Controls.Add(BtnVolver);
            Name = "FrmCrudDispositivos";
            Text = "FrmDispositivos";
            Load += FrmVer_Load;
            Controls.SetChildIndex(BtnVolver, 0);
            Controls.SetChildIndex(lstBox, 0);
            Controls.SetChildIndex(grpOrdenCarac, 0);
            Controls.SetChildIndex(grpOrden, 0);
            Controls.SetChildIndex(BtnOrdenar, 0);
            Controls.SetChildIndex(BtnVer, 0);
            Controls.SetChildIndex(BtnModificar, 0);
            Controls.SetChildIndex(BtnEliminar, 0);
            Controls.SetChildIndex(BtnAgregar, 0);
            Controls.SetChildIndex(LblUsuarioConectado, 0);
            Controls.SetChildIndex(lblCliente, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnVolver;
        private Label lblCliente;
    }
}