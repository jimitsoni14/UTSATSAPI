using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class PrgPipelineRepository : GenericRepository<PrgPipeline>, IPrgPipelineRepository
{
public PrgPipelineRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}