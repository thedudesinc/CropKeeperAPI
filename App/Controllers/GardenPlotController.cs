using CropKeeperApi.Domain.Abstractions.Services;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepository.Controllers;

[ApiController]
[Route("api/gardenPlot")]
public class GardenPlotController
{
    private readonly IGardenPlotService _service;

    public GardenPlotController(IGardenPlotService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IEnumerable<GardenPlotOutput>> Get(CancellationToken ct)
    {
        return await _service.Get(ct);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<GardenPlotOutput>> Get(Guid id, CancellationToken ct)
    {
        return await _service.Get(id, ct);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status202Accepted)]
    public async Task<ActionResult<GardenPlotOutput>> Create([FromBody] GardenPlotInput gardenPlot, CancellationToken ct)
    {
        return await _service.Create(gardenPlot, ct);
    }

    [HttpPut]
    [Route("{id}")]
    public async Task<ActionResult<GardenPlotOutput>> Update(Guid id, [FromBody] GardenPlotInput gardenPlot, CancellationToken ct)
    {
        return await _service.Update(id, gardenPlot, ct);
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task Delete(Guid id, CancellationToken ct)
    {
        await _service.Delete(id, ct);
    }
}

