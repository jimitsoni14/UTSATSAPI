using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class GenTalentComfortableWorkingDetailRepository : GenericRepository<GenTalentComfortableWorkingDetail>, IGenTalentComfortableWorkingDetailRepository
{
public GenTalentComfortableWorkingDetailRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}