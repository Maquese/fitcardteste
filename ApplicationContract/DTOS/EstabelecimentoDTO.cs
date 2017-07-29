using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationContract.DTOS
{
    public class EstabelecimentoDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public CategoriaDTO Categoria { get; set; }
        public bool Status { get; set; }

        public Guid IdCategoria { get; set; }

    }
}
