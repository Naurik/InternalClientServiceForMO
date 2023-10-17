using Service.Helpers.Clients.Shep;
using Service.Helpers.Helpers.MO_ISHASMR_ENBEKSERVICE;
using Service.Helpers.ResponseModel;
using Service.DATA.ResponseModel.MO_ISHASMR_ENBEKSERVICE;
using static Service.Helpers.Utils.Signing;
using _logger = Service.DATA.Logger;
using static Service.DATA.ResponseModel.RDBService_MTSZN.RdbResponses;
using static Service.DATA.ResponseModel.MO_ISHASMR_ENBEKSERVICE.MO_ISHASMR_ENBEKSERVICE;
using Service.DATA.Models.DTO;

namespace Service.Helpers.Clients.MO_ISHASMR_ENBEKSERVICE
{
    public class SendMO_ISHASMR_ENBEKSERVICEWithSHEP
    {
        public MilitaryServiceResponse SignXmlAndSend(SurveyDTO surveyDTO)
        {
            SendToShep send = new SendToShep();
            StringXml stringXml = new StringXml();
            var guid = Guid.NewGuid().ToString();
            var reguestStr = stringXml.StringXmlRequest(surveyDTO, guid);
            var model = new RequestModel() { Attr = guid, Xml = reguestStr };
            var sign = SignWSSE(model, "MO_ISHASMR_ENBEKSERVICE");
            _logger.WriteToFile($"String request xml =  {sign}", "MO_ISHASMR_ENBEKSERVICE", _logger.LogLevel.Debug);

            //Запись запроса в файл
            string path = @"C:\xml\MO_ISHASMR_ENBEKSERVICE\example.xml";
            using (StreamWriter file = new StreamWriter(path))
            {
                file.Write(sign);
            }

            var responseResult = send.SendRequestToShep(sign);
            _logger.WriteToFile($"String response xml =  {responseResult}", "MO_ISHASMR_ENBEKSERVICE", _logger.LogLevel.Debug);
            var deserialize = DeserilizeXmlToObject<Envelope>(responseResult, "MO_ISHASMR_ENBEKSERVICE");
            _logger.WriteToFile($"Deserialize =  {deserialize}", "MO_ISHASMR_ENBEKSERVICE", _logger.LogLevel.Debug);
            var resp = deserialize.Body.SendMessageResponse.response.responseData.data;

            var rdbResponse = DeserilizeXmlToObject<MilitaryServiceResponse>(resp, "MO_ISHASMR_ENBEKSERVICE");
            _logger.WriteToFile($"Deserialize rdb =  {deserialize}", "MO_ISHASMR_ENBEKSERVICE", _logger.LogLevel.Debug);

            return rdbResponse;
        }
    }
}
