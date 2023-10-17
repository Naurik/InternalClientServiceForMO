using Service.DATA.Models.DTO;

namespace Service.Helpers.Helpers.KDP_Service
{
    public class StringXml
    {
        /// <summary>
        /// Реализация xml запроса в string формате
        /// </summary>
        /// <param name="iin"></param>
        /// <param name="guid"></param>
        /// <returns></returns>
        public string StringXmlRequest(SurveyDTO surveyDTO, string guid, string token)
        {
            var dateTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");
            var service_id = "KDP_SERVICE";
            string login = "int1jauyngerkz";
            string password = "QwgII3j4";

            var request = $"<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns=\"http://service.2fa-chain.kz/ns/kdp\">" +
                $"<soapenv:Header/>" +
                $"<soapenv:Body Id=\"{guid}\">" +
                $"<sendMessageRequest>" +
                $"<request>" +
                $"<requestInfo>" +
                $"<messageId>{Guid.NewGuid()}</messageId>" +
                $"<serviceId>{service_id}</serviceId>" +
                $"<sessionId>{Guid.NewGuid()}</sessionId>" +
                $"<messageDate>{dateTime}</messageDate>" +
                $"<sender>" +
                $"<senderId>{login}</senderId>" +
                $"<password>{password}</password>" +
                $"</sender>" +
                $"</requestInfo>" +
                $"<requestData>" +
                $"<data xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:type=\"getUserDataRequest\">" +
                $"<uin>941111350315</uin>" +
                $"<company>ТОО 21Tech</company>" +
                $"<company_bin>210140026476</company_bin>" +
                $"<company_responsible>База мобильных граждан</company_responsible>" +
                $"<employee_name>Кылышбек Мади Асылбекулы</employee_name>" +
                $"<access_name>MCDB_SERVICE</access_name>" +
                $"<personal_data_name></personal_data_name>" +
                $"<expiresIn>600000</expiresIn>" +
                $"<omit-sms>true</omit-sms>" +
                $"<ovt>{token}</ovt>" +
                $"</data>" +
                $"</requestData>" +
                $"</request>" +
                $"</sendMessageRequest>" +
                $"</soapenv:Body>" +
                $"</soapenv:Envelope>";

            var req = $"<soap:Envelope xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">" +
                        $"<SOAP-ENV:Header xmlns:SOAP-ENV=\"http://schemas.xmlsoap.org/soap/envelope/\"/>" +
                            $"<soap:Body Id=\"{guid}\">" +
                                $"<SendMessage xmlns=\"http://bip.bee.kz/SyncChannel/v10/Types\">" +
                                    $"<request xmlns=\"\">" +
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
                                                $"<data xsi:type=\"getUserDataRequest\">" +
                                                    $"<uin>941111350315</uin>" +
                                                    $"<company>ТОО 21Tech</company>" +
                                                    $"<company_bin>210140026476</company_bin>" +
                                                    $"<company_responsible>База мобильных граждан</company_responsible>" +
                                                    $"<employee_name>Кылышбек Мади Асылбекулы</employee_name>" +
                                                    $"<access_name>MCDB_SERVICE</access_name>" +
                                                    $"<personal_data_name></personal_data_name>" +
                                                    $"<expiresIn>600000</expiresIn>" +
                                                    $"<omit-sms>true</omit-sms>" +
                                                    $"<ovt>{token}</ovt>" +
                                                $"</data>" +
                                            $"</requestData>" +
                                        $"</request>" +
                                    $"</SendMessage>" +
                                $"</soap:Body>" +
                            $"</soap:Envelope>";

            return req;
        }
    }
}
