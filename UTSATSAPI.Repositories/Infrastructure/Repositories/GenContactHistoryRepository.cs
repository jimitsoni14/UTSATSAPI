using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class GenContactHistoryRepository : GenericRepository<GenContactHistory>, IGenContactHistoryRepository
{
public GenContactHistoryRepository(UTSATSAPIDBConnection dbContext) : base(dbContext){}
}
}
