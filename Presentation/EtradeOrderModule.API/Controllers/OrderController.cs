using EtradeOrderModule.Application.Features.Commands.OrderCommand.CreateOrder;
using EtradeOrderModule.Application.Features.Commands.OrderCommand.DeleteOrder;
using EtradeOrderModule.Application.Features.Commands.OrderCommand.UpdateOrder;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EtradeOrderModule.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderCommandRequest request)
        {
            if (request == null)
            {
                return BadRequest("Invalid request data.");
            }
            var response = await Mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOrder([FromBody] UpdateOrderCommandRequest request)
        {
            if (request == null)
            {
                return BadRequest("For address change, you must enter data.");
            }
            var response = await Mediator.Send(request);
            return Ok(response);
        }

        //Deletion was done by setting IsDeleted to true. The customer's order history may be needed later. This data can be used as recommendation advertising.
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteOrderCommandRequest deleteOrderCommandRequest)
        {
            DeleteOrderCommandResponse response = await Mediator.Send(deleteOrderCommandRequest);
            return Ok(response);
        }
    }
}
