using Microsoft.AspNetCore.Mvc;
using Optsol.Components.Service.Controllers;
using Optsol.Components.Service.Responses;

namespace FavoriteGames.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BaseController : ApiControllerBase, IApiControllerBase
    {
        public BaseController(IResponseFactory responseFactory) : base(responseFactory)
        {
        }
    }
}