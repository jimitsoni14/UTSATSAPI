using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class PrgIncContractsSlabRepository : GenericRepository<PrgIncContractsSlab>, IPrgIncContractsSlabRepository
{
public PrgIncContractsSlabRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}