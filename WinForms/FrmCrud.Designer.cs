namespace WinForms
{
    partial class FrmCrud
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
            lstBox = new ListBox();
            grpOrdenCarac = new GroupBox();
            BtnCaracteristicaDos = new RadioButton();
            BtnCaracteristicaUno = new RadioButton();
            grpOrden = new GroupBox();
            BtnDescendente = new RadioButton();
            BtnAscendente = new RadioButton();
            BtnOrdenar = new Button();
            BtnVer = new Button();
            BtnModificar = new Button();
            BtnEliminar = new Button();
            BtnAgregar = new Button();
            LblUsuarioConectado = new Label();
            BtnUsuarios = new Button();
            grpOrdenCarac.SuspendLayout();
            grpOrden.SuspendLayout();
            SuspendLayout();
            // 
            // lstBox
            // 
            lstBox.FormattingEnabled = true;
            lstBox.ItemHeight = 15;
            lstBox.Location = new Point(29, 31);
            lstBox.Name = "lstBox";
            lstBox.ScrollAlwaysVisible = true;
            lstBox.Size = new Size(395, 379);
            lstBox.TabIndex = 0;
            lstBox.SelectedIndexChanged += lstBox_SelectedIndexChanged;
            // 
            // grpOrdenCarac
            // 
            grpOrdenCarac.Controls.Add(BtnCaracteristicaDos);
            grpOrdenCarac.Controls.Add(BtnCaracteristicaUno);
            grpOrdenCarac.Location = new Point(483, 63);
            grpOrdenCarac.Name = "grpOrdenCarac";
            grpOrdenCarac.Size = new Size(120, 102);
            grpOrdenCarac.TabIndex = 1;
            grpOrdenCarac.TabStop = false;
            grpOrdenCarac.Text = "Caracteristica";
            // 
            // BtnCaracteristicaDos
            // 
            BtnCaracteristicaDos.AutoSize = true;
            BtnCaracteristicaDos.Location = new Point(18, 57);
            BtnCaracteristicaDos.Name = "BtnCaracteristicaDos";
            BtnCaracteristicaDos.Size = new Size(93, 19);
            BtnCaracteristicaDos.TabIndex = 5;
            BtnCaracteristicaDos.TabStop = true;
            BtnCaracteristicaDos.Text = "Descendente";
            BtnCaracteristicaDos.UseVisualStyleBackColor = true;
            // 
            // BtnCaracteristicaUno
            // 
            BtnCaracteristicaUno.AccessibleName = "BtnCaracteristicaUno";
            BtnCaracteristicaUno.AutoSize = true;
            BtnCaracteristicaUno.Location = new Point(18, 22);
            BtnCaracteristicaUno.Name = "BtnCaracteristicaUno";
            BtnCaracteristicaUno.Size = new Size(87, 19);
            BtnCaracteristicaUno.TabIndex = 4;
            BtnCaracteristicaUno.TabStop = true;
            BtnCaracteristicaUno.Text = "Ascendente";
            BtnCaracteristicaUno.UseVisualStyleBackColor = true;
            BtnCaracteristicaUno.CheckedChanged += BtnCaracteristicaUno_CheckedChanged;
            // 
            // grpOrden
            // 
            grpOrden.Controls.Add(BtnDescendente);
            grpOrden.Controls.Add(BtnAscendente);
            grpOrden.Location = new Point(635, 63);
            grpOrden.Name = "grpOrden";
            grpOrden.Size = new Size(120, 102);
            grpOrden.TabIndex = 2;
            grpOrden.TabStop = false;
            grpOrden.Text = "Orden";
            // 
            // BtnDescendente
            // 
            BtnDescendente.AutoSize = true;
            BtnDescendente.Location = new Point(12, 57);
            BtnDescendente.Name = "BtnDescendente";
            BtnDescendente.Size = new Size(93, 19);
            BtnDescendente.TabIndex = 3;
            BtnDescendente.TabStop = true;
            BtnDescendente.Text = "Descendente";
            BtnDescendente.UseVisualStyleBackColor = true;
            // 
            // BtnAscendente
            // 
            BtnAscendente.AutoSize = true;
            BtnAscendente.Location = new Point(12, 22);
            BtnAscendente.Name = "BtnAscendente";
            BtnAscendente.Size = new Size(87, 19);
            BtnAscendente.TabIndex = 2;
            BtnAscendente.TabStop = true;
            BtnAscendente.Text = "Ascendente";
            BtnAscendente.UseVisualStyleBackColor = true;
            // 
            // BtnOrdenar
            // 
            BtnOrdenar.Location = new Point(483, 178);
            BtnOrdenar.Name = "BtnOrdenar";
            BtnOrdenar.Size = new Size(272, 29);
            BtnOrdenar.TabIndex = 3;
            BtnOrdenar.Text = "Ordenar";
            BtnOrdenar.UseVisualStyleBackColor = true;
            BtnOrdenar.Click += BtnOrdenar_Click;
            // 
            // BtnVer
            // 
            BtnVer.Location = new Point(483, 229);
            BtnVer.Name = "BtnVer";
            BtnVer.Size = new Size(272, 29);
            BtnVer.TabIndex = 4;
            BtnVer.Text = "Ver";
            BtnVer.UseVisualStyleBackColor = true;
            BtnVer.Click += BtnVer_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(483, 331);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(272, 29);
            BtnModificar.TabIndex = 5;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(483, 381);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(272, 29);
            BtnEliminar.TabIndex = 7;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(483, 281);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(272, 29);
            BtnAgregar.TabIndex = 8;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // LblUsuarioConectado
            // 
            LblUsuarioConectado.AutoSize = true;
            LblUsuarioConectado.Location = new Point(483, 31);
            LblUsuarioConectado.Name = "LblUsuarioConectado";
            LblUsuarioConectado.Size = new Size(105, 15);
            LblUsuarioConectado.TabIndex = 9;
            LblUsuarioConectado.Text = "UsuarioConectado";
            LblUsuarioConectado.Click += LblUsuarioConectado_Click;
            // 
            // BtnUsuarios
            // 
            BtnUsuarios.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnUsuarios.ImageAlign = ContentAlignment.TopCenter;
            BtnUsuarios.Location = new Point(659, 29);
            BtnUsuarios.Margin = new Padding(1);
            BtnUsuarios.Name = "BtnUsuarios";
            BtnUsuarios.Size = new Size(96, 19);
            BtnUsuarios.TabIndex = 10;
            BtnUsuarios.Text = "Usuarios";
            BtnUsuarios.UseVisualStyleBackColor = true;
            BtnUsuarios.Click += BtnUsuarios_Click;
            // 
            // FrmCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnUsuarios);
            Controls.Add(LblUsuarioConectado);
            Controls.Add(BtnAgregar);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnModificar);
            Controls.Add(BtnVer);
            Controls.Add(BtnOrdenar);
            Controls.Add(grpOrden);
            Controls.Add(grpOrdenCarac);
            Controls.Add(lstBox);
            Name = "FrmCrud";
            Text = "FrmCrud";
            Load += FrmCrud_Load;
            grpOrdenCarac.ResumeLayout(false);
            grpOrdenCarac.PerformLayout();
            grpOrden.ResumeLayout(false);
            grpOrden.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ListBox lstBox;
        public GroupBox grpOrdenCarac;
        public GroupBox grpOrden;
        public Button BtnOrdenar;
        public Button BtnVer;
        public Button BtnModificar;
        public Button BtnEliminar;
        public Button BtnAgregar;
        public Label LblUsuarioConectado;
        public RadioButton BtnDescendente;
        public RadioButton BtnAscendente;
        public RadioButton BtnCaracteristicaDos;
        public RadioButton BtnCaracteristicaUno;
        private Button BtnUsuarios;
    }
}