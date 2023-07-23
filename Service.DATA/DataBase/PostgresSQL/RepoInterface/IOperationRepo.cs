using Service.DATA.Model;
using Service.DATA.Models.DTO;
using Service.Helpers.Classes.MO_RequestResponse;

namespace Service.DATA.DataBase.PostgresSQL.RepoInterface
{
    public interface IOperationRepo
    {
        public int AddDB_Candidates(MO_DataResponse responseData);
        //public List<Candidates> GetAllCandidates();
        public SurveyDTO GetIIN();
    }
}
