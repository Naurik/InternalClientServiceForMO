using Hangfire;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.DATA.DataBase.PostgresSQL.RepoInterface;
using Service.Helpers.Clients.KDP_PERSONALDATA;
using Service.DATA.ResponseModel.KDP_PERSONALDATA;
using _logger = Service.DATA.Logger;

namespace BackgroundTaskService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class KDP_PERSONALDATAController : ControllerBase
    {
        private IOperationRepo _repo;
        public KDP_PERSONALDATAController(IOperationRepo repo) { _repo = repo; }

        [HttpPost(Name = "RecurringKDP_PERSONALDATA")]
        [Route("recurring")]
        public IActionResult RecurringTaskKDP_PERSONALDATA()
        {
            RecurringJob.AddOrUpdate(() => SendRequest(), Cron.Daily, TimeZoneInfo.Local);
            return Ok($"Add task KDP_PERSONALDATA");
        }

        [NonAction]
        public void SendRequest()
        {
            try
            {
                var getSurveyDTO = _repo.SendKDP_PERSONALDATAGetIIN();

                _logger.WriteToFile($"SurveyData =  {getSurveyDTO}", "KDP_PERSONALDATA", _logger.LogLevel.Debug);

                var cnt = 1;
                _logger.WriteToFile($"SurveyData count =  {getSurveyDTO.Count}", "KDP_PERSONALDATA", _logger.LogLevel.Debug);

                SendKDP_PERSONALDATAWithSHEP send = new SendKDP_PERSONALDATAWithSHEP();
                foreach (var list in getSurveyDTO)
                {
                    _logger.WriteToFile($"Send {cnt} request", "KDP_PERSONALDATA", _logger.LogLevel.Debug);
                    //Отправляем в ШЭП 
                    var response = send.SignXmlAndSend(list);

                    if (response == null)
                    {
                        _logger.WriteToFile($"Response is null", "KDP_PERSONALDATA", _logger.LogLevel.Error);
                        throw new Exception("Response is null");
                    }

                    //Сохранение
                    var AddkdpPersonal = _repo.AddKDP_PERSONALDATA(response);
                    if(AddkdpPersonal != 1)
                    {
                        _logger.WriteToFile($"Saving response error", "KDP_PERSONALDATA", _logger.LogLevel.Error);
                    }
                    cnt++;
                }

                _logger.WriteToFile($"Response successfull!", "KDP_PERSONALDATA", _logger.LogLevel.Debug);

            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex);
            }
        }
    }
}
