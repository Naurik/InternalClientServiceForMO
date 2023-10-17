using Service.DATA.Models;
using Service.DATA.ResponseModel.GBDFLUniversal_token;
using Service.DATA.ResponseModel.KDP_Service;
using static Service.DATA.ResponseModel.MO_ISHASMR_ENBEKSERVICE.MO_ISHASMR_ENBEKSERVICE;
using static Service.DATA.ResponseModel.RDBService_MTSZN.RdbResponses;
using static Service.DATA.ResponseModel.RDBService_STATUS.ResponseModel;
using Service.DATA.Models.DTO;

namespace Service.DATA.DataBase.PostgresSQL.RepoInterface
{
    public interface IOperationRepo
    {
        public List<SurveyDTO> SendKDP_ServiceGetIIN();

        public List<SurveyDTO> SendGBDFLUniversal_tokenGetIIN();

        public Kdptoken GetKdptokenGBDFLUniversal_token(long surveyId);

        public List<SurveyDTO> SendRDBService_MTSZNGetIIN();

        public List<SurveyDTO> SendRDBService_STATUSGetIIN();

        public List<SurveyDTO> SendKDP_PERSONALDATAGetIIN();

        public List<SurveyDTO> SendMO_ISHASMR_ENBEKSERVICEGetIIN();

        public int AddKDP_Service(sendMessageResponseResponseResponseDataData response, long surveyID);

        public int AddGBDFLUniversal_token(responseResponseDataDataPersons response);

        public int AddRDBService_MTSZNResponse(GetRdbResponse response, long surveyId);

        public int AddRDBService_STATUSResponse(responseResponseDataDataRdbResponse response, long surveyId);

        public int AddKDP_PERSONALDATA(ResponseModel.KDP_PERSONALDATA.responseResponseDataData response);

        public int AddMO_ISHASMR_ENBEKSERVICE(MilitaryServiceResponse response, long surveyId);
    }
}
