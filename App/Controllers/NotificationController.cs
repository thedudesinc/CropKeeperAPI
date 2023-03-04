using CropKeeperApi.Domain.Abstractions.Services;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepository.Controllers;

[ApiController]
[Route("api/notification")]
public class NotificationController
{
    private readonly INotificationService _service;

    public NotificationController(INotificationService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IEnumerable<NotificationOutput>> Get(CancellationToken ct)
    {
        return await _service.Get(ct);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<NotificationOutput>> Get(Guid id, CancellationToken ct)
    {
        return await _service.Get(id, ct);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status202Accepted)]
    public async Task<ActionResult<NotificationOutput>> Create([FromBody] NotificationInput notification, CancellationToken ct)
    {
        return await _service.Create(notification, ct);
    }

    [HttpPut]
    [Route("{id}")]
    public async Task<ActionResult<NotificationOutput>> Update(Guid id, [FromBody] NotificationInput notification, CancellationToken ct)
    {
        return await _service.Update(id, notification, ct);
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task Delete(Guid id, CancellationToken ct)
    {
        await _service.Delete(id, ct);
    }
}

