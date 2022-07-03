using System;

namespace apAlunos
{
    public class Aluno
    {

        public int ra { get; set; }
        public void setRa(int ra)
        {
            string raToString = ra.ToString();
            if (raToString.Length != 5)
                throw new Exception("Formato do RA inválido. O RA deve conter 5 caracteres.");

            this.ra = ra;
        }

        public string nome { get; set; }
        public void setNome(string nome)
        {
            if (nome == null && nome.Equals(""))
                throw new Exception("Nome não fornecido.");

            this.nome = nome;
        }

        public int cep { get; set; }
        public void setCep(int cep)
        {
            string cepToString = cep.ToString();
            if (cepToString.Length != 8)
                throw new Exception("CEP em formato incorreto! CEP deve conter 8 caracteres.");

            this.cep = cep;
            
        }

        public string complemento { get; set; }
        public void setComplemento(string complemento)
        {
            if (complemento == null && complemento.Equals(""))
                throw new Exception("Complemento não fornecido.");

            this.complemento = complemento;
        }

        public int numeroresidencia { get; set; }
        public void setNumeroresidencia(int numeroresidencia)
        {
            if (numeroresidencia <= 0)
                throw new Exception("Número de residência inválido.");

            this.numeroresidencia = numeroresidencia;
        }

        public Aluno() { }

        public Aluno(int ra,
                     string nome,
                     int cep,
                     string comlemento,
                     int numeroresidencia)
        {
            this.setRa(ra);
            this.setNome(nome);
            this.setCep(cep);
            this.setComplemento(complemento);
            this.setNumeroresidencia(numeroresidencia);
            
        }

        public Aluno(Aluno modelo)
        {
            if (modelo == null)
                throw new Exception("Modelo não encontrado.");

            this.ra = modelo.ra;
            this.nome = modelo.nome;
            this.cep = modelo.cep;
            this.complemento = modelo.complemento;
            this.numeroresidencia = modelo.numeroresidencia;

        }
        
    }


}
