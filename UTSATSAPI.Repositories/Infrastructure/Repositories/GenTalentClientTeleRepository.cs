using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class GenTalentClientTeleRepository : GenericRepository<GenTalentClientTele>, IGenTalentClientTeleRepository
{
public GenTalentClientTeleRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}