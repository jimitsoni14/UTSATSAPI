using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class GenIncAmTalentDeployUserRoleDetailRepository : GenericRepository<GenIncAmTalentDeployUserRoleDetail>, IGenIncAmTalentDeployUserRoleDetailRepository
{
public GenIncAmTalentDeployUserRoleDetailRepository(UTSATSAPIDBConnection dbContext) : base(dbContext){}
}
}
