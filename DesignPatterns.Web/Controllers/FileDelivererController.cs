using DesignPatterns.Strategy;
using DesignPatterns.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileDelivererController : ControllerBase
    {
        private readonly ILogger<FileDelivererController> _logger;
        private readonly IFileDelivererService _fileDelivererService;

        public FileDelivererController(ILogger<FileDelivererController> logger, IFileDelivererService fileDelivererService)
        {
            _logger = logger;
            _fileDelivererService = fileDelivererService;
        }

        [HttpPost]
        public IActionResult Deliver(FileDeliverRequest request)
        {
            var result = _fileDelivererService.Deliver(request.Content, request.Destination);
            _logger.LogInformation(result);
            return Ok(result);
        }
    }
}
