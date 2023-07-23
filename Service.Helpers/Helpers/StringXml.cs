namespace Service.Helpers.Helpers
{
    public class StringXml
    {
        /// <summary>
        /// Реализация xml запроса в string формате
        /// </summary>
        /// <param name="iin"></param>
        /// <param name="guid"></param>
        /// <returns></returns>
        public string StringXmlRequest(string iin, string guid) 
        {
            var dateTime = DateTime.Now;
            string login = "int1jauyngerkz";
            string password = "QwgII3j4";
            var request =
                    $"<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:typ=\"http://bip.bee.kz/SyncChannel/v10/Types\">" +
                        $"<soapenv:Body  Id=\"{guid}\">" +
                            $"<typ:SendMessage>" +
                                $"<request>" +
                                    $"<requestInfo>" +
                                        $"<messageId>{Guid.NewGuid()}</messageId>" +
                                        $"<serviceId>KDP_SERVICE</serviceId>" +
                                        $"<messageDate>{dateTime.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz")}</messageDate>" +
                                        $"<sender>" +
                                        $"<senderId>{login}</senderId>" +
                                        $"<password>{password}</password>" +
                                        $"</sender>" +
                                        $"<sessionId>{Guid.NewGuid()}</sessionId>" +
                                    $"</requestInfo>" +
                                    $"<requestData>" +
                                    $"<data>" +
                                        $"<iin>{iin}</iin>" +
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
