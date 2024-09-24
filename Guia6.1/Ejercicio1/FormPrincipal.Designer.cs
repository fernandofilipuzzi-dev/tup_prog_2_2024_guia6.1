namespace Ejercicio1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProcesar = new System.Windows.Forms.Button();
            this.tbVer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnString = new System.Windows.Forms.RadioButton();
            this.rbtnRegex = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(597, 36);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(123, 79);
            this.btnProcesar.TabIndex = 0;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // tbVer
            // 
            this.tbVer.Location = new System.Drawing.Point(13, 36);
            this.tbVer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbVer.Multiline = true;
            this.tbVer.Name = "tbVer";
            this.tbVer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbVer.Size = new System.Drawing.Size(562, 168);
            this.tbVer.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ver";
            // 
            // rbtnString
            // 
            this.rbtnString.AutoSize = true;
            this.rbtnString.Location = new System.Drawing.Point(597, 133);
            this.rbtnString.Name = "rbtnString";
            this.rbtnString.Size = new System.Drawing.Size(66, 24);
            this.rbtnString.TabIndex = 11;
            this.rbtnString.TabStop = true;
            this.rbtnString.Text = "string";
            this.rbtnString.UseVisualStyleBackColor = true;
            // 
            // rbtnRegex
            // 
            this.rbtnRegex.AutoSize = true;
            this.rbtnRegex.Location = new System.Drawing.Point(597, 177);
            this.rbtnRegex.Name = "rbtnRegex";
            this.rbtnRegex.Size = new System.Drawing.Size(66, 24);
            this.rbtnRegex.TabIndex = 12;
            this.rbtnRegex.TabStop = true;
            this.rbtnRegex.Text = "regex";
            this.rbtnRegex.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 213);
            this.Controls.Add(this.rbtnRegex);
            this.Controls.Add(this.rbtnString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbVer);
            this.Controls.Add(this.btnProcesar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Ejercicio 1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox tbVer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnString;
        private System.Windows.Forms.RadioButton rbtnRegex;
    }
}

