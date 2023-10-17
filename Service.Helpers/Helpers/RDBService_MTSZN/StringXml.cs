using Service.DATA.Models.DTO;
using System.ComponentModel.DataAnnotations;

namespace Service.Helpers.Helpers.RDBService_MTSZN
{
    public class StringXml
    {
        /// <summary>
        /// Реализация xml запроса в string формате
        /// </summary>
        /// <param name="iin"></param>
        /// <param name="guid"></param>
        /// <returns></returns>
        public string StringXmlRequest(SurveyDTO surveyDTO, string guid)
        {
            var dateTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");
            var service_id = "RDBService_MTSZN";
            string login = "int1jauyngerkz";
            string password = "QwgII3j4";

            var request = $"<soap:Envelope xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns=\"http://bip.bee.kz/SyncChannel/v10/Types\">" +
                $"<soap:Header/>" +
                $"<soap:Body Id=\"{guid}\">" +
                $"<SendMessage>" +
                $"<request>" +
                $"<requestInfo>" +
                $"<messageId>{Guid.NewGuid()}</messageId>" +
                $"<serviceId>{service_id}</serviceId>" +
                $"<messageDate>{dateTime}</messageDate>" +
                $"<sender>" +
                $"<senderId>{login}</senderId>" +
                $"<password>{password}</password>" +
                $"</sender>" +
                $"</requestInfo>" +
                $"<requestData>" +
                $"<data>" +
                $"<GetRdbRequest>" +
                $"<iin>{surveyDTO.IIN}</iin>" +
                $"<groupId>123</groupId>" +
                $"<requestId>{Guid.NewGuid()}</requestId>" +
                $"</GetRdbRequest>" +
                $"</data>" +
                $"</requestData>" +
                $"</request>" +
                $"</SendMessage>" +
                $"</soap:Body>" +
                $"</soap:Envelope>";

            var req = $"<soap:Envelope xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\">" +
                $"<SOAP-ENV:Header xmlns:SOAP-ENV=\"http://schemas.xmlsoap.org/soap/envelope/\">" +
                $"</SOAP-ENV:Header>" +
                $"<soap:Body xmlns:wsu=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd\" wsu:Id=\"{guid}\">" +
                $"<ns2:SendMessage xmlns:ns2=\"http://bip.bee.kz/SyncChannel/v10/Types\">" +
                $"<request>" +
                $"<requestInfo>" +
                $"<messageId>{Guid.NewGuid()}</messageId>" +
                $"<serviceId>RDBService_MTSZN</serviceId>" +
                $"<messageDate>{dateTime}</messageDate>" +
                $"<sender>" +
                $"<senderId>{login}</senderId>" +
                $"<password>{password}</password>" +
                $"</sender>" +
                $"<sessionId>{Guid.NewGuid()}</sessionId>" +
                $"</requestInfo>" +
                $"<requestData>" +
                $"<data>" +
                $"<applicationId>001007788643</applicationId>" +
                $"<GetRdbRequest>" +
                $"<requestId>10100555762399</requestId>" +
                $"<iin>941111350315</iin>" +
                $"<groupId>123</groupId>" +
                $"</GetRdbRequest>" +
                $"</data>" +
                $"</requestData>" +
                $"</request>" +
                $"</ns2:SendMessage>" +
                $"</soap:Body>" +
                $"</soap:Envelope>"; 

            return req;
        }
    }
}
