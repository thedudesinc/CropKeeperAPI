using CropKeeperApi.Domain.Abstractions.Repositories;
using CropKeeperApi.Persistance.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepository.Controllers;

[ApiController]
[Route("api/user")]
public class UserController
{
    private readonly IUserRepository _repository;

    public UserController(IUserRepository repository)
    {
        _repository = repository;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status202Accepted)]
    public async Task<ActionResult<User>> Create([FromBody] User user, CancellationToken ct)
    {
        await _repository.Create(user);

        var createdUser = await _repository.Get(user.Id);

        return createdUser;
    }
}

