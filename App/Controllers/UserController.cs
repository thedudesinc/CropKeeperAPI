using CropKeeperApi.Domain.Abstractions.Services;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepository.Controllers;

[ApiController]
[Route("api/user")]
public class UserController
{
    private readonly IUserService _service;

    public UserController(IUserService service)
    {
        _service = service;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status202Accepted)]
    public async Task<ActionResult<UserOutput>> Create([FromBody] UserInput user, CancellationToken ct)
    {
        return await _service.Create(user, ct);
    }

    [HttpPut]
    [Route("{id}")]
    public async Task<ActionResult<UserOutput>> Update(Guid id, [FromBody] UserInput user, CancellationToken ct)
    {
        return await _service.Update(id, user, ct);
    }
}

