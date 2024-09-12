﻿namespace RegexEditor
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
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbContenido = new System.Windows.Forms.TextBox();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.btnVerResultado = new System.Windows.Forms.Button();
            this.tbPatron = new System.Windows.Forms.TextBox();
            this.chx = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbContenido
            // 
            this.tbContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContenido.Location = new System.Drawing.Point(15, 31);
            this.tbContenido.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbContenido.Multiline = true;
            this.tbContenido.Name = "tbContenido";
            this.tbContenido.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbContenido.Size = new System.Drawing.Size(1059, 109);
            this.tbContenido.TabIndex = 8;
            // 
            // tbResultado
            // 
            this.tbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResultado.Location = new System.Drawing.Point(15, 326);
            this.tbResultado.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbResultado.Multiline = true;
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResultado.Size = new System.Drawing.Size(1059, 259);
            this.tbResultado.TabIndex = 9;
            // 
            // btnVerResultado
            // 
            this.btnVerResultado.Location = new System.Drawing.Point(1100, 59);
            this.btnVerResultado.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnVerResultado.Name = "btnVerResultado";
            this.btnVerResultado.Size = new System.Drawing.Size(184, 122);
            this.btnVerResultado.TabIndex = 10;
            this.btnVerResultado.Text = "Ver Resultado";
            this.btnVerResultado.UseVisualStyleBackColor = true;
            this.btnVerResultado.Click += new System.EventHandler(this.btnVerResultado_Click);
            // 
            // tbPatron
            // 
            this.tbPatron.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPatron.Location = new System.Drawing.Point(15, 181);
            this.tbPatron.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbPatron.Multiline = true;
            this.tbPatron.Name = "tbPatron";
            this.tbPatron.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPatron.Size = new System.Drawing.Size(1059, 109);
            this.tbPatron.TabIndex = 11;
            // 
            // chx
            // 
            this.chx.AutoSize = true;
            this.chx.Location = new System.Drawing.Point(1118, 194);
            this.chx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chx.Name = "chx";
            this.chx.Size = new System.Drawing.Size(133, 24);
            this.chx.TabIndex = 12;
            this.chx.Text = "Imprimir Group";
            this.chx.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Patrón";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Salida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Contenido";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 601);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chx);
            this.Controls.Add(this.tbPatron);
            this.Controls.Add(this.btnVerResultado);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.tbContenido);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Regex editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbContenido;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Button btnVerResultado;
        private System.Windows.Forms.TextBox tbPatron;
        private System.Windows.Forms.CheckBox chx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

