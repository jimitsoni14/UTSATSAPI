using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
namespace UTSATSAPI.Repositories.Infrastructure.Repositories
{
public class HubspotWebhookNotificationRepository : GenericRepository<HubspotWebhookNotification>, IHubspotWebhookNotificationRepository
{
public HubspotWebhookNotificationRepository(TalentConnectAdminDBContext dbContext) : base(dbContext){}
}
}