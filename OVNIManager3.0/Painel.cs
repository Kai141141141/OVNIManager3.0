using BibliotecaOVNI;
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
    public partial class Painel : Form
    {
        //Objetos globais
        BibliotecaOVNI.OVNI ovni;
        public Painel(BibliotecaOVNI.OVNI ovni)
        {
            InitializeComponent();
            this.ovni = ovni;
            AtualizarDados();
            //Popular o CMD
            cmbPlanetas.DataSource = BibliotecaOVNI.OVNI.PlanetasValidos;
        }
        //método para atualizar dados:
        public void AtualizarDados()
        {
            lblAbduzidoss.Text = "Abduzidos: " + ovni.QtdAbduzidos;
            lblTripulantess.Text = "Tripulantes: " + ovni.QtdTripulantes;
            lblSituacao.Text = "Situação: " + (ovni.Situacao ? "Ligado" : "Desligado");
            btnPlaneta.Text = "Planeta: " + ovni.PlanetaAtual;
            // Ativar/Desativar botões:
            bntLigar.Enabled = !ovni.Situacao;
            bntDesligar.Enabled = ovni.Situacao;
        }




        private void Painel_Load(object sender, EventArgs e)
        {

        }

        private void bntLigar_Click(object sender, EventArgs e)
        {
            if (ovni.Ligar() == false)
            {
                MessageBox.Show("A nave já está ligada");
            }
            AtualizarDados();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            if (ovni.AdicionarTripulante() == true)
            { AtualizarDados(); }
            else
            { MessageBox.Show("Impossível adicionar tripulante. Verifique se a nave está deligada ou se o limite foi excedido!"); }
            {
                
            }

        }

        private void bntDesligar_Click(object sender, EventArgs e)
        {
            if (ovni.Desligar() == false)
            {
                MessageBox.Show("A nave já está desligada");
            }
            AtualizarDados();
        }
        private void cmdMudar_Click(object sender, EventArgs e)

        {
            ovni.MudarPlaneta(cmbPlanetas.Text);
            AtualizarDados();
        }

        private void bntRemover_Click(object sender, EventArgs e)
        {
            if (ovni.RemoverTripulante() == false)
            {
                MessageBox.Show("Impossível remover tripulante o número minímo é 1!");
            }
            AtualizarDados();
                       
           
        }

        private void BntAbduzirr_Click(object sender, EventArgs e)
        {
            if (ovni.Abduzir() == true)
            { AtualizarDados(); }
            else
            {
                MessageBox.Show("Impossível abduzir. Verifique  se o limite foi excedido!");
            }
            
        }

        private void bntDesabduzir_Click(object sender, EventArgs e)
        {
            if (ovni.Desabduzir() == false)
            {
                
                MessageBox.Show("Impossível desabduzir o número minímo de abduzidos é 0!");
            }
            AtualizarDados();







        }

        private void bntRetornar_Click(object sender, EventArgs e)
        {
            if (ovni.RetornarAoPlanetaDeOrigem() == false)
           {
                MessageBox.Show("Você se encontra em seu pais de origem");
           }
            AtualizarDados();
        }
    }
}
