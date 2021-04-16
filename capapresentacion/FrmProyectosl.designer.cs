
namespace capapresentacion
{
    partial class FrmProyectos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProyectos));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabProyectos = new System.Windows.Forms.TabPage();
            this.label_añadir = new System.Windows.Forms.Label();
            this.panelRecuadro = new System.Windows.Forms.Panel();
            this.dataListProyectos = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminarProyecto = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cbEliminar = new System.Windows.Forms.CheckBox();
            this.btnBuscarProyecto = new System.Windows.Forms.Button();
            this.txtBuscarProyecto = new System.Windows.Forms.TextBox();
            this.cboBuscarProyecto = new System.Windows.Forms.ComboBox();
            this.ControlPestanias = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabProyectos.SuspendLayout();
            this.panelRecuadro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListProyectos)).BeginInit();
            this.ControlPestanias.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tabProyectos
            // 
            this.tabProyectos.Controls.Add(this.label_añadir);
            this.tabProyectos.Controls.Add(this.panelRecuadro);
            this.tabProyectos.Controls.Add(this.btnNuevo);
            this.tabProyectos.Controls.Add(this.btnEliminarProyecto);
            this.tabProyectos.Controls.Add(this.lblTotal);
            this.tabProyectos.Controls.Add(this.cbEliminar);
            this.tabProyectos.Controls.Add(this.btnBuscarProyecto);
            this.tabProyectos.Controls.Add(this.txtBuscarProyecto);
            this.tabProyectos.Controls.Add(this.cboBuscarProyecto);
            this.tabProyectos.Location = new System.Drawing.Point(4, 22);
            this.tabProyectos.Name = "tabProyectos";
            this.tabProyectos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProyectos.Size = new System.Drawing.Size(802, 517);
            this.tabProyectos.TabIndex = 0;
            this.tabProyectos.Text = "Proyectos";
            this.tabProyectos.UseVisualStyleBackColor = true;
            // 
            // label_añadir
            // 
            this.label_añadir.AutoSize = true;
            this.label_añadir.Location = new System.Drawing.Point(152, 117);
            this.label_añadir.Name = "label_añadir";
            this.label_añadir.Size = new System.Drawing.Size(37, 13);
            this.label_añadir.TabIndex = 12;
            this.label_añadir.Text = "Añadir";
            this.label_añadir.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelRecuadro
            // 
            this.panelRecuadro.BackColor = System.Drawing.Color.Gold;
            this.panelRecuadro.Controls.Add(this.dataListProyectos);
            this.panelRecuadro.Location = new System.Drawing.Point(21, 150);
            this.panelRecuadro.Name = "panelRecuadro";
            this.panelRecuadro.Size = new System.Drawing.Size(663, 282);
            this.panelRecuadro.TabIndex = 11;
            //this.panelRecuadro.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRecuadro_Paint);
            // 
            // dataListProyectos
            // 
            this.dataListProyectos.AllowUserToAddRows = false;
            this.dataListProyectos.AllowUserToDeleteRows = false;
            this.dataListProyectos.AllowUserToOrderColumns = true;
            this.dataListProyectos.BackgroundColor = System.Drawing.Color.White;
            this.dataListProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListProyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListProyectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListProyectos.Location = new System.Drawing.Point(0, 0);
            this.dataListProyectos.Name = "dataListProyectos";
            this.dataListProyectos.ReadOnly = true;
            this.dataListProyectos.RowHeadersWidth = 51;
            this.dataListProyectos.Size = new System.Drawing.Size(663, 282);
            this.dataListProyectos.TabIndex = 4;
            this.dataListProyectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListProyectos_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 2;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::capapresentacion.Properties.Resources.addNew;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(204, 109);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(26, 28);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminarProyecto
            // 
            this.btnEliminarProyecto.BackColor = System.Drawing.Color.White;
            this.btnEliminarProyecto.BackgroundImage = global::capapresentacion.Properties.Resources.DeleteButton;
            this.btnEliminarProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarProyecto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarProyecto.FlatAppearance.BorderSize = 0;
            this.btnEliminarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProyecto.Location = new System.Drawing.Point(89, 109);
            this.btnEliminarProyecto.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarProyecto.Name = "btnEliminarProyecto";
            this.btnEliminarProyecto.Size = new System.Drawing.Size(32, 28);
            this.btnEliminarProyecto.TabIndex = 9;
            this.btnEliminarProyecto.UseVisualStyleBackColor = false;
            this.btnEliminarProyecto.Click += new System.EventHandler(this.btnEliminarProyecto_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(558, 117);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(109, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "numero de proyectos:";
            //this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // cbEliminar
            // 
            this.cbEliminar.AutoSize = true;
            this.cbEliminar.Location = new System.Drawing.Point(21, 116);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(62, 17);
            this.cbEliminar.TabIndex = 7;
            this.cbEliminar.Text = "Eliminar";
            this.cbEliminar.UseVisualStyleBackColor = true;
            this.cbEliminar.CheckedChanged += new System.EventHandler(this.cbEliminar_CheckedChanged);
            // 
            // btnBuscarProyecto
            // 
            this.btnBuscarProyecto.BackColor = System.Drawing.Color.White;
            this.btnBuscarProyecto.BackgroundImage = global::capapresentacion.Properties.Resources.Lupa;
            this.btnBuscarProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProyecto.Location = new System.Drawing.Point(659, 25);
            this.btnBuscarProyecto.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscarProyecto.Name = "btnBuscarProyecto";
            this.btnBuscarProyecto.Size = new System.Drawing.Size(25, 21);
            this.btnBuscarProyecto.TabIndex = 6;
            this.btnBuscarProyecto.UseVisualStyleBackColor = false;
            this.btnBuscarProyecto.Click += new System.EventHandler(this.P_btnBuscar_Click);
            // 
            // txtBuscarProyecto
            // 
            this.txtBuscarProyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarProyecto.Location = new System.Drawing.Point(204, 25);
            this.txtBuscarProyecto.Name = "txtBuscarProyecto";
            this.txtBuscarProyecto.Size = new System.Drawing.Size(452, 20);
            this.txtBuscarProyecto.TabIndex = 5;
           // this.txtBuscarProyecto.TextChanged += new System.EventHandler(this.txtBuscarProyecto_TextChanged);
            // 
            // cboBuscarProyecto
            // 
            this.cboBuscarProyecto.FormattingEnabled = true;
            this.cboBuscarProyecto.Items.AddRange(new object[] {
            "titulo",
            "observaciones",
            "codigo_proyecto"});
            this.cboBuscarProyecto.Location = new System.Drawing.Point(28, 24);
            this.cboBuscarProyecto.Name = "cboBuscarProyecto";
            this.cboBuscarProyecto.Size = new System.Drawing.Size(153, 21);
            this.cboBuscarProyecto.TabIndex = 2;
            this.cboBuscarProyecto.Text = "titulo";
            this.cboBuscarProyecto.SelectedIndexChanged += new System.EventHandler(this.cboBuscarProyecto_SelectedIndexChanged);
            // 
            // ControlPestanias
            // 
            this.ControlPestanias.Controls.Add(this.tabProyectos);
            this.ControlPestanias.Location = new System.Drawing.Point(12, 12);
            this.ControlPestanias.Name = "ControlPestanias";
            this.ControlPestanias.SelectedIndex = 0;
            this.ControlPestanias.Size = new System.Drawing.Size(810, 543);
            this.ControlPestanias.TabIndex = 0;
            this.ControlPestanias.SelectedIndexChanged += new System.EventHandler(this.ControlPestanias_SelectedIndexChanged);
            // 
            // FrmProyectosl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 567);
            this.Controls.Add(this.ControlPestanias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProyectosl";
            this.Text = "WPTimeTracking";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmPrincipal_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabProyectos.ResumeLayout(false);
            this.tabProyectos.PerformLayout();
            this.panelRecuadro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListProyectos)).EndInit();
            this.ControlPestanias.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TabControl ControlPestanias;
        private System.Windows.Forms.TabPage tabProyectos;
        private System.Windows.Forms.Panel panelRecuadro;
        private System.Windows.Forms.DataGridView dataListProyectos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminarProyecto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox cbEliminar;
        private System.Windows.Forms.Button btnBuscarProyecto;
        private System.Windows.Forms.TextBox txtBuscarProyecto;
        private System.Windows.Forms.ComboBox cboBuscarProyecto;
        private System.Windows.Forms.Label label_añadir;
    }
}