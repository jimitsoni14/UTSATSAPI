using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class GenHrnotesTagUserDetailRepository : GenericRepository<GenHrnotesTagUserDetail>, IGenHrnotesTagUserDetailRepository
{
public GenHrnotesTagUserDetailRepository(UTSATSAPIDBConnection dbContext) : base(dbContext){}
}
}
