using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class GenDirectPlacementRepository : GenericRepository<GenDirectPlacement>, IGenDirectPlacementRepository
{
public GenDirectPlacementRepository(UTSATSAPIDBConnection dbContext) : base(dbContext){}
}
}
