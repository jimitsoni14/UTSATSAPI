using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class PrgOrgLevelRepository : GenericRepository<PrgOrgLevel>, IPrgOrgLevelRepository
{
public PrgOrgLevelRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}