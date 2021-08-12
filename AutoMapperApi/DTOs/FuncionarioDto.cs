using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperApi.DTOs
{
    public class FuncionarioDto
    {
        public string NomeCompleto { get; set; }
        public string Sexo { get; set; }
        public decimal Salario { get; set; }
        public EnderecoDto Endereco { get; set; }
    }
}
