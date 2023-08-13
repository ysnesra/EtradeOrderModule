using EtradeOrderModule.Application.Features.Commands.OrderCommand.CreateOrder;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EtradeOrderModule.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> CreatOrder(CreateOrderCommandRequest request)
        {
            if (request == null)
            {
                return BadRequest("Invalid request data.");
            }
            var response = await Mediator.Send(request);
            return Ok(response);
        }
    }
}
