using AutoMapperApi.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperApi.Models
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public Sexo Sexo { get; set; }
        public decimal Salario { get; set; }
        public bool EstaAtivo { get; set; }
        public Endereco Endereco { get; set; }
    }
}
