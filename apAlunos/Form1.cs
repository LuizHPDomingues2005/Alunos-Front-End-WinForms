using System;
using System.Net.Http;
using System.Windows.Forms;



namespace apAlunos
{
    public partial class Form1 : Form
    {
    
        Aluno aluno = new Aluno();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClientSW client = new ClientSW();
            client.GetAllAlunos("http://localhost:3000/alunos", dgvAlunos);
        }
    }
}
