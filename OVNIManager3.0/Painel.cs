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
        public Painel(BibliotecaOVNI.OVNI ovni)
        {
            InitializeComponent();
        }
        //método para atualizar dados:
        
        public void AtualizarDados()
        {
            lblAbduzidoss.Text 
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
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {

        }

        private void bntDesligar_Click(object sender, EventArgs e)
        {
            if (ovni.Desligar() == false)
                {
                MessageBox.Show("A nave já está desligada");
            }
        }
    }
}
