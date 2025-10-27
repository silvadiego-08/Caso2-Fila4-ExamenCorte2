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
            this.lblNumPedido.Location = new System.Drawing.Point(28, 57);
            this.lblNumPedido.Name = "lblNumPedido";
            this.lblNumPedido.Size = new System.Drawing.Size(143, 20);
            this.lblNumPedido.TabIndex = 0;
            this.lblNumPedido.Text = "Codigo de pedido:";
            // 
            // tbNumPedido
            // 
            this.tbNumPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumPedido.Location = new System.Drawing.Point(199, 54);
            this.tbNumPedido.Name = "tbNumPedido";
            this.tbNumPedido.Size = new System.Drawing.Size(160, 27);
            this.tbNumPedido.TabIndex = 1;
            // 
            // cbEnvioPrioritario
            // 
            this.cbEnvioPrioritario.AutoSize = true;
            this.cbEnvioPrioritario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEnvioPrioritario.Location = new System.Drawing.Point(89, 114);
            this.cbEnvioPrioritario.Name = "cbEnvioPrioritario";
            this.cbEnvioPrioritario.Size = new System.Drawing.Size(270, 24);
            this.cbEnvioPrioritario.TabIndex = 3;
            this.cbEnvioPrioritario.Text = "Registrar como Envío Prioritario";
            this.cbEnvioPrioritario.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(172, 167);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(126, 44);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbPrioritario
            // 
            this.lbPrioritario.FormattingEnabled = true;
            this.lbPrioritario.ItemHeight = 16;
            this.lbPrioritario.Location = new System.Drawing.Point(70, 264);
            this.lbPrioritario.Name = "lbPrioritario";
            this.lbPrioritario.Size = new System.Drawing.Size(134, 148);
            this.lbPrioritario.TabIndex = 5;
            // 
            // lbRegular
            // 
            this.lbRegular.FormattingEnabled = true;
            this.lbRegular.ItemHeight = 16;
            this.lbRegular.Location = new System.Drawing.Point(267, 264);
            this.lbRegular.Name = "lbRegular";
            this.lbRegular.Size = new System.Drawing.Size(136, 148);
            this.lbRegular.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prioritario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Regular";
            // 
            // btnDespachar
            // 
            this.btnDespachar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDespachar.Location = new System.Drawing.Point(172, 434);
            this.btnDespachar.Name = "btnDespachar";
            this.btnDespachar.Size = new System.Drawing.Size(126, 44);
            this.btnDespachar.TabIndex = 9;
            this.btnDespachar.Text = "Despachar";
            this.btnDespachar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 499);
            this.Controls.Add(this.btnDespachar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbRegular);
            this.Controls.Add(this.lbPrioritario);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbEnvioPrioritario);
            this.Controls.Add(this.tbNumPedido);
            this.Controls.Add(this.lblNumPedido);
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

