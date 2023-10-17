using Service.DATA.Models;
using Service.Helpers.Clients.Shep;
using Service.Helpers.Helpers.GBDFLUniversal_token;
using Service.Helpers.ResponseModel;
using Service.DATA.ResponseModel.GBDFLUniversal_token;
using static Service.Helpers.Utils.Signing;
using _logger = Service.DATA.Logger;
using Service.DATA.Models.DTO;

namespace Service.Helpers.Clients.GBDFLUniversal_token
{
    public class SendGBDFLUniversal_tokenWithSHEP
    {
        public responseResponseDataData SignXmlAndSend(SurveyDTO surveyDTO, Kdptoken token)
        {
            SendToShep send = new SendToShep();
            StringXml stringXml = new StringXml();
            var guid = Guid.NewGuid().ToString();
            var reguestStr = stringXml.StringXmlRequest(surveyDTO, token, guid);
            var model = new RequestModel() { Attr = guid, Xml = reguestStr };
            var sign = SignWSSE(model, "GBDFLUniversal_token");
            _logger.WriteToFile($"String request xml =  {sign}", "GBDFLUniversal_token", _logger.LogLevel.Information);

            //Запись запроса в файл
            string path = @"C:\xml\GBDFLUniversal_token\example.xml";
            using (StreamWriter file = new StreamWriter(path))
            {
                file.Write(sign);
            }

            var responseResult = send.SendRequestToShep(sign);
            _logger.WriteToFile($"String response xml =  {responseResult}", "GBDFLUniversal_token", _logger.LogLevel.Debug);

            var afterDeserialize = GetTag("persons", responseResult);
            if(afterDeserialize == 0)
            {
                var deserialize = DeserilizeXmlToObject<ErrorModel.Envelope>(responseResult, "MO_ISHASMR_ENBEKSERVICE");
                _logger.WriteToFile($"Deserialize =  {deserialize}", "GBDFLUniversal_token", _logger.LogLevel.Warning);
                return null;
            }
            else
            {
                var deserialize = DeserilizeXmlToObject<Envelope>(responseResult, "GBDFLUniversal_token");
                _logger.WriteToFile($"Deserialize =  {deserialize}", "GBDFLUniversal_token", _logger.LogLevel.Debug);
                var resp = deserialize.Body.SendMessageResponse.response.responseData.data;
                return resp;
            }
            
        }
    }
}
