namespace EmpresaMensajeria
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbProducto = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.chUrgente = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRegulares = new System.Windows.Forms.Label();
            this.lbUrgentes = new System.Windows.Forms.Label();
            this.btnDespachar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del producto:";
            // 
            // tbProducto
            // 
            this.tbProducto.Location = new System.Drawing.Point(193, 39);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.Size = new System.Drawing.Size(269, 26);
            this.tbProducto.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(193, 137);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(157, 44);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // chUrgente
            // 
            this.chUrgente.AutoSize = true;
            this.chUrgente.Location = new System.Drawing.Point(193, 88);
            this.chUrgente.Name = "chUrgente";
            this.chUrgente.Size = new System.Drawing.Size(93, 24);
            this.chUrgente.TabIndex = 4;
            this.chUrgente.Text = "Urgente";
            this.chUrgente.UseVisualStyleBackColor = true;
            this.chUrgente.CheckedChanged += new System.EventHandler(this.chUrgente_CheckedChanged);
            this.chUrgente.Click += new System.EventHandler(this.chUrgente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Productos Regulares:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Productos Urgentes:";
            // 
            // lbRegulares
            // 
            this.lbRegulares.AutoSize = true;
            this.lbRegulares.Location = new System.Drawing.Point(26, 281);
            this.lbRegulares.Name = "lbRegulares";
            this.lbRegulares.Size = new System.Drawing.Size(108, 20);
            this.lbRegulares.TabIndex = 7;
            this.lbRegulares.Text = "Sin Productos";
            // 
            // lbUrgentes
            // 
            this.lbUrgentes.AutoSize = true;
            this.lbUrgentes.Location = new System.Drawing.Point(255, 281);
            this.lbUrgentes.Name = "lbUrgentes";
            this.lbUrgentes.Size = new System.Drawing.Size(108, 20);
            this.lbUrgentes.TabIndex = 8;
            this.lbUrgentes.Text = "Sin Productos";
            // 
            // btnDespachar
            // 
            this.btnDespachar.Location = new System.Drawing.Point(198, 358);
            this.btnDespachar.Name = "btnDespachar";
            this.btnDespachar.Size = new System.Drawing.Size(152, 62);
            this.btnDespachar.TabIndex = 9;
            this.btnDespachar.Text = "Despachar";
            this.btnDespachar.UseVisualStyleBackColor = true;
            this.btnDespachar.Click += new System.EventHandler(this.btnDespachar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.btnDespachar);
            this.Controls.Add(this.lbUrgentes);
            this.Controls.Add(this.lbRegulares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chUrgente);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbProducto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "App mensajeria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckBox chUrgente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRegulares;
        private System.Windows.Forms.Label lbUrgentes;
        private System.Windows.Forms.Button btnDespachar;
    }
}

