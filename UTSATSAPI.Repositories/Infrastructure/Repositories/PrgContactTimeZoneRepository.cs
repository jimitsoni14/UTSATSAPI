using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class PrgContactTimeZoneRepository : GenericRepository<PrgContactTimeZone>, IPrgContactTimeZoneRepository
{
public PrgContactTimeZoneRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}