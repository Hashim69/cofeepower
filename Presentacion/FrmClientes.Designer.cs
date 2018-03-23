namespace Presentacion
{
    partial class FrmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards1 = new ns1.BunifuCards();
            this.btnexport = new ns1.BunifuFlatButton();
            this.btneliminar = new ns1.BunifuTileButton();
            this.btneditar = new ns1.BunifuTileButton();
            this.btnnuevo = new ns1.BunifuTileButton();
            this.GVCliente = new ns1.BunifuCustomDataGrid();
            this.bunifuCustomLabel8 = new ns1.BunifuCustomLabel();
            this.progressbar = new ns1.BunifuProgressBar();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(247)))));
            this.bunifuCards1.Controls.Add(this.progressbar);
            this.bunifuCards1.Controls.Add(this.btnexport);
            this.bunifuCards1.Controls.Add(this.btneliminar);
            this.bunifuCards1.Controls.Add(this.btneditar);
            this.bunifuCards1.Controls.Add(this.btnnuevo);
            this.bunifuCards1.Controls.Add(this.GVCliente);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel8);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(12, 12);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 100;
            this.bunifuCards1.Size = new System.Drawing.Size(997, 593);
            this.bunifuCards1.TabIndex = 0;
            // 
            // btnexport
            // 
            this.btnexport.Activecolor = System.Drawing.Color.Black;
            this.btnexport.BackColor = System.Drawing.Color.White;
            this.btnexport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexport.BorderRadius = 5;
            this.btnexport.ButtonText = "Exportar a Excel";
            this.btnexport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexport.DisabledColor = System.Drawing.Color.Gray;
            this.btnexport.Iconcolor = System.Drawing.Color.Transparent;
            this.btnexport.Iconimage = global::Presentacion.Properties.Resources.Microsoft_Excel_48px;
            this.btnexport.Iconimage_right = null;
            this.btnexport.Iconimage_right_Selected = null;
            this.btnexport.Iconimage_Selected = null;
            this.btnexport.IconMarginLeft = 0;
            this.btnexport.IconMarginRight = 0;
            this.btnexport.IconRightVisible = true;
            this.btnexport.IconRightZoom = 0D;
            this.btnexport.IconVisible = true;
            this.btnexport.IconZoom = 70D;
            this.btnexport.IsTab = false;
            this.btnexport.Location = new System.Drawing.Point(12, 45);
            this.btnexport.Name = "btnexport";
            this.btnexport.Normalcolor = System.Drawing.Color.White;
            this.btnexport.OnHovercolor = System.Drawing.Color.Gray;
            this.btnexport.OnHoverTextColor = System.Drawing.Color.White;
            this.btnexport.selected = false;
            this.btnexport.Size = new System.Drawing.Size(172, 36);
            this.btnexport.TabIndex = 53;
            this.btnexport.Text = "Exportar a Excel";
            this.btnexport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexport.Textcolor = System.Drawing.Color.Black;
            this.btnexport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Transparent;
            this.btneliminar.color = System.Drawing.Color.Transparent;
            this.btneliminar.colorActive = System.Drawing.Color.Silver;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.Enabled = false;
            this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.Black;
            this.btneliminar.Image = global::Presentacion.Properties.Resources.Delete_48px_6;
            this.btneliminar.ImagePosition = 8;
            this.btneliminar.ImageZoom = 45;
            this.btneliminar.LabelPosition = 25;
            this.btneliminar.LabelText = "Eliminar";
            this.btneliminar.Location = new System.Drawing.Point(907, 12);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(6);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(77, 66);
            this.btneliminar.TabIndex = 52;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.Transparent;
            this.btneditar.color = System.Drawing.Color.Transparent;
            this.btneditar.colorActive = System.Drawing.Color.Silver;
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.Enabled = false;
            this.btneditar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.Black;
            this.btneditar.Image = global::Presentacion.Properties.Resources.Edit_Property_48;
            this.btneditar.ImagePosition = 8;
            this.btneditar.ImageZoom = 45;
            this.btneditar.LabelPosition = 25;
            this.btneditar.LabelText = "Editar";
            this.btneditar.Location = new System.Drawing.Point(818, 12);
            this.btneditar.Margin = new System.Windows.Forms.Padding(6);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(77, 66);
            this.btneditar.TabIndex = 51;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnnuevo.color = System.Drawing.Color.Transparent;
            this.btnnuevo.colorActive = System.Drawing.Color.Silver;
            this.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.ForeColor = System.Drawing.Color.Black;
            this.btnnuevo.Image = global::Presentacion.Properties.Resources.Plus_48px;
            this.btnnuevo.ImagePosition = 8;
            this.btnnuevo.ImageZoom = 45;
            this.btnnuevo.LabelPosition = 25;
            this.btnnuevo.LabelText = "Nuevo";
            this.btnnuevo.Location = new System.Drawing.Point(729, 12);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(6);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(77, 66);
            this.btnnuevo.TabIndex = 50;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // GVCliente
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GVCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.GVCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVCliente.BackgroundColor = System.Drawing.Color.Silver;
            this.GVCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GVCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GVCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.GVCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVCliente.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVCliente.DefaultCellStyle = dataGridViewCellStyle15;
            this.GVCliente.DoubleBuffered = true;
            this.GVCliente.EnableHeadersVisualStyles = false;
            this.GVCliente.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.GVCliente.HeaderForeColor = System.Drawing.Color.White;
            this.GVCliente.Location = new System.Drawing.Point(12, 87);
            this.GVCliente.Name = "GVCliente";
            this.GVCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GVCliente.Size = new System.Drawing.Size(972, 492);
            this.GVCliente.TabIndex = 29;
            this.GVCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVCliente_CellClick);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(247)))));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(8, 12);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(189, 23);
            this.bunifuCustomLabel8.TabIndex = 28;
            this.bunifuCustomLabel8.Text = "Registro de clientes";
            // 
            // progressbar
            // 
            this.progressbar.BackColor = System.Drawing.Color.Silver;
            this.progressbar.BorderRadius = 5;
            this.progressbar.Location = new System.Drawing.Point(218, 58);
            this.progressbar.MaximumValue = 1;
            this.progressbar.Name = "progressbar";
            this.progressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(247)))));
            this.progressbar.Size = new System.Drawing.Size(502, 11);
            this.progressbar.TabIndex = 54;
            this.progressbar.Value = 0;
            this.progressbar.Visible = false;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 617);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuCards bunifuCards1;
        private ns1.BunifuTileButton btneliminar;
        private ns1.BunifuTileButton btneditar;
        private ns1.BunifuTileButton btnnuevo;
        private ns1.BunifuCustomDataGrid GVCliente;
        private ns1.BunifuCustomLabel bunifuCustomLabel8;
        private ns1.BunifuFlatButton btnexport;
        private ns1.BunifuProgressBar progressbar;
    }
}