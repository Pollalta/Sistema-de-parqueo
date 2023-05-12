namespace CATEDRA
{
    partial class Form1
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
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rdbSur = new System.Windows.Forms.RadioButton();
            this.rdbNorte = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContraL = new System.Windows.Forms.TextBox();
            this.txtDuiL = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtAsignado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnPagar = new System.Windows.Forms.Button();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApagar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pizzara = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.tabPrincipal.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPage2);
            this.tabPrincipal.Controls.Add(this.tabPage3);
            this.tabPrincipal.Controls.Add(this.tabPage4);
            this.tabPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(291, 505);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rdbSur);
            this.tabPage2.Controls.Add(this.rdbNorte);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnLogin);
            this.tabPage2.Controls.Add(this.txtUbicacion);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtContraL);
            this.tabPage2.Controls.Add(this.txtDuiL);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(283, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Solicitar Espacio";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // rdbSur
            // 
            this.rdbSur.AutoSize = true;
            this.rdbSur.Location = new System.Drawing.Point(167, 190);
            this.rdbSur.Name = "rdbSur";
            this.rdbSur.Size = new System.Drawing.Size(81, 17);
            this.rdbSur.TabIndex = 21;
            this.rdbSur.TabStop = true;
            this.rdbSur.Text = "Entrada Sur";
            this.rdbSur.UseVisualStyleBackColor = true;
            this.rdbSur.CheckedChanged += new System.EventHandler(this.rdbSur_CheckedChanged);
            // 
            // rdbNorte
            // 
            this.rdbNorte.AutoSize = true;
            this.rdbNorte.Location = new System.Drawing.Point(19, 190);
            this.rdbNorte.Name = "rdbNorte";
            this.rdbNorte.Size = new System.Drawing.Size(91, 17);
            this.rdbNorte.TabIndex = 20;
            this.rdbNorte.TabStop = true;
            this.rdbNorte.Text = "Entrada Norte";
            this.rdbNorte.UseVisualStyleBackColor = true;
            this.rdbNorte.CheckedChanged += new System.EventHandler(this.rdbNorte_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Posicion otorgada:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Seleccion Entrada:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(95, 234);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = "Solicitar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(9, 292);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.ReadOnly = true;
            this.txtUbicacion.Size = new System.Drawing.Size(239, 20);
            this.txtUbicacion.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "DUI:";
            // 
            // txtContraL
            // 
            this.txtContraL.Location = new System.Drawing.Point(19, 108);
            this.txtContraL.Name = "txtContraL";
            this.txtContraL.PasswordChar = '*';
            this.txtContraL.ReadOnly = true;
            this.txtContraL.Size = new System.Drawing.Size(239, 20);
            this.txtContraL.TabIndex = 12;
            // 
            // txtDuiL
            // 
            this.txtDuiL.Location = new System.Drawing.Point(19, 43);
            this.txtDuiL.Name = "txtDuiL";
            this.txtDuiL.ReadOnly = true;
            this.txtDuiL.Size = new System.Drawing.Size(239, 20);
            this.txtDuiL.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtAsignado);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(283, 479);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ruta";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtAsignado
            // 
            this.txtAsignado.Location = new System.Drawing.Point(30, 43);
            this.txtAsignado.Name = "txtAsignado";
            this.txtAsignado.Size = new System.Drawing.Size(184, 20);
            this.txtAsignado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "El Estacionamiento asignado es:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnPagar);
            this.tabPage4.Controls.Add(this.txtEntrada);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.txtSalida);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.txtApagar);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(283, 479);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pago";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(92, 182);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 4;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(29, 77);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(199, 20);
            this.txtSalida.TabIndex = 3;
            this.txtSalida.TextChanged += new System.EventHandler(this.txtSalida_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hora de Salida";
            // 
            // txtApagar
            // 
            this.txtApagar.Location = new System.Drawing.Point(31, 123);
            this.txtApagar.Name = "txtApagar";
            this.txtApagar.Size = new System.Drawing.Size(199, 20);
            this.txtApagar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad a pagar";
            // 
            // Pizzara
            // 
            this.Pizzara.Location = new System.Drawing.Point(309, 12);
            this.Pizzara.Name = "Pizzara";
            this.Pizzara.Size = new System.Drawing.Size(638, 501);
            this.Pizzara.TabIndex = 1;
            this.Pizzara.Paint += new System.Windows.Forms.PaintEventHandler(this.Pizzara_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hora de entrada";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(29, 38);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(199, 20);
            this.txtEntrada.TabIndex = 3;
            this.txtEntrada.TextChanged += new System.EventHandler(this.txtSalida_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 529);
            this.Controls.Add(this.Pizzara);
            this.Controls.Add(this.tabPrincipal);
            this.Name = "Form1";
            this.Text = "Sistema Estacionamiento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel Pizzara;
        private System.Windows.Forms.RadioButton rdbSur;
        private System.Windows.Forms.RadioButton rdbNorte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContraL;
        private System.Windows.Forms.TextBox txtDuiL;
        private System.Windows.Forms.TextBox txtAsignado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApagar;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPagar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label label5;
    }
}

