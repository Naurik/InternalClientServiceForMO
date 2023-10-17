using Service.DATA.Models.DTO;

namespace Service.Helpers.Helpers.MO_ISHASMR_ENBEKSERVICE
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
            var service_id = "MO_ISHASMR_ENBEKSERVICE";
            string login = "int1jauyngerkz";
            string password = "QwgII3j4";
            string[] Names = surveyDTO.FullName!.Split(' ');
            string firstName = "";
            string secondName = "";
            string patronymic = "";

            if (Names.Length == 2)
            { 
                firstName = Names[0];
                patronymic = Names[1];

            }
            else
            {
                secondName = Names[0];
                firstName = Names[1];
                patronymic = Names[2];
            }
            

            var request = $"<S:Envelope xmlns:S=\"http://schemas.xmlsoap.org/soap/envelope/\">" +
                $"<SOAP-ENV:Header xmlns:SOAP-ENV=\"http://schemas.xmlsoap.org/soap/envelope/\"/>" +
                $"<S:Body Id=\"{guid}\">" +
                $"<ns2:SendMessage xmlns:ns2=\"http://bip.bee.kz/SyncChannel/v10/Types\" xmlns:ns3=\"http://bip.bee.kz/SyncChannel/v10/Interfaces\">" +
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
                $"<data xsi:type=\"xs:string\" xmlns:xs=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">" +
                $"<![CDATA[<MilitaryServiceRequest xmlns=\"http://geocenter.kz/services/enbek/schemas\">" +
                $"<requestNumber>10100521127456</requestNumber>" +
                $"<requestDate>{dateTime}</requestDate>" +
                $"<IIN>{surveyDTO.IIN}</IIN>" +
                $"<lastname>{secondName}</lastname>" +
                $"<firstname>{firstName}</firstname>" +
                $"<patronymic>{patronymic}</patronymic>" +
                $"<birthdate></birthdate>" +
                $"</MilitaryServiceRequest>]]></data>" +
                $"</requestData>" +
                $"</request>" +
                $"</ns2:SendMessage>" +
                $"</S:Body></S:Envelope>";

            return request;
        }
    }
}
