using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Linq;
using System;

public class ClientSW
{

    public ClientSW() { }

    public async void GetAllAlunos(string url, DataGridView dgvAlunos)
    {
        using(var client = new HttpClient())
        {
            try
            {
                using (var response = await client.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var alunosJson = await response.Content.ReadAsStringAsync();
                        dgvAlunos.DataSource = JsonConvert.DeserializeObject<apAlunos.Aluno[]>(alunosJson).ToList();
                    }
                    else
                        MessageBox.Show("Não foi possível recuperar os alunos." + response.StatusCode);
                }
            }
            catch (Exception) { MessageBox.Show("Erro ao se conectar."); }
        }
    }
}

