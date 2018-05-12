using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadroMedalhas
{
    public partial class FrmQuadro : Form
    {
        private DataTable dt = new DataTable();
        private BindingSource bds = new BindingSource();

        public FrmQuadro()
        {
            InitializeComponent();
            BotoesDeslogado();
            CarregarGrid();
        }

        public void BotoesDeslogado()
        {
            btnDeslogar.Hide();
            btnEditar.Hide();
            btnNovo.Hide();
            btnRemover.Hide();
            btnLogar.Show();
        }

        public void BotoesLogado()
        {
            btnDeslogar.Show();
            btnEditar.Show();
            btnNovo.Show();
            btnRemover.Show();
            btnLogar.Hide();
        }

        private void CarregarGrid()
        {
            QuadroMedalhas.Banco.TblPaises paises = new Banco.TblPaises();
            dt = paises.SelecionarGrid();
            bds.DataSource = dt;
            grdQuadro.DataSource = bds;

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            if(frmLogin.ShowDialog() == DialogResult.OK)
            {
                BotoesLogado();
            }
                
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            QuadroMedalhas.Telas.FrmPais frmPais = new Telas.FrmPais(false, null);
            frmPais.ShowDialog();
            CarregarGrid();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja mesmo remover o país selecionado?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DataRowView drv = (DataRowView)bds.Current;
                QuadroMedalhas.Banco.TblPaises pais = new Banco.TblPaises();
                pais.id = Convert.ToInt16(drv["id"]);

                pais.Excluir();
                CarregarGrid();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            QuadroMedalhas.Banco.TblPaises pais = new Banco.TblPaises();
            QuadroMedalhas.Banco.TblContinentes continente = new Banco.TblContinentes();
            DataRowView drv = (DataRowView)bds.Current;

            pais.id = Convert.ToInt16(drv["id"]);
            pais.nome = drv["nome"].ToString();
            pais.sigla = drv["sigla"].ToString();
            pais.ouro = Convert.ToInt16(drv["ouro"]);
            pais.prata = Convert.ToInt16(drv["prata"]);
            pais.bronze = Convert.ToInt16(drv["bronze"]);
            pais.id_continente = Convert.ToInt16((drv["id_continente"]));
            string nome_continente = drv["continente"].ToString();
            pais.bandeira = (byte[])drv["bandeira"];

            QuadroMedalhas.Telas.FrmPais frmPais = new Telas.FrmPais(true, pais);
            frmPais.ShowDialog();
            CarregarGrid();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            bds.Filter = "nome LIKE '%" + txtFiltro.Text + "%'";
      
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            BotoesDeslogado();
        }
    }
}
