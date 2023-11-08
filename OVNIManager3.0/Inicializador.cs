using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OVNIManager3._0
{
    public partial class Inicializador : Form
    {
        public Inicializador()
        {
            InitializeComponent();
        }

        private void cmbPlaneta_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Inicializador_Load(object sender, EventArgs e)
        {
            cmbPlaneta.DataSource = BibliotecaOVNI.OVNI.PlanetasValidos;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Obter informações do form:
            int maxTripulantes = (int)nudeTripulantes.Value;
            int maxAbduzidos = (int)nudeAbduzidos.Value;
            string planetaOrigem = cmbPlaneta.Text;

            //Instanciar o OVNI:

            BibliotecaOVNI.OVNI ovni = new BibliotecaOVNI.OVNI(maxTripulantes, maxAbduzidos, planetaOrigem);

            //Abrir janela do painel:
            Painel janela = new Painel(ovni);
            //Abrir a janela:
            janela.ShowDialog();

        }
    }
}
