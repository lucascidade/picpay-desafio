using Microsoft.AspNetCore.Mvc;
using picpay_desafio.DTO;
using picpay_desafio.Interface.Services;

namespace picpay_desafio.Controllers;


[ApiController]
[Route("v1/users")]
public class UserController : ControllerBase
{
    private readonly IUserService _service;


    public UserController(IUserService service)
    {
        _service = service;
    }
    [HttpGet]
    public async Task<ActionResult<List<UserDTO>>> GetAll()
    {
        return Ok(await _service.GetAll());
    }
    [HttpPost]
    public async Task<Guid> Create(UserCreateDTO userCreateDTO)
    {
        return await _service.Create(userCreateDTO);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<UserDTO>> GetById(Guid id)
    {
        return Ok(await _service.GetById(id));
    }

    [HttpDelete("{id}")]
    public async Task Delete(Guid id)
    {
        await _service.DeleteUser(id);
    }

}
