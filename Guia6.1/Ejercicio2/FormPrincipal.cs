using Ejercicio2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            tbContenido.Text = @"                                            Paraná, 20 de Diciembre de 2024
Sr(a) Medina Noemí, El despacho JURÍDICO GUTIERREZ & ASOCIADOS, mediante el
presente EXHORTO EXTRA JUDICIAL de  cobro se le Notifica:
Basados en el  en  el préstamo emitido por el corporativo LEANDRO KRUGER,
se ejecutará a las 16:00 horas del día 1 de enero del año 2024, UNA
DILIGENCIA DE RECUPERACIÓN DE CARTERA EN SU DOMICILIO, debido a la EVASIÓN 
DE PAGO consumada contra mi cliente, por el adeudo de su crédito por la
cantidad de $6.000,00 (seis mil pesos).
";
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string contenido=tbContenido.Text;
            IProcesable procesar = null;
            if (rbtnString.Checked)
            {
                procesar = new StringProcesableImpl();
            }
            else if (rbtnRegex.Checked)
            {
                procesar = new RegexProcesableImpl();
            }
    
            Intimacion intimacion = procesar.Procesar(contenido);

            tbVer.Clear();
            tbVer.Text += $"{intimacion} \r\n";
        }
    }
}
