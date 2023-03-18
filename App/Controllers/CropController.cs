using CropKeeperApi.Domain.Abstractions.Services;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepository.Controllers;

[Authorize]
[ApiController]
[Route("api/crop")]
public class CropController
{
    private readonly ICropService _service;

    public CropController(ICropService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IEnumerable<CropOutput>> Get(CancellationToken ct)
    {
        return await _service.Get(ct);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<CropOutput>> Get(Guid id, CancellationToken ct)
    {
        return await _service.Get(id, ct);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status202Accepted)]
    public async Task<ActionResult<CropOutput>> Create([FromBody] CropInput crop, CancellationToken ct)
    {
        return await _service.Create(crop, ct);
    }

    [HttpPut]
    [Route("{id}")]
    public async Task<ActionResult<CropOutput>> Update(Guid id, [FromBody] CropInput crop, CancellationToken ct)
    {
        return await _service.Update(id, crop, ct);
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task Delete(Guid id, CancellationToken ct)
    {
        await _service.Delete(id, ct);
    }
}

