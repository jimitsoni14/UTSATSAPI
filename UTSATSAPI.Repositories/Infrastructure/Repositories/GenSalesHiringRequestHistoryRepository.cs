using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class GenSalesHiringRequestHistoryRepository : GenericRepository<GenSalesHiringRequestHistory>, IGenSalesHiringRequestHistoryRepository
{
public GenSalesHiringRequestHistoryRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}