using AutoMapper;
using AutoMapperApi.DTOs;
using AutoMapperApi.Models;
using AutoMapperApi.Models.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        private readonly IMapper mapper;

        public FuncionariosController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post (FuncionarioDto dto)
        {
            //Funcionario funcionario = new Funcionario
            //{
            //    Nome = dto.NomeCompleto.Split(" ")[0],
            //    Sobrenome = dto.NomeCompleto.Split(" ")[1],
            //    Sexo = (Sexo)Enum.Parse(typeof(Sexo), dto.Sexo),
            //    Endereco = new Endereco { Cidade = dto.Endereco.Cidade },
            //    EstaAtivo = dto.Salario > 0 ? true : false,
            //    Salario = dto.Salario
            //};

            var funcionario = mapper.Map<Funcionario>(dto);

            return Ok(funcionario);
        }
    }
}
