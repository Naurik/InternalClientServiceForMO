using Service.Helpers.Clients.Shep;
using Service.Helpers.Helpers.KDP_PERSONALDATA;
using Service.Helpers.ResponseModel;
using Service.DATA.ResponseModel.KDP_PERSONALDATA;
using static Service.Helpers.Utils.Signing;
using _logger = Service.DATA.Logger;
using Service.DATA.Models.DTO;

namespace Service.Helpers.Clients.KDP_PERSONALDATA
{
    public class SendKDP_PERSONALDATAWithSHEP
    {
        public responseResponseDataData SignXmlAndSend(SurveyDTO surveyDTO)
        {
            SendToShep send = new SendToShep();
            StringXml stringXml = new StringXml();
            var guid = Guid.NewGuid().ToString();
            var reguestStr = stringXml.StringXmlRequest(surveyDTO, guid);
            var model = new RequestModel() { Attr = guid, Xml = reguestStr };
            var sign = SignWSSE(model, "KDP_PERSONALDATA");
            _logger.WriteToFile($"String request xml =  {sign}", "KDP_PERSONALDATA", _logger.LogLevel.Debug);

            //Запись запроса в файл
            string path = @"C:\xml\KDP_PERSONALDATA\example.xml";
            using (StreamWriter file = new StreamWriter(path))
            {
                file.Write(sign);
            }

            var responseResult = send.SendRequestToShep(sign);
            _logger.WriteToFile($"String response xml =  {responseResult}", "KDP_PERSONALDATA", _logger.LogLevel.Debug);
            var deserialize = DeserilizeXmlToObject<Envelope>(responseResult, "KDP_PERSONALDATA");
            _logger.WriteToFile($"Deserialize =  {deserialize}", "KDP_PERSONALDATA", _logger.LogLevel.Debug);
            var resp = deserialize.Body.SendMessageResponse.response.responseData.data;
            return resp;
        }
    }
}
