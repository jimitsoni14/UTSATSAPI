using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class PrgCrmApiPartnerRepository : GenericRepository<PrgCrmApiPartner>, IPrgCrmApiPartnerRepository
{
public PrgCrmApiPartnerRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}