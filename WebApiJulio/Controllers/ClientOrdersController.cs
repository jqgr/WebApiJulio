using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiJulio.Models;
using WebApiJulio.Repositories;

namespace WebApiJulio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientOrdersController : ControllerBase
    {
        private readonly IClientOrdersService clientOrdersService;

        public ClientOrdersController(IClientOrdersService clientOrdersService)
        {
            this.clientOrdersService = clientOrdersService;
        }

        [HttpGet("ClientOrders")]
        public async Task<IEnumerable<ClientOrders>> GetClientOrdersAsync(int CustId)
        {
            try
            {
                var response = await clientOrdersService.GetClientOrdersAsync(CustId);

                if (response == null)
                    return null;

                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
