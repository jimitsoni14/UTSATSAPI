using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class GenTalentPrimarySkillDetailRepository : GenericRepository<GenTalentPrimarySkillDetail>, IGenTalentPrimarySkillDetailRepository
{
public GenTalentPrimarySkillDetailRepository(UTSATSAPIDBConnection dbContext) : base(dbContext){}
}
}
