using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace prj_cliente
{
    public partial class frmClientes : Form
    {
        OleDbConnection conn = Conexao.obterConexao();
        OleDbDataReader dr_cli;
        BindingSource bs_cli = new BindingSource();
        String _query;

        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private bool valida()
        {
            bool erro = true;
            if (txbNome.Text == "")
            {
                MessageBox.Show("Nome inválido. Redigite!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbNome.Focus();
            }
            else if (txbEmail.Text == "")
            {
                MessageBox.Show("E-Mail inválido. Redigite!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbEmail.Focus();
            }
            else if (txbRg.Text == "")
            {
                MessageBox.Show("RG inválido. Redigite!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbRg.Focus();
            }
            else if (txbCpf.Text == "")
            {
                MessageBox.Show("CPF inválido. Redigite!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbCpf.Focus();
            }
            else if (txbEndereco.Text == "")
            {
                MessageBox.Show("Endereço inválido. Redigite!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbEndereco.Focus();
            }
            else if (txbTelefone.Text == "")
            {
                MessageBox.Show("Telefone inválido. Redigite!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbTelefone.Focus();
            }
            else
            {
                erro = false;
            }
            return erro;
        }

        private void igualar_text()
        {
            lblNumCod.DataBindings.Add("Text", bs_cli, "Cod_cliente");
            lblNumCod.DataBindings.Clear();
            txbNome.DataBindings.Add("Text", bs_cli, "Nome_Cliente");
            txbNome.DataBindings.Clear();
            dtpDataNasc.DataBindings.Add("Text", bs_cli, "Dt_Nasc");
            dtpDataNasc.DataBindings.Clear();
            txbEmail.DataBindings.Add("Text", bs_cli, "Email");
            txbEmail.DataBindings.Clear();
            cmbSexo.DataBindings.Add("Text", bs_cli, "Sexo");
            cmbSexo.DataBindings.Clear();
            cmbEstCivil.DataBindings.Add("Text", bs_cli, "Estado_Civil");
            cmbEstCivil.DataBindings.Clear();
            txbRg.DataBindings.Add("Text", bs_cli, "RG");
            txbRg.DataBindings.Clear();
            txbCpf.DataBindings.Add("Text", bs_cli, "CPF");
            txbCpf.DataBindings.Clear();
            txbEndereco.DataBindings.Add("Text", bs_cli, "Endereco");
            txbEndereco.DataBindings.Clear();
            txbTelefone.DataBindings.Add("Text", bs_cli, "Telefone");
            txbTelefone.DataBindings.Clear();
            dtpDataCad.DataBindings.Add("Text", bs_cli, "Dt_cadastro");
            dtpDataCad.DataBindings.Clear();
        }

        private void carregar_grid()
        {
            _query = "Select * from tbl_cli";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_cli = _dataCommand.ExecuteReader();

            if (dr_cli.HasRows == true)
            {
                bs_cli.DataSource = dr_cli;
                dgv_clientes.DataSource = bs_cli;
                igualar_text();
            }
            else
            {
                MessageBox.Show("Não há clientes cadastrados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnPrim_Click(object sender, EventArgs e)
        {
            bs_cli.MoveFirst();
            igualar_text();
        }

        private void btnUlt_Click(object sender, EventArgs e)
        {
            bs_cli.MoveLast();
            igualar_text();
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            if (bs_cli.Position + 1 == bs_cli.Count)
            {
                MessageBox.Show("Fim de arquivo encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bs_cli.MoveNext();
                igualar_text();
            }
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            if (bs_cli.Position == 0)
            {
                MessageBox.Show("Início de arquivo encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bs_cli.MovePrevious();
                igualar_text();
            }
        }

        private void dgv_clientes_Click(object sender, EventArgs e)
        {
            igualar_text();
        }

        private void dgv_clientes_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_text();
        }

        private void txbPesquisa_TextChanged(object sender, EventArgs e)
        {
            _query = "Select * from tbl_cli where Nome_Cliente like '" + txbPesquisa.Text + "%'";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_cli = _dataCommand.ExecuteReader();

            if (dr_cli.HasRows == true)
            {
                bs_cli.DataSource = dr_cli;
            }
            else
            {
                MessageBox.Show("Não há clientes cadastrados com este nome!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPesquisa.Text = "";
            }
        }
        private void limpar()
        {
            lblNumCod.Text = "";
            txbNome.Clear();
            txbEmail.Clear();
            txbRg.Clear();
            txbCpf.Clear();
            txbEndereco.Clear();
            txbTelefone.Clear();
            dtpDataCad.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtpDataNasc.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void btnLimparInf_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
            txbNome.Focus();
        }

        private void btnInc_Click(object sender, EventArgs e)
        {
            bool teste = valida();
            if (teste == false)
            {
                _query = "Insert into tbl_cli (Nome_Cliente,Email,Dt_Nasc,Sexo,Estado_Civil,RG, CPF, Endereco, Telefone, Dt_Cadastro) Values ";
                _query += "('" + txbNome.Text + "','" + txbEmail.Text + "','" + dtpDataNasc.Text + "','" + cmbSexo.Text + "','" + cmbEstCivil.Text + "','" + txbRg.Text + "','" + txbCpf.Text + "','" + txbEndereco.Text + "','" + txbTelefone.Text + "','" + dtpDataCad.Text + "')";
                try
                {
                    OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                    _dataCommand.ExecuteNonQuery();
                    carregar_grid();
                    MessageBox.Show("Incluído com sucesso!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception)
                {
                    MessageBox.Show("Problemas com a Inclusão!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            bool teste = valida();
            if (teste == false)
            {
                _query = "Update tbl_cli set Nome_Cliente ='" + txbNome.Text + "',";
                _query += "Dt_Nasc = '" + dtpDataNasc.Text + "',";
                _query += "Email = '" + txbEmail.Text + "',";
                _query += "Sexo = '" + cmbSexo.Text + "',";
                _query += "Estado_Civil = '" + cmbEstCivil.Text+ "',";
                _query += "CPF = '" + txbCpf.Text + "',";
                _query += "Endereco = '" + txbEndereco.Text + "',";
                _query += "Telefone = '" + txbTelefone.Text + "',";
                _query += "Dt_Cadastro = '" + dtpDataCad.Text + "',";
                _query += "RG = '" + txbRg.Text + "'";
                _query += "where Cod_Cliente like '" + lblNumCod.Text + "'";

                try
                {
                    OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                    _dataCommand.ExecuteNonQuery();
                    carregar_grid();
                    MessageBox.Show("Alterado com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception)
                {
                    MessageBox.Show("Problemas com a Alteração!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnExc_Click(object sender, EventArgs e)
        {
            _query = "delete from tbl_cli where Cod_Cliente like '" + lblNumCod.Text + "'";

            try
            {
                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                _dataCommand.ExecuteNonQuery();
                carregar_grid();
                MessageBox.Show("Excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com a Exclusão!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
