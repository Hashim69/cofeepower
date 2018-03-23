namespace Presentacion
{
    partial class FrmCredenciales
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Clientes");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Pedidos");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Venta", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Abrir Caja");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Cerrar Caja");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Facturar");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Cuentas x Pagar");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Caja", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Proveedores");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Productos");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Pedidos");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Compra", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Empresa");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Reportes");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Graficos");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Gestion del Negocio", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Bitacora");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Usuarios");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Credenciales");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Administracion", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            this.bunifuCards1 = new ns1.BunifuCards();
            this.bunifuCustomLabel8 = new ns1.BunifuCustomLabel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(247)))));
            this.bunifuCards1.Controls.Add(this.treeView1);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel8);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(553, 400);
            this.bunifuCards1.TabIndex = 0;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(247)))));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(3, 9);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(134, 23);
            this.bunifuCustomLabel8.TabIndex = 29;
            this.bunifuCustomLabel8.Text = "Credenciales";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 52);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Clientes";
            treeNode1.Text = "Clientes";
            treeNode2.Name = "Pedidosv";
            treeNode2.Text = "Pedidos";
            treeNode3.Name = "Venta";
            treeNode3.Text = "Venta";
            treeNode4.Name = "AbrirCaja";
            treeNode4.Text = "Abrir Caja";
            treeNode5.Name = "CerrarCaja";
            treeNode5.Text = "Cerrar Caja";
            treeNode6.Name = "Facturar";
            treeNode6.Text = "Facturar";
            treeNode7.Name = "CuentasxPagar";
            treeNode7.Text = "Cuentas x Pagar";
            treeNode8.Name = "Caja";
            treeNode8.Text = "Caja";
            treeNode9.Name = "Proveedores";
            treeNode9.Text = "Proveedores";
            treeNode10.Name = "Productos";
            treeNode10.Text = "Productos";
            treeNode11.Name = "Pedidosc";
            treeNode11.Text = "Pedidos";
            treeNode12.Name = "Compra";
            treeNode12.Text = "Compra";
            treeNode13.Name = "Empresa";
            treeNode13.Text = "Empresa";
            treeNode14.Name = "Reportes";
            treeNode14.Text = "Reportes";
            treeNode15.Name = "Graficos";
            treeNode15.Text = "Graficos";
            treeNode16.Name = "GestionNegocio";
            treeNode16.Text = "Gestion del Negocio";
            treeNode17.Name = "Bitacora";
            treeNode17.Text = "Bitacora";
            treeNode18.Name = "Usuarios";
            treeNode18.Text = "Usuarios";
            treeNode19.Name = "Credenciales";
            treeNode19.Text = "Credenciales";
            treeNode20.Name = "Administracion";
            treeNode20.Text = "Administracion";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode8,
            treeNode12,
            treeNode16,
            treeNode20});
            this.treeView1.Size = new System.Drawing.Size(203, 336);
            this.treeView1.TabIndex = 30;
            // 
            // FrmCredenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 400);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCredenciales";
            this.Text = "FrmCredenciales";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuCards bunifuCards1;
        private System.Windows.Forms.TreeView treeView1;
        private ns1.BunifuCustomLabel bunifuCustomLabel8;
    }
}