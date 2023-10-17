using Service.DATA.DataBase.PostgresSQL.RepoInterface;
using Service.DATA.Models;
using Service.DATA.ResponseModel.GBDFLUniversal_token;
using Service.DATA.ResponseModel.KDP_Service;
using static Service.DATA.ResponseModel.MO_ISHASMR_ENBEKSERVICE.MO_ISHASMR_ENBEKSERVICE;
using static Service.DATA.ResponseModel.RDBService_MTSZN.RdbResponses;
using static Service.DATA.ResponseModel.RDBService_STATUS.ResponseModel;
using Service.DATA.Models.DTO;
using _logger = Service.DATA.Logger;
using static System.Net.Mime.MediaTypeNames;

namespace Service.DATA.DataBase.PostgresSQL.Repository
{
    public class OperationRepo : IOperationRepo
    {
        private KontraktnikDbContext _context;
        public OperationRepo(KontraktnikDbContext context)
        {
            _context = context;
        }

        public List<SurveyDTO> SendKDP_ServiceGetIIN()
        {
            try
            {
                List<SurveyDTO> client = (from c in _context.Surveys
                                          orderby c.Id
                                          //where c.CreatedAt < DateTime.Now && c.CreatedAt >= DateTime.Today.AddDays(-1)
                                          select new SurveyDTO
                                            {
                                                Id = c.Id,
                                                IIN = c.Iin,
                                                Phone = c.Phone,
                                                FullName = c.FullName,
                                            }).ToList();

                if (client is null) { throw new Exception("ИИН не найден"); }

                return client;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<SurveyDTO> SendGBDFLUniversal_tokenGetIIN()
        {
            try
            {
                List<SurveyDTO> client = (from c in _context.Surveys
                                          orderby c.Id
                                          //where c.CreatedAt < DateTime.Now && c.CreatedAt >= DateTime.Today.AddDays(-1)
                                          select new SurveyDTO
                                          {
                                              Id = c.Id,
                                              IIN = c.Iin
                                          }).ToList();

                if (client is null) { throw new Exception("ИИН не найден"); }

                return client;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<SurveyDTO> SendKDP_PERSONALDATAGetIIN()
        {
            try
            {
                List<SurveyDTO> client = (from c in _context.Surveys
                                          orderby c.Id
                                          //where c.CreatedAt < DateTime.Now && c.CreatedAt >= DateTime.Today.AddDays(-1)
                                          select new SurveyDTO
                                          {
                                              Id = c.Id,
                                              IIN = c.Iin
                                          }).ToList();

                if (client is null) { throw new Exception("ИИН не найден"); }

                return client;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<SurveyDTO> SendMO_ISHASMR_ENBEKSERVICEGetIIN()
        {
            try
            {
                List<SurveyDTO> client = (from c in _context.Surveys
                                          orderby c.Id
                                          //where c.CreatedAt < DateTime.Now && c.CreatedAt >= DateTime.Today.AddDays(-1)
                                          select new SurveyDTO
                                          {
                                              Id = c.Id,
                                              IIN = c.Iin,
                                              FullName = c.FullName,
                                          }).ToList();

                if (client is null) { throw new Exception("ИИН не найден"); }

                return client;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<SurveyDTO> SendRDBService_MTSZNGetIIN()
        {
            try
            {
                List<SurveyDTO> client = (from c in _context.Surveys
                                          orderby c.Id
                                          //where c.CreatedAt < DateTime.Now && c.CreatedAt >= DateTime.Today.AddDays(-1)
                                          select new SurveyDTO
                                          {
                                              Id = c.Id,
                                              IIN = c.Iin
                                          }).ToList();

                if (client is null) { throw new Exception("ИИН не найден"); }

                return client;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<SurveyDTO> SendRDBService_STATUSGetIIN()
        {
            try
            {
                List<SurveyDTO> client = (from c in _context.Surveys
                                          orderby c.Id
                                          //where c.CreatedAt < DateTime.Now && c.CreatedAt >= DateTime.Today.AddDays(-1)
                                          select new SurveyDTO
                                          {
                                              Id = c.Id,
                                              IIN = c.Iin
                                          }).ToList();

                if (client is null) { throw new Exception("ИИН не найден"); }

                return client;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddKDP_Service(sendMessageResponseResponseResponseDataData response, long surveyID)
        {
            try
            {
                var kdpToken = new Kdptoken()
                {
                    TokenVal = response.code,
                    SurveyId = surveyID,
                    PublicKey = response.publickey
                };

                _context.Kdptokens.Add(kdpToken);
                _context.SaveChanges();

                return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddGBDFLUniversal_token(responseResponseDataDataPersons response)
        {
            try
            {
                GbdflBirthPlace gbdflBirthPlace = new GbdflBirthPlace
                {
                    Countrycode = response.person.birthPlace.country.code.ToString(),
                    Countrynameru = response.person.birthPlace.country.nameRu.ToString(),
                    Countrynamekz = response.person.birthPlace.country.nameKz.ToString(),
                    Countrychangedate = (DateTime)response.person.birthPlace.country.changeDate,
                    Districtcode = response.person.birthPlace.district.code.ToString(),
                    Districtnameru = response.person.birthPlace.district.nameRu.ToString(),
                    Districtnamekz = response.person.birthPlace.district.nameKz.ToString(),
                    Districtchangedate = (DateTime)response.person.birthPlace.district.changeDate,
                    Regioncode = response.person.birthPlace.region.code.ToString(),
                    Regionnameru = response.person.birthPlace.region.nameRu.ToString(),
                    Regionnamekz = response.person.birthPlace.region.nameKz.ToString(),
                    Regionchangedate = (DateTime)response.person.birthPlace.region.changeDate,
                    City = response.person.birthPlace.city.ToString()
                };

                _logger.WriteToFile($"ADD gbdflBirthPlace", "GBDFLUniversal_token", _logger.LogLevel.Information);

                GbdflRegAddress gbdflRegAddress = new GbdflRegAddress
                {
                    Countrycode = response.person.regAddress.country.code.ToString(),
                    Countrynameru = response.person.regAddress.country.nameRu.ToString(),
                    Countrynamekz = response.person.regAddress.country.nameKz.ToString(),
                    Countrychangedate = (DateTime)response.person.regAddress.country.changeDate,
                    Districtcode = response.person.regAddress.district.code.ToString(),
                    Districtnameru = response.person.regAddress.district.nameRu.ToString(),
                    Districtnamekz = response.person.regAddress.district.nameKz.ToString(),
                    Districtchangedate = (DateTime)response.person.regAddress.district.changeDate,
                    Regioncode = response.person.regAddress.region.code.ToString(),
                    Regionnameru = response.person.regAddress.region.nameRu.ToString(),
                    Regionnamekz = response.person.regAddress.region.nameKz.ToString(),
                    Regionchangedate = (DateTime)response.person.regAddress.region.changeDate,
                    Street = response.person.regAddress.street.ToString(),
                    Building = response.person.regAddress.building.ToString(),
                    Begindate = (DateTime)response.person.regAddress.beginDate,
                    Statuscode = response.person.regAddress.status.code.ToString(),
                    Statusnameru = response.person.regAddress.status.nameRu.ToString(),
                    Statusnamekz = response.person.regAddress.status.nameKz.ToString(),
                    Statuschangedate = (DateTime)response.person.regAddress.status.changeDate,
                    Invaliditycode = response.person.regAddress.invalidity.code.ToString(),
                    Invaliditynameru = response.person.regAddress.invalidity.nameRu.ToString(),
                    Invaliditynamekz = response.person.regAddress.invalidity.nameKz.ToString(),
                    Invaliditychangedate = (DateTime)response.person.regAddress.invalidity.changeDate,
                    Arcode = response.person.regAddress.arCode.ToString(),
                };

                _logger.WriteToFile($"ADD gbdflRegAddress", "GBDFLUniversal_token", _logger.LogLevel.Information);

                GbdflDocument gbdflDocument = new GbdflDocument
                {
                    Typecode = response.person.documents.document.type.code.ToString(),
                    Typenameru = response.person.documents.document.type.nameRu.ToString(),
                    Typenamekz = response.person.documents.document.type.nameKz.ToString(),
                    Typechangedate = (DateTime)response.person.documents.document.type.changeDate,
                    Number = response.person.documents.document.number.ToString(),
                    Begindate = (DateTime)response.person.documents.document.beginDate,
                    Enddate = (DateTime)response.person.documents.document.endDate,
                    Issueorganizationcode = response.person.documents.document.issueOrganization.code.ToString(),
                    Issueorganizationcodenameru = response.person.documents.document.issueOrganization.nameRu.ToString(),
                    Issueorganizationcodenamekz = response.person.documents.document.issueOrganization.nameKz.ToString(),
                    Issueorganizationcodechangedate = (DateTime)response.person.documents.document.issueOrganization.changeDate,
                    Statuscode = response.person.documents.document.status.code.ToString(),
                    Statusnameru = response.person.documents.document.status.nameRu.ToString(),
                    Statusnamekz = response.person.documents.document.status.nameKz.ToString(),
                    Statuschangedate = (DateTime)response.person.documents.document.status.changeDate,
                    Surname = response.person.documents.document.surname.ToString(),
                    Name = response.person.documents.document.name.ToString(),
                    Patronymic = response.person.documents.document.patronymic.ToString(),
                    Birthdate = (DateTime)response.person.documents.document.birthDate,
                };

                _logger.WriteToFile($"ADD gbdflDocument", "GBDFLUniversal_token", _logger.LogLevel.Information);

                _context.GbdflBirthPlaces.Add(gbdflBirthPlace);
                _context.GbdflDocuments.Add(gbdflDocument);
                _context.GbdflRegAddresses.Add(gbdflRegAddress);
                _context.SaveChanges();

                _logger.WriteToFile($"Saving gbdflBirthPlace, gbdflDocument, gbdflRegAddress... ID = {gbdflBirthPlace.Id} || " +
                    $"{gbdflDocument.Id} || {gbdflRegAddress.Id}", "GBDFLUniversal_token", _logger.LogLevel.Information);

                var getSurveyId = _context.Surveys.SingleOrDefault(s => s.Iin == response.person.iin.ToString())!.Id;

                _logger.WriteToFile($"getSurveyId = {getSurveyId}", "GBDFLUniversal_token", _logger.LogLevel.Information);

                GbdflPersonInfo gbdflPersonInfo = new GbdflPersonInfo
                {
                    Birthplaceid = gbdflBirthPlace.Id,
                    Documentsid = gbdflDocument.Id,
                    Regaddressid = gbdflRegAddress.Id,
                    Iin = response.person.iin.ToString(),
                    Surname = response.person.surname.ToString(),
                    Name = response.person.name.ToString(),
                    Patronymic = response.person.patronymic.ToString(),
                    Birthdate = (DateTime)response.person.birthDate,
                    Gendercode = response.person.gender.code.ToString(),
                    Gendernameru = response.person.gender.nameRu.ToString(),
                    Gendernamekz = response.person.gender.nameKz.ToString(),
                    Genderchangedate = (DateTime)response.person.gender.changeDate,
                    Nationalitycode = response.person.nationality.code.ToString(),
                    Nationalitynameru = response.person.nationality.nameRu.ToString(),
                    Nationalitynamekz = response.person.nationality.nameKz.ToString(),
                    Nationalitychangedate = (DateTime)response.person.nationality.changeDate,
                    Citizenshipcode = response.person.citizenship.code.ToString(),
                    Citizenshipnameru = response.person.citizenship.nameRu.ToString(),
                    Citizenshipnamekz = response.person.citizenship.nameKz.ToString(),
                    Citizenshipchangedate = (DateTime)response.person.citizenship.changeDate,
                    Lifestatuscode = response.person.lifeStatus.code.ToString(),
                    Lifestatusnameru = response.person.lifeStatus.nameRu.ToString(),
                    Lifestatusnamekz = response.person.lifeStatus.nameKz.ToString(),
                    Lifestatuschangedate = (DateTime)response.person.lifeStatus.changeDate,
                    Surveyid = getSurveyId
                };

                _logger.WriteToFile($"Add gbdflPersonInfo", "GBDFLUniversal_token", _logger.LogLevel.Information);

                _context.GbdflPersonInfos.Add(gbdflPersonInfo);
                _context.SaveChanges();

                return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddKDP_PERSONALDATA(ResponseModel.KDP_PERSONALDATA.responseResponseDataData response)
        {
            try
            {
                //var tokens = (from t in _context.Kdptokens
                //              where t.SurveyId == surveyId
                //              select t).FirstOrDefault();

                return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddMO_ISHASMR_ENBEKSERVICE(MilitaryServiceResponse response, long surveyId)
        {
            try
            {
                var mo_ishsmr_service = new MoIshasmrEnbekDatum
                {
                    Iin = response.IIN.ToString(),
                    Requestnumber = response.requestNumber.ToString(),
                    Responsedate = (DateTime)response.responseDate,
                    Requestdate = (DateTime)response.requestDate,
                    Lastname = response.lastname.ToString(),
                    Firstname = response.firstname.ToString(),
                    Patronymic = response.patronymic.ToString(),
                    Birthdate = (DateTime)response.birthdate,
                    Statuscode = response.status.ToString(),
                    Statusnameru = response.statusNameRu.ToString(),
                    Statusnamekz = response.statusNameKz.ToString(),
                    Commentru = response.commentRu.ToString(),
                    Commentkz = response.commentKz.ToString(),
                    Surveyid = surveyId
                };

                _logger.WriteToFile($"Add mo_ishsmr_service", "MO_ISHASMR_ENBEKSERVICE", _logger.LogLevel.Information);

                _context.MoIshasmrEnbekData.Add(mo_ishsmr_service);
                _context.SaveChanges();

                _logger.WriteToFile($"Save mo_ishsmr_service", "MO_ISHASMR_ENBEKSERVICE", _logger.LogLevel.Information);

                return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Kdptoken GetKdptokenGBDFLUniversal_token(long surveyId)
        {
            try
            {
                var tokens = (from t in _context.Kdptokens
                              where t.SurveyId == surveyId
                              select t).FirstOrDefault();
                if(tokens is null) 
                {
                    _logger.WriteToFile($"In KdpToken table = {tokens}", "GBDFLUniversal_token", _logger.LogLevel.Information);
                    return null;
                }
                return tokens!;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message); 
            }
        }

        public int AddRDBService_MTSZNResponse(GetRdbResponse response, long surveyId)
        {
            try
            {
                var existRdbData = _context.RdbData.Select(r => r.Surveyid == surveyId &&
                                                                    r.Iin == response.RdbResponse.Iin.ToString()).FirstOrDefault();

                _logger.WriteToFile($"existRdbData = {existRdbData}", "RDBService_MTSZN", _logger.LogLevel.Information);

                if (existRdbData == false)
                {
                    string[] messageRu = response.RdbResponse.Message.Split(new char[] { ';' });
                    string[] messageKz = response.RdbResponse.MessageKz.Split(new char[] { ';' });

                    RdbDatum rdbDatum = new RdbDatum
                    {
                        Firstname = response.RdbResponse.FirstName,
                        Lastname = response.RdbResponse.LastName,
                        Secondname = response.RdbResponse.SecondName,
                        Birthdate = response.RdbResponse.BirthDate,
                        Iin = response.RdbResponse.Iin.ToString(),
                        Messagenarcologyru = messageRu[0],
                        Messagenarcologykz = messageKz[0],
                        Messagepsychoru = messageRu[1],
                        Messagepsychokz = messageKz[1],
                        Messagetuberculosisru = messageRu[2],
                        Messagetuberculosiskz = messageKz[2],
                        Address = response.RdbResponse.Address,
                        Surveyid = surveyId
                    };

                    _context.RdbData.Add(rdbDatum);
                    _context.SaveChanges();

                    _logger.WriteToFile($"Saving", "RDBService_MTSZN", _logger.LogLevel.Information);
                }
                else
                {
                    string[] messageRu = response.RdbResponse.Message.Split(new char[] { ';' });
                    string[] messageKz = response.RdbResponse.MessageKz.Split(new char[] { ';' });

                    _logger.WriteToFile($"messageRu1 = {messageRu[0]}", "RDBService_MTSZN", _logger.LogLevel.Information);
                    _logger.WriteToFile($"messageRu2 = {messageRu[1]}", "RDBService_MTSZN", _logger.LogLevel.Information);
                    _logger.WriteToFile($"messageRu3 = {messageRu[2]}", "RDBService_MTSZN", _logger.LogLevel.Information);


                    var updateRdbData = new RdbDatum
                    {
                        Messagenarcologyru = messageRu[0],
                        Messagenarcologykz = messageKz[0],
                        Messagepsychoru = messageRu[1],
                        Messagepsychokz = messageKz[1],
                        Messagetuberculosisru = messageRu[2],
                        Messagetuberculosiskz = messageKz[2],
                    };

                    _context.RdbData.Update(updateRdbData);
                    _context.SaveChanges();

                    _logger.WriteToFile($"Saving", "RDBService_MTSZN", _logger.LogLevel.Information);
                }

                return 1;
            }
            catch (Exception ex)
            {
                _logger.WriteToFile($"ErrorData = {ex.Message} ||| {ex.InnerException}", "RDBService_MTSZN", _logger.LogLevel.Error);
                throw new Exception(ex.Message);
            }
        }

        public int AddRDBService_STATUSResponse(responseResponseDataDataRdbResponse response, long surveyId)
        {
            try
            {
                var existRdbData = _context.RdbData.FirstOrDefault(r => r.Surveyid == surveyId || r.Iin == response.Iin.ToString());

                _logger.WriteToFile($"existRdbData.IIN = {existRdbData.Iin}", "RDBService_STATUS", _logger.LogLevel.Information);

                if (existRdbData == null)
                {
                    RdbDatum rdbDatum = new RdbDatum
                    {
                        Firstname = response.FirstName,
                        Lastname = response.LastName,
                        Secondname = response.SecondName,
                        Birthdate = response.BirthDate,
                        Iin = response.Iin.ToString(),
                        Address = response.Address,
                        Messagevenereologicalru = response.Message,
                        Messagevenereologicalkz = response.MessageKz,
                        Surveyid = surveyId
                    };

                    _context.RdbData.Add(rdbDatum);
                    _context.SaveChanges();
                    _logger.WriteToFile($"Saving", "RDBService_STATUS", _logger.LogLevel.Information);
                }
                else
                {
                    existRdbData = new RdbDatum
                    {
                        Messagevenereologicalru = response.Message,
                        Messagevenereologicalkz = response.MessageKz
                    };

                    _context.RdbData.Update(existRdbData);
                    _context.SaveChanges();

                    _logger.WriteToFile($"Saving", "RDBService_STATUS", _logger.LogLevel.Information);
                }

                return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
