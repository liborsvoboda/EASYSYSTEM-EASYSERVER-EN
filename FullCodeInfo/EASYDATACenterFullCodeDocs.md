<a name='assembly'></a>
# EASYDATACenter

## Contents

- [AuthenticateResponse](#T-EASYDATACenter-ServerCoreDefinition-AuthenticateResponse 'EASYDATACenter.ServerCoreDefinition.AuthenticateResponse')
  - [Expiration](#P-EASYDATACenter-ServerCoreDefinition-AuthenticateResponse-Expiration 'EASYDATACenter.ServerCoreDefinition.AuthenticateResponse.Expiration')
  - [Id](#P-EASYDATACenter-ServerCoreDefinition-AuthenticateResponse-Id 'EASYDATACenter.ServerCoreDefinition.AuthenticateResponse.Id')
  - [Name](#P-EASYDATACenter-ServerCoreDefinition-AuthenticateResponse-Name 'EASYDATACenter.ServerCoreDefinition.AuthenticateResponse.Name')
  - [Role](#P-EASYDATACenter-ServerCoreDefinition-AuthenticateResponse-Role 'EASYDATACenter.ServerCoreDefinition.AuthenticateResponse.Role')
  - [Surname](#P-EASYDATACenter-ServerCoreDefinition-AuthenticateResponse-Surname 'EASYDATACenter.ServerCoreDefinition.AuthenticateResponse.Surname')
  - [Token](#P-EASYDATACenter-ServerCoreDefinition-AuthenticateResponse-Token 'EASYDATACenter.ServerCoreDefinition.AuthenticateResponse.Token')
- [AuthenticationService](#T-EASYDATACenter-ServerServices-AuthenticationService 'EASYDATACenter.ServerServices.AuthenticationService')
  - [Authenticate(username,password)](#M-EASYDATACenter-ServerServices-AuthenticationService-Authenticate-System-String,System-String- 'EASYDATACenter.ServerServices.AuthenticationService.Authenticate(System.String,System.String)')
  - [LifetimeValidator(notBefore,expires,token,params)](#M-EASYDATACenter-ServerServices-AuthenticationService-LifetimeValidator-System-Nullable{System-DateTime},System-Nullable{System-DateTime},Microsoft-IdentityModel-Tokens-SecurityToken,Microsoft-IdentityModel-Tokens-TokenValidationParameters- 'EASYDATACenter.ServerServices.AuthenticationService.LifetimeValidator(System.Nullable{System.DateTime},System.Nullable{System.DateTime},Microsoft.IdentityModel.Tokens.SecurityToken,Microsoft.IdentityModel.Tokens.TokenValidationParameters)')
  - [RefreshUserToken(username,token)](#M-EASYDATACenter-ServerServices-AuthenticationService-RefreshUserToken-System-String,EASYDATACenter-ServerCoreDefinition-AuthenticateResponse- 'EASYDATACenter.ServerServices.AuthenticationService.RefreshUserToken(System.String,EASYDATACenter.ServerCoreDefinition.AuthenticateResponse)')
- [BackendServer](#T-EASYDATACenter-BackendServer 'EASYDATACenter.BackendServer')
  - [ServerRuntimeData](#F-EASYDATACenter-BackendServer-ServerRuntimeData 'EASYDATACenter.BackendServer.ServerRuntimeData')
  - [ServerSettings](#F-EASYDATACenter-BackendServer-ServerSettings 'EASYDATACenter.BackendServer.ServerSettings')
  - [BuildWebHost(args)](#M-EASYDATACenter-BackendServer-BuildWebHost-System-String[]- 'EASYDATACenter.BackendServer.BuildWebHost(System.String[])')
  - [Main(args)](#M-EASYDATACenter-BackendServer-Main-System-String[]- 'EASYDATACenter.BackendServer.Main(System.String[])')
  - [ServerStartupDbDataLoading()](#M-EASYDATACenter-BackendServer-ServerStartupDbDataLoading 'EASYDATACenter.BackendServer.ServerStartupDbDataLoading')
- [CommunicationController](#T-EASYDATACenter-ServerCoreDefinition-CommunicationController 'EASYDATACenter.ServerCoreDefinition.CommunicationController')
  - [HttpContext](#P-EASYDATACenter-ServerCoreDefinition-CommunicationController-HttpContext 'EASYDATACenter.ServerCoreDefinition.CommunicationController.HttpContext')
  - [CheckAdmin()](#M-EASYDATACenter-ServerCoreDefinition-CommunicationController-CheckAdmin 'EASYDATACenter.ServerCoreDefinition.CommunicationController.CheckAdmin')
- [CoreFunctions](#T-EASYDATACenter-ServerCoreOperations-CoreFunctions 'EASYDATACenter.ServerCoreOperations.CoreFunctions')
  - [LoadSettings()](#M-EASYDATACenter-ServerCoreOperations-CoreFunctions-LoadSettings 'EASYDATACenter.ServerCoreOperations.CoreFunctions.LoadSettings')
- [DBOperations](#T-EASYDATACenter-ServerCoreOperations-DBOperations 'EASYDATACenter.ServerCoreOperations.DBOperations')
  - [DBTranslate(word,language)](#M-EASYDATACenter-ServerCoreOperations-DBOperations-DBTranslate-System-String,System-String- 'EASYDATACenter.ServerCoreOperations.DBOperations.DBTranslate(System.String,System.String)')
  - [DBTranslateOffline(word,language)](#M-EASYDATACenter-ServerCoreOperations-DBOperations-DBTranslateOffline-System-String,System-String- 'EASYDATACenter.ServerCoreOperations.DBOperations.DBTranslateOffline(System.String,System.String)')
  - [DBTranslateOnline(word,language)](#M-EASYDATACenter-ServerCoreOperations-DBOperations-DBTranslateOnline-System-String,System-String- 'EASYDATACenter.ServerCoreOperations.DBOperations.DBTranslateOnline(System.String,System.String)')
  - [LoadStaticDbDials(onlyThis)](#M-EASYDATACenter-ServerCoreOperations-DBOperations-LoadStaticDbDials-System-Nullable{EASYDATACenter-ServerCoreDefinition-ServerLocalDbDials}- 'EASYDATACenter.ServerCoreOperations.DBOperations.LoadStaticDbDials(System.Nullable{EASYDATACenter.ServerCoreDefinition.ServerLocalDbDials})')
  - [WriteVisit(ipAddress,userId,userName)](#M-EASYDATACenter-ServerCoreOperations-DBOperations-WriteVisit-System-String,System-Int32,System-String- 'EASYDATACenter.ServerCoreOperations.DBOperations.WriteVisit(System.String,System.Int32,System.String)')
- [DBResult](#T-EASYDATACenter-ServerCoreDefinition-DBResult 'EASYDATACenter.ServerCoreDefinition.DBResult')
- [DBResultMessage](#T-EASYDATACenter-ServerCoreDefinition-DBResultMessage 'EASYDATACenter.ServerCoreDefinition.DBResultMessage')
  - [ErrorMessage](#P-EASYDATACenter-ServerCoreDefinition-DBResultMessage-ErrorMessage 'EASYDATACenter.ServerCoreDefinition.DBResultMessage.ErrorMessage')
  - [InsertedId](#P-EASYDATACenter-ServerCoreDefinition-DBResultMessage-InsertedId 'EASYDATACenter.ServerCoreDefinition.DBResultMessage.InsertedId')
  - [RecordCount](#P-EASYDATACenter-ServerCoreDefinition-DBResultMessage-RecordCount 'EASYDATACenter.ServerCoreDefinition.DBResultMessage.RecordCount')
  - [status](#P-EASYDATACenter-ServerCoreDefinition-DBResultMessage-status 'EASYDATACenter.ServerCoreDefinition.DBResultMessage.status')
- [EASYDATACenterContext](#T-EASYDATACenter-ServerConfiguration-EASYDATACenterContext 'EASYDATACenter.ServerConfiguration.EASYDATACenterContext')
  - [GetApiUser(httpContext)](#M-EASYDATACenter-ServerConfiguration-EASYDATACenterContext-GetApiUser-Microsoft-AspNetCore-Http-HttpContext- 'EASYDATACenter.ServerConfiguration.EASYDATACenterContext.GetApiUser(Microsoft.AspNetCore.Http.HttpContext)')
- [IgnoredExceptionListApi](#T-EASYDATACenter-Controllers-IgnoredExceptionListApi 'EASYDATACenter.Controllers.IgnoredExceptionListApi')
  - [DeleteIgnoredExceptionList(id)](#M-EASYDATACenter-Controllers-IgnoredExceptionListApi-DeleteIgnoredExceptionList-System-String- 'EASYDATACenter.Controllers.IgnoredExceptionListApi.DeleteIgnoredExceptionList(System.String)')
  - [GetIgnoredExceptionList()](#M-EASYDATACenter-Controllers-IgnoredExceptionListApi-GetIgnoredExceptionList 'EASYDATACenter.Controllers.IgnoredExceptionListApi.GetIgnoredExceptionList')
  - [GetIgnoredExceptionListByFilter(filter)](#M-EASYDATACenter-Controllers-IgnoredExceptionListApi-GetIgnoredExceptionListByFilter-System-String- 'EASYDATACenter.Controllers.IgnoredExceptionListApi.GetIgnoredExceptionListByFilter(System.String)')
  - [GetIgnoredExceptionListKey(id)](#M-EASYDATACenter-Controllers-IgnoredExceptionListApi-GetIgnoredExceptionListKey-System-Int32- 'EASYDATACenter.Controllers.IgnoredExceptionListApi.GetIgnoredExceptionListKey(System.Int32)')
  - [InsertIgnoredExceptionList(record)](#M-EASYDATACenter-Controllers-IgnoredExceptionListApi-InsertIgnoredExceptionList-EASYDATACenter-DBModel-IgnoredExceptionList- 'EASYDATACenter.Controllers.IgnoredExceptionListApi.InsertIgnoredExceptionList(EASYDATACenter.DBModel.IgnoredExceptionList)')
  - [UpdateIgnoredExceptionList(record)](#M-EASYDATACenter-Controllers-IgnoredExceptionListApi-UpdateIgnoredExceptionList-EASYDATACenter-DBModel-IgnoredExceptionList- 'EASYDATACenter.Controllers.IgnoredExceptionListApi.UpdateIgnoredExceptionList(EASYDATACenter.DBModel.IgnoredExceptionList)')
- [ServerCoreConfiguration](#T-EASYDATACenter-ServerConfiguration-ServerCoreConfiguration 'EASYDATACenter.ServerConfiguration.ServerCoreConfiguration')
  - [ConfigureAuthentication(services)](#M-EASYDATACenter-ServerConfiguration-ServerCoreConfiguration-ConfigureAuthentication-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerConfiguration.ServerCoreConfiguration.ConfigureAuthentication(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureControllers(services)](#M-EASYDATACenter-ServerConfiguration-ServerCoreConfiguration-ConfigureControllers-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerConfiguration.ServerCoreConfiguration.ConfigureControllers(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureCookie(services)](#M-EASYDATACenter-ServerConfiguration-ServerCoreConfiguration-ConfigureCookie-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerConfiguration.ServerCoreConfiguration.ConfigureCookie(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureDatabaseContext(services)](#M-EASYDATACenter-ServerConfiguration-ServerCoreConfiguration-ConfigureDatabaseContext-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerConfiguration.ServerCoreConfiguration.ConfigureDatabaseContext(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureLogging(services)](#M-EASYDATACenter-ServerConfiguration-ServerCoreConfiguration-ConfigureLogging-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerConfiguration.ServerCoreConfiguration.ConfigureLogging(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureScopes(services)](#M-EASYDATACenter-ServerConfiguration-ServerCoreConfiguration-ConfigureScopes-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerConfiguration.ServerCoreConfiguration.ConfigureScopes(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureThirdPartyApi(services)](#M-EASYDATACenter-ServerConfiguration-ServerCoreConfiguration-ConfigureThirdPartyApi-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerConfiguration.ServerCoreConfiguration.ConfigureThirdPartyApi(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
- [ServerEnablingServices](#T-EASYDATACenter-ServerConfiguration-ServerEnablingServices 'EASYDATACenter.ServerConfiguration.ServerEnablingServices')
  - [EnableCors()](#M-EASYDATACenter-ServerConfiguration-ServerEnablingServices-EnableCors-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'EASYDATACenter.ServerConfiguration.ServerEnablingServices.EnableCors(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
  - [EnableEndpoints()](#M-EASYDATACenter-ServerConfiguration-ServerEnablingServices-EnableEndpoints-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'EASYDATACenter.ServerConfiguration.ServerEnablingServices.EnableEndpoints(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
  - [EnableLogging(app,loggerFactory)](#M-EASYDATACenter-ServerConfiguration-ServerEnablingServices-EnableLogging-Microsoft-AspNetCore-Builder-IApplicationBuilder@,Microsoft-Extensions-Logging-ILoggerFactory@- 'EASYDATACenter.ServerConfiguration.ServerEnablingServices.EnableLogging(Microsoft.AspNetCore.Builder.IApplicationBuilder@,Microsoft.Extensions.Logging.ILoggerFactory@)')
  - [EnableWebSocket(app)](#M-EASYDATACenter-ServerConfiguration-ServerEnablingServices-EnableWebSocket-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'EASYDATACenter.ServerConfiguration.ServerEnablingServices.EnableWebSocket(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
- [ServerLocalDbDials](#T-EASYDATACenter-ServerCoreDefinition-ServerLocalDbDials 'EASYDATACenter.ServerCoreDefinition.ServerLocalDbDials')
- [ServerModulesConfiguration](#T-EASYDATACenter-ServerConfiguration-ServerModulesConfiguration 'EASYDATACenter.ServerConfiguration.ServerModulesConfiguration')
  - [ConfigureCoreAdmin(services)](#M-EASYDATACenter-ServerConfiguration-ServerModulesConfiguration-ConfigureCoreAdmin-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerConfiguration.ServerModulesConfiguration.ConfigureCoreAdmin(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureHealthCheck(services)](#M-EASYDATACenter-ServerConfiguration-ServerModulesConfiguration-ConfigureHealthCheck-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerConfiguration.ServerModulesConfiguration.ConfigureHealthCheck(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureSwagger(services)](#M-EASYDATACenter-ServerConfiguration-ServerModulesConfiguration-ConfigureSwagger-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerConfiguration.ServerModulesConfiguration.ConfigureSwagger(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
- [ServerModulesEnabling](#T-EASYDATACenter-ServerConfiguration-ServerModulesEnabling 'EASYDATACenter.ServerConfiguration.ServerModulesEnabling')
  - [EnableCoreAdmin()](#M-EASYDATACenter-ServerConfiguration-ServerModulesEnabling-EnableCoreAdmin-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'EASYDATACenter.ServerConfiguration.ServerModulesEnabling.EnableCoreAdmin(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
  - [EnableSwagger()](#M-EASYDATACenter-ServerConfiguration-ServerModulesEnabling-EnableSwagger-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'EASYDATACenter.ServerConfiguration.ServerModulesEnabling.EnableSwagger(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
- [ServerPagesController](#T-EASYDATACenter-ServerPages-ServerPagesController 'EASYDATACenter.ServerPages.ServerPagesController')
  - [About()](#M-EASYDATACenter-ServerPages-ServerPagesController-About 'EASYDATACenter.ServerPages.ServerPagesController.About')
  - [Index()](#M-EASYDATACenter-ServerPages-ServerPagesController-Index 'EASYDATACenter.ServerPages.ServerPagesController.Index')
- [ServerRuntimeData](#T-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData 'EASYDATACenter.ServerCoreDefinition.ServerRuntimeData')
  - [LocalDBTableList](#F-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-LocalDBTableList 'EASYDATACenter.ServerCoreDefinition.ServerRuntimeData.LocalDBTableList')
  - [ConfigFile](#P-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-ConfigFile 'EASYDATACenter.ServerCoreDefinition.ServerRuntimeData.ConfigFile')
  - [DataPath](#P-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-DataPath 'EASYDATACenter.ServerCoreDefinition.ServerRuntimeData.DataPath')
  - [DebugMode](#P-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-DebugMode 'EASYDATACenter.ServerCoreDefinition.ServerRuntimeData.DebugMode')
  - [Setting_folder](#P-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-Setting_folder 'EASYDATACenter.ServerCoreDefinition.ServerRuntimeData.Setting_folder')
  - [Startup_path](#P-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-Startup_path 'EASYDATACenter.ServerCoreDefinition.ServerRuntimeData.Startup_path')
- [ServerSettings](#T-EASYDATACenter-ServerCoreDefinition-ServerSettings 'EASYDATACenter.ServerCoreDefinition.ServerSettings')
  - [ConfigServerStartupPort](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigServerStartupPort 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ConfigServerStartupPort')
  - [ConfigCertificateDomain](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigCertificateDomain 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ConfigCertificateDomain')
  - [ConfigCertificatePassword](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigCertificatePassword 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ConfigCertificatePassword')
  - [DatabaseConnectionString](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-DatabaseConnectionString 'EASYDATACenter.ServerCoreDefinition.ServerSettings.DatabaseConnectionString')
  - [SpecialCoreCheckerEmailSenderActive](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-SpecialCoreCheckerEmailSenderActive 'EASYDATACenter.ServerCoreDefinition.ServerSettings.SpecialCoreCheckerEmailSenderActive')
  - [ModuleSwaggerApiDocEnabled](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ModuleSwaggerApiDocEnabled 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ModuleSwaggerApiDocEnabled')
  - [ModuleDataManagerEnabled](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ModuleDataManagerEnabled 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ModuleDataManagerEnabled')
  - [ModuleHealthServiceEnabled](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ModuleHealthServiceEnabled 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ModuleHealthServiceEnabled')
  - [ServerFtpEngineEnabled](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ServerFtpEngineEnabled 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ServerFtpEngineEnabled')
  - [ServerWebBrowserEnabled](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ServerWebBrowserEnabled 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ServerWebBrowserEnabled')
  - [ConfigServerStartupOnHttps](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigServerStartupOnHttps 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ConfigServerStartupOnHttps')
  - [DatabaseInternalCachingEnabled](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-DatabaseInternalCachingEnabled 'EASYDATACenter.ServerCoreDefinition.ServerSettings.DatabaseInternalCachingEnabled')
  - [ConfigJwtLocalKey](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigJwtLocalKey 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ConfigJwtLocalKey')
  - [DatabaseInternalCacheTimeoutMin](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-DatabaseInternalCacheTimeoutMin 'EASYDATACenter.ServerCoreDefinition.ServerSettings.DatabaseInternalCacheTimeoutMin')
  - [ConfigApiTokenTimeoutMin](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigApiTokenTimeoutMin 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ConfigApiTokenTimeoutMin')
  - [ConfigMaxWebSocketBufferSizeKb](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigMaxWebSocketBufferSizeKb 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ConfigMaxWebSocketBufferSizeKb')
  - [EmailerSMTPLoginPassword](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerSMTPLoginPassword 'EASYDATACenter.ServerCoreDefinition.ServerSettings.EmailerSMTPLoginPassword')
  - [EmailerSMTPPort](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerSMTPPort 'EASYDATACenter.ServerCoreDefinition.ServerSettings.EmailerSMTPPort')
  - [EmailerSMTPServerAddress](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerSMTPServerAddress 'EASYDATACenter.ServerCoreDefinition.ServerSettings.EmailerSMTPServerAddress')
  - [EmailerSMTPSslIsEnabled](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerSMTPSslIsEnabled 'EASYDATACenter.ServerCoreDefinition.ServerSettings.EmailerSMTPSslIsEnabled')
  - [EmailerSMTPLoginUsername](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerSMTPLoginUsername 'EASYDATACenter.ServerCoreDefinition.ServerSettings.EmailerSMTPLoginUsername')
  - [ModuleHealthServiceRefreshIntervalSec](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ModuleHealthServiceRefreshIntervalSec 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ModuleHealthServiceRefreshIntervalSec')
  - [ConfigServerLanguage](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigServerLanguage 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ConfigServerLanguage')
  - [SpecialServerServiceName](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-SpecialServerServiceName 'EASYDATACenter.ServerCoreDefinition.ServerSettings.SpecialServerServiceName')
  - [EmailerServiceEmailAddress](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerServiceEmailAddress 'EASYDATACenter.ServerCoreDefinition.ServerSettings.EmailerServiceEmailAddress')
  - [ConfigWebSocketTimeoutMin](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigWebSocketTimeoutMin 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ConfigWebSocketTimeoutMin')
  - [ServerTimeTokenValidationEnabled](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ServerTimeTokenValidationEnabled 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ServerTimeTokenValidationEnabled')
  - [SpecialUseDbLocalAutoupdatedDials](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-SpecialUseDbLocalAutoupdatedDials 'EASYDATACenter.ServerCoreDefinition.ServerSettings.SpecialUseDbLocalAutoupdatedDials')
- [ServiceHealthCheck](#T-EASYDATACenter-ServerCoreDefinition-ServiceHealthCheck 'EASYDATACenter.ServerCoreDefinition.ServiceHealthCheck')
  - [Microsoft#Extensions#Diagnostics#HealthChecks#IHealthCheck#CheckHealthAsync(context,cancellationToken)](#M-EASYDATACenter-ServerCoreDefinition-ServiceHealthCheck-Microsoft#Extensions#Diagnostics#HealthChecks#IHealthCheck#CheckHealthAsync-Microsoft-Extensions-Diagnostics-HealthChecks-HealthCheckContext,System-Threading-CancellationToken- 'EASYDATACenter.ServerCoreDefinition.ServiceHealthCheck.Microsoft#Extensions#Diagnostics#HealthChecks#IHealthCheck#CheckHealthAsync(Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckContext,System.Threading.CancellationToken)')
- [SetReportFilter](#T-EASYDATACenter-Controllers-SetReportFilter 'EASYDATACenter.Controllers.SetReportFilter')
- [Startup](#T-EASYDATACenter-Startup 'EASYDATACenter.Startup')
  - [Configure(app,loggerFactory)](#M-EASYDATACenter-Startup-Configure-Microsoft-AspNetCore-Builder-IApplicationBuilder,Microsoft-Extensions-Logging-ILoggerFactory- 'EASYDATACenter.Startup.Configure(Microsoft.AspNetCore.Builder.IApplicationBuilder,Microsoft.Extensions.Logging.ILoggerFactory)')
  - [ConfigureServices(Microsoft.Extensions.DependencyInjection.IServiceCollection services.Extensions.DependencyInjection.IServiceCollectionservices)](#M-EASYDATACenter-Startup-ConfigureServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'EASYDATACenter.Startup.ConfigureServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [SystemFunctions](#T-EASYDATACenter-ServerCoreOperations-SystemFunctions 'EASYDATACenter.ServerCoreOperations.SystemFunctions')
  - [GetSystemErrMessage(exception,msgCount)](#M-EASYDATACenter-ServerCoreOperations-SystemFunctions-GetSystemErrMessage-System-Exception,System-Int32- 'EASYDATACenter.ServerCoreOperations.SystemFunctions.GetSystemErrMessage(System.Exception,System.Int32)')
  - [GetUserApiErrMessage(exception,msgCount)](#M-EASYDATACenter-ServerCoreOperations-SystemFunctions-GetUserApiErrMessage-System-Exception,System-Int32- 'EASYDATACenter.ServerCoreOperations.SystemFunctions.GetUserApiErrMessage(System.Exception,System.Int32)')
  - [SendMail(message)](#M-EASYDATACenter-ServerCoreOperations-SystemFunctions-SendMail-System-String- 'EASYDATACenter.ServerCoreOperations.SystemFunctions.SendMail(System.String)')
- [TemplateAuthApiService](#T-EASYDATACenter-Templates-TemplateAuthApiService 'EASYDATACenter.Templates.TemplateAuthApiService')
  - [Authenticate(Authorization)](#M-EASYDATACenter-Templates-TemplateAuthApiService-Authenticate-System-String- 'EASYDATACenter.Templates.TemplateAuthApiService.Authenticate(System.String)')
  - [Authenticate(username,password)](#M-EASYDATACenter-Templates-TemplateAuthApiService-Authenticate-System-String,System-String- 'EASYDATACenter.Templates.TemplateAuthApiService.Authenticate(System.String,System.String)')
  - [LifetimeValidator(notBefore,expires,token,params)](#M-EASYDATACenter-Templates-TemplateAuthApiService-LifetimeValidator-System-Nullable{System-DateTime},System-Nullable{System-DateTime},Microsoft-IdentityModel-Tokens-SecurityToken,Microsoft-IdentityModel-Tokens-TokenValidationParameters- 'EASYDATACenter.Templates.TemplateAuthApiService.LifetimeValidator(System.Nullable{System.DateTime},System.Nullable{System.DateTime},Microsoft.IdentityModel.Tokens.SecurityToken,Microsoft.IdentityModel.Tokens.TokenValidationParameters)')
  - [RefreshUserToken(username,token)](#M-EASYDATACenter-Templates-TemplateAuthApiService-RefreshUserToken-System-String,EASYDATACenter-ServerCoreDefinition-AuthenticateResponse- 'EASYDATACenter.Templates.TemplateAuthApiService.RefreshUserToken(System.String,EASYDATACenter.ServerCoreDefinition.AuthenticateResponse)')
- [TemplateCentralDBListApi](#T-EASYDATACenter-Templates-TemplateCentralDBListApi 'EASYDATACenter.Templates.TemplateCentralDBListApi')
  - [DeleteTemplateCentralDBList(id)](#M-EASYDATACenter-Templates-TemplateCentralDBListApi-DeleteTemplateCentralDBList-System-String- 'EASYDATACenter.Templates.TemplateCentralDBListApi.DeleteTemplateCentralDBList(System.String)')
  - [GetTemplateCentralDBList()](#M-EASYDATACenter-Templates-TemplateCentralDBListApi-GetTemplateCentralDBList 'EASYDATACenter.Templates.TemplateCentralDBListApi.GetTemplateCentralDBList')
  - [GetTemplateCentralDBListByFilter(filter)](#M-EASYDATACenter-Templates-TemplateCentralDBListApi-GetTemplateCentralDBListByFilter-System-String- 'EASYDATACenter.Templates.TemplateCentralDBListApi.GetTemplateCentralDBListByFilter(System.String)')
  - [GetTemplateCentralDBListKey(id)](#M-EASYDATACenter-Templates-TemplateCentralDBListApi-GetTemplateCentralDBListKey-System-Int32- 'EASYDATACenter.Templates.TemplateCentralDBListApi.GetTemplateCentralDBListKey(System.Int32)')
  - [InsertTemplateCentralDBList(record)](#M-EASYDATACenter-Templates-TemplateCentralDBListApi-InsertTemplateCentralDBList-EASYDATACenter-DBModel-TemplateList- 'EASYDATACenter.Templates.TemplateCentralDBListApi.InsertTemplateCentralDBList(EASYDATACenter.DBModel.TemplateList)')
  - [UpdateTemplateCentralDBList(record)](#M-EASYDATACenter-Templates-TemplateCentralDBListApi-UpdateTemplateCentralDBList-EASYDATACenter-DBModel-TemplateList- 'EASYDATACenter.Templates.TemplateCentralDBListApi.UpdateTemplateCentralDBList(EASYDATACenter.DBModel.TemplateList)')
- [TemplateClassList](#T-EASYDATACenter-Templates-TemplateClassList 'EASYDATACenter.Templates.TemplateClassList')
- [TemplateImageApi](#T-EASYDATACenter-Templates-TemplateImageApi 'EASYDATACenter.Templates.TemplateImageApi')
  - [GetSearchImageById(id)](#M-EASYDATACenter-Templates-TemplateImageApi-GetSearchImageById-System-Nullable{System-Int32}- 'EASYDATACenter.Templates.TemplateImageApi.GetSearchImageById(System.Nullable{System.Int32})')
  - [GetSearchImageByKeys(id,fileName)](#M-EASYDATACenter-Templates-TemplateImageApi-GetSearchImageByKeys-System-Nullable{System-Int32},System-String- 'EASYDATACenter.Templates.TemplateImageApi.GetSearchImageByKeys(System.Nullable{System.Int32},System.String)')
- [TemplateItemListApi](#T-EASYDATACenter-Templates-TemplateItemListApi 'EASYDATACenter.Templates.TemplateItemListApi')
- [TemplateList](#T-EASYDATACenter-DBModel-TemplateList 'EASYDATACenter.DBModel.TemplateList')
- [TemplateProcedureApi](#T-EASYDATACenter-Templates-TemplateProcedureApi 'EASYDATACenter.Templates.TemplateProcedureApi')
  - [GetTemplateProcedure(unlockCode,partNumber)](#M-EASYDATACenter-Templates-TemplateProcedureApi-GetTemplateProcedure-System-String,System-String- 'EASYDATACenter.Templates.TemplateProcedureApi.GetTemplateProcedure(System.String,System.String)')
- [WebSocketExampleApi](#T-EASYDATACenter-WebSocketDefinition-WebSocketExampleApi 'EASYDATACenter.WebSocketDefinition.WebSocketExampleApi')
  - [CloseDisconnectedSocketConnections()](#M-EASYDATACenter-WebSocketDefinition-WebSocketExampleApi-CloseDisconnectedSocketConnections 'EASYDATACenter.WebSocketDefinition.WebSocketExampleApi.CloseDisconnectedSocketConnections')
  - [Get()](#M-EASYDATACenter-WebSocketDefinition-WebSocketExampleApi-Get 'EASYDATACenter.WebSocketDefinition.WebSocketExampleApi.Get')
  - [GetbyId(id)](#M-EASYDATACenter-WebSocketDefinition-WebSocketExampleApi-GetbyId-System-String- 'EASYDATACenter.WebSocketDefinition.WebSocketExampleApi.GetbyId(System.String)')
  - [ListenMessages(webSocket,auctionId)](#M-EASYDATACenter-WebSocketDefinition-WebSocketExampleApi-ListenMessages-System-Net-WebSockets-WebSocket,System-String- 'EASYDATACenter.WebSocketDefinition.WebSocketExampleApi.ListenMessages(System.Net.WebSockets.WebSocket,System.String)')
  - [UpdateSocketsByAuctionIdInfo(auctionId)](#M-EASYDATACenter-WebSocketDefinition-WebSocketExampleApi-UpdateSocketsByAuctionIdInfo-System-String- 'EASYDATACenter.WebSocketDefinition.WebSocketExampleApi.UpdateSocketsByAuctionIdInfo(System.String)')

<a name='T-EASYDATACenter-ServerCoreDefinition-AuthenticateResponse'></a>
## AuthenticateResponse `type`

##### Namespace

EASYDATACenter.ServerCoreDefinition

##### Summary

The authenticate response.

<a name='P-EASYDATACenter-ServerCoreDefinition-AuthenticateResponse-Expiration'></a>
### Expiration `property`

##### Summary

Gets or Sets the expiration.

<a name='P-EASYDATACenter-ServerCoreDefinition-AuthenticateResponse-Id'></a>
### Id `property`

##### Summary

Gets or Sets the id.

<a name='P-EASYDATACenter-ServerCoreDefinition-AuthenticateResponse-Name'></a>
### Name `property`

##### Summary

Gets or Sets the name.

<a name='P-EASYDATACenter-ServerCoreDefinition-AuthenticateResponse-Role'></a>
### Role `property`

##### Summary

Gets or Sets the role.

<a name='P-EASYDATACenter-ServerCoreDefinition-AuthenticateResponse-Surname'></a>
### Surname `property`

##### Summary

Gets or Sets the surname.

<a name='P-EASYDATACenter-ServerCoreDefinition-AuthenticateResponse-Token'></a>
### Token `property`

##### Summary

Gets or Sets the token.

<a name='T-EASYDATACenter-ServerServices-AuthenticationService'></a>
## AuthenticationService `type`

##### Namespace

EASYDATACenter.ServerServices

<a name='M-EASYDATACenter-ServerServices-AuthenticationService-Authenticate-System-String,System-String-'></a>
### Authenticate(username,password) `method`

##### Summary

API Authenticated and Generate Token

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EASYDATACenter-ServerServices-AuthenticationService-LifetimeValidator-System-Nullable{System-DateTime},System-Nullable{System-DateTime},Microsoft-IdentityModel-Tokens-SecurityToken,Microsoft-IdentityModel-Tokens-TokenValidationParameters-'></a>
### LifetimeValidator(notBefore,expires,token,params) `method`

##### Summary

API Token LifeTime Validator

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| notBefore | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') |  |
| expires | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') |  |
| token | [Microsoft.IdentityModel.Tokens.SecurityToken](#T-Microsoft-IdentityModel-Tokens-SecurityToken 'Microsoft.IdentityModel.Tokens.SecurityToken') |  |
| params | [Microsoft.IdentityModel.Tokens.TokenValidationParameters](#T-Microsoft-IdentityModel-Tokens-TokenValidationParameters 'Microsoft.IdentityModel.Tokens.TokenValidationParameters') |  |

<a name='M-EASYDATACenter-ServerServices-AuthenticationService-RefreshUserToken-System-String,EASYDATACenter-ServerCoreDefinition-AuthenticateResponse-'></a>
### RefreshUserToken(username,token) `method`

##### Summary

API Refresh User Token

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| token | [EASYDATACenter.ServerCoreDefinition.AuthenticateResponse](#T-EASYDATACenter-ServerCoreDefinition-AuthenticateResponse 'EASYDATACenter.ServerCoreDefinition.AuthenticateResponse') |  |

<a name='T-EASYDATACenter-BackendServer'></a>
## BackendServer `type`

##### Namespace

EASYDATACenter

##### Summary

Server Main Definition Starting Point Of Project

<a name='F-EASYDATACenter-BackendServer-ServerRuntimeData'></a>
### ServerRuntimeData `constants`

##### Summary

Startup Server Initialization Server Runtime Data

<a name='F-EASYDATACenter-BackendServer-ServerSettings'></a>
### ServerSettings `constants`

##### Summary

Startup Server Initialization Server Setting Data

<a name='M-EASYDATACenter-BackendServer-BuildWebHost-System-String[]-'></a>
### BuildWebHost(args) `method`

##### Summary

Final Preparing Server HostBuilder Definition

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='M-EASYDATACenter-BackendServer-Main-System-String[]-'></a>
### Main(args) `method`

##### Summary

Server Startup Process

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='M-EASYDATACenter-BackendServer-ServerStartupDbDataLoading'></a>
### ServerStartupDbDataLoading() `method`

##### Summary

Server Startup DB Data loading for minimize DB Connect TO Frequency Dials Without Changes
Example: LanguageList

##### Parameters

This method has no parameters.

<a name='T-EASYDATACenter-ServerCoreDefinition-CommunicationController'></a>
## CommunicationController `type`

##### Namespace

EASYDATACenter.ServerCoreDefinition

##### Summary

Server Communication Extensions for Controlling Data

<a name='P-EASYDATACenter-ServerCoreDefinition-CommunicationController-HttpContext'></a>
### HttpContext `property`

##### Summary

Server Request Accessory controller

<a name='M-EASYDATACenter-ServerCoreDefinition-CommunicationController-CheckAdmin'></a>
### CheckAdmin() `method`

##### Summary

Check Admin Role

##### Parameters

This method has no parameters.

<a name='T-EASYDATACenter-ServerCoreOperations-CoreFunctions'></a>
## CoreFunctions `type`

##### Namespace

EASYDATACenter.ServerCoreOperations

<a name='M-EASYDATACenter-ServerCoreOperations-CoreFunctions-LoadSettings'></a>
### LoadSettings() `method`

##### Summary

Server Local Startup Configuration Its Running as First - Load from Congig.Json After DB
connection Before Server Start Is This configuration Replaced By Data from DB And next
Server Start. Its for situation - Bad Connection Server Start with Configuration from File

##### Parameters

This method has no parameters.

<a name='T-EASYDATACenter-ServerCoreOperations-DBOperations'></a>
## DBOperations `type`

##### Namespace

EASYDATACenter.ServerCoreOperations

##### Summary

All Server Definitions of Database Operation method

<a name='M-EASYDATACenter-ServerCoreOperations-DBOperations-DBTranslate-System-String,System-String-'></a>
### DBTranslate(word,language) `method`

##### Summary

Default Operation for Call Translation

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| word | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| language | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EASYDATACenter-ServerCoreOperations-DBOperations-DBTranslateOffline-System-String,System-String-'></a>
### DBTranslateOffline(word,language) `method`

##### Summary

Database LanuageList for Off-line Using Definitions

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| word | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| language | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EASYDATACenter-ServerCoreOperations-DBOperations-DBTranslateOnline-System-String,System-String-'></a>
### DBTranslateOnline(word,language) `method`

##### Summary

Database LanuageList for On-line Using Definitions

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| word | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| language | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EASYDATACenter-ServerCoreOperations-DBOperations-LoadStaticDbDials-System-Nullable{EASYDATACenter-ServerCoreDefinition-ServerLocalDbDials}-'></a>
### LoadStaticDbDials(onlyThis) `method`

##### Summary

Method for All Server Defined Table for Local Using As Off line AutoUpdated Tables

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| onlyThis | [System.Nullable{EASYDATACenter.ServerCoreDefinition.ServerLocalDbDials}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{EASYDATACenter.ServerCoreDefinition.ServerLocalDbDials}') |  |

<a name='M-EASYDATACenter-ServerCoreOperations-DBOperations-WriteVisit-System-String,System-Int32,System-String-'></a>
### WriteVisit(ipAddress,userId,userName) `method`

##### Summary

Trigger User Login History

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ipAddress | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| userId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| userName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-EASYDATACenter-ServerCoreDefinition-DBResult'></a>
## DBResult `type`

##### Namespace

EASYDATACenter.ServerCoreDefinition

##### Summary

Database response types definition

<a name='T-EASYDATACenter-ServerCoreDefinition-DBResultMessage'></a>
## DBResultMessage `type`

##### Namespace

EASYDATACenter.ServerCoreDefinition

##### Summary

The DB result message.

<a name='P-EASYDATACenter-ServerCoreDefinition-DBResultMessage-ErrorMessage'></a>
### ErrorMessage `property`

##### Summary

Gets or Sets the error message.

<a name='P-EASYDATACenter-ServerCoreDefinition-DBResultMessage-InsertedId'></a>
### InsertedId `property`

##### Summary

Gets or Sets the inserted id.

<a name='P-EASYDATACenter-ServerCoreDefinition-DBResultMessage-RecordCount'></a>
### RecordCount `property`

##### Summary

Gets or Sets the record count.

<a name='P-EASYDATACenter-ServerCoreDefinition-DBResultMessage-status'></a>
### status `property`

##### Summary

Gets or Sets the status.

<a name='T-EASYDATACenter-ServerConfiguration-EASYDATACenterContext'></a>
## EASYDATACenterContext `type`

##### Namespace

EASYDATACenter.ServerConfiguration

##### Summary

Server Main Database Settings Here is Included ScaffoldContext which is connected via Visual
Studio Tool Here can Be added customization which are not on the server Here is Extended the
Context with Insert News Functionality

<a name='M-EASYDATACenter-ServerConfiguration-EASYDATACenterContext-GetApiUser-Microsoft-AspNetCore-Http-HttpContext-'></a>
### GetApiUser(httpContext) `method`

##### Summary

Return User From API Request if Exist other null

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| httpContext | [Microsoft.AspNetCore.Http.HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') |  |

<a name='T-EASYDATACenter-Controllers-IgnoredExceptionListApi'></a>
## IgnoredExceptionListApi `type`

##### Namespace

EASYDATACenter.Controllers

##### Summary

Universal Template For Make Any Full Backend Server One Template Has All data operation
Controls for simple copy and build ANY Backend Server

<a name='M-EASYDATACenter-Controllers-IgnoredExceptionListApi-DeleteIgnoredExceptionList-System-String-'></a>
### DeleteIgnoredExceptionList(id) `method`

##### Summary

Operation: Delete record by unique Id key Standard API for delete existing record in DB table

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EASYDATACenter-Controllers-IgnoredExceptionListApi-GetIgnoredExceptionList'></a>
### GetIgnoredExceptionList() `method`

##### Summary

Operation: Select All records Standard API for return all records from DB table

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EASYDATACenter-Controllers-IgnoredExceptionListApi-GetIgnoredExceptionListByFilter-System-String-'></a>
### GetIgnoredExceptionListByFilter(filter) `method`

##### Summary

Operation: Select By sent SQL Where Condition Standard API for return records by Where
condition in Query from DB table

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EASYDATACenter-Controllers-IgnoredExceptionListApi-GetIgnoredExceptionListKey-System-Int32-'></a>
### GetIgnoredExceptionListKey(id) `method`

##### Summary

Operation: Select Unique record Standard API for return one record by primary Id key
from DB table

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-EASYDATACenter-Controllers-IgnoredExceptionListApi-InsertIgnoredExceptionList-EASYDATACenter-DBModel-IgnoredExceptionList-'></a>
### InsertIgnoredExceptionList(record) `method`

##### Summary

Operation: Insert new record Standard API for insert new record to DB table

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| record | [EASYDATACenter.DBModel.IgnoredExceptionList](#T-EASYDATACenter-DBModel-IgnoredExceptionList 'EASYDATACenter.DBModel.IgnoredExceptionList') |  |

<a name='M-EASYDATACenter-Controllers-IgnoredExceptionListApi-UpdateIgnoredExceptionList-EASYDATACenter-DBModel-IgnoredExceptionList-'></a>
### UpdateIgnoredExceptionList(record) `method`

##### Summary

Operation: Update record by unique Id key Standard API for update existing record in DB table

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| record | [EASYDATACenter.DBModel.IgnoredExceptionList](#T-EASYDATACenter-DBModel-IgnoredExceptionList 'EASYDATACenter.DBModel.IgnoredExceptionList') |  |

<a name='T-EASYDATACenter-ServerConfiguration-ServerCoreConfiguration'></a>
## ServerCoreConfiguration `type`

##### Namespace

EASYDATACenter.ServerConfiguration

##### Summary

Server Core: Configuration Server Net Communications, Core Technologies, Security, Cache, Etc..

<a name='M-EASYDATACenter-ServerConfiguration-ServerCoreConfiguration-ConfigureAuthentication-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureAuthentication(services) `method`

##### Summary

Server Core: Configure Server Authentication Support

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EASYDATACenter-ServerConfiguration-ServerCoreConfiguration-ConfigureControllers-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureControllers(services) `method`

##### Summary

Server Core: Configure Server Controllers
options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = [ValidateNever]
in Class options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore
= [JsonIgnore] in Class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EASYDATACenter-ServerConfiguration-ServerCoreConfiguration-ConfigureCookie-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureCookie(services) `method`

##### Summary

Server Core: Configure Cookie Politics

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EASYDATACenter-ServerConfiguration-ServerCoreConfiguration-ConfigureDatabaseContext-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureDatabaseContext(services) `method`

##### Summary

Server Core: Configure Custom Services

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EASYDATACenter-ServerConfiguration-ServerCoreConfiguration-ConfigureLogging-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureLogging(services) `method`

##### Summary

Server Core: Configure Server Logging

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EASYDATACenter-ServerConfiguration-ServerCoreConfiguration-ConfigureScopes-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureScopes(services) `method`

##### Summary

Server Core: Configure Custom Core Services

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EASYDATACenter-ServerConfiguration-ServerCoreConfiguration-ConfigureThirdPartyApi-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureThirdPartyApi(services) `method`

##### Summary

Server Core: Configure HTTP Client for work with third party API

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='T-EASYDATACenter-ServerConfiguration-ServerEnablingServices'></a>
## ServerEnablingServices `type`

##### Namespace

EASYDATACenter.ServerConfiguration

##### Summary

Server configuration services, modules, Politics, etc.

<a name='M-EASYDATACenter-ServerConfiguration-ServerEnablingServices-EnableCors-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableCors() `method`

##### Summary

Server Cors Configuration

##### Parameters

This method has no parameters.

<a name='M-EASYDATACenter-ServerConfiguration-ServerEnablingServices-EnableEndpoints-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableEndpoints() `method`

##### Summary

Server Endpoints Configuration

##### Parameters

This method has no parameters.

<a name='M-EASYDATACenter-ServerConfiguration-ServerEnablingServices-EnableLogging-Microsoft-AspNetCore-Builder-IApplicationBuilder@,Microsoft-Extensions-Logging-ILoggerFactory@-'></a>
### EnableLogging(app,loggerFactory) `method`

##### Summary

Enable Server Logging in Debug Mode

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.IApplicationBuilder@](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder@ 'Microsoft.AspNetCore.Builder.IApplicationBuilder@') |  |
| loggerFactory | [Microsoft.Extensions.Logging.ILoggerFactory@](#T-Microsoft-Extensions-Logging-ILoggerFactory@ 'Microsoft.Extensions.Logging.ILoggerFactory@') |  |

<a name='M-EASYDATACenter-ServerConfiguration-ServerEnablingServices-EnableWebSocket-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableWebSocket(app) `method`

##### Summary

Server WebSocket Configuration

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.IApplicationBuilder@](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder@ 'Microsoft.AspNetCore.Builder.IApplicationBuilder@') |  |

<a name='T-EASYDATACenter-ServerCoreDefinition-ServerLocalDbDials'></a>
## ServerLocalDbDials `type`

##### Namespace

EASYDATACenter.ServerCoreDefinition

##### Summary

Special Functions: Definition of Selected tables for Optimal Using to Data nature Its saves
traffic, increases availability and for Example implemented Language is in Develop Auto Fill
Table when is First Using Its can be used for more Dials

<a name='T-EASYDATACenter-ServerConfiguration-ServerModulesConfiguration'></a>
## ServerModulesConfiguration `type`

##### Namespace

EASYDATACenter.ServerConfiguration

##### Summary

Configure Server Ad-dons and Modules

<a name='M-EASYDATACenter-ServerConfiguration-ServerModulesConfiguration-ConfigureCoreAdmin-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureCoreAdmin(services) `method`

##### Summary

Server Module: Automatic DB Data Manager for work with data directly
services.AddCoreAdmin("Admin"); is Token RoleName

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EASYDATACenter-ServerConfiguration-ServerModulesConfiguration-ConfigureHealthCheck-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureHealthCheck(services) `method`

##### Summary

Server Module: Automatic DB Data Manager for work with data directly

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EASYDATACenter-ServerConfiguration-ServerModulesConfiguration-ConfigureSwagger-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureSwagger(services) `method`

##### Summary

Server Module: Swagger Api Doc Generator And Online Tester Configuration

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='T-EASYDATACenter-ServerConfiguration-ServerModulesEnabling'></a>
## ServerModulesEnabling `type`

##### Namespace

EASYDATACenter.ServerConfiguration

##### Summary

Enable Configured Server Ad-dons and Modules

<a name='M-EASYDATACenter-ServerConfiguration-ServerModulesEnabling-EnableCoreAdmin-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableCoreAdmin() `method`

##### Summary

Server Module: Enable Swagger Api Doc Generator And Online Tester

##### Parameters

This method has no parameters.

<a name='M-EASYDATACenter-ServerConfiguration-ServerModulesEnabling-EnableSwagger-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableSwagger() `method`

##### Summary

Server Module: Enable Swagger Api Doc Generator And Online Tester

##### Parameters

This method has no parameters.

<a name='T-EASYDATACenter-ServerPages-ServerPagesController'></a>
## ServerPagesController `type`

##### Namespace

EASYDATACenter.ServerPages

##### Summary

Server pages Controller

##### See Also

- [Microsoft.AspNetCore.Mvc.Controller](#T-Microsoft-AspNetCore-Mvc-Controller 'Microsoft.AspNetCore.Mvc.Controller')

<a name='M-EASYDATACenter-ServerPages-ServerPagesController-About'></a>
### About() `method`

##### Summary

Abouts page of local WebPages.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EASYDATACenter-ServerPages-ServerPagesController-Index'></a>
### Index() `method`

##### Summary

Default Index page of local WebPages Starts up.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData'></a>
## ServerRuntimeData `type`

##### Namespace

EASYDATACenter.ServerCoreDefinition

##### Summary

The server runtime data.

<a name='F-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-LocalDBTableList'></a>
### LocalDBTableList `constants`

##### Summary

The local db table list.

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-ConfigFile'></a>
### ConfigFile `property`

##### Summary

Gets or Sets the configure file.

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-DataPath'></a>
### DataPath `property`

##### Summary

Gets or Sets the data path.

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-DebugMode'></a>
### DebugMode `property`

##### Summary

Gets or Sets the debug mode.

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-Setting_folder'></a>
### Setting_folder `property`

##### Summary

Gets or Sets the setting_folder.

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-Startup_path'></a>
### Startup_path `property`

##### Summary

Gets or Sets the startup_path.

<a name='T-EASYDATACenter-ServerCoreDefinition-ServerSettings'></a>
## ServerSettings `type`

##### Namespace

EASYDATACenter.ServerCoreDefinition

##### Summary

The server settings.

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigServerStartupPort'></a>
### ConfigServerStartupPort `property`

##### Summary

Set Server API Port for Http/HttpS/WebSocket - API and WebPages

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigCertificateDomain'></a>
### ConfigCertificateDomain `property`

##### Summary

Special Function: Its Domain for include to AutoGenerated certificate by Server for
validation in your Domain or Company. Can be Changed for commercial.

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigCertificatePassword'></a>
### ConfigCertificatePassword `property`

##### Summary

Password for Generated Certificate.

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-DatabaseConnectionString'></a>
### DatabaseConnectionString `property`

##### Summary

DB Connection string

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-SpecialCoreCheckerEmailSenderActive'></a>
### SpecialCoreCheckerEmailSenderActive `property`

##### Summary

Activation / Deactivation of Email Sender

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ModuleSwaggerApiDocEnabled'></a>
### ModuleSwaggerApiDocEnabled `property`

##### Summary

Special Function: Server Automatically Generate Full Documentation of API structure AND
Database Model. Plus Included API Interface for Online Testing All API Methods with
Authentication Its Automatic Solution for Third Party cooperation. All changes are
Reflected after restart server

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ModuleDataManagerEnabled'></a>
### ModuleDataManagerEnabled `property`

##### Summary

Special Function: AutoGenerated Database DataManager for working with Data Running only
in Debug mode for simple Develop, can be modified. All changes are Reflected after
restart server

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ModuleHealthServiceEnabled'></a>
### ModuleHealthServiceEnabled `property`

##### Summary

Special Function: More than 200 Server Statuses Can be monitored by HeathCheckService,
Over Net can Control Other Company Services Also as Central Control Point With Email
Service. For Example: Server/Memory/All DB Types/IP/HDD/Port/Api/NET/Cloud/Environment
Must be run for Metrics AddOn https://learn.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/monitor-app-health

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ServerFtpEngineEnabled'></a>
### ServerFtpEngineEnabled `property`

##### Summary

Enable FTP File Server

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ServerWebBrowserEnabled'></a>
### ServerWebBrowserEnabled `property`

##### Summary

Enable WebPages File Browsing

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigServerStartupOnHttps'></a>
### ConfigServerStartupOnHttps `property`

##### Summary

Setting for Server URL Services. Logically can run only one Http or Https

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-DatabaseInternalCachingEnabled'></a>
### DatabaseInternalCachingEnabled `property`

##### Summary

Enable Disable Entity Framework Internal Cache I recommend turning it off : from Logic,
Same Functionality has Server

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigJwtLocalKey'></a>
### ConfigJwtLocalKey `property`

##### Summary

Special Functions:Server AutoGenerated encryption Key For Securing Communication On Each
Server Restart All Tokens not will be valid and the Login Reconnect is Requested. Its
AntiHacker Security Rule

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-DatabaseInternalCacheTimeoutMin'></a>
### DatabaseInternalCacheTimeoutMin `property`

##### Summary

Time in Minutes for Valid Cache Data and refresh

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigApiTokenTimeoutMin'></a>
### ConfigApiTokenTimeoutMin `property`

##### Summary

Bearer Token Timeout Setting in Minutes

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigMaxWebSocketBufferSizeKb'></a>
### ConfigMaxWebSocketBufferSizeKb `property`

##### Summary

Maximum socket message size for control Traffic

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerSMTPLoginPassword'></a>
### EmailerSMTPLoginPassword `property`

##### Summary

SMTP Password for login service

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerSMTPPort'></a>
### EmailerSMTPPort `property`

##### Summary

SMTP Port for Mail Service

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerSMTPServerAddress'></a>
### EmailerSMTPServerAddress `property`

##### Summary

SMTP Server for Mail Service

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerSMTPSslIsEnabled'></a>
### EmailerSMTPSslIsEnabled `property`

##### Summary

EmailerSMTPSslIsEnabled SSl Email protocol

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerSMTPLoginUsername'></a>
### EmailerSMTPLoginUsername `property`

##### Summary

SMTP UserName for login service

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ModuleHealthServiceRefreshIntervalSec'></a>
### ModuleHealthServiceRefreshIntervalSec `property`

##### Summary

Special Function: More than 200 Server Statuses Can be monitored by HeathCheckService,
Over Net can Control Other Company Services Also as Central Control Point With Email
Service. For Example: Server/Memory/All DB Types/IP/HDD/Port/Api/NET/Cloud/Environment
Must be run for Metrics AddOn
https://github.com/Xabaril/AspNetCore.Diagnostics.HealthChecks https://testfully.io/blog/api-health-check-monitoring/

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigServerLanguage'></a>
### ConfigServerLanguage `property`

##### Summary

Server Language for Translating Server internal statuses

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-SpecialServerServiceName'></a>
### SpecialServerServiceName `property`

##### Summary

Server Emailing Configuration

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerServiceEmailAddress'></a>
### EmailerServiceEmailAddress `property`

##### Summary

Service email, for info about not available service from HeatchCheck Can be used for
next Develop, automatic checking problems, missing data and all other

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigWebSocketTimeoutMin'></a>
### ConfigWebSocketTimeoutMin `property`

##### Summary

WebSocket Timeout Connection Settings

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ServerTimeTokenValidationEnabled'></a>
### ServerTimeTokenValidationEnabled `property`

##### Summary

Enable Disable Bearer Token Timeout Validation Token can be valid EveryTime to using:
Example for machine connection Or is Control last activity

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-SpecialUseDbLocalAutoupdatedDials'></a>
### SpecialUseDbLocalAutoupdatedDials `property`

##### Summary

Special Function: Using Selected Tables with AutoRefresh On change as Local DataSets,
For Optimize Traffic. For Example LanguageList - Static table with often reading

<a name='T-EASYDATACenter-ServerCoreDefinition-ServiceHealthCheck'></a>
## ServiceHealthCheck `type`

##### Namespace

EASYDATACenter.ServerCoreDefinition

<a name='M-EASYDATACenter-ServerCoreDefinition-ServiceHealthCheck-Microsoft#Extensions#Diagnostics#HealthChecks#IHealthCheck#CheckHealthAsync-Microsoft-Extensions-Diagnostics-HealthChecks-HealthCheckContext,System-Threading-CancellationToken-'></a>
### Microsoft#Extensions#Diagnostics#HealthChecks#IHealthCheck#CheckHealthAsync(context,cancellationToken) `method`

##### Summary

checks any service whether it ends normally or with an exception

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckContext](#T-Microsoft-Extensions-Diagnostics-HealthChecks-HealthCheckContext 'Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckContext') |  |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |  |

<a name='T-EASYDATACenter-Controllers-SetReportFilter'></a>
## SetReportFilter `type`

##### Namespace

EASYDATACenter.Controllers

##### Summary

Database Model Extension Definitions
Its API Filter, Extended Classes, Translation, etc

<a name='T-EASYDATACenter-Startup'></a>
## Startup `type`

##### Namespace

EASYDATACenter

##### Summary

Server Startup Definitions

<a name='M-EASYDATACenter-Startup-Configure-Microsoft-AspNetCore-Builder-IApplicationBuilder,Microsoft-Extensions-Logging-ILoggerFactory-'></a>
### Configure(app,loggerFactory) `method`

##### Summary

Server Core: Main Enabling of Server Services, Technologies, Modules, etc..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder') |  |
| loggerFactory | [Microsoft.Extensions.Logging.ILoggerFactory](#T-Microsoft-Extensions-Logging-ILoggerFactory 'Microsoft.Extensions.Logging.ILoggerFactory') |  |

<a name='M-EASYDATACenter-Startup-ConfigureServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### ConfigureServices(Microsoft.Extensions.DependencyInjection.IServiceCollection services.Extensions.DependencyInjection.IServiceCollectionservices) `method`

##### Summary

Server Core: Main Configure of Server Services, Technologies, Modules, etc..

##### Returns

void.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Microsoft.Extensions.DependencyInjection.IServiceCollection services.Extensions.DependencyInjection.IServiceCollectionservices | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | : Describe Microsoft.Extensions.DependencyInjection.IServiceCollection services here. |

<a name='T-EASYDATACenter-ServerCoreOperations-SystemFunctions'></a>
## SystemFunctions `type`

##### Namespace

EASYDATACenter.ServerCoreOperations

<a name='M-EASYDATACenter-ServerCoreOperations-SystemFunctions-GetSystemErrMessage-System-Exception,System-Int32-'></a>
### GetSystemErrMessage(exception,msgCount) `method`

##### Summary

Mined-ed Error Message For System Save to Database For Simple Solving Problem

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') |  |
| msgCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-EASYDATACenter-ServerCoreOperations-SystemFunctions-GetUserApiErrMessage-System-Exception,System-Int32-'></a>
### GetUserApiErrMessage(exception,msgCount) `method`

##### Summary

Mined-ed Error Message For Answer in API Error Response with detailed info about problem

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') |  |
| msgCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-EASYDATACenter-ServerCoreOperations-SystemFunctions-SendMail-System-String-'></a>
### SendMail(message) `method`

##### Summary

System Mailer sending Emails To service email with detected fail for analyze and
corrections on the Way provide better services every time

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-EASYDATACenter-Templates-TemplateAuthApiService'></a>
## TemplateAuthApiService `type`

##### Namespace

EASYDATACenter.Templates

##### Summary

System Template of Authentication Basic / Bearer security Api communication

<a name='M-EASYDATACenter-Templates-TemplateAuthApiService-Authenticate-System-String-'></a>
### Authenticate(Authorization) `method`

##### Summary

Server Basic Authentication API for login Via UserName and Password Returned is Token
for next communication Token Can be limited by Time - Validating is via LifetimeValidator

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Authorization | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EASYDATACenter-Templates-TemplateAuthApiService-Authenticate-System-String,System-String-'></a>
### Authenticate(username,password) `method`

##### Summary

API Authenticated and Generate Token

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EASYDATACenter-Templates-TemplateAuthApiService-LifetimeValidator-System-Nullable{System-DateTime},System-Nullable{System-DateTime},Microsoft-IdentityModel-Tokens-SecurityToken,Microsoft-IdentityModel-Tokens-TokenValidationParameters-'></a>
### LifetimeValidator(notBefore,expires,token,params) `method`

##### Summary

API Token LifeTime Validator

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| notBefore | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') |  |
| expires | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') |  |
| token | [Microsoft.IdentityModel.Tokens.SecurityToken](#T-Microsoft-IdentityModel-Tokens-SecurityToken 'Microsoft.IdentityModel.Tokens.SecurityToken') |  |
| params | [Microsoft.IdentityModel.Tokens.TokenValidationParameters](#T-Microsoft-IdentityModel-Tokens-TokenValidationParameters 'Microsoft.IdentityModel.Tokens.TokenValidationParameters') |  |

<a name='M-EASYDATACenter-Templates-TemplateAuthApiService-RefreshUserToken-System-String,EASYDATACenter-ServerCoreDefinition-AuthenticateResponse-'></a>
### RefreshUserToken(username,token) `method`

##### Summary

API Refresh User Token

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| token | [EASYDATACenter.ServerCoreDefinition.AuthenticateResponse](#T-EASYDATACenter-ServerCoreDefinition-AuthenticateResponse 'EASYDATACenter.ServerCoreDefinition.AuthenticateResponse') |  |

<a name='T-EASYDATACenter-Templates-TemplateCentralDBListApi'></a>
## TemplateCentralDBListApi `type`

##### Namespace

EASYDATACenter.Templates

##### Summary

Universal Template For Make Any Full Backend Server One Template Has All data operation
Controls for simple copy and build ANY Backend Server

<a name='M-EASYDATACenter-Templates-TemplateCentralDBListApi-DeleteTemplateCentralDBList-System-String-'></a>
### DeleteTemplateCentralDBList(id) `method`

##### Summary

Operation: Delete record by unique Id key Standard API for delete existing record in DB table

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EASYDATACenter-Templates-TemplateCentralDBListApi-GetTemplateCentralDBList'></a>
### GetTemplateCentralDBList() `method`

##### Summary

Operation: Select All records Standard API for return all records from DB table

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EASYDATACenter-Templates-TemplateCentralDBListApi-GetTemplateCentralDBListByFilter-System-String-'></a>
### GetTemplateCentralDBListByFilter(filter) `method`

##### Summary

Operation: Select By sent SQL Where Condition Standard API for return records by Where
condition in Query from DB table

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EASYDATACenter-Templates-TemplateCentralDBListApi-GetTemplateCentralDBListKey-System-Int32-'></a>
### GetTemplateCentralDBListKey(id) `method`

##### Summary

Operation: Select Unique record Standard API for return one record by primary Id key
from DB table

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-EASYDATACenter-Templates-TemplateCentralDBListApi-InsertTemplateCentralDBList-EASYDATACenter-DBModel-TemplateList-'></a>
### InsertTemplateCentralDBList(record) `method`

##### Summary

Operation: Insert new record Standard API for insert new record to DB table

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| record | [EASYDATACenter.DBModel.TemplateList](#T-EASYDATACenter-DBModel-TemplateList 'EASYDATACenter.DBModel.TemplateList') |  |

<a name='M-EASYDATACenter-Templates-TemplateCentralDBListApi-UpdateTemplateCentralDBList-EASYDATACenter-DBModel-TemplateList-'></a>
### UpdateTemplateCentralDBList(record) `method`

##### Summary

Operation: Update record by unique Id key Standard API for update existing record in DB table

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| record | [EASYDATACenter.DBModel.TemplateList](#T-EASYDATACenter-DBModel-TemplateList 'EASYDATACenter.DBModel.TemplateList') |  |

<a name='T-EASYDATACenter-Templates-TemplateClassList'></a>
## TemplateClassList `type`

##### Namespace

EASYDATACenter.Templates

##### Summary

Template System Class, This Class has all DBLogic auto Fields and user join for simple
creating system Only Rename for your new table

<a name='T-EASYDATACenter-Templates-TemplateImageApi'></a>
## TemplateImageApi `type`

##### Namespace

EASYDATACenter.Templates

##### Summary

This is Template for Images API for Returning files Its standard using for WebPages or can
be used for Document System Can be used for All file types

<a name='M-EASYDATACenter-Templates-TemplateImageApi-GetSearchImageById-System-Nullable{System-Int32}-'></a>
### GetSearchImageById(id) `method`

##### Summary

Return Image by Primary Key

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') |  |

<a name='M-EASYDATACenter-Templates-TemplateImageApi-GetSearchImageByKeys-System-Nullable{System-Int32},System-String-'></a>
### GetSearchImageByKeys(id,fileName) `method`

##### Summary

Return Image by Foreign Key / or Hidden Logic Previous Attackers

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') |  |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-EASYDATACenter-Templates-TemplateItemListApi'></a>
## TemplateItemListApi `type`

##### Namespace

EASYDATACenter.Templates

##### Summary

This Template Show managing SubItems Invoice and Items for example Where SubItems is managed
as Collection - One Operation for All Items = Range join between tables are managed by DB
Foreign Key - with ON DELETE CASCADE

<a name='T-EASYDATACenter-DBModel-TemplateList'></a>
## TemplateList `type`

##### Namespace

EASYDATACenter.DBModel

##### Summary

Template System Class, This Class has all DBLogic auto Fields and user join for simple
creating system Only Rename for your new table

<a name='T-EASYDATACenter-Templates-TemplateProcedureApi'></a>
## TemplateProcedureApi `type`

##### Namespace

EASYDATACenter.Templates

<a name='M-EASYDATACenter-Templates-TemplateProcedureApi-GetTemplateProcedure-System-String,System-String-'></a>
### GetTemplateProcedure(unlockCode,partNumber) `method`

##### Summary

API With response from DATABASE STORED PROCEDURE Procedure use IN/OUT parameters In
Database User must have right for Execute procedure

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| unlockCode | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| partNumber | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-EASYDATACenter-WebSocketDefinition-WebSocketExampleApi'></a>
## WebSocketExampleApi `type`

##### Namespace

EASYDATACenter.WebSocketDefinition

##### Summary

WEBSocket Template still not used Ideal for Terminal Panels, chat, controlling services

<a name='M-EASYDATACenter-WebSocketDefinition-WebSocketExampleApi-CloseDisconnectedSocketConnections'></a>
### CloseDisconnectedSocketConnections() `method`

##### Summary

WebSocket Disconnection Service for All connected Clients

##### Parameters

This method has no parameters.

<a name='M-EASYDATACenter-WebSocketDefinition-WebSocketExampleApi-Get'></a>
### Get() `method`

##### Summary

WebSocket Registration Connection API

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EASYDATACenter-WebSocketDefinition-WebSocketExampleApi-GetbyId-System-String-'></a>
### GetbyId(id) `method`

##### Summary

WebSocket API for Specific Information

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EASYDATACenter-WebSocketDefinition-WebSocketExampleApi-ListenMessages-System-Net-WebSockets-WebSocket,System-String-'></a>
### ListenMessages(webSocket,auctionId) `method`

##### Summary

Register new WebSocket Connection

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| webSocket | [System.Net.WebSockets.WebSocket](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.WebSockets.WebSocket 'System.Net.WebSockets.WebSocket') |  |
| auctionId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EASYDATACenter-WebSocketDefinition-WebSocketExampleApi-UpdateSocketsByAuctionIdInfo-System-String-'></a>
### UpdateSocketsByAuctionIdInfo(auctionId) `method`

##### Summary

After Change Detection is Sent Status to All Clients
which are connected for Changed Information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| auctionId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
