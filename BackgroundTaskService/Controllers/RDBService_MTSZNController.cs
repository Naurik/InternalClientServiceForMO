using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Service.DATA.DataBase.PostgresSQL.RepoInterface;
using Service.Helpers.Clients.RDBService_MTSZN;
using _logger = Service.DATA.Logger;

namespace BackgroundTaskService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class RDBService_MTSZNController : ControllerBase
    {
        private IOperationRepo _repo;
        public RDBService_MTSZNController(IOperationRepo repo) { _repo = repo; }

        [HttpPost(Name = "RecurringRDBService_MTSZN")]
        [Route("recurring")]
        public IActionResult RecurringTaskRDBService_MTSZN()
        {
            RecurringJob.AddOrUpdate(() => SendRequest(), Cron.Daily, TimeZoneInfo.Local);
            return Ok($"Add task RDBService_MTSZN");
        }

        [NonAction]
        public void SendRequest()
        {
            try
            {
                var getSurveyDTO = _repo.SendRDBService_MTSZNGetIIN();

                _logger.WriteToFile($"SurveyData =  {getSurveyDTO}", "RDBService_MTSZN", _logger.LogLevel.Debug);

                var cnt = 1;
                _logger.WriteToFile($"SurveyData count =  {getSurveyDTO.Count}", "RDBService_MTSZN", _logger.LogLevel.Debug);

                SendRDBService_MTSZNWithSHEP send = new SendRDBService_MTSZNWithSHEP();
                foreach (var list in getSurveyDTO)
                {
                    _logger.WriteToFile($"Send {cnt} request", "RDBService_MTSZN", _logger.LogLevel.Debug);
                    //Отправляем в ШЭП 
                    var response = send.SignXmlAndSend(getSurveyDTO[0]);

                    if (response == null)
                    {
                        _logger.WriteToFile($"Response is null", "RDBService_MTSZN", _logger.LogLevel.Error);
                        throw new Exception("Response is null");
                    }

                    //Сохранение
                    _logger.WriteToFile($"Adding Data", "RDBService_MTSZN", _logger.LogLevel.Debug);
                    var AddRDBServMstzn = _repo.AddRDBService_MTSZNResponse(response, list.Id);
                    if (AddRDBServMstzn != 1)
                    {
                        _logger.WriteToFile($"Saving response error", "RDBService_MTSZN", _logger.LogLevel.Error);
                    }

                    cnt++;
                }

                _logger.WriteToFile($"Response successfull!", "RDBService_MTSZN", _logger.LogLevel.Debug);
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex);
            }
        }
    }
}
