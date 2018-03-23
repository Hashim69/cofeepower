namespace Presentacion
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.linetickuser = new ns1.BunifuSeparator();
            this.linetickpass = new ns1.BunifuSeparator();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuImageButton3 = new ns1.BunifuImageButton();
            this.btnlogin = new ns1.BunifuThinButton2();
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(247)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 185);
            this.panel1.TabIndex = 0;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña.Location = new System.Drawing.Point(37, 213);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(223, 20);
            this.txtcontraseña.TabIndex = 2;
            this.txtcontraseña.UseSystemPasswordChar = true;
            this.txtcontraseña.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtcontraseña_MouseClick);
            this.txtcontraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontraseña_KeyPress);
            // 
            // txtusuario
            // 
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(37, 151);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(223, 20);
            this.txtusuario.TabIndex = 1;
            this.txtusuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtusuario_MouseClick);
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.txtcontraseña);
            this.panel2.Controls.Add(this.txtusuario);
            this.panel2.Controls.Add(this.linetickuser);
            this.panel2.Controls.Add(this.linetickpass);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.bunifuImageButton3);
            this.panel2.Controls.Add(this.bunifuThinButton21);
            this.panel2.Controls.Add(this.btnlogin);
            this.panel2.Location = new System.Drawing.Point(151, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 310);
            this.panel2.TabIndex = 5;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(33, 127);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(66, 21);
            this.bunifuCustomLabel2.TabIndex = 10;
            this.bunifuCustomLabel2.Text = "Usuario";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(33, 184);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(103, 21);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "Contraseña";
            // 
            // linetickuser
            // 
            this.linetickuser.BackColor = System.Drawing.Color.Transparent;
            this.linetickuser.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(247)))));
            this.linetickuser.LineThickness = 3;
            this.linetickuser.Location = new System.Drawing.Point(37, 171);
            this.linetickuser.Name = "linetickuser";
            this.linetickuser.Size = new System.Drawing.Size(223, 10);
            this.linetickuser.TabIndex = 8;
            this.linetickuser.Transparency = 255;
            this.linetickuser.Vertical = false;
            // 
            // linetickpass
            // 
            this.linetickpass.BackColor = System.Drawing.Color.Transparent;
            this.linetickpass.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.linetickpass.LineThickness = 2;
            this.linetickpass.Location = new System.Drawing.Point(35, 231);
            this.linetickpass.Name = "linetickpass";
            this.linetickpass.Size = new System.Drawing.Size(225, 10);
            this.linetickpass.TabIndex = 7;
            this.linetickpass.Transparency = 255;
            this.linetickpass.Vertical = false;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(102, 76);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(87, 21);
            this.bunifuCustomLabel3.TabIndex = 6;
            this.bunifuCustomLabel3.Text = "User Login";
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = global::Presentacion.Properties.Resources._8_512;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(110, 3);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 5;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // btnlogin
            // 
            this.btnlogin.ActiveBorderThickness = 1;
            this.btnlogin.ActiveCornerRadius = 20;
            this.btnlogin.ActiveFillColor = System.Drawing.Color.White;
            this.btnlogin.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(247)))));
            this.btnlogin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(247)))));
            this.btnlogin.BackColor = System.Drawing.Color.White;
            this.btnlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlogin.BackgroundImage")));
            this.btnlogin.ButtonText = "Aceptar";
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(247)))));
            this.btnlogin.IdleBorderThickness = 1;
            this.btnlogin.IdleCornerRadius = 20;
            this.btnlogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(247)))));
            this.btnlogin.IdleForecolor = System.Drawing.Color.White;
            this.btnlogin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(247)))));
            this.btnlogin.Location = new System.Drawing.Point(37, 249);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(102, 41);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Cancelar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(247)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(158, 249);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(102, 41);
            this.bunifuThinButton21.TabIndex = 3;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(596, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuThinButton2 btnlogin;
        private System.Windows.Forms.Panel panel2;
        private ns1.BunifuImageButton bunifuImageButton3;
        private ns1.BunifuSeparator linetickuser;
        private ns1.BunifuSeparator linetickpass;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuThinButton2 bunifuThinButton21;
    }
}