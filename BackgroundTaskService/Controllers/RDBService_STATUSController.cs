using Hangfire;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.DATA.DataBase.PostgresSQL.RepoInterface;
using Service.Helpers.Clients.RDBService_STATUS;
using _logger = Service.DATA.Logger;

namespace BackgroundTaskService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class RDBService_STATUSController : ControllerBase
    {
        private IOperationRepo _repo;
        public RDBService_STATUSController(IOperationRepo repo) { _repo = repo; }

        [HttpPost(Name = "RecurringRDBService_STATUS")]
        [Route("recurring")]
        public IActionResult RecurringTaskRDBService_STATUS()
        {
            RecurringJob.AddOrUpdate(() => SendRequest(), Cron.Daily, TimeZoneInfo.Local);
            return Ok($"Add task RDBService_STATUS");
        }

        [NonAction]
        public void SendRequest()
        {
            try
            {
                var getSurveyDTO = _repo.SendRDBService_STATUSGetIIN();

                _logger.WriteToFile($"SurveyData =  {getSurveyDTO}", "RDBService_STATUS", _logger.LogLevel.Debug);

                var cnt = 1;
                _logger.WriteToFile($"SurveyData count =  {getSurveyDTO.Count}", "RDBService_STATUS", _logger.LogLevel.Debug);

                SendRDBService_STATUSWithSHEP send = new SendRDBService_STATUSWithSHEP();
                foreach (var list in getSurveyDTO)
                {
                    _logger.WriteToFile($"Send {cnt} request", "RDBService_STATUS", _logger.LogLevel.Debug);
                    //Отправляем в ШЭП 
                    var response = send.SignXmlAndSend(getSurveyDTO[0]);

                    if (response == null)
                    {
                        _logger.WriteToFile($"Response is null", "RDBService_STATUS", _logger.LogLevel.Error);
                        throw new Exception("Response is null");
                    }

                    //Сохранение
                    var AddRDBServStatus =_repo.AddRDBService_STATUSResponse(response, list.Id);
                    if (AddRDBServStatus != 1)
                    {
                        _logger.WriteToFile($"Saving response error", "RDBService_STATUS", _logger.LogLevel.Error);
                    }

                    cnt++;
                }

                _logger.WriteToFile($"Response successfull!", "RDBService_STATUS", _logger.LogLevel.Debug);
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex);
            }
        }
    }
}
