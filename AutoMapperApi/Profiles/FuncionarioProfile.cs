using AutoMapper;
using AutoMapperApi.DTOs;
using AutoMapperApi.Models;
using AutoMapperApi.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperApi.Profiles
{
    public class FuncionarioProfile : Profile
    {
        public FuncionarioProfile()
        {
            CreateMap<FuncionarioDto, Funcionario>()
                .ForMember(dest => dest.Nome, map =>
                    map.MapFrom(src => src.NomeCompleto.Split( )[0]))
                .ForMember(dest => dest.Sobrenome, map =>
                    map.MapFrom(src => src.NomeCompleto.Split( )[1]))
                .ForMember(dest => dest.Sexo, map =>
                    map.MapFrom(src => src.Sexo == "M" ? Sexo.Masculino : Sexo.Feminino))
                .ForMember(dest => dest.EstaAtivo, map =>
                    map.MapFrom(src => src.Salario > 0 ? true : false))
                .ReverseMap();
                

            CreateMap<Endereco, EnderecoDto>()
                .ReverseMap();
        }
    }
}
