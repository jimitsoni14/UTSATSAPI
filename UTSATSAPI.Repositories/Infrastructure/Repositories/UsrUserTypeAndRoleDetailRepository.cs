using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class UsrUserTypeAndRoleDetailRepository : GenericRepository<UsrUserTypeAndRoleDetail>, IUsrUserTypeAndRoleDetailRepository
{
public UsrUserTypeAndRoleDetailRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}