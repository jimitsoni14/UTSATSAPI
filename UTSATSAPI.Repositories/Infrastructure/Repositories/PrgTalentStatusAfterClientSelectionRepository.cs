using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class PrgTalentStatusAfterClientSelectionRepository : GenericRepository<PrgTalentStatusAfterClientSelection>, IPrgTalentStatusAfterClientSelectionRepository
{
public PrgTalentStatusAfterClientSelectionRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}