using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace task_scheduler.Controllers
{
    [ApiController]
    [Route("/api/UserScheduler")]
    public class UserSchedulerController : Controller
    {
        private readonly IMediator _messageBus;


        [HttpGet("/api/UserScheduler/{id}")]
        public string GetUser()
        {
           return "teste";
        }

        [HttpPost("/api/UserScheduler/registerUser")]
        public string RegisterUser(
            [FromServices] RegisterUserRequest
            [FromBody] RegisterUserRequest request)
        {
            _messageBus.Send(command)
            return "teste";
        }

        [HttpPost("/api/UserScheduler/resgisterTask")]
        public string RegisterTask()
        {
            return "teste";
        }

        [HttpPatch("/api/UserScheduler/UpdateTask")]
        public string UpdateTask()
        {
            return "teste";
        }

        [HttpDelete("/api/UserScheduler/DeleteTask")]
        public string DeleteTask()
        {
            return "teste";
        }
    }
}
