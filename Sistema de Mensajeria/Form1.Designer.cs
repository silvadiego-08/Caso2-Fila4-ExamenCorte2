namespace Sistema_de_Mensajeria
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
            this.lblNumPedido = new System.Windows.Forms.Label();
            this.tbNumPedido = new System.Windows.Forms.TextBox();
            this.cbEnvioPrioritario = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbPrioritario = new System.Windows.Forms.ListBox();
            this.lbRegular = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDespachar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumPedido
            // 
            this.lblNumPedido.AutoSize = true;
            this.lblNumPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPedido.Location = new System.Drawing.Point(21, 46);
            this.lblNumPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumPedido.Name = "lblNumPedido";
            this.lblNumPedido.Size = new System.Drawing.Size(123, 17);
            this.lblNumPedido.TabIndex = 0;
            this.lblNumPedido.Text = "Codigo de pedido:";
            // 
            // tbNumPedido
            // 
            this.tbNumPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumPedido.Location = new System.Drawing.Point(149, 44);
            this.tbNumPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNumPedido.Name = "tbNumPedido";
            this.tbNumPedido.Size = new System.Drawing.Size(121, 23);
            this.tbNumPedido.TabIndex = 1;
            // 
            // cbEnvioPrioritario
            // 
            this.cbEnvioPrioritario.AutoSize = true;
            this.cbEnvioPrioritario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEnvioPrioritario.Location = new System.Drawing.Point(67, 93);
            this.cbEnvioPrioritario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEnvioPrioritario.Name = "cbEnvioPrioritario";
            this.cbEnvioPrioritario.Size = new System.Drawing.Size(227, 21);
            this.cbEnvioPrioritario.TabIndex = 3;
            this.cbEnvioPrioritario.Text = "Registrar como Envío Prioritario";
            this.cbEnvioPrioritario.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(129, 136);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 36);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbPrioritario
            // 
            this.lbPrioritario.FormattingEnabled = true;
            this.lbPrioritario.Location = new System.Drawing.Point(52, 214);
            this.lbPrioritario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbPrioritario.Name = "lbPrioritario";
            this.lbPrioritario.Size = new System.Drawing.Size(102, 121);
            this.lbPrioritario.TabIndex = 5;
            // 
            // lbRegular
            // 
            this.lbRegular.FormattingEnabled = true;
            this.lbRegular.Location = new System.Drawing.Point(200, 214);
            this.lbRegular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbRegular.Name = "lbRegular";
            this.lbRegular.Size = new System.Drawing.Size(103, 121);
            this.lbRegular.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prioritario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Regular";
            // 
            // btnDespachar
            // 
            this.btnDespachar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDespachar.Location = new System.Drawing.Point(129, 353);
            this.btnDespachar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDespachar.Name = "btnDespachar";
            this.btnDespachar.Size = new System.Drawing.Size(94, 36);
            this.btnDespachar.TabIndex = 9;
            this.btnDespachar.Text = "Despachar";
            this.btnDespachar.UseVisualStyleBackColor = true;
            this.btnDespachar.Click += new System.EventHandler(this.btnDespachar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 405);
            this.Controls.Add(this.btnDespachar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbRegular);
            this.Controls.Add(this.lbPrioritario);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbEnvioPrioritario);
            this.Controls.Add(this.tbNumPedido);
            this.Controls.Add(this.lblNumPedido);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Sistema de Mensajería";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumPedido;
        private System.Windows.Forms.TextBox tbNumPedido;
        private System.Windows.Forms.CheckBox cbEnvioPrioritario;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lbPrioritario;
        private System.Windows.Forms.ListBox lbRegular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDespachar;
    }
}

