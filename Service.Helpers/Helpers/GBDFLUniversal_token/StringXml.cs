using Service.DATA.Models.DTO;
using Service.DATA.Models;
using System.ComponentModel.DataAnnotations;

namespace Service.Helpers.Helpers.GBDFLUniversal_token
{
    public class StringXml
    {
        /// <summary>
        /// Реализация xml запроса в string формате
        /// </summary>
        /// <param name="iin"></param>
        /// <param name="guid"></param>
        /// <returns></returns>
        public string StringXmlRequest(SurveyDTO surveyDTO, Kdptoken token, string guid)
        {
            var dateTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");
            var service_id = "GBDFLUniversal_token";
            string login = "int1jauyngerkz";
            string password = "QwgII3j4";

            var request = $"<?xml version=\"1.0\" encoding=\"UTF-8\"?><soapenv:Envelope xmlns:typ=\"http://bip.bee.kz/SyncChannel/v10/Types\" xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\">" +
                $"<soapenv:Header/>" +
                $"<soapenv:Body Id=\"{guid}\">" +
                $"<typ:SendMessage>" +
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
                $"<messageId>{Guid.NewGuid()}</messageId>" +
                $"<messageDate>{dateTime}</messageDate>" +
                $"<senderCode></senderCode>" +
                $"<iin>920202987654</iin>" +
                $"<kdpToken>{token.TokenVal}</kdpToken>" +
                $"<publicKey>{token.PublicKey}</publicKey>" +
                $"</data>" +
                $"</requestData>" +
                $"</request>" +
                $"</typ:SendMessage>" +
                $"</soapenv:Body>" +
                $"</soapenv:Envelope>";

            return request;
        }
    }
}
