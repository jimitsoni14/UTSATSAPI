using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class PrgTalentSkillBenchMarkRepository : GenericRepository<PrgTalentSkillBenchMark>, IPrgTalentSkillBenchMarkRepository
{
public PrgTalentSkillBenchMarkRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}