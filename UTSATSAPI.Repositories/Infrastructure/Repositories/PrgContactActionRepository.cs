using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class PrgContactActionRepository : GenericRepository<PrgContactAction>, IPrgContactActionRepository
{
public PrgContactActionRepository(UTSATSAPIDBConnection dbContext) : base(dbContext){}
}
}
