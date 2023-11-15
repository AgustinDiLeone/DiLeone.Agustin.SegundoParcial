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
            grpOrden.SuspendLayout();
            SuspendLayout();
            // 
            // FrmCrudCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "FrmCrudCliente";
            Text = "FrmCrudCliente";
            FormClosed += FrmCrudCliente_FormClosed;
            Load += FrmCrudCliente_Load;
            grpOrden.ResumeLayout(false);
            grpOrden.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}