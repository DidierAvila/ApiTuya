using System.Net.Mime;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ApiTuya.Application.Services.TEntitys;
using ApiTuya.Domain.Entities;
using AutoWrapper.Wrappers;

namespace ApiTuya.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _CustomerService;

        public CustomerController(ICustomerService customerService)
        {
            _CustomerService = customerService;
        }

        [HttpPost()]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> CreateOrder([FromBody] Customer createRequest, CancellationToken cancellationToken)
        {
            var EntityUser = await _CustomerService.CreateCustomer(createRequest, cancellationToken);
            return Ok(new ApiResponse("User create", EntityUser, 200));
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> ReadOrder([FromRoute]int id, CancellationToken cancellationToken)
        {
            var response = await _CustomerService.GetByID(id, cancellationToken);
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
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> UpdateOrder([FromRoute]int id, [FromBody] Customer updateRequest, CancellationToken cancellationToken)
        {
            Customer response = await _CustomerService.GetByID(id, cancellationToken);
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
                await _CustomerService.Update(response, cancellationToken);
                return Ok(new ApiResponse("User updated", "sadas", 200));

            }
        }

        [HttpGet()]
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            IEnumerable<Customer> response = await _CustomerService.GetAll(cancellationToken);
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
        [Authorize(Roles = "Administrador")]
        public async Task<ApiResponse> Delete([FromRoute]int id, CancellationToken cancellationToken)
        {
            await _CustomerService.Delete(id, cancellationToken);
            return new ApiResponse("AccionParticipacionPersonaBusca deleted.", null, 204);
        }
    }
}