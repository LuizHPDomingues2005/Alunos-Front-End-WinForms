using System;
using System.Net.Http;
using System.Windows.Forms;



namespace apAlunos
{
    public partial class FrmAlunos : Form
    {

        Aluno aluno = new Aluno();

        public FrmAlunos()
        {
            InitializeComponent();
        }

        void AtualizarCampos(int operacao)
        {
            if (operacao == 1)
            {
                btnBuscar.Enabled = true;
                btnBuscar.Visible = true;

                btnInserir.Enabled = false;
                btnInserir.Visible = false;

                lbRa.Visible = false;
                lbNome.Visible = false;
                lbCep.Visible = false;
                lbComplemento.Visible = false;
                lbNumResi.Visible = false;

                txtRa.Visible = false;
                txtNome.Visible = false;
                txtCep.Visible = false;
                txtComplemento.Visible = false;
                txtNumResi.Visible = false;
            }

            if (operacao == 2)
            {
                btnBuscar.Enabled = false;
                btnBuscar.Visible = true;

                btnInserir.Enabled = false;
                btnInserir.Visible = false;

                lbRa.Visible = true;
                lbNome.Visible = false;
                lbCep.Visible = false;
                lbComplemento.Visible = false;
                lbNumResi.Visible = false;

                txtRa.Visible = true;
                txtNome.Visible = false;
                txtCep.Visible = false;
                txtComplemento.Visible = false;
                txtNumResi.Visible = false;
            }

            if (operacao == 3)
            {
                btnBuscar.Enabled = false;
                btnBuscar.Visible = false;

                btnInserir.Enabled = false;
                btnInserir.Visible = true;

                lbRa.Visible = true;
                lbNome.Visible = true;
                lbCep.Visible = true;
                lbComplemento.Visible = true;
                lbNumResi.Visible = true;

                txtRa.Visible = true;
                txtNome.Visible = true;
                txtCep.Visible = true;
                txtComplemento.Visible = true;
                txtNumResi.Visible = true;
            }


        }

        void BotaoInserir()
        {

            if (rbInsert.Checked &&
               txtRa.Text.Length == 5 &&
               txtNome.Text != "" &&
               txtCep.Text.Length == 8 &&
               txtComplemento.Text != "" &
               txtNumResi.Text != "")
                btnInserir.Enabled = true;
            else
                btnInserir.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (rbGetAll.Checked)
            {
                ClientSW client = new ClientSW();
                client.GetAllAlunos("http://localhost:3000/alunos", dgvAlunos);

                dgvAlunos.Visible = true;
            }
            if (rbGetOne.Checked)
            {
                ClientSW client = new ClientSW();

                int ra = int.Parse(txtRa.Text);
                client.GetAlunoByRa("http://localhost:3000/alunos", dgvAlunos, ra);

                dgvAlunos.Visible = true;
            }
        }

        private void rbGetAll_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarCampos(1);
        }

        private void rbGetOne_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarCampos(2);

        }

        private void rbInsert_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarCampos(3);
        }

        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar.Visible = false;
        }

        private void rbDelete_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar.Visible = false;
        }

        private void txtRa_TextChanged(object sender, EventArgs e)
        {
            if (txtRa.Text.Length == 5 && rbGetOne.Checked)
                    btnBuscar.Enabled = true;
            else
                    btnBuscar.Enabled = false;

            BotaoInserir();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            BotaoInserir();
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            BotaoInserir();
        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {
            BotaoInserir();
        }

        private void txtNumResi_TextChanged(object sender, EventArgs e)
        {
            BotaoInserir();
        }
    }
}