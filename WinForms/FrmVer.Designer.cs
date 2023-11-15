namespace WinForms
{
    partial class FrmVer
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
            TxtDispositivos = new RichTextBox();
            SuspendLayout();
            // 
            // BtnVolver
            // 
            BtnVolver.Location = new Point(26, 392);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(396, 37);
            BtnVolver.TabIndex = 1;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = true;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // TxtDispositivos
            // 
            TxtDispositivos.Location = new Point(26, 27);
            TxtDispositivos.Name = "TxtDispositivos";
            TxtDispositivos.Size = new Size(396, 347);
            TxtDispositivos.TabIndex = 2;
            TxtDispositivos.Text = "";
            TxtDispositivos.TextChanged += TxtDispositivos_TextChanged;
            // 
            // FrmVer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 454);
            Controls.Add(TxtDispositivos);
            Controls.Add(BtnVolver);
            Name = "FrmVer";
            Text = "FrmVer";
            Load += FrmVer_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button BtnVolver;
        private RichTextBox TxtDispositivos;
    }
}