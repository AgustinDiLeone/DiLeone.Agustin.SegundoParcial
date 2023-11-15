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
            BtnBackUp = new Button();
            grpOrdenCarac.SuspendLayout();
            grpOrden.SuspendLayout();
            SuspendLayout();
            // 
            // BtnVer
            // 
            BtnVer.Size = new Size(133, 29);
            // 
            // LblUsuarioConectado
            // 
            LblUsuarioConectado.Size = new Size(0, 15);
            LblUsuarioConectado.Text = "";
            // 
            // BtnBackUp
            // 
            BtnBackUp.Location = new Point(635, 229);
            BtnBackUp.Name = "BtnBackUp";
            BtnBackUp.Size = new Size(120, 29);
            BtnBackUp.TabIndex = 11;
            BtnBackUp.Text = "BackUp SQL";
            BtnBackUp.UseVisualStyleBackColor = true;
            BtnBackUp.Click += BtnBackUp_Click;
            // 
            // FrmCrudCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnBackUp);
            Name = "FrmCrudCliente";
            Text = "FrmCrudCliente";
            FormClosing += FrmCrudCliente_FormClosing;
            FormClosed += FrmCrudCliente_FormClosed;
            Load += FrmCrudCliente_Load;
            Controls.SetChildIndex(lstBox, 0);
            Controls.SetChildIndex(grpOrdenCarac, 0);
            Controls.SetChildIndex(grpOrden, 0);
            Controls.SetChildIndex(BtnOrdenar, 0);
            Controls.SetChildIndex(BtnVer, 0);
            Controls.SetChildIndex(BtnModificar, 0);
            Controls.SetChildIndex(BtnEliminar, 0);
            Controls.SetChildIndex(BtnAgregar, 0);
            Controls.SetChildIndex(LblUsuarioConectado, 0);
            Controls.SetChildIndex(BtnBackUp, 0);
            grpOrdenCarac.ResumeLayout(false);
            grpOrdenCarac.PerformLayout();
            grpOrden.ResumeLayout(false);
            grpOrden.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBackUp;
    }
}