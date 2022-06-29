using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseProject.Common.Models.CQRS.Queries.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BaseProject.Api.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("carpma-islemi")]
        public async Task<IActionResult> Carpma([FromQuery] HomeCarpmaQueryRequest request) 
	    {
            var res = await _mediator.Send(request);
            return Ok(res);	    
	    }

        
	   
    }
}

