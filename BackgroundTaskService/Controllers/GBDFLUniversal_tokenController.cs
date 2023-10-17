using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Service.DATA.DataBase.PostgresSQL.RepoInterface;
using Service.Helpers;
using Service.Helpers.Clients.GBDFLUniversal_token;
using Service.DATA.ResponseModel.GBDFLUniversal_token;
using _logger = Service.DATA.Logger;

namespace BackgroundTaskService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class GBDFLUniversal_tokenController : ControllerBase
    {
        private IOperationRepo _repo;
        public GBDFLUniversal_tokenController(IOperationRepo repo) { _repo = repo; }

        [HttpPost(Name = "RecurringGBDFLUniversal_token")]
        [Route("recurring")]
        [Obsolete]
        public IActionResult RecurringTaskGBDFLUniversal_token()
        {
            RecurringJob.AddOrUpdate(() => SendRequest(), Cron.Daily, TimeZoneInfo.Local);
            return Ok($"Add task GBDFLUniversal_token");
        }

        [NonAction]
        public void SendRequest()
        {
            try
            {
                var getSurveyDTO = _repo.SendGBDFLUniversal_tokenGetIIN();

                _logger.WriteToFile($"SurveyData =  {getSurveyDTO}", "GBDFLUniversal_token", _logger.LogLevel.Debug);

                var cnt = 1;
                _logger.WriteToFile($"SurveyData count =  {getSurveyDTO.Count}", "GBDFLUniversal_token", _logger.LogLevel.Debug);

                SendGBDFLUniversal_tokenWithSHEP send = new SendGBDFLUniversal_tokenWithSHEP();
                foreach (var list in getSurveyDTO)
                {
                    _logger.WriteToFile($"Send {cnt} request", "GBDFLUniversal_token", _logger.LogLevel.Debug);

                    var token = _repo.GetKdptokenGBDFLUniversal_token(list.Id);
                    if(token != null)
                    {
                        //Отправляем в ШЭП 
                        var response = send.SignXmlAndSend(list, token);

                        if (response == null)
                        {
                            _logger.WriteToFile($"Ошибка в токене безопасности", "GBDFLUniversal_token", _logger.LogLevel.Error);
                        }
                        else 
                        {
                            //Сохранение
                            var addGBDFL = _repo.AddGBDFLUniversal_token(response.persons);
                            if (addGBDFL != 1)
                            {
                                _logger.WriteToFile($"Saving response error", "GBDFLUniversal_token", _logger.LogLevel.Error);
                            }
                        }
                        
                    }
                    
                    cnt++;
                }

                _logger.WriteToFile($"Response successfull!", "GBDFLUniversal_token", _logger.LogLevel.Debug);
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex);
            }
        }
    }
}
