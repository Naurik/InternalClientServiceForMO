using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Service.DATA.DataBase.PostgresSQL.RepoInterface;
using Service.Helpers;
using Service.Helpers.Clients.Shep;

namespace BackgroundTaskService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangFireBackgroundTask : ControllerBase
    {
        private IOperationRepo _repo;
        public HangFireBackgroundTask(IOperationRepo repo) { _repo = repo; }

        [HttpPost]
        [Route("recurring")]
        [Obsolete]
        public IActionResult Recurring()
        {
            RecurringJob.AddOrUpdate(() => SendRequest(), Cron.Daily);
            return Ok($"Send request MO");
        }

        public void SendRequest()
        {
            try
            {
                var getSurveyDTO = _repo.GetIIN();

                Logger.Log.Debug("IIN = " + getSurveyDTO.IIN);

                SendToShep sendToShep = new SendToShep();

                //Отправляем в ШЭП 
                var response = sendToShep.SignXmlAndSend(getSurveyDTO.IIN);

                //Метод проверки ЭЦП на валидность

                //Здесь пока закомментировал, так как для теста хотим увидеть что приходят,
                //а после уже можно будет преобразовать MO_DataResponse
                //MO_DataResponse data = (MO_DataResponse)response.response.responseData.data;
                Logger.Log.Debug("Response = " + response);

                //Пока закомментирован
                //_repo.AddDB_Candidates(data);
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex);
            }
        }
    }
}
