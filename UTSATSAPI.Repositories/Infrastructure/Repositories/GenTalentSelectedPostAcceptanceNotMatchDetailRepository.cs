using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class GenTalentSelectedPostAcceptanceNotMatchDetailRepository : GenericRepository<GenTalentSelectedPostAcceptanceNotMatchDetail>, IGenTalentSelectedPostAcceptanceNotMatchDetailRepository
{
public GenTalentSelectedPostAcceptanceNotMatchDetailRepository(UTSATSAPIDBConnection dbContext) : base(dbContext){}
}
}
