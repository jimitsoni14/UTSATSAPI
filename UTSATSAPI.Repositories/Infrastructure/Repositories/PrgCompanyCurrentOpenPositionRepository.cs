using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class PrgCompanyCurrentOpenPositionRepository : GenericRepository<PrgCompanyCurrentOpenPosition>, IPrgCompanyCurrentOpenPositionRepository
{
public PrgCompanyCurrentOpenPositionRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}