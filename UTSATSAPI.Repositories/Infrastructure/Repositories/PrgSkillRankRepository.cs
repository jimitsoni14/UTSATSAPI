using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class PrgSkillRankRepository : GenericRepository<PrgSkillRank>, IPrgSkillRankRepository
{
public PrgSkillRankRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}