using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UbisoftTest.HttpApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {

        private readonly ILogger<GameController> _logger;

        public GameController(ILogger<GameController> logger)
        {
            _logger = logger;
        }

        //Replace parameter values with model
        [HttpPost]
        public void MatchDetails(
            string player,
            string match,
            int kills,
            int score)
        {

        }

        //return model instead of string
        [HttpGet]
        public async Task<List<string>> HighScorer(string match, DateTime time)
        {
            return null;
        }

        //return model instead of string
        [HttpGet]
        public async Task<List<string>> GetPlayerStatus(string payerName)
        {
            return null;
        }

        //return model instead of string
        [HttpGet]
        public async Task<List<string>> PlayerStatusByMatch(string match, DateTime time)
        {
            return null;
        }
    }
}
