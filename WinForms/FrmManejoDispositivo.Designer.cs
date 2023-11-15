namespace WinForms
{
    partial class FrmManejoDispositivo
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
            LblTitulo = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            CmbTipo = new ComboBox();
            TxtId = new TextBox();
            TxtCantidad = new TextBox();
            TxtMarca = new TextBox();
            TxtModelo = new TextBox();
            TxtPrecio = new TextBox();
            TabDispositivos = new TabControl();
            PageCelular = new TabPage();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label1 = new Label();
            TxtCantCamarasCelular = new TextBox();
            TxtRamCelular = new TextBox();
            TxtAlmacenamientoCelular = new TextBox();
            TxtPulgadasCelular = new TextBox();
            PageNotebook = new TabPage();
            label12 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label11 = new Label();
            checkSSD = new CheckBox();
            TxtSONote = new TextBox();
            TxtRamNote = new TextBox();
            TxtAlmacenamientoNote = new TextBox();
            TxtResolucionNote = new TextBox();
            TxtPulgadasNote = new TextBox();
            PageTelevisor = new TabPage();
            label17 = new Label();
            label16 = new Label();
            checkSmartTv = new CheckBox();
            TxtResolucionTele = new TextBox();
            TxtPulgadasTele = new TextBox();
            BtnAceptar = new Button();
            BtnCancelar = new Button();
            TabDispositivos.SuspendLayout();
            PageCelular.SuspendLayout();
            PageNotebook.SuspendLayout();
            PageTelevisor.SuspendLayout();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblTitulo.Location = new Point(12, 9);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(57, 21);
            LblTitulo.TabIndex = 1;
            LblTitulo.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 51);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 3;
            label2.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 116);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 361);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 5;
            label4.Text = "Tipo de factura:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 253);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 6;
            label5.Text = "Marca:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 308);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 7;
            label6.Text = "Modelo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 186);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 8;
            label7.Text = "Precio:";
            // 
            // CmbTipo
            // 
            CmbTipo.FormattingEnabled = true;
            CmbTipo.Location = new Point(38, 383);
            CmbTipo.Name = "CmbTipo";
            CmbTipo.Size = new Size(153, 23);
            CmbTipo.TabIndex = 11;
            // 
            // TxtId
            // 
            TxtId.Location = new Point(38, 76);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(153, 23);
            TxtId.TabIndex = 13;
            // 
            // TxtCantidad
            // 
            TxtCantidad.Location = new Point(38, 142);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(153, 23);
            TxtCantidad.TabIndex = 14;
            // 
            // TxtMarca
            // 
            TxtMarca.Location = new Point(38, 271);
            TxtMarca.Name = "TxtMarca";
            TxtMarca.Size = new Size(153, 23);
            TxtMarca.TabIndex = 15;
            // 
            // TxtModelo
            // 
            TxtModelo.Location = new Point(38, 326);
            TxtModelo.Name = "TxtModelo";
            TxtModelo.Size = new Size(153, 23);
            TxtModelo.TabIndex = 16;
            // 
            // TxtPrecio
            // 
            TxtPrecio.Location = new Point(38, 204);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(153, 23);
            TxtPrecio.TabIndex = 17;
            // 
            // TabDispositivos
            // 
            TabDispositivos.Controls.Add(PageCelular);
            TabDispositivos.Controls.Add(PageNotebook);
            TabDispositivos.Controls.Add(PageTelevisor);
            TabDispositivos.Location = new Point(231, 27);
            TabDispositivos.Name = "TabDispositivos";
            TabDispositivos.SelectedIndex = 0;
            TabDispositivos.Size = new Size(570, 322);
            TabDispositivos.TabIndex = 20;
            // 
            // PageCelular
            // 
            PageCelular.Controls.Add(label10);
            PageCelular.Controls.Add(label9);
            PageCelular.Controls.Add(label8);
            PageCelular.Controls.Add(label1);
            PageCelular.Controls.Add(TxtCantCamarasCelular);
            PageCelular.Controls.Add(TxtRamCelular);
            PageCelular.Controls.Add(TxtAlmacenamientoCelular);
            PageCelular.Controls.Add(TxtPulgadasCelular);
            PageCelular.Location = new Point(4, 24);
            PageCelular.Name = "PageCelular";
            PageCelular.Padding = new Padding(3);
            PageCelular.Size = new Size(562, 294);
            PageCelular.TabIndex = 0;
            PageCelular.Tag = "";
            PageCelular.Text = "Celular";
            PageCelular.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(281, 117);
            label10.Name = "label10";
            label10.Size = new Size(121, 15);
            label10.TabIndex = 28;
            label10.Text = "Cantidad de camaras:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(281, 33);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 27;
            label9.Text = "RAM:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 117);
            label8.Name = "label8";
            label8.Size = new Size(101, 15);
            label8.TabIndex = 26;
            label8.Text = "Almacenamiento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 33);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 25;
            label1.Text = "Pulgadas:";
            // 
            // TxtCantCamarasCelular
            // 
            TxtCantCamarasCelular.Location = new Point(328, 135);
            TxtCantCamarasCelular.Name = "TxtCantCamarasCelular";
            TxtCantCamarasCelular.Size = new Size(153, 23);
            TxtCantCamarasCelular.TabIndex = 24;
            // 
            // TxtRamCelular
            // 
            TxtRamCelular.Location = new Point(328, 57);
            TxtRamCelular.Name = "TxtRamCelular";
            TxtRamCelular.Size = new Size(153, 23);
            TxtRamCelular.TabIndex = 23;
            // 
            // TxtAlmacenamientoCelular
            // 
            TxtAlmacenamientoCelular.Location = new Point(65, 135);
            TxtAlmacenamientoCelular.Name = "TxtAlmacenamientoCelular";
            TxtAlmacenamientoCelular.Size = new Size(153, 23);
            TxtAlmacenamientoCelular.TabIndex = 22;
            // 
            // TxtPulgadasCelular
            // 
            TxtPulgadasCelular.Location = new Point(65, 57);
            TxtPulgadasCelular.Name = "TxtPulgadasCelular";
            TxtPulgadasCelular.Size = new Size(153, 23);
            TxtPulgadasCelular.TabIndex = 21;
            // 
            // PageNotebook
            // 
            PageNotebook.Controls.Add(label12);
            PageNotebook.Controls.Add(label15);
            PageNotebook.Controls.Add(label14);
            PageNotebook.Controls.Add(label13);
            PageNotebook.Controls.Add(label11);
            PageNotebook.Controls.Add(checkSSD);
            PageNotebook.Controls.Add(TxtSONote);
            PageNotebook.Controls.Add(TxtRamNote);
            PageNotebook.Controls.Add(TxtAlmacenamientoNote);
            PageNotebook.Controls.Add(TxtResolucionNote);
            PageNotebook.Controls.Add(TxtPulgadasNote);
            PageNotebook.Location = new Point(4, 24);
            PageNotebook.Name = "PageNotebook";
            PageNotebook.Padding = new Padding(3);
            PageNotebook.Size = new Size(562, 294);
            PageNotebook.TabIndex = 1;
            PageNotebook.Text = "Notebook";
            PageNotebook.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(38, 117);
            label12.Name = "label12";
            label12.Size = new Size(68, 15);
            label12.TabIndex = 32;
            label12.Text = "Resolucion:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(301, 117);
            label15.Name = "label15";
            label15.Size = new Size(106, 15);
            label15.TabIndex = 31;
            label15.Text = "Sistema Operativo:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(301, 33);
            label14.Name = "label14";
            label14.Size = new Size(36, 15);
            label14.TabIndex = 30;
            label14.Text = "RAM:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(38, 202);
            label13.Name = "label13";
            label13.Size = new Size(101, 15);
            label13.TabIndex = 29;
            label13.Text = "Almacenamiento:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(38, 33);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 27;
            label11.Text = "Pulgadas:";
            // 
            // checkSSD
            // 
            checkSSD.AutoSize = true;
            checkSSD.Location = new Point(345, 224);
            checkSSD.Name = "checkSSD";
            checkSSD.Size = new Size(46, 19);
            checkSSD.TabIndex = 26;
            checkSSD.Text = "SSD";
            checkSSD.UseVisualStyleBackColor = true;
            // 
            // TxtSONote
            // 
            TxtSONote.Location = new Point(332, 135);
            TxtSONote.Name = "TxtSONote";
            TxtSONote.Size = new Size(153, 23);
            TxtSONote.TabIndex = 25;
            // 
            // TxtRamNote
            // 
            TxtRamNote.Location = new Point(332, 57);
            TxtRamNote.Name = "TxtRamNote";
            TxtRamNote.Size = new Size(153, 23);
            TxtRamNote.TabIndex = 24;
            // 
            // TxtAlmacenamientoNote
            // 
            TxtAlmacenamientoNote.Location = new Point(68, 220);
            TxtAlmacenamientoNote.Name = "TxtAlmacenamientoNote";
            TxtAlmacenamientoNote.Size = new Size(153, 23);
            TxtAlmacenamientoNote.TabIndex = 23;
            // 
            // TxtResolucionNote
            // 
            TxtResolucionNote.Location = new Point(68, 135);
            TxtResolucionNote.Name = "TxtResolucionNote";
            TxtResolucionNote.Size = new Size(153, 23);
            TxtResolucionNote.TabIndex = 22;
            // 
            // TxtPulgadasNote
            // 
            TxtPulgadasNote.Location = new Point(68, 57);
            TxtPulgadasNote.Name = "TxtPulgadasNote";
            TxtPulgadasNote.Size = new Size(153, 23);
            TxtPulgadasNote.TabIndex = 21;
            // 
            // PageTelevisor
            // 
            PageTelevisor.Controls.Add(label17);
            PageTelevisor.Controls.Add(label16);
            PageTelevisor.Controls.Add(checkSmartTv);
            PageTelevisor.Controls.Add(TxtResolucionTele);
            PageTelevisor.Controls.Add(TxtPulgadasTele);
            PageTelevisor.Location = new Point(4, 24);
            PageTelevisor.Name = "PageTelevisor";
            PageTelevisor.Padding = new Padding(3);
            PageTelevisor.Size = new Size(562, 294);
            PageTelevisor.TabIndex = 2;
            PageTelevisor.Text = "Televisor";
            PageTelevisor.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(309, 65);
            label17.Name = "label17";
            label17.Size = new Size(68, 15);
            label17.TabIndex = 25;
            label17.Text = "Resolucion:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(53, 65);
            label16.Name = "label16";
            label16.Size = new Size(58, 15);
            label16.TabIndex = 24;
            label16.Text = "Pulgadas:";
            // 
            // checkSmartTv
            // 
            checkSmartTv.AutoSize = true;
            checkSmartTv.Location = new Point(78, 201);
            checkSmartTv.Name = "checkSmartTv";
            checkSmartTv.Size = new Size(79, 19);
            checkSmartTv.TabIndex = 23;
            checkSmartTv.Text = "SMART TV";
            checkSmartTv.UseVisualStyleBackColor = true;
            // 
            // TxtResolucionTele
            // 
            TxtResolucionTele.Location = new Point(322, 91);
            TxtResolucionTele.Name = "TxtResolucionTele";
            TxtResolucionTele.Size = new Size(153, 23);
            TxtResolucionTele.TabIndex = 22;
            // 
            // TxtPulgadasTele
            // 
            TxtPulgadasTele.Location = new Point(78, 91);
            TxtPulgadasTele.Name = "TxtPulgadasTele";
            TxtPulgadasTele.Size = new Size(153, 23);
            TxtPulgadasTele.TabIndex = 21;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Location = new Point(235, 370);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(285, 36);
            BtnAceptar.TabIndex = 21;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(526, 370);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(271, 36);
            BtnCancelar.TabIndex = 22;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // FrmManejoDispositivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 422);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAceptar);
            Controls.Add(TabDispositivos);
            Controls.Add(TxtPrecio);
            Controls.Add(TxtModelo);
            Controls.Add(TxtMarca);
            Controls.Add(TxtCantidad);
            Controls.Add(TxtId);
            Controls.Add(CmbTipo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LblTitulo);
            Name = "FrmManejoDispositivo";
            Text = "FrmProducto";
            Load += FrmManejoDispositivo_Load;
            TabDispositivos.ResumeLayout(false);
            PageCelular.ResumeLayout(false);
            PageCelular.PerformLayout();
            PageNotebook.ResumeLayout(false);
            PageNotebook.PerformLayout();
            PageTelevisor.ResumeLayout(false);
            PageTelevisor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblTitulo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox CmbTipo;
        private TextBox TxtId;
        private TextBox TxtCantidad;
        private TextBox TxtMarca;
        private TextBox TxtModelo;
        private TextBox TxtPrecio;
        private TabControl TabDispositivos;
        private TabPage PageCelular;
        private TabPage PageNotebook;
        private TabPage PageTelevisor;
        private TextBox TxtCantCamarasCelular;
        private TextBox TxtRamCelular;
        private TextBox TxtAlmacenamientoCelular;
        private TextBox TxtPulgadasCelular;
        private TextBox TxtRamNote;
        private TextBox TxtAlmacenamientoNote;
        private TextBox TxtResolucionNote;
        private TextBox TxtPulgadasNote;
        private CheckBox checkSSD;
        private TextBox TxtSONote;
        private TextBox TxtResolucionTele;
        private TextBox TxtPulgadasTele;
        private CheckBox checkSmartTv;
        private Label label8;
        private Label label1;
        private Label label10;
        private Label label9;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label11;
        private Label label12;
        private Label label17;
        private Label label16;
        private Button BtnAceptar;
        private Button BtnCancelar;
    }
}