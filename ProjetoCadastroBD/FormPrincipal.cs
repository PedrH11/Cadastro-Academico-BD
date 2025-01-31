using ReaLTaiizor.Forms;

namespace ProjetoCadastroBD
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aluno = new FormAluno();
            aluno.MdiParent = this;
            aluno.Show();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var curso = new FormCurso();
            curso.MdiParent = this;
            curso.Show();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }
    }
}
