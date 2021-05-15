using Microsoft.AspNetCore.Mvc;
using TesteBotTelegram.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TesteBotTelegram.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelegramController : ControllerBase
    {
        private readonly ITelegramService _telegramService;

        public TelegramController(ITelegramService telegramService)
        {
            _telegramService = telegramService;
        }

        // GET: api/<TelegramController>
        [HttpGet]
        public void Get()
        {
            _telegramService.BotHandler();
        }
    }
}
