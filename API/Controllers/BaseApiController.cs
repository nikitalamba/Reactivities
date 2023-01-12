using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class BaseApiController : ControllerBase
    {
        private IMediator _meditor;

        protected IMediator Mediator => _meditor??=
            HttpContext.RequestServices.GetService<IMediator>();
        
    }
}