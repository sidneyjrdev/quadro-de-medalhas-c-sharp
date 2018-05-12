using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuadroMedalhas.Banco;
using System.IO;
using System.Drawing.Imaging;

namespace QuadroMedalhas.Telas
{
    public partial class FrmPais : Form
    {
        bool alterando = false;
        TblPaises pais;
        int id_pais = 0;
        int id_continente = 0;
        byte[] bandeira = null;
        Image imagem = null;

        public FrmPais(bool alterando, TblPaises pais)
        {
            InitializeComponent();
            this.alterando = alterando;
            this.pais = pais;

            TblContinentes continente = new TblContinentes();
            cmbContinente.DataSource = continente.selecionarComboBox();
            cmbContinente.DisplayMember = "nome";
            cmbContinente.ValueMember = "id";
            
            if (alterando)
            {
                this.Text = "Editar país";

                id_pais = pais.id;
                txtNome.Text = pais.nome;
                txtSigla.Text = pais.sigla;
                txtOuro.Text = (pais.ouro).ToString();
                txtPrata.Text = (pais.prata).ToString();
                txtBronze.Text = (pais.bronze).ToString();
                id_continente = pais.id_continente;
                cmbContinente.SelectedValue = pais.id_continente;

                bandeira = pais.bandeira;
                MemoryStream ms = new MemoryStream(bandeira);
                imagem = Image.FromStream(ms);
                imgBandeira.Image = imagem;
            }
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            if (!alterando)
            {
                this.pais = new TblPaises();
            }

            pais.nome = txtNome.Text;
            pais.sigla = txtSigla.Text;
            pais.ouro = Convert.ToInt16(txtOuro.Text);
            pais.prata = Convert.ToInt16(txtPrata.Text);
            pais.bronze = Convert.ToInt16(txtBronze.Text);
            pais.id_continente = Convert.ToInt16(cmbContinente.SelectedValue);
            pais.bandeira = bandeira;

            if (alterando)
            {
                pais.id = id_pais;
                pais.Alterar();

            }
            else
            {
                pais.Inserir();
            }
            Close();
         
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        

        private void btnBandeira_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivo = openFileDialog1.FileName;
                Bitmap bmp = new Bitmap(nomeArquivo);
                imgBandeira.Image = bmp;

                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, ImageFormat.Bmp);
                bandeira = ms.ToArray();
               
            }

        }
    }
}
