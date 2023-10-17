using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Service.DATA.DataBase.PostgresSQL.RepoInterface;
using Service.Helpers.Clients.KDP_Service;
using _logger = Service.DATA.Logger;
using static Service.Helpers.Utils.Signing;

namespace BackgroundTaskService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class KDP_ServiceController : ControllerBase
    {
        private IOperationRepo _repo;
        public KDP_ServiceController(IOperationRepo repo) { _repo = repo; }

        [HttpPost(Name = "RecurringKDP_Service")]
        [Route("recurring")]
        public IActionResult RecurringTaskKDP_Service()
        {
            RecurringJob.AddOrUpdate(() => SendRequest(), Cron.Daily, TimeZoneInfo.Local);
            return Ok($"Add task KDP_Service");
        }

        [NonAction]
        public void SendRequest()
        {
            try
            {
                var getSurveyDTO = _repo.SendKDP_ServiceGetIIN();

                _logger.WriteToFile($"SurveyData =  {getSurveyDTO}", "KDP_Service", _logger.LogLevel.Debug);
                var cnt = 1;
                _logger.WriteToFile($"SurveyData count =  {getSurveyDTO.Count}", "KDP_Service", _logger.LogLevel.Debug);

                SendKDP_ServiceWithSHEP send = new SendKDP_ServiceWithSHEP();
                foreach (var list in getSurveyDTO)
                {
                    _logger.WriteToFile($"Send {cnt} request", "KDP_Service", _logger.LogLevel.Debug);
                    //Отправляем в ШЭП 
                    var response = send.SignXmlAndSend(list);

                    if (response == null)
                    {
                        _logger.WriteToFile($"Response is null", "KDP_Service", _logger.LogLevel.Error);
                        throw new Exception("Response is null");
                    }

                    //var valid = ValidateJwtToken(response.code, response.publickey);
                    //if (!valid)
                    //{
                    //    _logger.WriteToFile($"Error!!! Token is not valid", "KDP_Service", _logger.LogLevel.Error);
                    //    throw new Exception("JWT token in response is not valid");
                    //}

                    var AddkdpServ = _repo.AddKDP_Service(response, list.Id);
                    if(AddkdpServ != 1) 
                    {
                        _logger.WriteToFile($"Saving response error", "KDP_Service", _logger.LogLevel.Error);
                    }

                    cnt++;
                }

                _logger.WriteToFile($"Response successfull!", "KDP_Service", _logger.LogLevel.Debug);
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex);
            }
        }
    }
}
