using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class CustomExceptionRepository : GenericRepository<CustomException>, ICustomExceptionRepository
{
public CustomExceptionRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}