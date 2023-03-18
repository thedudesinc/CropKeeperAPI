using CropKeeperApi.Domain.Abstractions.Services;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepository.Controllers;

[Authorize]
[ApiController]
[Route("api/gardenPlotCrop")]
public class GardenPlotCropController
{
    private readonly IGardenPlotCropService _service;

    public GardenPlotCropController(IGardenPlotCropService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IEnumerable<GardenPlotCropOutput>> Get(CancellationToken ct)
    {
        return await _service.Get(ct);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<GardenPlotCropOutput>> Get(Guid id, CancellationToken ct)
    {
        return await _service.Get(id, ct);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status202Accepted)]
    public async Task<ActionResult<GardenPlotCropOutput>> Create([FromBody] GardenPlotCropInput gardenPlotCrop, CancellationToken ct)
    {
        return await _service.Create(gardenPlotCrop, ct);
    }

    [HttpPut]
    [Route("{id}")]
    public async Task<ActionResult<GardenPlotCropOutput>> Update(Guid id, [FromBody] GardenPlotCropInput gardenPlotCrop, CancellationToken ct)
    {
        return await _service.Update(id, gardenPlotCrop, ct);
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task Delete(Guid id, CancellationToken ct)
    {
        await _service.Delete(id, ct);
    }
}

