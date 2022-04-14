using AutoMapper;
using estudos_automapper.Extensions;
using estudos_automapper.Models;
using estudos_automapper.ViewModel;

namespace estudos_automapper.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup(){

            #region Usuario para UsuarioViewModel

                CreateMap<Usuario, UsuarioViewModel>()
                                            .ForMember(uv => uv.Idade,
                                                m => m.MapFrom(a => a.DataNascimento.CalcularIdade())
                                            );

            #endregion

        }
    }
}