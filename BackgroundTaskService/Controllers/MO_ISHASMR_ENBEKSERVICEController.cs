using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Service.DATA.DataBase.PostgresSQL.RepoInterface;
using Service.Helpers.Clients.MO_ISHASMR_ENBEKSERVICE;
using _logger = Service.DATA.Logger;

namespace BackgroundTaskService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class MO_ISHASMR_ENBEKSERVICEController : ControllerBase
    {
        private IOperationRepo _repo;
        public MO_ISHASMR_ENBEKSERVICEController(IOperationRepo repo) { _repo = repo; }

        [HttpPost(Name = "RecurringMO_ISHASMR_ENBEKSERVICE")]
        [Route("recurring")]
        public IActionResult RecurringTaskMO_ISHASMR_ENBEKSERVICE()
        {
            RecurringJob.AddOrUpdate(() => SendRequest(), Cron.Daily, TimeZoneInfo.Local);
            return Ok($"Add task MO_ISHASMR_ENBEKSERVICE");
        }

        [NonAction]
        public void SendRequest()
        {
            try
            {
                var getSurveyDTO = _repo.SendMO_ISHASMR_ENBEKSERVICEGetIIN();

                _logger.WriteToFile($"SurveyData =  {getSurveyDTO}", "MO_ISHASMR_ENBEKSERVICE", _logger.LogLevel.Debug);

                var cnt = 1;
                _logger.WriteToFile($"SurveyData count =  {getSurveyDTO.Count}", "MO_ISHASMR_ENBEKSERVICE", _logger.LogLevel.Debug);

                SendMO_ISHASMR_ENBEKSERVICEWithSHEP send = new SendMO_ISHASMR_ENBEKSERVICEWithSHEP();
                foreach (var list in getSurveyDTO)
                {
                    _logger.WriteToFile($"Send {cnt} request", "MO_ISHASMR_ENBEKSERVICE", _logger.LogLevel.Debug);
                    //Отправляем в ШЭП 
                    var response = send.SignXmlAndSend(list);

                    if (response == null)
                    {
                        _logger.WriteToFile($"Response is null", "MO_ISHASMR_ENBEKSERVICE", _logger.LogLevel.Error);
                        throw new Exception("Response is null");
                    }

                    //Сохранение
                    var AddMO_ISHasMR = _repo.AddMO_ISHASMR_ENBEKSERVICE(response, list.Id);
                    if (AddMO_ISHasMR != 1)
                    {
                        _logger.WriteToFile($"Saving response error", "MO_ISHASMR_ENBEKSERVICE", _logger.LogLevel.Error);
                    }

                    cnt++;
                }

                _logger.WriteToFile($"Response successfull!", "MO_ISHASMR_ENBEKSERVICE", _logger.LogLevel.Debug);
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex);
            }
        }
    }
}
