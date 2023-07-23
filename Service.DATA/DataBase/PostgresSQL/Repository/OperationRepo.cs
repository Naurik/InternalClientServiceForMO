using Service.DATA.DataBase.PostgresSQL.RepoInterface;
using Service.DATA.Models;
using Service.DATA.Models.DTO;
using Service.Helpers;
using Service.Helpers.Classes.MO_RequestResponse;

namespace Service.DATA.DataBase.PostgresSQL.Repository
{
    public class OperationRepo : IOperationRepo
    {
        private KontraktnikDbContext _context;
        public OperationRepo(KontraktnikDbContext context)
        {
            _context = context;
        }

        //Добавление кандидатов из ответа МО
        public int AddDB_Candidates(MO_DataResponse responseData) 
        {
            try
            {
                // добавление данных
                using (_context = new KontraktnikDbContext())
                {
                    //// создаем два объекта User
                    //Candidates candidates = new Candidates
                    //{
                    //    FullName = responseData.FullName,
                    //    BirthDate = responseData.BirthDate,
                    //    EducationInfo = responseData.EducationInfo,
                    //    Locations = responseData.Locations,
                    //    SpouseEducationInfo = responseData.SpouseEducationInfo,
                    //    WorkingActivity = responseData.WorkingActivity,
                    //    ResponseDate = responseData.ResponseDate,
                    //};

                    //// добавляем их в бд
                    //_context.Candidates.AddRange(candidates);
                    //_context.SaveChanges();
                    return 1;
                }
            }
            catch(Exception ex)
            {
                Logger.Log.Debug("Error in Insert: " + responseData, ex);
                return 0;
            }
        }

        //public List<Candidates> GetAllCandidates()
        //{
        //    List<Candidates> list = _context.Surveys.Select(x => new Candidates
        //    {
        //        Id = x.Id,
        //        FullName = x.FullName,
        //        BirthDate = x.BirthDate,
        //        Locations = x.Locations,
        //        EducationInfo = x.EducationInfo,
        //        SpouseEducationInfo = x.SpouseEducationInfo,
        //        WorkingActivity = x.WorkingActivity,
        //        ResponseDate = x.ResponseDate

        //    }).ToList();

        //    return list;
        //}

        public SurveyDTO GetIIN()
        {
            var client = (from c in _context.Surveys
                          orderby c.Id
                          select new SurveyDTO {IIN = c.Iin }).FirstOrDefault();

            if (client is null) { throw new Exception("ИИН не найден"); }

            return client;
        }
    }
}
