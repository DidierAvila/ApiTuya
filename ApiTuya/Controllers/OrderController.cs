using ApiTuya.Application.Services.Orders;
using ApiTuya.Application.Services.TEntitys;
using ApiTuya.Domain.Entities;
using AutoWrapper.Wrappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ApiTuya.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _OrderService;

        public OrderController(IOrderService orderService)
        {
            _OrderService = orderService;
        }

        [HttpPost()]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(Roles = "Cajero")]
        public async Task<IActionResult> CreateOrder([FromBody] Order createRequest, CancellationToken cancellationToken)
        {
            var EntityUser = await _OrderService.CreateOrder(createRequest, cancellationToken);
            return Ok(new ApiResponse("User create", EntityUser, 200));
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Cajero")]
        public async Task<IActionResult> ReadOrder([FromRoute] int id, CancellationToken cancellationToken)
        {
            var response = await _OrderService.GetByID(id, cancellationToken);
            if (response != null)
            {
                return Ok(response);
            }
            else
            {
                return NotFound("Not found user");
            }
        }

        [HttpPut("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(Roles = "Cajero")]
        public async Task<IActionResult> UpdateOrder([FromRoute] int id, [FromBody] Customer updateRequest, CancellationToken cancellationToken)
        {
            Order response = await _OrderService.GetByID(id, cancellationToken);
            if (response == null)
            {
                return NotFound("Not found user");
            }
            else
            {
                if (updateRequest.Id != id)
                {
                    return BadRequest("AccionParticipacionOCMP Id and id doesn't match");
                }
                await _OrderService.Update(response, cancellationToken);
                return Ok(new ApiResponse("User updated", "sadas", 200));

            }
        }

        [HttpGet()]
        [Authorize(Roles = "Cajero")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            IEnumerable<Order> response = await _OrderService.GetAll(cancellationToken);
            if (response != null)
            {
                return Ok(response);
            }
            else
            {
                return NotFound("Not found User");
            }
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Cajero")]
        public async Task<ApiResponse> Delete([FromRoute] int id, CancellationToken cancellationToken)
        {
            await _OrderService.Delete(id, cancellationToken);
            return new ApiResponse("AccionParticipacionPersonaBusca deleted.", null, 204);
        }
    }
}