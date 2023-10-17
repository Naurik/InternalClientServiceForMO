using Service.DATA.Models.DTO;

namespace Service.Helpers.Helpers.KDP_PERSONALDATA
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
            var service_id = "KDP_PERSONALDATA";
            string login = "int1jauyngerkz";
            string password = "QwgII3j4";

            var request = $"<S:Envelope xmlns:S=\"http://schemas.xmlsoap.org/soap/envelope/\">" +
                $"<S:Header/>" +
                $"<S:Body xmlns:wsu=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd\" wsu:Id=\"{guid}\">" +
                $"<ns2:SendMessageRequest xmlns:ns2=\"http://bip.bee.kz/SyncChannel/v10/Types\" xmlns:ns3=\"http://service.2fa-chain.kz/ns/kdp/personalData\" xmlns:ns4=\"http://service.2fa-chain.kz/ns/kdp/personalData\">" +
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
                $"<data xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:type=\"ns4:personalDataRequest\">" +
                $"<ns4:uin>941111350315</ns4:uin>" +
                $"<ns4:start_date>2022-01-01T15:24:08.662+06:00</ns4:start_date>" +
                $"<ns4:end_date>2023-05-05T15:24:08.662+06:00</ns4:end_date>" +
                $"</data>" +
                $"</requestData>" +
                $"</request>" +
                $"</ns2:SendMessageRequest>" +
                $"</S:Body>" +
                $"</S:Envelope>";

            return request;
        }
    }
}
