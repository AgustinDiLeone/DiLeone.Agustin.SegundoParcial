namespace WinForms
{
    partial class FrmCrudCliente
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
            grpOrdenCarac.SuspendLayout();
            grpOrden.SuspendLayout();
            SuspendLayout();
            // 
            // LblUsuarioConectado
            // 
            LblUsuarioConectado.Size = new Size(0, 15);
            LblUsuarioConectado.Text = "";
            // 
            // FrmCrudCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "FrmCrudCliente";
            Text = "FrmCrudCliente";
            FormClosing += FrmCrudCliente_FormClosing;
            FormClosed += FrmCrudCliente_FormClosed;
            Load += FrmCrudCliente_Load;
            grpOrdenCarac.ResumeLayout(false);
            grpOrdenCarac.PerformLayout();
            grpOrden.ResumeLayout(false);
            grpOrden.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}