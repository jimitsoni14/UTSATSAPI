﻿using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UTSATSAPI.Models.Generic;
using UTSATSAPI.Models.Models;
using UTSATSAPI.Repositories.Infrastructure.Repositories;
using UTSATSAPI.Repositories.Interfaces;
using UTSATSAPI.Repositories.Interfaces.UpChat;
using UTSATSAPI.Repositories.Repositories;
using UTSATSAPI.Repositories.Repositories.UpChat;

namespace UTSATSAPI.Repositories.Infrastructure.ServiceExtension
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddDIServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient();
            services.AddTransient<ICommonInterface, CommonRepository>();
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IUniversalProcRunner, UniversalProcRunnerRepository>();

            services.AddDbContextPool<TalentConnectAdminDBContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("TalentConnectAdminDBConnection"), 
                    sqlOptions => sqlOptions.CommandTimeout(120)
                );
            });

            services.AddDbContext<TalentConnectAdminDBContext>(ServiceLifetime.Scoped);
            services.AddDbContext<InMemoryDbContext>(ServiceLifetime.Scoped,ServiceLifetime.Scoped);
            
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUsrUserRepository, UsrUserRepository>();

            //services.AddScoped<ICustomExceptionRepository, CustomExceptionRepository>();
            //services.AddScoped<IGenAibasedHrtalentMatchMakingRepository, GenAibasedHrtalentMatchMakingRepository>();
            //services.AddScoped<IGenAibasedHrtalentMatchMakingDetailRepository, GenAibasedHrtalentMatchMakingDetailRepository>();
            //services.AddScoped<IGenAmAssignmentRuleHistoryRepository, GenAmAssignmentRuleHistoryRepository>();
            //services.AddScoped<IGenAmnbdAssignmentEmailsendDetailRepository, GenAmnbdAssignmentEmailsendDetailRepository>();
            //services.AddScoped<IGenBlogRepository, GenBlogRepository>();
            //services.AddScoped<IGenClientAmAssignmentRepository, GenClientAmAssignmentRepository>();
            //services.AddScoped<IGenClientAmAssignmentHistoryRepository, GenClientAmAssignmentHistoryRepository>();
            //services.AddScoped<IGenClientCalendarEventRepository, GenClientCalendarEventRepository>();
            //services.AddScoped<IGenClientHappinessSurveyRepository, GenClientHappinessSurveyRepository>();
            //services.AddScoped<IGenClientHappinessSurveyOptionRepository, GenClientHappinessSurveyOptionRepository>();
            //services.AddScoped<IGenClientHappinessSurveyQuestionRepository, GenClientHappinessSurveyQuestionRepository>();
            //services.AddScoped<IGenClientPayOutAdditionalLineItemRepository, GenClientPayOutAdditionalLineItemRepository>();
            services.AddScoped<IGenCompanyRepository, GenCompanyRepository>();
            services.AddScoped<IGenCompanyContractDetailRepository, GenCompanyContractDetailRepository>();
            //services.AddScoped<IGenCompanyLeadTypeUserDetailRepository, GenCompanyLeadTypeUserDetailRepository>();
            //services.AddScoped<IGenCompanyLegalInfoRepository, GenCompanyLegalInfoRepository>();
            //services.AddScoped<IGenCompanyUpdateRepository, GenCompanyUpdateRepository>();
            //services.AddScoped<IGenCompanyWeightedAverageCriterionRepository, GenCompanyWeightedAverageCriterionRepository>();
            services.AddScoped<IGenContactRepository, GenContactRepository>();
            //services.AddScoped<IGenContactGetHelpQuestionRepository, GenContactGetHelpQuestionRepository>();
            //services.AddScoped<IGenContactHistoryRepository, GenContactHistoryRepository>();
            //services.AddScoped<IGenContactInterviewFeedbackRepository, GenContactInterviewFeedbackRepository>();
            //services.AddScoped<IGenContactNotificationHistoryRepository, GenContactNotificationHistoryRepository>();
            //services.AddScoped<IGenContactPendingActionRepository, GenContactPendingActionRepository>();
            services.AddScoped<IGenContactPointofContactRepository, GenContactPointofContactRepository>();
            services.AddScoped<IGenContactTalentPriorityRepository, GenContactTalentPriorityRepository>();
            services.AddScoped<IGenDealRepository, GenDealRepository>();
            //services.AddScoped<IGenDealContactRepository, GenDealContactRepository>();
            //services.AddScoped<IGenDealTicketRepository, GenDealTicketRepository>();
            //services.AddScoped<IGenDirectPlacementRepository, GenDirectPlacementRepository>();
            //services.AddScoped<IGenEsalesAmApiResponseRepository, GenEsalesAmApiResponseRepository>();
            //services.AddScoped<IGenFrontendClientRepository, GenFrontendClientRepository>();
            //services.AddScoped<IGenHistoryRepository, GenHistoryRepository>();
            //services.AddScoped<IGenHrnoteRepository, GenHrnoteRepository>();
            //services.AddScoped<IGenHrnotesTagUserDetailRepository, GenHrnotesTagUserDetailRepository>();
            //services.AddScoped<IGenHubSpotCompanyRepository, GenHubSpotCompanyRepository>();
            //services.AddScoped<IGenHubSpotContactRepository, GenHubSpotContactRepository>();
            //services.AddScoped<IGenIncAmNrUserRoleDetailRepository, GenIncAmNrUserRoleDetailRepository>();
            //services.AddScoped<IGenIncAmTalentDeployUserRoleDetailRepository, GenIncAmTalentDeployUserRoleDetailRepository>();
            //services.AddScoped<IGenIncBaseSalUserRoleDetailRepository, GenIncBaseSalUserRoleDetailRepository>();
            //services.AddScoped<IGenIncContractTalentUserRoleDetailRepository, GenIncContractTalentUserRoleDetailRepository>();
            //services.AddScoped<IGenIncContractUserRoleDetailRepository, GenIncContractUserRoleDetailRepository>();
            //services.AddScoped<IGenIncPlacementFeesTalentUserRoleDetailRepository, GenIncPlacementFeesTalentUserRoleDetailRepository>();
            //services.AddScoped<IGenIncSalesIncentiveTargetDetailRepository, GenIncSalesIncentiveTargetDetailRepository>();
            //services.AddScoped<IGenIncSalesIncentiveTargetSummaryRepository, GenIncSalesIncentiveTargetSummaryRepository>();
            //services.AddScoped<IGenIncSalesIncentiveTargetSummaryHistoryRepository, GenIncSalesIncentiveTargetSummaryHistoryRepository>();
            //services.AddScoped<IGenIncTargetAcheivedDetailRepository, GenIncTargetAcheivedDetailRepository>();
            //services.AddScoped<IGenIncUserTargetRepository, GenIncUserTargetRepository>();
            //services.AddScoped<IGenIncUserTargetsHistoryRepository, GenIncUserTargetsHistoryRepository>();
            //services.AddScoped<IGenInterviewSlotsMasterRepository, GenInterviewSlotsMasterRepository>();
            //services.AddScoped<IGenManagedTalentRepository, GenManagedTalentRepository>();
            //services.AddScoped<IGenManagedTalentHistoryRepository, GenManagedTalentHistoryRepository>();
            //services.AddScoped<IGenMenuMasterRepository, GenMenuMasterRepository>();
            //services.AddScoped<IGenMenuRightRepository, GenMenuRightRepository>();
            //services.AddScoped<IGenOnBoardClientContractDetailRepository, GenOnBoardClientContractDetailRepository>();
            //services.AddScoped<IGenOnBoardClientDevicePolicyDetailRepository, GenOnBoardClientDevicePolicyDetailRepository>();
            //services.AddScoped<IGenOnBoardClientInvoiceSummaryRepository, GenOnBoardClientInvoiceSummaryRepository>();
            //services.AddScoped<IGenOnBoardClientLeavePolicyRepository, GenOnBoardClientLeavePolicyRepository>();
            //services.AddScoped<IGenOnBoardClientTeamRepository, GenOnBoardClientTeamRepository>();
            services.AddScoped<IGenOnBoardTalentRepository, GenOnBoardTalentRepository>();
            //services.AddScoped<IGenOnBoardTalentsClientFeedbackRepository, GenOnBoardTalentsClientFeedbackRepository>();
            //services.AddScoped<IGenOnBoardTalentsLegalDetailRepository, GenOnBoardTalentsLegalDetailRepository>();
            services.AddScoped<IGenOnBoardTalentsReplacementDetailRepository, GenOnBoardTalentsReplacementDetailRepository>();
            //services.AddScoped<IGenOnlyDealIdRepository, GenOnlyDealIdRepository>();
            //services.AddScoped<IGenPayoutInformationRepository, GenPayoutInformationRepository>();
            //services.AddScoped<IGenPmsTalentRedirectUrlDetailRepository, GenPmsTalentRedirectUrlDetailRepository>();
            //services.AddScoped<IGenPostalCodeswithDetailRepository, GenPostalCodeswithDetailRepository>();
            services.AddScoped<IGenSalesHiringRequestRepository, GenSalesHiringRequestRepository>();
            //services.AddScoped<IGenSalesHiringRequestDetailRepository, GenSalesHiringRequestDetailRepository>();
            //services.AddScoped<IGenSalesHiringRequestDetailsHistoryRepository, GenSalesHiringRequestDetailsHistoryRepository>();
            //services.AddScoped<IGenSalesHiringRequestHistoryRepository, GenSalesHiringRequestHistoryRepository>();
            //services.AddScoped<IGenSalesHiringRequestInterviewerDetailRepository, GenSalesHiringRequestInterviewerDetailRepository>();
            //services.AddScoped<IGenSalesHiringRequestPriorityRepository, GenSalesHiringRequestPriorityRepository>();
            //services.AddScoped<IGenSalesHiringRequestPriorityHistoryRepository, GenSalesHiringRequestPriorityHistoryRepository>();
            services.AddScoped<IGenSalesHiringRequestSkillDetailRepository, GenSalesHiringRequestSkillDetailRepository>();
            //services.AddScoped<IGenSalesHrJddumpRepository, GenSalesHrJddumpRepository>();
            //services.AddScoped<IGenSalesHrJddumpSkillDetailRepository, GenSalesHrJddumpSkillDetailRepository>();
            //services.AddScoped<IGenSalesHrTracceptedDetailRepository, GenSalesHrTracceptedDetailRepository>();
            //services.AddScoped<IGenShortlistedTalentRepository, GenShortlistedTalentRepository>();
            //services.AddScoped<IGenShortlistedTalentInterviewDetailRepository, GenShortlistedTalentInterviewDetailRepository>();
            //services.AddScoped<IGenSocialMediaLoginDetailRepository, GenSocialMediaLoginDetailRepository>();
            //services.AddScoped<IGenSystemConfigurationRepository, GenSystemConfigurationRepository>();
            services.AddScoped<IGenTalentRepository, GenTalentRepository>();
            //services.AddScoped<IGenTalentApplicationToolRepository, GenTalentApplicationToolRepository>();
            //services.AddScoped<IGenTalentAssesmentScoreRepository, GenTalentAssesmentScoreRepository>();
            //services.AddScoped<IGenTalentAssesmentSkillScoreRepository, GenTalentAssesmentSkillScoreRepository>();
            //services.AddScoped<IGenTalentCertificationsDetailRepository, GenTalentCertificationsDetailRepository>();
            //services.AddScoped<IGenTalentClientTeleRepository, GenTalentClientTeleRepository>();
            //services.AddScoped<IGenTalentComfortableAreaDetailRepository, GenTalentComfortableAreaDetailRepository>();
            //services.AddScoped<IGenTalentComfortableWorkingDetailRepository, GenTalentComfortableWorkingDetailRepository>();
            //services.AddScoped<IGenTalentEducationDetailRepository, GenTalentEducationDetailRepository>();
            //services.AddScoped<IGenTalentFinancialDetailRepository, GenTalentFinancialDetailRepository>();
            //services.AddScoped<IGenTalentGetHelpQuestionRepository, GenTalentGetHelpQuestionRepository>();
            //services.AddScoped<IGenTalentHistoryRepository, GenTalentHistoryRepository>();
            //services.AddScoped<IGenTalentInterestDetailRepository, GenTalentInterestDetailRepository>();
            //services.AddScoped<IGenTalentInterviewFeedbackRepository, GenTalentInterviewFeedbackRepository>();
            //services.AddScoped<IGenTalentKeyQualityDetailRepository, GenTalentKeyQualityDetailRepository>();
            //services.AddScoped<IGenTalentLegalInfoRepository, GenTalentLegalInfoRepository>();
            //services.AddScoped<IGenTalentNotificationHistoryRepository, GenTalentNotificationHistoryRepository>();
            //services.AddScoped<IGenTalentPayOutAdditionalLineItemRepository, GenTalentPayOutAdditionalLineItemRepository>();
            //services.AddScoped<IGenTalentPendingActionRepository, GenTalentPendingActionRepository>();
            //services.AddScoped<IGenTalentPointofContactRepository, GenTalentPointofContactRepository>();
            //services.AddScoped<IGenTalentPreferableWorkingDetailRepository, GenTalentPreferableWorkingDetailRepository>();
            //services.AddScoped<IGenTalentPrimarySkillDetailRepository, GenTalentPrimarySkillDetailRepository>();
            //services.AddScoped<IGenTalentProfessionalExperienceRepository, GenTalentProfessionalExperienceRepository>();
            //services.AddScoped<IGenTalentProjectDetailRepository, GenTalentProjectDetailRepository>();
            //services.AddScoped<IGenTalentResumeDetailRepository, GenTalentResumeDetailRepository>();
            //services.AddScoped<IGenTalentSecondarySkillDetailRepository, GenTalentSecondarySkillDetailRepository>();
            //services.AddScoped<IGenTalentSelectedInterviewDetailRepository, GenTalentSelectedInterviewDetailRepository>();
            //services.AddScoped<IGenTalentSelectedInterviewerDetailRepository, GenTalentSelectedInterviewerDetailRepository>();
            //services.AddScoped<IGenTalentSelectedNextRoundInterviewDetailRepository, GenTalentSelectedNextRoundInterviewDetailRepository>();
            //services.AddScoped<IGenTalentSelectedPostAcceptanceDetailRepository, GenTalentSelectedPostAcceptanceDetailRepository>();
            //services.AddScoped<IGenTalentSelectedPostAcceptanceNotMatchDetailRepository, GenTalentSelectedPostAcceptanceNotMatchDetailRepository>();
            //services.AddScoped<IGenTalentSelectionHistoryRepository, GenTalentSelectionHistoryRepository>();
            //services.AddScoped<IGenTalentTestimonialOrFeedbackRepository, GenTalentTestimonialOrFeedbackRepository>();
            services.AddScoped<IGenTeamRepository, GenTeamRepository>();
            //services.AddScoped<IGenTeamDistributionRepository, GenTeamDistributionRepository>();
            //services.AddScoped<IGenTestimonialRepository, GenTestimonialRepository>();
            //services.AddScoped<IGenTicketRepository, GenTicketRepository>();
            //services.AddScoped<IGenUserHistoryRepository, GenUserHistoryRepository>();
            //services.AddScoped<IGenUtsAssignmentHistoryRepository, GenUtsAssignmentHistoryRepository>();
            //services.AddScoped<IGenUtsAtsApiRecordRepository, GenUtsAtsApiRecordRepository>();
            //services.AddScoped<IGenUtsOnBoardLineItemRepository, GenUtsOnBoardLineItemRepository>();
            //services.AddScoped<IHubSpotEventTypeRepository, HubSpotEventTypeRepository>();
            //services.AddScoped<IHubspotWebhookNotificationRepository, HubspotWebhookNotificationRepository>();
            services.AddScoped<IPrgActionFilterRepository, PrgActionFilterRepository>();
            //services.AddScoped<IPrgAmAssignmentRuleRepository, PrgAmAssignmentRuleRepository>();
            //services.AddScoped<IPrgAmdealContactRepository, PrgAmdealContactRepository>();
            //services.AddScoped<IPrgApitimeZoneResponseRepository, PrgApitimeZoneResponseRepository>();
            //services.AddScoped<IPrgBenchMarkRepository, PrgBenchMarkRepository>();
            //services.AddScoped<IPrgClientEngagementModelRepository, PrgClientEngagementModelRepository>();
            //services.AddScoped<IPrgClientHappinessSurveyFeedbackOptionRepository, PrgClientHappinessSurveyFeedbackOptionRepository>();
            //services.AddScoped<IPrgClientHappinessSurveyFeedbackQuestionRepository, PrgClientHappinessSurveyFeedbackQuestionRepository>();
            //services.AddScoped<IPrgClientInvoiceStatusRepository, PrgClientInvoiceStatusRepository>();
            //services.AddScoped<IPrgClientLegalDocumentTypeRepository, PrgClientLegalDocumentTypeRepository>();
            //services.AddScoped<IPrgClientStageRepository, PrgClientStageRepository>();
            //services.AddScoped<IPrgCompanyCurrentOpenPositionRepository, PrgCompanyCurrentOpenPositionRepository>();
            //services.AddScoped<IPrgCompanyDomainRepository, PrgCompanyDomainRepository>();
            //services.AddScoped<IPrgCompanySizeRepository, PrgCompanySizeRepository>();
            //services.AddScoped<IPrgCompanyTargetGroupRepository, PrgCompanyTargetGroupRepository>();
            //services.AddScoped<IPrgCompanyTypeofInterviewerRepository, PrgCompanyTypeofInterviewerRepository>();
            //services.AddScoped<IPrgContactActionRepository, PrgContactActionRepository>();
            //services.AddScoped<IPrgContactStatusRepository, PrgContactStatusRepository>();
            //services.AddScoped<IPrgContactTimeZoneRepository, PrgContactTimeZoneRepository>();
            //services.AddScoped<IPrgCountryRegionRepository, PrgCountryRegionRepository>();
            //services.AddScoped<IPrgCrmApiDetailRepository, PrgCrmApiDetailRepository>();
            //services.AddScoped<IPrgCrmApiPartnerRepository, PrgCrmApiPartnerRepository>();
            //services.AddScoped<IPrgCrmApiTestsResponseRepository, PrgCrmApiTestsResponseRepository>();
            //services.AddScoped<IPrgCurrencyExchangeRateRepository, PrgCurrencyExchangeRateRepository>();
            //services.AddScoped<IPrgDealPipelineRepository, PrgDealPipelineRepository>();
            services.AddScoped<IPrgDealStageRepository, PrgDealStageRepository>();
            //services.AddScoped<IPrgDealStatusRepository, PrgDealStatusRepository>();
            //services.AddScoped<IPrgDealStatusIdpipelineStageIdRepository, PrgDealStatusIdpipelineStageIdRepository>();
            services.AddScoped<IPrgDealTypeRepository, PrgDealTypeRepository>();
            //services.AddScoped<IPrgDepartmentRepository, PrgDepartmentRepository>();
            //services.AddScoped<IPrgEmploymentStatusRepository, PrgEmploymentStatusRepository>();
            //services.AddScoped<IPrgExtractedSkillsforJdparsingRepository, PrgExtractedSkillsforJdparsingRepository>();
            services.AddScoped<IPrgGeoRepository, PrgGeoRepository>();
            //services.AddScoped<IPrgHiringRequestRoleStatusRepository, PrgHiringRequestRoleStatusRepository>();
            services.AddScoped<IPrgHiringRequestStatusRepository, PrgHiringRequestStatusRepository>();
            //services.AddScoped<IPrgHistoryActionRepository, PrgHistoryActionRepository>();
            //services.AddScoped<IPrgHowSoonClientWantTalentRepository, PrgHowSoonClientWantTalentRepository>();
            //services.AddScoped<IPrgHrdeleteReasonRepository, PrgHrdeleteReasonRepository>();
            //services.AddScoped<IPrgIncAmNrSlabRepository, PrgIncAmNrSlabRepository>();
            //services.AddScoped<IPrgIncAmSlabRepository, PrgIncAmSlabRepository>();
            //services.AddScoped<IPrgIncContractsSlabRepository, PrgIncContractsSlabRepository>();
            //services.AddScoped<IPrgIncPlacementFeesSlabRepository, PrgIncPlacementFeesSlabRepository>();
            //services.AddScoped<IPrgIncSalgoalSlabRepository, PrgIncSalgoalSlabRepository>();
            //services.AddScoped<IPrgInterviewStatusRepository, PrgInterviewStatusRepository>();
            //services.AddScoped<IPrgMatchMakingFactorRepository, PrgMatchMakingFactorRepository>();
            //services.AddScoped<IPrgMatchMakingSubFactorRepository, PrgMatchMakingSubFactorRepository>();
            //services.AddScoped<IPrgModeOfWorkingRepository, PrgModeOfWorkingRepository>();
            //services.AddScoped<IPrgOnBoardLegalKickOffStatusRepository, PrgOnBoardLegalKickOffStatusRepository>();
            //services.AddScoped<IPrgOnBoardPolicyDeviceMasterRepository, PrgOnBoardPolicyDeviceMasterRepository>();
            //services.AddScoped<IPrgOrgLevelRepository, PrgOrgLevelRepository>();
            //services.AddScoped<IPrgPartialEngagementTypeRepository, PrgPartialEngagementTypeRepository>();
            services.AddScoped<IPrgPipelineRepository, PrgPipelineRepository>();
            //services.AddScoped<IPrgPreOnBoardStatusRepository, PrgPreOnBoardStatusRepository>();
            //services.AddScoped<IPrgRateCardRepository, PrgRateCardRepository>();
            //services.AddScoped<IPrgRequirementRepository, PrgRequirementRepository>();
            //services.AddScoped<IPrgRolesAndResponsilbityRepository, PrgRolesAndResponsilbityRepository>();
            services.AddScoped<IPrgSkillRepository, PrgSkillRepository>();
            //services.AddScoped<IPrgSkillCategoryRepository, PrgSkillCategoryRepository>();
            //services.AddScoped<IPrgSkillRankRepository, PrgSkillRankRepository>();
            //services.AddScoped<IPrgSkillSourceRepository, PrgSkillSourceRepository>();
            //services.AddScoped<IPrgSkillsInAssesmentRepository, PrgSkillsInAssesmentRepository>();
            //services.AddScoped<IPrgSkillsRoleRepository, PrgSkillsRoleRepository>();
            //services.AddScoped<IPrgSlatimeRepository, PrgSlatimeRepository>();
            //services.AddScoped<IPrgSocialProviderRepository, PrgSocialProviderRepository>();
            services.AddScoped<IPrgSummaryStagesForReportRepository, PrgSummaryStagesForReportRepository>();
            //services.AddScoped<IPrgTalentAccountStatusRepository, PrgTalentAccountStatusRepository>();
            //services.AddScoped<IPrgTalentActionRepository, PrgTalentActionRepository>();
            //services.AddScoped<IPrgTalentApplicationToolRepository, PrgTalentApplicationToolRepository>();
            //services.AddScoped<IPrgTalentAssociatedWithUplerRepository, PrgTalentAssociatedWithUplerRepository>();
            //services.AddScoped<IPrgTalentCategoryRepository, PrgTalentCategoryRepository>();
            //services.AddScoped<IPrgTalentCertificationRepository, PrgTalentCertificationRepository>();
            //services.AddScoped<IPrgTalentComfortableAreaRepository, PrgTalentComfortableAreaRepository>();
            //services.AddScoped<IPrgTalentComfortableWorkingRepository, PrgTalentComfortableWorkingRepository>();
            //services.AddScoped<IPrgTalentCommunicationSkillRepository, PrgTalentCommunicationSkillRepository>();
            //services.AddScoped<IPrgTalentInterestRepository, PrgTalentInterestRepository>();
            //services.AddScoped<IPrgTalentJoinningRepository, PrgTalentJoinningRepository>();
            //services.AddScoped<IPrgTalentKeyQualityRepository, PrgTalentKeyQualityRepository>();
            //services.AddScoped<IPrgTalentLegalDocumentTypeRepository, PrgTalentLegalDocumentTypeRepository>();
            //services.AddScoped<IPrgTalentPayoutStatusRepository, PrgTalentPayoutStatusRepository>();
            //services.AddScoped<IPrgTalentPreferableWorkingRepository, PrgTalentPreferableWorkingRepository>();
            //services.AddScoped<IPrgTalentPrimarySkillRepository, PrgTalentPrimarySkillRepository>();
            //services.AddScoped<IPrgTalentRejectReasonRepository, PrgTalentRejectReasonRepository>();
            services.AddScoped<IPrgTalentRoleRepository, PrgTalentRoleRepository>();
            //services.AddScoped<IPrgTalentRoleCategoryRepository, PrgTalentRoleCategoryRepository>();
            //services.AddScoped<IPrgTalentRoleTemplateRepository, PrgTalentRoleTemplateRepository>();
            //services.AddScoped<IPrgTalentSkillBenchMarkRepository, PrgTalentSkillBenchMarkRepository>();
            //services.AddScoped<IPrgTalentStatusRepository, PrgTalentStatusRepository>();
            //services.AddScoped<IPrgTalentStatusAfterClientSelectionRepository, PrgTalentStatusAfterClientSelectionRepository>();
            //services.AddScoped<IPrgTalentTimeZoneRepository, PrgTalentTimeZoneRepository>();
            //services.AddScoped<IPrgTalentTypeRepository, PrgTalentTypeRepository>();
            //services.AddScoped<IPrgTempApplicationToolRepository, PrgTempApplicationToolRepository>();
            //services.AddScoped<IPrgTempApplicationToolsMergePrgTalentApplicationToolRepository, PrgTempApplicationToolsMergePrgTalentApplicationToolRepository>();
            //services.AddScoped<IPrgTempCertificationRepository, PrgTempCertificationRepository>();
            //services.AddScoped<IPrgTempCertificationsMergePrgTalentCertificationRepository, PrgTempCertificationsMergePrgTalentCertificationRepository>();
            //services.AddScoped<IPrgTempInterestRepository, PrgTempInterestRepository>();
            //services.AddScoped<IPrgTempInterestMergePrgTalentInterestRepository, PrgTempInterestMergePrgTalentInterestRepository>();
            services.AddScoped<IPrgTempSkillRepository, PrgTempSkillRepository>();
            //services.AddScoped<IPrgTempSkillsMergePrgSkillRepository, PrgTempSkillsMergePrgSkillRepository>();
            //services.AddScoped<IPrgTicketCategoryRepository, PrgTicketCategoryRepository>();
            //services.AddScoped<IPrgTicketStatusRepository, PrgTicketStatusRepository>();
            //services.AddScoped<IPrgTicketTechnicalJustificationRepository, PrgTicketTechnicalJustificationRepository>();
            //services.AddScoped<IPrgTimeZoneRepository, PrgTimeZoneRepository>();
            //services.AddScoped<IPrgTimeZoneCostPreferenceRepository, PrgTimeZoneCostPreferenceRepository>();
            //services.AddScoped<IPrgTimeZonePreferenceRepository, PrgTimeZonePreferenceRepository>();
            //services.AddScoped<ISkillRole1Repository, SkillRole1Repository>();
            //services.AddScoped<IUsrUserGeoDetailRepository, UsrUserGeoDetailRepository>();
            //services.AddScoped<IUsrUserHierarchyRepository, UsrUserHierarchyRepository>();
            //services.AddScoped<IUsrUserPriorityCountLogRepository, UsrUserPriorityCountLogRepository>();
            services.AddScoped<IUsrUserRoleRepository, UsrUserRoleRepository>();
            services.AddScoped<IUsrUserRoleDetailRepository, UsrUserRoleDetailRepository>();
            //services.AddScoped<IUsrUserTeamRepository, UsrUserTeamRepository>();
            services.AddScoped<IUsrUserTypeRepository, UsrUserTypeRepository>();
            //services.AddScoped<IUsrUserTypeAndRoleDetailRepository, UsrUserTypeAndRoleDetailRepository>();
            
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IHubSpotRepository, HubSpotRepository>();
            services.AddScoped<IStoreAPIUrlRepository, StoreAPIUrlRepository>();

            return services;
        }
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IAdminUserLogin, AdminUserRepository>();
            services.AddScoped<IClient, ClientRepository>();
            services.AddScoped<IIncentiveReport, IncentiveReportRepository>();
            services.AddScoped<IIncentiveTarget, IncentiveTargetRepository>();
            services.AddScoped<IDeals, DealListRepository>();
            services.AddScoped<IAMAssignmentRules, AMAssigmentRulesRepository>();
            services.AddScoped<ITalentReplacement, TalentReplacementRepository>();
            services.AddScoped<IUserTeam, UserTeamRepository>();
            services.AddScoped<IReport, ReportsRepository>();
            services.AddScoped<ISLAReport, SLAReportRepository>();
            services.AddScoped<ICompany, CompanyRepository>();
            services.AddScoped<IInterviewToSuccess, InterviewToSuccessRepository>();
            services.AddScoped<IChannel, ChannelRepository>();
            services.AddScoped<IUser, UserRepository>();
            services.AddScoped<IUpChatCall, UpChatCallRepository>();
            services.AddScoped<IUsers, UsersRepository>();
            services.AddScoped<ITalent, TalentRepository>();
            services.AddScoped<IJDParse, JDParseRepository>();
            services.AddScoped<IIncentive, IncentiveRepository>();
            services.AddScoped<IHRInterviewerDetail, HRInterviewerRepository>();
            services.AddScoped<IInterviewer, InterviewerRepository>();
            services.AddScoped<IEmail, UpchatEmailRepository>();
            services.AddScoped<IOnboard, OnBoardRepository>();
            services.AddScoped<IAMAssignment, AMAssigmentRepository>();
            services.AddScoped<IEngagement, EngagementRepository>();
            services.AddScoped<IMasters, MastersRepositories>();
            services.AddScoped<IHRAcceptance, HRAacceptanceRepository>();
            services.AddScoped<IHubSpotCompany, HubSpotCompanyRepository>();
            services.AddScoped<IHiringRequest, HiringRequestRepository>();
            services.AddScoped<IChatGPTResponse, ChatGPTRepository>();
            services.AddScoped<ISchedular, SchedularRepository>();
        }
    }
}