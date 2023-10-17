using Service.DATA.Models.DTO;

namespace Service.Helpers.Helpers.RDBService_STATUS
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
            var service_id = "RDBService_STATUS";
            string login = "int1jauyngerkz";
            string password = "QwgII3j4";

            var request = $"<soap:Envelope xmlns:soap=\"http://www.w3.org/2003/05/soap-envelope\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                $"<soap:Header/>" +
                $"<soap:Body Id=\"{guid}\">" +
                $"<typ:SendMessage xmlns:typ=\"http://bip.bee.kz/SyncChannel/v10/Types\">" +
                $"<request>" +
                $"<requestInfo>" +
                $"<messageId>{Guid.NewGuid()}</messageId>" +
                $"<serviceId>{service_id}</serviceId>" +
                $"<messageDate>{dateTime}</messageDate>" +
                $"<sender>" +
                $"<senderId>{login}</senderId>" +
                $"<password>{password}</password>" +
                $"</sender>" +
                $"<sessionId>{Guid.NewGuid()}</sessionId>" +
                $"</requestInfo>" +
                $"<requestData>" +
                $"<data xmlns:cs=\"http://message.persistence.interactive.nat\" xsi:type=\"cs:Request\" xmlns:i=\"http://www.w3.org/2001/XMLSchema-instance\">" +
                $"<requestId>1</requestId>" +
                $"<iin>941111350315</iin>" +
                $"<groupId>1</groupId>" +
                $"</data>" +
                $"</requestData>" +
                $"</request>" +
                $"</typ:SendMessage>" +
                $"</soap:Body>" +
                $"</soap:Envelope>";

            return request;
        }
    }
}
