using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class PrgTalentRejectReasonRepository : GenericRepository<PrgTalentRejectReason>, IPrgTalentRejectReasonRepository
{
public PrgTalentRejectReasonRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}