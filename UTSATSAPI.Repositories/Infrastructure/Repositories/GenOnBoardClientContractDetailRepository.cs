using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class GenOnBoardClientContractDetailRepository : GenericRepository<GenOnBoardClientContractDetail>, IGenOnBoardClientContractDetailRepository
{
public GenOnBoardClientContractDetailRepository(UTSATSAPIDBConnection dbContext) : base(dbContext){}
}
}
