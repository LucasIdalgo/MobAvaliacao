using System;
using System.Collections.Generic;
using System.Text;

namespace MobAvaliacao.Models
{
    public class ModelEntidade
    {
        public int IdEntidade { get; set; }

        public string DocumentoFederal { get; set; }

        public string Nome { get; set; }

        public DateTime DataNasc { get; set; }

        public string Sexo { get; set; }

        public bool Ativo { get; set; }

        public string CEP { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public string Referencia { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }

        public string Telefone1 { get; set; }

        public string Telefone2 { get; set; }

        public ModelEntidade()
        {
            IdEntidade = 0;
            DocumentoFederal = "";
            Nome = "";
            DataNasc = DateTime.MinValue;
            Sexo = "";
            Ativo = true;
            CEP = "";
            Logradouro = "";
            Bairro = "";
            Numero = 0;
            Complemento = null;
            Referencia = null;
            Cidade = "";
            UF = "";
            Telefone1 = "";
            Telefone2 = null;
        }
    }
}
