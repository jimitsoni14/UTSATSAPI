using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class GenShortlistedTalentInterviewDetailRepository : GenericRepository<GenShortlistedTalentInterviewDetail>, IGenShortlistedTalentInterviewDetailRepository
{
public GenShortlistedTalentInterviewDetailRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}