using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class GenClientHappinessSurveyQuestionRepository : GenericRepository<GenClientHappinessSurveyQuestion>, IGenClientHappinessSurveyQuestionRepository
{
public GenClientHappinessSurveyQuestionRepository(UTSATSAPIDBConnection dbContext) : base(dbContext){}
}
}
