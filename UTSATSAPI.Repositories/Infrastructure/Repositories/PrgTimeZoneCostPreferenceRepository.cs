using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class PrgTimeZoneCostPreferenceRepository : GenericRepository<PrgTimeZoneCostPreference>, IPrgTimeZoneCostPreferenceRepository
{
public PrgTimeZoneCostPreferenceRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}