using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class PrgRateCardRepository : GenericRepository<PrgRateCard>, IPrgRateCardRepository
{
public PrgRateCardRepository(UTSATSAPIDBConnection dbContext) : base(dbContext){}
}
}
