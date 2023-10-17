using Service.Helpers.Clients.Shep;
using Service.Helpers.ResponseModel;
using static Service.Helpers.Utils.Signing;
using _logger = Service.DATA.Logger;
using static Service.DATA.ResponseModel.RDBService_STATUS.ResponseModel;
using Service.Helpers.Helpers.RDBService_STATUS;
using Service.DATA.Models.DTO;

namespace Service.Helpers.Clients.RDBService_STATUS
{
    public class SendRDBService_STATUSWithSHEP
    {
        public responseResponseDataDataRdbResponse SignXmlAndSend(SurveyDTO surveyDTO)
        {
            SendToShep send = new SendToShep();
            StringXml stringXml = new StringXml();
            var guid = Guid.NewGuid().ToString();
            var reguestStr = stringXml.StringXmlRequest(surveyDTO, guid);
            var model = new RequestModel() { Attr = guid, Xml = reguestStr };
            var sign = SignWSSE(model, "RDBService_STATUS");
            _logger.WriteToFile($"String request xml =  {sign}", "RDBService_STATUS", _logger.LogLevel.Information);

            //Запись запроса в файл
            string path = @"C:\xml\RDBService_STATUS\example.xml";
            using (StreamWriter file = new StreamWriter(path))
            {
                file.Write(sign);
            }

            var responseResult = send.SendRequestToShep(sign);
            _logger.WriteToFile($"String response xml =  {responseResult}", "RDBService_STATUS", _logger.LogLevel.Debug);
            var deserialize = DeserilizeXmlToObject<Envelope>(responseResult, "RDBService_STATUS");
            _logger.WriteToFile($"Deserialize =  {deserialize}", "RDBService_STATUS", _logger.LogLevel.Debug);

            var resp = deserialize.Body.SendMessageResponse.response.responseData.data.RdbResponse;

            return resp;
        }
    }
}
