using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using estudos_automapper.Models;

namespace estudos_automapper.AutoMapper
{
    public class ConvensaoDeNomes : Profile
    {
        public ConvensaoDeNomes()
        {
            CreateMap<ConvensaoNomeOrigem, ConvensaoNomeDestino>();
            SourceMemberNamingConvention = new LowerUnderscoreNamingConvention();
            DestinationMemberNamingConvention = new PascalCaseNamingConvention();
        }    
    }

}