using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class PrgCrmApiDetailRepository : GenericRepository<PrgCrmApiDetail>, IPrgCrmApiDetailRepository
{
public PrgCrmApiDetailRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}