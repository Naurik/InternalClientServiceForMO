using Service.Helpers.Clients.Shep;
using Microsoft.AspNetCore.Mvc;
using Service.Helpers;
using Service.DATA.Model;
using Service.DATA.DataBase.PostgresSQL.Repository;
using Service.Helpers.Classes.MO_RequestResponse;

namespace ClientService_Integration.Controllers
{
    public class MO_SendRequestController : Controller
    {
        private OperationRepo _repo;

        public MO_SendRequestController(OperationRepo repo) { _repo = repo; }

        [HttpGet]
        public IActionResult SendRequest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendRequest(MO_SendRequest mO_SendRequest)
        {
            try
            {
                //Logger.Log.Debug("RequestUser = " + mO_SendRequest.IIN);
                //SendToShep sendToShep = new SendToShep();
                
                ////Отправляем в ШЭП 
                //var response = sendToShep.SignXmlAndSend(mO_SendRequest.IIN);

                //Метод проверки ЭЦП на валидность

                //Здесь пока закомментировал, так как для теста хотим увидеть что приходят,
                //а после уже можно будет преобразовать MO_DataResponse
                //MO_DataResponse data = (MO_DataResponse)response.response.responseData.data;
                ViewBag.Message = string.Format("Send IIN");

                //Пока закомментирован
                //_repo.AddDB_Candidates(data);

                return View();
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex);
            }
        }
    }
}
