﻿namespace CapaVista
{
    partial class FrmGestionPedidoCotizaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IDPR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIOSOLICITANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDADPRODUCTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadPedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Proveedor2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Proveedor3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provedor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provedor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provedor3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPR,
            this.FECHA,
            this.USUARIOSOLICITANTE,
            this.CANTIDADPRODUCTOS});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(6, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(441, 187);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // IDPR
            // 
            this.IDPR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IDPR.HeaderText = "Nro. Pedido";
            this.IDPR.Name = "IDPR";
            this.IDPR.ReadOnly = true;
            this.IDPR.Width = 88;
            // 
            // FECHA
            // 
            this.FECHA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.FECHA.DefaultCellStyle = dataGridViewCellStyle1;
            this.FECHA.HeaderText = "Fecha";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            this.FECHA.Width = 62;
            // 
            // USUARIOSOLICITANTE
            // 
            this.USUARIOSOLICITANTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.USUARIOSOLICITANTE.HeaderText = "Pedido Por";
            this.USUARIOSOLICITANTE.Name = "USUARIOSOLICITANTE";
            this.USUARIOSOLICITANTE.ReadOnly = true;
            this.USUARIOSOLICITANTE.Width = 84;
            // 
            // CANTIDADPRODUCTOS
            // 
            this.CANTIDADPRODUCTOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CANTIDADPRODUCTOS.HeaderText = "Cantidad";
            this.CANTIDADPRODUCTOS.Name = "CANTIDADPRODUCTOS";
            this.CANTIDADPRODUCTOS.ReadOnly = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProducto,
            this.Descripcion2,
            this.CantidadPedida,
            this.Proveedor1,
            this.Proveedor2,
            this.Proveedor3});
            this.dataGridView3.Location = new System.Drawing.Point(462, 36);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(613, 187);
            this.dataGridView3.TabIndex = 16;
            this.dataGridView3.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellValueChanged);
            // 
            // IDProducto
            // 
            this.IDProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDProducto.HeaderText = "IDProducto";
            this.IDProducto.Name = "IDProducto";
            this.IDProducto.Visible = false;
            // 
            // Descripcion2
            // 
            this.Descripcion2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion2.HeaderText = "Producto";
            this.Descripcion2.Name = "Descripcion2";
            // 
            // CantidadPedida
            // 
            this.CantidadPedida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CantidadPedida.HeaderText = "Cant. Pedida";
            this.CantidadPedida.Name = "CantidadPedida";
            // 
            // Proveedor1
            // 
            this.Proveedor1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Proveedor1.HeaderText = "Proveedor 1";
            this.Proveedor1.Name = "Proveedor1";
            this.Proveedor1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Proveedor1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Proveedor2
            // 
            this.Proveedor2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Proveedor2.HeaderText = "Proveedor 2";
            this.Proveedor2.Name = "Proveedor2";
            this.Proveedor2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Proveedor2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Proveedor3
            // 
            this.Proveedor3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Proveedor3.HeaderText = "Proveedor 3";
            this.Proveedor3.Name = "Proveedor3";
            this.Proveedor3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Proveedor3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(542, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "SELECCION DE PROVEEDORES POR PRODUCTOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "PEDIDOS PENDIENTES";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "Mandar Solicitud";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(992, 228);
            this.dateTimePicker1.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(83, 20);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.Value = new System.DateTime(2025, 6, 12, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(763, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fecha Limite del Presupuesto:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 43);
            this.button2.TabIndex = 23;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(561, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 37);
            this.button3.TabIndex = 24;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1089, 304);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1081, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nueva Cotizacion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.dataGridView4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1081, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Precios Cotizaciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(468, 229);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 37);
            this.button5.TabIndex = 26;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(367, 229);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 37);
            this.button6.TabIndex = 25;
            this.button6.Text = "Actualizar Presupuestos";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 43);
            this.button4.TabIndex = 24;
            this.button4.Text = "Modificar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "PRESUPUESTOS PENDIENTES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(591, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "CARGA DE PRESUPUESTOS POR PRODUCTO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Provedor1,
            this.Precio1,
            this.Provedor2,
            this.Precio2,
            this.Provedor3,
            this.precio3});
            this.dataGridView1.Location = new System.Drawing.Point(367, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(708, 187);
            this.dataGridView1.TabIndex = 21;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToResizeColumns = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.idusuario});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView4.Location = new System.Drawing.Point(6, 36);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(355, 187);
            this.dataGridView4.TabIndex = 20;
            this.dataGridView4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "Nro. Cotizacion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 96;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn5.HeaderText = "Fecha Limite";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 85;
            // 
            // idusuario
            // 
            this.idusuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idusuario.HeaderText = "Usuario que lo cargo";
            this.idusuario.Name = "idusuario";
            this.idusuario.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "IDProducto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Provedor1
            // 
            this.Provedor1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Provedor1.HeaderText = "Proveedor 1";
            this.Provedor1.Name = "Provedor1";
            // 
            // Precio1
            // 
            this.Precio1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio1.HeaderText = "Precio";
            this.Precio1.Name = "Precio1";
            this.Precio1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Provedor2
            // 
            this.Provedor2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Provedor2.HeaderText = "Proveedor 2";
            this.Provedor2.Name = "Provedor2";
            this.Provedor2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Precio2
            // 
            this.Precio2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio2.HeaderText = "Precio";
            this.Precio2.Name = "Precio2";
            this.Precio2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Provedor3
            // 
            this.Provedor3.HeaderText = "Proveedor3";
            this.Provedor3.Name = "Provedor3";
            // 
            // precio3
            // 
            this.precio3.HeaderText = "Precio";
            this.precio3.Name = "precio3";
            // 
            // FrmGestionPedidoCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 303);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmGestionPedidoCotizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTION PEDIDOS DE COTIZACION";
            this.Load += new System.EventHandler(this.FrmGestionPedidoCotizaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadPedida;
        private System.Windows.Forms.DataGridViewComboBoxColumn Proveedor1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Proveedor2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Proveedor3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIOSOLICITANTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDADPRODUCTOS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provedor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provedor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provedor3;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio3;
    }
}