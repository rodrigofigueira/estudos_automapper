using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using estudos_automapper.ViewModel;
using estudos_automapper.Models;

namespace estudos_automapper.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{

    private readonly IMapper _mapper;

    public UsuarioController(IMapper mapper)
    {
        _mapper = mapper;
    }

    [HttpPost]
    [Route("padrao")]
    public ActionResult<UsuarioViewModel> Post(Usuario usuario)
    {
        var usuarioViewModel = _mapper.Map<UsuarioViewModel>(usuario);
        return Ok(usuarioViewModel);
    }

    [HttpPost]
    [Route("convensao_nomes_diferentes")]
    public ActionResult<ConvensaoNomeDestino> ConvensaoNomes(ConvensaoNomeOrigem convensaoOrigem){
        ConvensaoNomeDestino convensaoDestino = _mapper.Map<ConvensaoNomeDestino>(convensaoOrigem);
        return Ok(convensaoDestino);
    }

}
