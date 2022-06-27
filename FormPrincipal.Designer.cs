namespace tienda_mayorista_app
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nbCantidad = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nbPrecio = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbPremium = new System.Windows.Forms.RadioButton();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbChupin = new System.Windows.Forms.CheckBox();
            this.cbMangaCorta = new System.Windows.Forms.CheckBox();
            this.cbCuelloMao = new System.Windows.Forms.CheckBox();
            this.radioBtnPantalon = new System.Windows.Forms.RadioButton();
            this.radioBtnCamisa = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDireccionTienda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbNombreTienda = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.llbHistorialCotizaciones = new System.Windows.Forms.LinkLabel();
            this.lbCodigoVendedor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbNombreVendedor = new System.Windows.Forms.ComboBox();
            this.lbPrecioFinal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPrecio)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cotizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cotizar";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.nbCantidad);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.nbPrecio);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(222, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 70);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Precio y Cantidad";
            // 
            // nbCantidad
            // 
            this.nbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbCantidad.Location = new System.Drawing.Point(211, 27);
            this.nbCantidad.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nbCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbCantidad.Name = "nbCantidad";
            this.nbCantidad.Size = new System.Drawing.Size(56, 24);
            this.nbCantidad.TabIndex = 4;
            this.nbCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nbPrecio
            // 
            this.nbPrecio.DecimalPlaces = 2;
            this.nbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbPrecio.Location = new System.Drawing.Point(32, 26);
            this.nbPrecio.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nbPrecio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nbPrecio.Name = "nbPrecio";
            this.nbPrecio.Size = new System.Drawing.Size(69, 24);
            this.nbPrecio.TabIndex = 2;
            this.nbPrecio.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "$";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox3.Controls.Add(this.rbPremium);
            this.groupBox3.Controls.Add(this.rbStandard);
            this.groupBox3.Location = new System.Drawing.Point(104, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(112, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calidad de Prenda";
            // 
            // rbPremium
            // 
            this.rbPremium.AutoSize = true;
            this.rbPremium.Location = new System.Drawing.Point(7, 44);
            this.rbPremium.Name = "rbPremium";
            this.rbPremium.Size = new System.Drawing.Size(65, 17);
            this.rbPremium.TabIndex = 1;
            this.rbPremium.TabStop = true;
            this.rbPremium.Text = "Premium";
            this.rbPremium.UseVisualStyleBackColor = true;
            this.rbPremium.CheckedChanged += new System.EventHandler(this.rbPremium_CheckedChanged);
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Location = new System.Drawing.Point(7, 20);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(68, 17);
            this.rbStandard.TabIndex = 0;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "Standard";
            this.rbStandard.UseVisualStyleBackColor = true;
            this.rbStandard.CheckedChanged += new System.EventHandler(this.rbStandard_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.cbChupin);
            this.groupBox2.Controls.Add(this.cbMangaCorta);
            this.groupBox2.Controls.Add(this.cbCuelloMao);
            this.groupBox2.Controls.Add(this.radioBtnPantalon);
            this.groupBox2.Controls.Add(this.radioBtnCamisa);
            this.groupBox2.Location = new System.Drawing.Point(104, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 83);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prenda";
            // 
            // cbChupin
            // 
            this.cbChupin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbChupin.AutoSize = true;
            this.cbChupin.Location = new System.Drawing.Point(118, 47);
            this.cbChupin.Name = "cbChupin";
            this.cbChupin.Size = new System.Drawing.Size(59, 17);
            this.cbChupin.TabIndex = 4;
            this.cbChupin.Text = "Chupin";
            this.cbChupin.UseVisualStyleBackColor = true;
            this.cbChupin.CheckedChanged += new System.EventHandler(this.cbChupin_CheckedChanged);
            // 
            // cbMangaCorta
            // 
            this.cbMangaCorta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMangaCorta.AutoSize = true;
            this.cbMangaCorta.Location = new System.Drawing.Point(205, 24);
            this.cbMangaCorta.Name = "cbMangaCorta";
            this.cbMangaCorta.Size = new System.Drawing.Size(87, 17);
            this.cbMangaCorta.TabIndex = 3;
            this.cbMangaCorta.Text = "Manga Corta";
            this.cbMangaCorta.UseVisualStyleBackColor = true;
            this.cbMangaCorta.CheckedChanged += new System.EventHandler(this.cbMangaCorta_CheckedChanged);
            // 
            // cbCuelloMao
            // 
            this.cbCuelloMao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCuelloMao.AutoSize = true;
            this.cbCuelloMao.Location = new System.Drawing.Point(118, 24);
            this.cbCuelloMao.Name = "cbCuelloMao";
            this.cbCuelloMao.Size = new System.Drawing.Size(79, 17);
            this.cbCuelloMao.TabIndex = 2;
            this.cbCuelloMao.Text = "Cuello Mao";
            this.cbCuelloMao.UseVisualStyleBackColor = true;
            this.cbCuelloMao.CheckedChanged += new System.EventHandler(this.cbCuelloMao_CheckedChanged);
            // 
            // radioBtnPantalon
            // 
            this.radioBtnPantalon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnPantalon.AutoSize = true;
            this.radioBtnPantalon.Location = new System.Drawing.Point(15, 47);
            this.radioBtnPantalon.Name = "radioBtnPantalon";
            this.radioBtnPantalon.Size = new System.Drawing.Size(67, 17);
            this.radioBtnPantalon.TabIndex = 1;
            this.radioBtnPantalon.Text = "Pantalon";
            this.radioBtnPantalon.UseVisualStyleBackColor = true;
            this.radioBtnPantalon.CheckedChanged += new System.EventHandler(this.radioBtnPantalon_CheckedChanged);
            // 
            // radioBtnCamisa
            // 
            this.radioBtnCamisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnCamisa.AutoSize = true;
            this.radioBtnCamisa.Location = new System.Drawing.Point(15, 24);
            this.radioBtnCamisa.Name = "radioBtnCamisa";
            this.radioBtnCamisa.Size = new System.Drawing.Size(59, 17);
            this.radioBtnCamisa.TabIndex = 0;
            this.radioBtnCamisa.Text = "Camisa";
            this.radioBtnCamisa.UseVisualStyleBackColor = true;
            this.radioBtnCamisa.CheckedChanged += new System.EventHandler(this.radioBtnCamisa_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbDireccionTienda);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbbNombreTienda);
            this.panel1.Location = new System.Drawing.Point(12, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 31);
            this.panel1.TabIndex = 0;
            // 
            // lbDireccionTienda
            // 
            this.lbDireccionTienda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDireccionTienda.AutoSize = true;
            this.lbDireccionTienda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDireccionTienda.Location = new System.Drawing.Point(298, 8);
            this.lbDireccionTienda.Name = "lbDireccionTienda";
            this.lbDireccionTienda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbDireccionTienda.Size = new System.Drawing.Size(114, 13);
            this.lbDireccionTienda.TabIndex = 2;
            this.lbDireccionTienda.Text = "Direccion de la Tienda";
            this.lbDireccionTienda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre Tienda";
            // 
            // cbbNombreTienda
            // 
            this.cbbNombreTienda.FormattingEnabled = true;
            this.cbbNombreTienda.Location = new System.Drawing.Point(90, 5);
            this.cbbNombreTienda.Name = "cbbNombreTienda";
            this.cbbNombreTienda.Size = new System.Drawing.Size(202, 21);
            this.cbbNombreTienda.TabIndex = 0;
            this.cbbNombreTienda.SelectedIndexChanged += new System.EventHandler(this.cbbNombreTienda_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(642, 59);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cotizador Express";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.llbHistorialCotizaciones);
            this.panel4.Controls.Add(this.lbCodigoVendedor);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.cbbNombreVendedor);
            this.panel4.Location = new System.Drawing.Point(12, 129);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(642, 54);
            this.panel4.TabIndex = 3;
            // 
            // llbHistorialCotizaciones
            // 
            this.llbHistorialCotizaciones.AutoSize = true;
            this.llbHistorialCotizaciones.Location = new System.Drawing.Point(4, 29);
            this.llbHistorialCotizaciones.Name = "llbHistorialCotizaciones";
            this.llbHistorialCotizaciones.Size = new System.Drawing.Size(122, 13);
            this.llbHistorialCotizaciones.TabIndex = 3;
            this.llbHistorialCotizaciones.TabStop = true;
            this.llbHistorialCotizaciones.Text = "Historial de Cotizaciones";
            this.llbHistorialCotizaciones.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbHistorialCotizaciones_LinkClicked);
            // 
            // lbCodigoVendedor
            // 
            this.lbCodigoVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCodigoVendedor.AutoSize = true;
            this.lbCodigoVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbCodigoVendedor.Location = new System.Drawing.Point(298, 8);
            this.lbCodigoVendedor.Name = "lbCodigoVendedor";
            this.lbCodigoVendedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbCodigoVendedor.Size = new System.Drawing.Size(86, 13);
            this.lbCodigoVendedor.TabIndex = 2;
            this.lbCodigoVendedor.Text = "CodigoVendedor";
            this.lbCodigoVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre Vendedor";
            // 
            // cbbNombreVendedor
            // 
            this.cbbNombreVendedor.FormattingEnabled = true;
            this.cbbNombreVendedor.Location = new System.Drawing.Point(99, 5);
            this.cbbNombreVendedor.Name = "cbbNombreVendedor";
            this.cbbNombreVendedor.Size = new System.Drawing.Size(193, 21);
            this.cbbNombreVendedor.TabIndex = 0;
            this.cbbNombreVendedor.SelectedIndexChanged += new System.EventHandler(this.cbbNombreVendedor_SelectedIndexChanged);
            // 
            // lbPrecioFinal
            // 
            this.lbPrecioFinal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPrecioFinal.AutoSize = true;
            this.lbPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioFinal.Location = new System.Drawing.Point(137, 433);
            this.lbPrecioFinal.Name = "lbPrecioFinal";
            this.lbPrecioFinal.Size = new System.Drawing.Size(35, 37);
            this.lbPrecioFinal.TabIndex = 5;
            this.lbPrecioFinal.Text = "$";
            this.lbPrecioFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(666, 479);
            this.Controls.Add(this.lbPrecioFinal);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "FormPrincipal";
            this.Text = "Venta Mayorista";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPrecio)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button button1;

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBtnPantalon;
        private System.Windows.Forms.RadioButton radioBtnCamisa;
        private System.Windows.Forms.CheckBox cbChupin;
        private System.Windows.Forms.CheckBox cbMangaCorta;
        private System.Windows.Forms.CheckBox cbCuelloMao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbNombreTienda;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDireccionTienda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbCodigoVendedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbNombreVendedor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel llbHistorialCotizaciones;
        private System.Windows.Forms.RadioButton rbPremium;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nbPrecio;
        private System.Windows.Forms.NumericUpDown nbCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPrecioFinal;
    }
}

