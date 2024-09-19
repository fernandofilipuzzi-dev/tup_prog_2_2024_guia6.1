namespace Ejercicio2
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
            this.rbtnRegex = new System.Windows.Forms.RadioButton();
            this.rbtnString = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVer = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtnRegex
            // 
            this.rbtnRegex.AutoSize = true;
            this.rbtnRegex.Location = new System.Drawing.Point(702, 209);
            this.rbtnRegex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnRegex.Name = "rbtnRegex";
            this.rbtnRegex.Size = new System.Drawing.Size(59, 20);
            this.rbtnRegex.TabIndex = 17;
            this.rbtnRegex.TabStop = true;
            this.rbtnRegex.Text = "regex";
            this.rbtnRegex.UseVisualStyleBackColor = true;
            // 
            // rbtnString
            // 
            this.rbtnString.AutoSize = true;
            this.rbtnString.Location = new System.Drawing.Point(702, 155);
            this.rbtnString.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnString.Name = "rbtnString";
            this.rbtnString.Size = new System.Drawing.Size(57, 20);
            this.rbtnString.TabIndex = 16;
            this.rbtnString.TabStop = true;
            this.rbtnString.Text = "string";
            this.rbtnString.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ver";
            // 
            // tbVer
            // 
            this.tbVer.Location = new System.Drawing.Point(5, 41);
            this.tbVer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbVer.Multiline = true;
            this.tbVer.Name = "tbVer";
            this.tbVer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbVer.Size = new System.Drawing.Size(645, 206);
            this.tbVer.TabIndex = 14;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(660, 41);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(164, 97);
            this.btnProcesar.TabIndex = 13;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 257);
            this.Controls.Add(this.rbtnRegex);
            this.Controls.Add(this.rbtnString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbVer);
            this.Controls.Add(this.btnProcesar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnRegex;
        private System.Windows.Forms.RadioButton rbtnString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVer;
        private System.Windows.Forms.Button btnProcesar;
    }
}

