using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Models
{
    public class Produto
    {
        public Guid FornecedorId { get; set; }

        public string Nome { get; set; }
        public string Descrica { get; set; }
        public string Imagem { get; set; }
        public string Valor { get; set; }
        public bool DataCadastro { get; set; }

        /*EF Relation*/
        public Fornecedor Fornecedor { get; set; }
    }
}
