using Microsoft.AspNetCore.Mvc;
using bgrutils.SpeechToText.Application.Interfaces;
using bgrutils.SpeechToText.Application.ViewModels;

namespace bgrutils.SpeechToText.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpeechController: ControllerBase
    {
        private readonly ISpeechApplication _application;
        public SpeechController(ISpeechApplication application)
        {
            _application = application;
        }

        [HttpPost]
        public IActionResult Post(SpeechViewModel data)
        {        
            return Ok( new { Ok = true, Message =  _application.SyncRecognize(data)});
        }
    }
}