using CropKeeperApi.App.Requests;
using CropKeeperApi.Domain.Abstractions.Services;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepository.Controllers;

[Authorize]
[ApiController]
[Route("api/user")]
public class UserController
{
    private readonly IUserService _service;

    public UserController(IUserService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IEnumerable<UserOutput>> Get(CancellationToken ct)
    {
        return await _service.Get(ct);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<UserOutput>> Get(Guid id, CancellationToken ct)
    {
        return await _service.Get(id, ct);
    }

    [HttpPost]
    [AllowAnonymous]
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

    [HttpDelete]
    [Route("{id}")]
    public async Task Delete(Guid id, CancellationToken ct)
    {
        await _service.Delete(id, ct);
    }

    [HttpPost]
    [Route("verifyEmail")]
    [AllowAnonymous]
    public async Task<ActionResult<bool>> VerifyEmail([FromBody] VerifyEmailRequest verifyEmailRequest, CancellationToken ct)
    {
        return await _service.VerifyEmail(verifyEmailRequest, ct);
    }
}
