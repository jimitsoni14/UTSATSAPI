using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class GenSalesHiringRequestSkillDetailRepository : GenericRepository<GenSalesHiringRequestSkillDetail>, IGenSalesHiringRequestSkillDetailRepository
{
public GenSalesHiringRequestSkillDetailRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}