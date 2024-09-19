using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
       
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            List<string> patentes = new List<string>
            {
                "OXY333", "OYZ 013", "AAA 123", "BCD-456", "AB 123 CD", "YZ5432EF", "QW 3456 AB"
            };

            IProcesar procesar = null;
            if (rbtnString.Checked)
            {
                procesar = new StringProcesarImpl();
            }
            else if (rbtnRegex.Checked)
            {
                procesar = new RegexProcesarImpl();
            }


            tbVer.Clear();
            foreach (string patente in patentes)
            {
                string descripcion = procesar.Procesar(patente, out string patenteFormateada);

                tbVer.Text += $"{patenteFormateada} {descripcion} \r\n";
            }
        }
    }
}
