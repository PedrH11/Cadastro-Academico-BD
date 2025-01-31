using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastroBD
{
    public partial class FormCurso : MaterialForm
    {
        bool isAlteracao = false;
        string conexao = @"server= 127.0.0.1;" +
                       "uid=root;" +
                       "pwd=Tiao1108@;" +
                       "database=academico";
        public FormCurso()
        {
            InitializeComponent();
        }

        private void Salvar()
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "";
            if (isAlteracao)
            {
                sql = "UPDATE curso SET " +
                      "cod_curso = @cod_curso, " +
                      "nome_curso = @nome_curso, " +
                      "nivel = @nivel, " +
                      "duracao = @duracao, " +
                      "area = @area, " +
                      "periodo = @periodo " +
                      " WHERE id_curso = @id_curso";
            }
            else
            {
                sql = "INSERT INTO curso " +
                      " (cod_curso, nome_curso, nivel, duracao, " +
                      " area, periodo) " +
                      " VALUES " +
                      " (@cod_curso, @nome_curso, @nivel, @duracao, " +
                      " @area, @periodo)";
            }

            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@cod_curso", txtCodCurso.Text);
            cmd.Parameters.AddWithValue("@nome_curso", txtNomeCurso.Text);
            cmd.Parameters.AddWithValue("@nivel", cbxNivel.Text);
            cmd.Parameters.AddWithValue("@duracao", cbxDuracao.Text);
            cmd.Parameters.AddWithValue("@area", cbxArea.Text);
            cmd.Parameters.AddWithValue("@periodo", cbxPeriodo.Text);
            if (isAlteracao)
                cmd.Parameters.AddWithValue("@id_curso", txtIdCurso.Text);
            cmd.Prepare();  //verifica se as instruções estão certas
            cmd.ExecuteNonQuery(); //executa e retorna num de linhas que inseriu
            con.Close();
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabPageCadastroCurso.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(txtCodCurso.Text))
            {
                MessageBox.Show("Código do curso obrigatório!");
                txtCodCurso.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNomeCurso.Text))
            {
                MessageBox.Show("Nome do curso obrigatório!");
                txtNomeCurso.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbxNivel.Text))
            {
                MessageBox.Show("Nível do curso obrigatório!");
                cbxNivel.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbxNivel.Text))
            {
                MessageBox.Show("Nível do curso obrigatório!");
                cbxNivel.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbxNivel.Text))
            {
                MessageBox.Show("Nível do curso obrigatório!");
                cbxNivel.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbxDuracao.Text))
            {
                MessageBox.Show("Nível do curso obrigatório!");
                cbxDuracao.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbxArea.Text))
            {
                MessageBox.Show("Nível do curso obrigatório!");
                cbxArea.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbxPeriodo.Text))
            {
                MessageBox.Show("Nível do curso obrigatório!");
                cbxPeriodo.Focus();
                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                Salvar();
                TabControlCadastroCurso.SelectedIndex = 1;
            }
        }

        private void CarregaGrid()
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "SELECT * FROM curso";
            var sqlAd = new MySqlDataAdapter(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            dataGridViewCurso.DataSource = dt;
            con.Close();
        }

        private void tabPageConsultaCurso_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void Editar()
        {
            if (dataGridViewCurso.SelectedRows.Count > 0)
            {
                isAlteracao = true;
                var linha = dataGridViewCurso.SelectedRows[0];
                txtIdCurso.Text = linha.Cells["id_curso"].Value.ToString();
                txtCodCurso.Text = linha.Cells["cod_curso"].Value.ToString();
                txtNomeCurso.Text = linha.Cells["nome_curso"].Value.ToString();
                cbxNivel.Text = linha.Cells["nivel"].Value.ToString();
                cbxDuracao.Text = linha.Cells["duracao"].Value.ToString();
                cbxArea.Text = linha.Cells["area"].Value.ToString();
                cbxPeriodo.Text = linha.Cells["periodo"].Value.ToString();
                TabControlCadastroCurso.SelectedIndex = 0;
                txtCodCurso.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum curso!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void dataGridViewCurso_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar();
        }

        private void Excluir(int id_curso)
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "DELETE FROM curso WHERE id_curso=@id_curso";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id_curso", id_curso);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewCurso.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir?", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id_curso = (int)dataGridViewCurso.SelectedRows[0].Cells["id_curso"].Value;
                    Excluir(id_curso);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione algum curso!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNovoCurso_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            TabControlCadastroCurso.SelectedIndex = 0;
            txtCodCurso.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Atenção: Informações não salvas serão perdidas. \r\n" +
                                 "Deseja cancelar?", "Pergunta", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                TabControlCadastroCurso.SelectedIndex = 1;
            }
        }
    }
}
