using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class PrgHrdeleteReasonRepository : GenericRepository<PrgHrdeleteReason>, IPrgHrdeleteReasonRepository
{
public PrgHrdeleteReasonRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}