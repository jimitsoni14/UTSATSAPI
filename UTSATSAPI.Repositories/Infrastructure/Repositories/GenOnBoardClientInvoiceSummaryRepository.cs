using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class GenOnBoardClientInvoiceSummaryRepository : GenericRepository<GenOnBoardClientInvoiceSummary>, IGenOnBoardClientInvoiceSummaryRepository
{
public GenOnBoardClientInvoiceSummaryRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}