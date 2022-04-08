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
    public ActionResult<UsuarioViewModel> Post(Usuario usuario)
    {
        var usuarioViewModel = _mapper.Map<UsuarioViewModel>(usuario);
        return Ok(usuarioViewModel);
    }

}
