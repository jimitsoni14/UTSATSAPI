using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class GenMenuRightRepository : GenericRepository<GenMenuRight>, IGenMenuRightRepository
{
public GenMenuRightRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}