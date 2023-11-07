using Microsoft.AspNetCore.Mvc;
using picpay_desafio.DTO;
using picpay_desafio.Interface.Services;

namespace picpay_desafio.Controllers;


[ApiController]
[Route("users")]
public class UserController : ControllerBase
{
    private readonly IUserService _service;

    public UserController(IUserService service)
    {
        _service = service;
    }
    [HttpGet]
    public async Task<List<UserDTO>> GetAll()
    {
        return await _service.GetAll();
    }
}
