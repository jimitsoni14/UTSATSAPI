using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class GenDealRepository : GenericRepository<GenDeal>, IGenDealRepository
{
public GenDealRepository(UTSATSAPIDBConnection dbContext) : base(dbContext){}
}
}
