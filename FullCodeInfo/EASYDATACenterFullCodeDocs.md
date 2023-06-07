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
- [BackendServer](#T-EASYDATACenter-BackendServer 'EASYDATACenter.BackendServer')
  - [ServerRuntimeData](#F-EASYDATACenter-BackendServer-ServerRuntimeData 'EASYDATACenter.BackendServer.ServerRuntimeData')
  - [ServerSettings](#F-EASYDATACenter-BackendServer-ServerSettings 'EASYDATACenter.BackendServer.ServerSettings')
  - [BuildWebHost(args)](#M-EASYDATACenter-BackendServer-BuildWebHost-System-String[]- 'EASYDATACenter.BackendServer.BuildWebHost(System.String[])')
  - [Main(args)](#M-EASYDATACenter-BackendServer-Main-System-String[]- 'EASYDATACenter.BackendServer.Main(System.String[])')
  - [RestartServer()](#M-EASYDATACenter-BackendServer-RestartServer 'EASYDATACenter.BackendServer.RestartServer')
  - [ServerStartupDbDataLoading()](#M-EASYDATACenter-BackendServer-ServerStartupDbDataLoading 'EASYDATACenter.BackendServer.ServerStartupDbDataLoading')
  - [StartServer()](#M-EASYDATACenter-BackendServer-StartServer 'EASYDATACenter.BackendServer.StartServer')
- [CommunicationController](#T-EASYDATACenter-ServerCoreDefinition-CommunicationController 'EASYDATACenter.ServerCoreDefinition.CommunicationController')
  - [HttpContext](#P-EASYDATACenter-ServerCoreDefinition-CommunicationController-HttpContext 'EASYDATACenter.ServerCoreDefinition.CommunicationController.HttpContext')
  - [CheckAdmin()](#M-EASYDATACenter-ServerCoreDefinition-CommunicationController-CheckAdmin 'EASYDATACenter.ServerCoreDefinition.CommunicationController.CheckAdmin')
- [CustomFtpUser](#T-EASYDATACenter-ServerCoreServers-HostedFtpServerMembershipProvider-CustomFtpUser 'EASYDATACenter.ServerCoreServers.HostedFtpServerMembershipProvider.CustomFtpUser')
  - [#ctor(name)](#M-EASYDATACenter-ServerCoreServers-HostedFtpServerMembershipProvider-CustomFtpUser-#ctor-System-String- 'EASYDATACenter.ServerCoreServers.HostedFtpServerMembershipProvider.CustomFtpUser.#ctor(System.String)')
  - [Name](#P-EASYDATACenter-ServerCoreServers-HostedFtpServerMembershipProvider-CustomFtpUser-Name 'EASYDATACenter.ServerCoreServers.HostedFtpServerMembershipProvider.CustomFtpUser.Name')
  - [IsInGroup()](#M-EASYDATACenter-ServerCoreServers-HostedFtpServerMembershipProvider-CustomFtpUser-IsInGroup-System-String- 'EASYDATACenter.ServerCoreServers.HostedFtpServerMembershipProvider.CustomFtpUser.IsInGroup(System.String)')
- [CustomString](#T-EASYDATACenter-ServerCoreDBSettings-CustomString 'EASYDATACenter.ServerCoreDBSettings.CustomString')
- [DBResult](#T-EASYDATACenter-ServerCoreDefinition-DBResult 'EASYDATACenter.ServerCoreDefinition.DBResult')
- [DBResultMessage](#T-EASYDATACenter-ServerCoreDefinition-DBResultMessage 'EASYDATACenter.ServerCoreDefinition.DBResultMessage')
  - [ErrorMessage](#P-EASYDATACenter-ServerCoreDefinition-DBResultMessage-ErrorMessage 'EASYDATACenter.ServerCoreDefinition.DBResultMessage.ErrorMessage')
  - [InsertedId](#P-EASYDATACenter-ServerCoreDefinition-DBResultMessage-InsertedId 'EASYDATACenter.ServerCoreDefinition.DBResultMessage.InsertedId')
  - [RecordCount](#P-EASYDATACenter-ServerCoreDefinition-DBResultMessage-RecordCount 'EASYDATACenter.ServerCoreDefinition.DBResultMessage.RecordCount')
  - [Status](#P-EASYDATACenter-ServerCoreDefinition-DBResultMessage-Status 'EASYDATACenter.ServerCoreDefinition.DBResultMessage.Status')
- [DatabaseContextExtensions](#T-EASYDATACenter-ServerCoreDBSettings-DatabaseContextExtensions 'EASYDATACenter.ServerCoreDBSettings.DatabaseContextExtensions')
- [DgmlSchemaApi](#T-EASYDATACenter-ServerCoreDBSettings-DgmlSchemaApi 'EASYDATACenter.ServerCoreDBSettings.DgmlSchemaApi')
  - [#ctor(context)](#M-EASYDATACenter-ServerCoreDBSettings-DgmlSchemaApi-#ctor-EASYDATACenter-ServerCoreDBSettings-EASYDATACenterContext- 'EASYDATACenter.ServerCoreDBSettings.DgmlSchemaApi.#ctor(EASYDATACenter.ServerCoreDBSettings.EASYDATACenterContext)')
  - [Get()](#M-EASYDATACenter-ServerCoreDBSettings-DgmlSchemaApi-Get 'EASYDATACenter.ServerCoreDBSettings.DgmlSchemaApi.Get')
- [EASYDATACenterContext](#T-EASYDATACenter-ServerCoreDBSettings-EASYDATACenterContext 'EASYDATACenter.ServerCoreDBSettings.EASYDATACenterContext')
  - [GetApiUserId(httpContext)](#M-EASYDATACenter-ServerCoreDBSettings-EASYDATACenterContext-GetApiUserId-Microsoft-AspNetCore-Http-HttpContext- 'EASYDATACenter.ServerCoreDBSettings.EASYDATACenterContext.GetApiUserId(Microsoft.AspNetCore.Http.HttpContext)')
  - [IsAdmin(httpContext)](#M-EASYDATACenter-ServerCoreDBSettings-EASYDATACenterContext-IsAdmin-Microsoft-AspNetCore-Http-HttpContext- 'EASYDATACenter.ServerCoreDBSettings.EASYDATACenterContext.IsAdmin(Microsoft.AspNetCore.Http.HttpContext)')
- [GLOBALNETAuthenticationApi](#T-EASYDATACenter-ControllersExtensions-GLOBALNETAuthenticationApi 'EASYDATACenter.ControllersExtensions.GLOBALNETAuthenticationApi')
  - [Authenticate(username,password)](#M-EASYDATACenter-ControllersExtensions-GLOBALNETAuthenticationApi-Authenticate-System-String,System-String- 'EASYDATACenter.ControllersExtensions.GLOBALNETAuthenticationApi.Authenticate(System.String,System.String)')
  - [LifetimeValidator(notBefore,expires,token,params)](#M-EASYDATACenter-ControllersExtensions-GLOBALNETAuthenticationApi-LifetimeValidator-System-Nullable{System-DateTime},System-Nullable{System-DateTime},Microsoft-IdentityModel-Tokens-SecurityToken,Microsoft-IdentityModel-Tokens-TokenValidationParameters- 'EASYDATACenter.ControllersExtensions.GLOBALNETAuthenticationApi.LifetimeValidator(System.Nullable{System.DateTime},System.Nullable{System.DateTime},Microsoft.IdentityModel.Tokens.SecurityToken,Microsoft.IdentityModel.Tokens.TokenValidationParameters)')
  - [RefreshUserToken(username,token)](#M-EASYDATACenter-ControllersExtensions-GLOBALNETAuthenticationApi-RefreshUserToken-System-String,EASYDATACenter-ServerCoreDefinition-AuthenticateResponse- 'EASYDATACenter.ControllersExtensions.GLOBALNETAuthenticationApi.RefreshUserToken(System.String,EASYDATACenter.ServerCoreDefinition.AuthenticateResponse)')
- [GLOBALNETBackendCheckApi](#T-EASYDATACenter-ControllersExtensions-GLOBALNETBackendCheckApi 'EASYDATACenter.ControllersExtensions.GLOBALNETBackendCheckApi')
  - [GetBackendCheckApi()](#M-EASYDATACenter-ControllersExtensions-GLOBALNETBackendCheckApi-GetBackendCheckApi 'EASYDATACenter.ControllersExtensions.GLOBALNETBackendCheckApi.GetBackendCheckApi')
- [HostedFtpServer](#T-EASYDATACenter-ServerCoreServers-HostedFtpServer 'EASYDATACenter.ServerCoreServers.HostedFtpServer')
  - [#ctor(ftpServerHost)](#M-EASYDATACenter-ServerCoreServers-HostedFtpServer-#ctor-FubarDev-FtpServer-IFtpServerHost- 'EASYDATACenter.ServerCoreServers.HostedFtpServer.#ctor(FubarDev.FtpServer.IFtpServerHost)')
  - [StartAsync()](#M-EASYDATACenter-ServerCoreServers-HostedFtpServer-StartAsync-System-Threading-CancellationToken- 'EASYDATACenter.ServerCoreServers.HostedFtpServer.StartAsync(System.Threading.CancellationToken)')
  - [StopAsync()](#M-EASYDATACenter-ServerCoreServers-HostedFtpServer-StopAsync-System-Threading-CancellationToken- 'EASYDATACenter.ServerCoreServers.HostedFtpServer.StopAsync(System.Threading.CancellationToken)')
- [HostedFtpServerMembershipProvider](#T-EASYDATACenter-ServerCoreServers-HostedFtpServerMembershipProvider 'EASYDATACenter.ServerCoreServers.HostedFtpServerMembershipProvider')
  - [ValidateUser(username,password)](#M-EASYDATACenter-ServerCoreServers-HostedFtpServerMembershipProvider-ValidateUser-System-String,System-String- 'EASYDATACenter.ServerCoreServers.HostedFtpServerMembershipProvider.ValidateUser(System.String,System.String)')
  - [ValidateUserAsync(username,password)](#M-EASYDATACenter-ServerCoreServers-HostedFtpServerMembershipProvider-ValidateUserAsync-System-String,System-String- 'EASYDATACenter.ServerCoreServers.HostedFtpServerMembershipProvider.ValidateUserAsync(System.String,System.String)')
- [IdFilter](#T-EASYDATACenter-ServerCoreDBSettings-IdFilter 'EASYDATACenter.ServerCoreDBSettings.IdFilter')
- [MailRequest](#T-EASYDATACenter-ServerCoreDefinition-MailRequest 'EASYDATACenter.ServerCoreDefinition.MailRequest')
- [NameFilter](#T-EASYDATACenter-ServerCoreDBSettings-NameFilter 'EASYDATACenter.ServerCoreDBSettings.NameFilter')
- [SHOPINGERAuthenticationApi](#T-SHOPINGER-Controllers-SHOPINGERAuthenticationApi 'SHOPINGER.Controllers.SHOPINGERAuthenticationApi')
  - [Authenticate(username,password)](#M-SHOPINGER-Controllers-SHOPINGERAuthenticationApi-Authenticate-System-String,System-String- 'SHOPINGER.Controllers.SHOPINGERAuthenticationApi.Authenticate(System.String,System.String)')
  - [LifetimeValidator(notBefore,expires,token,params)](#M-SHOPINGER-Controllers-SHOPINGERAuthenticationApi-LifetimeValidator-System-Nullable{System-DateTime},System-Nullable{System-DateTime},Microsoft-IdentityModel-Tokens-SecurityToken,Microsoft-IdentityModel-Tokens-TokenValidationParameters- 'SHOPINGER.Controllers.SHOPINGERAuthenticationApi.LifetimeValidator(System.Nullable{System.DateTime},System.Nullable{System.DateTime},Microsoft.IdentityModel.Tokens.SecurityToken,Microsoft.IdentityModel.Tokens.TokenValidationParameters)')
  - [RefreshUserToken(username,token)](#M-SHOPINGER-Controllers-SHOPINGERAuthenticationApi-RefreshUserToken-System-String,EASYDATACenter-ServerCoreDefinition-AuthenticateResponse- 'SHOPINGER.Controllers.SHOPINGERAuthenticationApi.RefreshUserToken(System.String,EASYDATACenter.ServerCoreDefinition.AuthenticateResponse)')
- [ServerConfigurationServices](#T-EASYDATACenter-ServerCoreConfiguration-ServerConfigurationServices 'EASYDATACenter.ServerCoreConfiguration.ServerConfigurationServices')
  - [ConfigureAuthentication(services)](#M-EASYDATACenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureAuthentication-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureAuthentication(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureControllers(services)](#M-EASYDATACenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureControllers-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureControllers(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureCookie(services)](#M-EASYDATACenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureCookie-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureCookie(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureDatabaseContext(services)](#M-EASYDATACenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureDatabaseContext-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureDatabaseContext(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureFTPServer(services)](#M-EASYDATACenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureFTPServer-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureFTPServer(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureLogging(services)](#M-EASYDATACenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureLogging-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureLogging(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureScopes(services)](#M-EASYDATACenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureScopes-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureScopes(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureServerWebPages(services)](#M-EASYDATACenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureServerWebPages-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureServerWebPages(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureThirdPartyApi(services)](#M-EASYDATACenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureThirdPartyApi-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureThirdPartyApi(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureWebSocketLoggerMonitor(services)](#M-EASYDATACenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureWebSocketLoggerMonitor-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureWebSocketLoggerMonitor(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
- [ServerCoreDbOperations](#T-EASYDATACenter-ServerCoreMethods-ServerCoreDbOperations 'EASYDATACenter.ServerCoreMethods.ServerCoreDbOperations')
  - [DBTranslate(word,language)](#M-EASYDATACenter-ServerCoreMethods-ServerCoreDbOperations-DBTranslate-System-String,System-String- 'EASYDATACenter.ServerCoreMethods.ServerCoreDbOperations.DBTranslate(System.String,System.String)')
  - [DBTranslateOffline(word,language)](#M-EASYDATACenter-ServerCoreMethods-ServerCoreDbOperations-DBTranslateOffline-System-String,System-String- 'EASYDATACenter.ServerCoreMethods.ServerCoreDbOperations.DBTranslateOffline(System.String,System.String)')
  - [DBTranslateOnline(word,language)](#M-EASYDATACenter-ServerCoreMethods-ServerCoreDbOperations-DBTranslateOnline-System-String,System-String- 'EASYDATACenter.ServerCoreMethods.ServerCoreDbOperations.DBTranslateOnline(System.String,System.String)')
  - [LoadStaticDbDials(onlyThis)](#M-EASYDATACenter-ServerCoreMethods-ServerCoreDbOperations-LoadStaticDbDials-System-Nullable{EASYDATACenter-ServerCoreDefinition-ServerLocalDbDials}- 'EASYDATACenter.ServerCoreMethods.ServerCoreDbOperations.LoadStaticDbDials(System.Nullable{EASYDATACenter.ServerCoreDefinition.ServerLocalDbDials})')
  - [WriteVisit(ipAddress,userId,userName)](#M-EASYDATACenter-ServerCoreMethods-ServerCoreDbOperations-WriteVisit-System-String,System-Int32,System-String- 'EASYDATACenter.ServerCoreMethods.ServerCoreDbOperations.WriteVisit(System.String,System.Int32,System.String)')
- [ServerCoreFunctions](#T-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions 'EASYDATACenter.ServerCoreMethods.ServerCoreFunctions')
  - [CheckDirectory(directory)](#M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-CheckDirectory-System-String- 'EASYDATACenter.ServerCoreMethods.ServerCoreFunctions.CheckDirectory(System.String)')
  - [CheckFile(file)](#M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-CheckFile-System-String- 'EASYDATACenter.ServerCoreMethods.ServerCoreFunctions.CheckFile(System.String)')
  - [CopyFile(from,to)](#M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-CopyFile-System-String,System-String- 'EASYDATACenter.ServerCoreMethods.ServerCoreFunctions.CopyFile(System.String,System.String)')
  - [CreatePath(path)](#M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-CreatePath-System-String- 'EASYDATACenter.ServerCoreMethods.ServerCoreFunctions.CreatePath(System.String)')
  - [FileDetectEncoding(FileName)](#M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-FileDetectEncoding-System-String- 'EASYDATACenter.ServerCoreMethods.ServerCoreFunctions.FileDetectEncoding(System.String)')
  - [GetSelfSignedCertificate(password)](#M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-GetSelfSignedCertificate-System-String- 'EASYDATACenter.ServerCoreMethods.ServerCoreFunctions.GetSelfSignedCertificate(System.String)')
  - [GetSelfSignedCertificateFromFile()](#M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-GetSelfSignedCertificateFromFile 'EASYDATACenter.ServerCoreMethods.ServerCoreFunctions.GetSelfSignedCertificateFromFile')
  - [GetSystemErrMessage(exception,msgCount)](#M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-GetSystemErrMessage-System-Exception,System-Int32- 'EASYDATACenter.ServerCoreMethods.ServerCoreFunctions.GetSystemErrMessage(System.Exception,System.Int32)')
  - [GetUserApiErrMessage(exception,msgCount)](#M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-GetUserApiErrMessage-System-Exception,System-Int32- 'EASYDATACenter.ServerCoreMethods.ServerCoreFunctions.GetUserApiErrMessage(System.Exception,System.Int32)')
  - [LoadSettings()](#M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-LoadSettings 'EASYDATACenter.ServerCoreMethods.ServerCoreFunctions.LoadSettings')
  - [RandomString(length)](#M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-RandomString-System-Int32- 'EASYDATACenter.ServerCoreMethods.ServerCoreFunctions.RandomString(System.Int32)')
  - [ReadFile(fileName)](#M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-ReadFile-System-String- 'EASYDATACenter.ServerCoreMethods.ServerCoreFunctions.ReadFile(System.String)')
  - [SendEmail(mailRequest,sendImmediately)](#M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-SendEmail-EASYDATACenter-ServerCoreDefinition-MailRequest,System-Boolean- 'EASYDATACenter.ServerCoreMethods.ServerCoreFunctions.SendEmail(EASYDATACenter.ServerCoreDefinition.MailRequest,System.Boolean)')
  - [SendMassEmail(mailRequests)](#M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-SendMassEmail-System-Collections-Generic-List{EASYDATACenter-ServerCoreDefinition-MailRequest}- 'EASYDATACenter.ServerCoreMethods.ServerCoreFunctions.SendMassEmail(System.Collections.Generic.List{EASYDATACenter.ServerCoreDefinition.MailRequest})')
  - [UnicodeToUTF8(strFrom)](#M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-UnicodeToUTF8-System-String- 'EASYDATACenter.ServerCoreMethods.ServerCoreFunctions.UnicodeToUTF8(System.String)')
- [ServerCoreHelpers](#T-EASYDATACenter-ServerCoreDefinition-ServerCoreHelpers 'EASYDATACenter.ServerCoreDefinition.ServerCoreHelpers')
  - [AddSocketConnectionToCentalList(newWebSocket,socketAPIPath)](#M-EASYDATACenter-ServerCoreDefinition-ServerCoreHelpers-AddSocketConnectionToCentalList-System-Net-WebSockets-WebSocket,System-String- 'EASYDATACenter.ServerCoreDefinition.ServerCoreHelpers.AddSocketConnectionToCentalList(System.Net.WebSockets.WebSocket,System.String)')
  - [BindList\`\`1(dt)](#M-EASYDATACenter-ServerCoreDefinition-ServerCoreHelpers-BindList``1-System-Data-DataTable- 'EASYDATACenter.ServerCoreDefinition.ServerCoreHelpers.BindList``1(System.Data.DataTable)')
  - [DisposeSocketConnectionsWithTimeOut()](#M-EASYDATACenter-ServerCoreDefinition-ServerCoreHelpers-DisposeSocketConnectionsWithTimeOut 'EASYDATACenter.ServerCoreDefinition.ServerCoreHelpers.DisposeSocketConnectionsWithTimeOut')
  - [ListenClientWebSocketMessages(webSocket,socketAPIPath)](#M-EASYDATACenter-ServerCoreDefinition-ServerCoreHelpers-ListenClientWebSocketMessages-System-Net-WebSockets-WebSocket,System-String- 'EASYDATACenter.ServerCoreDefinition.ServerCoreHelpers.ListenClientWebSocketMessages(System.Net.WebSockets.WebSocket,System.String)')
  - [SendMessageAndUpdateWebSocketsInSpecificPath(socketAPIPath,message)](#M-EASYDATACenter-ServerCoreDefinition-ServerCoreHelpers-SendMessageAndUpdateWebSocketsInSpecificPath-System-String,System-String- 'EASYDATACenter.ServerCoreDefinition.ServerCoreHelpers.SendMessageAndUpdateWebSocketsInSpecificPath(System.String,System.String)')
  - [SendMessageToClientSocket(webSocket,message)](#M-EASYDATACenter-ServerCoreDefinition-ServerCoreHelpers-SendMessageToClientSocket-System-Net-WebSockets-WebSocket,System-String- 'EASYDATACenter.ServerCoreDefinition.ServerCoreHelpers.SendMessageToClientSocket(System.Net.WebSockets.WebSocket,System.String)')
- [ServerCoreLoggerWS](#T-EASYDATACenter-ServerCoreDBSettings-ServerCoreLoggerWS 'EASYDATACenter.ServerCoreDBSettings.ServerCoreLoggerWS')
  - [Echo(context,webSocket)](#M-EASYDATACenter-ServerCoreDBSettings-ServerCoreLoggerWS-Echo-Microsoft-AspNetCore-Http-HttpContext,System-Net-WebSockets-WebSocket- 'EASYDATACenter.ServerCoreDBSettings.ServerCoreLoggerWS.Echo(Microsoft.AspNetCore.Http.HttpContext,System.Net.WebSockets.WebSocket)')
  - [Get()](#M-EASYDATACenter-ServerCoreDBSettings-ServerCoreLoggerWS-Get 'EASYDATACenter.ServerCoreDBSettings.ServerCoreLoggerWS.Get')
  - [GetBySocketAPIPath(id)](#M-EASYDATACenter-ServerCoreDBSettings-ServerCoreLoggerWS-GetBySocketAPIPath-System-String- 'EASYDATACenter.ServerCoreDBSettings.ServerCoreLoggerWS.GetBySocketAPIPath(System.String)')
- [ServerCorePagesApi](#T-EASYDATACenter-ServerCoreDBSettings-ServerCorePagesApi 'EASYDATACenter.ServerCoreDBSettings.ServerCorePagesApi')
- [ServerEmailerApi](#T-EASYDATACenter-ServerCoreDBSettings-ServerEmailerApi 'EASYDATACenter.ServerCoreDBSettings.ServerEmailerApi')
- [ServerEnablingServices](#T-EASYDATACenter-ServerCoreConfiguration-ServerEnablingServices 'EASYDATACenter.ServerCoreConfiguration.ServerEnablingServices')
  - [EnableCors()](#M-EASYDATACenter-ServerCoreConfiguration-ServerEnablingServices-EnableCors-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'EASYDATACenter.ServerCoreConfiguration.ServerEnablingServices.EnableCors(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
  - [EnableEndpoints()](#M-EASYDATACenter-ServerCoreConfiguration-ServerEnablingServices-EnableEndpoints-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'EASYDATACenter.ServerCoreConfiguration.ServerEnablingServices.EnableEndpoints(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
  - [EnableLogging(app,loggerFactory)](#M-EASYDATACenter-ServerCoreConfiguration-ServerEnablingServices-EnableLogging-Microsoft-AspNetCore-Builder-IApplicationBuilder@,Microsoft-Extensions-Logging-ILoggerFactory@- 'EASYDATACenter.ServerCoreConfiguration.ServerEnablingServices.EnableLogging(Microsoft.AspNetCore.Builder.IApplicationBuilder@,Microsoft.Extensions.Logging.ILoggerFactory@)')
  - [EnableWebSocket(app)](#M-EASYDATACenter-ServerCoreConfiguration-ServerEnablingServices-EnableWebSocket-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'EASYDATACenter.ServerCoreConfiguration.ServerEnablingServices.EnableWebSocket(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
- [ServerLocalDbDials](#T-EASYDATACenter-ServerCoreDefinition-ServerLocalDbDials 'EASYDATACenter.ServerCoreDefinition.ServerLocalDbDials')
- [ServerModules](#T-EASYDATACenter-ServerCoreConfiguration-ServerModules 'EASYDATACenter.ServerCoreConfiguration.ServerModules')
  - [ConfigureCoreAdmin(services)](#M-EASYDATACenter-ServerCoreConfiguration-ServerModules-ConfigureCoreAdmin-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerCoreConfiguration.ServerModules.ConfigureCoreAdmin(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureDocumentation(services)](#M-EASYDATACenter-ServerCoreConfiguration-ServerModules-ConfigureDocumentation-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerCoreConfiguration.ServerModules.ConfigureDocumentation(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureHealthCheck(services)](#M-EASYDATACenter-ServerCoreConfiguration-ServerModules-ConfigureHealthCheck-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerCoreConfiguration.ServerModules.ConfigureHealthCheck(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureSwagger(services)](#M-EASYDATACenter-ServerCoreConfiguration-ServerModules-ConfigureSwagger-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EASYDATACenter.ServerCoreConfiguration.ServerModules.ConfigureSwagger(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
- [ServerModulesEnabling](#T-EASYDATACenter-ServerCoreConfiguration-ServerModulesEnabling 'EASYDATACenter.ServerCoreConfiguration.ServerModulesEnabling')
  - [EnableCoreAdmin()](#M-EASYDATACenter-ServerCoreConfiguration-ServerModulesEnabling-EnableCoreAdmin-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'EASYDATACenter.ServerCoreConfiguration.ServerModulesEnabling.EnableCoreAdmin(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
  - [EnableDocumentation()](#M-EASYDATACenter-ServerCoreConfiguration-ServerModulesEnabling-EnableDocumentation-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'EASYDATACenter.ServerCoreConfiguration.ServerModulesEnabling.EnableDocumentation(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
  - [EnableSwagger()](#M-EASYDATACenter-ServerCoreConfiguration-ServerModulesEnabling-EnableSwagger-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'EASYDATACenter.ServerCoreConfiguration.ServerModulesEnabling.EnableSwagger(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
- [ServerRestartApi](#T-EASYDATACenter-ServerCoreDBSettings-ServerRestartApi 'EASYDATACenter.ServerCoreDBSettings.ServerRestartApi')
- [ServerRootApi](#T-EASYDATACenter-ServerCoreDBSettings-ServerRootApi 'EASYDATACenter.ServerCoreDBSettings.ServerRootApi')
  - [Index()](#M-EASYDATACenter-ServerCoreDBSettings-ServerRootApi-Index 'EASYDATACenter.ServerCoreDBSettings.ServerRootApi.Index')
- [ServerRuntimeData](#T-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData 'EASYDATACenter.ServerCoreDefinition.ServerRuntimeData')
  - [CentralWebSocketList](#F-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-CentralWebSocketList 'EASYDATACenter.ServerCoreDefinition.ServerRuntimeData.CentralWebSocketList')
  - [LocalDBTableList](#F-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-LocalDBTableList 'EASYDATACenter.ServerCoreDefinition.ServerRuntimeData.LocalDBTableList')
  - [ServerArgs](#F-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-ServerArgs 'EASYDATACenter.ServerCoreDefinition.ServerRuntimeData.ServerArgs')
  - [ServerCancelToken](#F-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-ServerCancelToken 'EASYDATACenter.ServerCoreDefinition.ServerRuntimeData.ServerCancelToken')
  - [ServerCoreStatus](#F-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-ServerCoreStatus 'EASYDATACenter.ServerCoreDefinition.ServerRuntimeData.ServerCoreStatus')
  - [ServerFTPProvider](#F-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-ServerFTPProvider 'EASYDATACenter.ServerCoreDefinition.ServerRuntimeData.ServerFTPProvider')
  - [ServerRestartRequest](#F-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-ServerRestartRequest 'EASYDATACenter.ServerCoreDefinition.ServerRuntimeData.ServerRestartRequest')
  - [ConfigFile](#P-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-ConfigFile 'EASYDATACenter.ServerCoreDefinition.ServerRuntimeData.ConfigFile')
  - [DataPath](#P-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-DataPath 'EASYDATACenter.ServerCoreDefinition.ServerRuntimeData.DataPath')
  - [DebugMode](#P-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-DebugMode 'EASYDATACenter.ServerCoreDefinition.ServerRuntimeData.DebugMode')
  - [Setting_folder](#P-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-Setting_folder 'EASYDATACenter.ServerCoreDefinition.ServerRuntimeData.Setting_folder')
  - [Startup_path](#P-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-Startup_path 'EASYDATACenter.ServerCoreDefinition.ServerRuntimeData.Startup_path')
- [ServerSettings](#T-EASYDATACenter-ServerCoreDefinition-ServerSettings 'EASYDATACenter.ServerCoreDefinition.ServerSettings')
  - [ConfigApiTokenTimeoutMin](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigApiTokenTimeoutMin 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ConfigApiTokenTimeoutMin')
  - [ConfigCertificateDomain](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigCertificateDomain 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ConfigCertificateDomain')
  - [ConfigCertificatePassword](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigCertificatePassword 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ConfigCertificatePassword')
  - [ConfigJwtLocalKey](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigJwtLocalKey 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ConfigJwtLocalKey')
  - [ConfigMaxWebSocketBufferSizeKb](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigMaxWebSocketBufferSizeKb 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ConfigMaxWebSocketBufferSizeKb')
  - [ConfigServerStartupOnHttps](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigServerStartupOnHttps 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ConfigServerStartupOnHttps')
  - [ConfigServerStartupPort](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigServerStartupPort 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ConfigServerStartupPort')
  - [ConfigWebSocketTimeoutMin](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigWebSocketTimeoutMin 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ConfigWebSocketTimeoutMin')
  - [DatabaseConnectionString](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-DatabaseConnectionString 'EASYDATACenter.ServerCoreDefinition.ServerSettings.DatabaseConnectionString')
  - [DatabaseInternalCacheTimeoutMin](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-DatabaseInternalCacheTimeoutMin 'EASYDATACenter.ServerCoreDefinition.ServerSettings.DatabaseInternalCacheTimeoutMin')
  - [DatabaseInternalCachingEnabled](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-DatabaseInternalCachingEnabled 'EASYDATACenter.ServerCoreDefinition.ServerSettings.DatabaseInternalCachingEnabled')
  - [EmailerSMTPLoginPassword](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerSMTPLoginPassword 'EASYDATACenter.ServerCoreDefinition.ServerSettings.EmailerSMTPLoginPassword')
  - [EmailerSMTPLoginUsername](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerSMTPLoginUsername 'EASYDATACenter.ServerCoreDefinition.ServerSettings.EmailerSMTPLoginUsername')
  - [EmailerSMTPPort](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerSMTPPort 'EASYDATACenter.ServerCoreDefinition.ServerSettings.EmailerSMTPPort')
  - [EmailerSMTPServerAddress](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerSMTPServerAddress 'EASYDATACenter.ServerCoreDefinition.ServerSettings.EmailerSMTPServerAddress')
  - [EmailerSMTPSslIsEnabled](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerSMTPSslIsEnabled 'EASYDATACenter.ServerCoreDefinition.ServerSettings.EmailerSMTPSslIsEnabled')
  - [EmailerServiceEmailAddress](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerServiceEmailAddress 'EASYDATACenter.ServerCoreDefinition.ServerSettings.EmailerServiceEmailAddress')
  - [ModuleDataManagerEnabled](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ModuleDataManagerEnabled 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ModuleDataManagerEnabled')
  - [ModuleDbDiagramGeneratorEnabled](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ModuleDbDiagramGeneratorEnabled 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ModuleDbDiagramGeneratorEnabled')
  - [ModuleHealthServiceEnabled](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ModuleHealthServiceEnabled 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ModuleHealthServiceEnabled')
  - [ModuleHealthServiceRefreshIntervalSec](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ModuleHealthServiceRefreshIntervalSec 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ModuleHealthServiceRefreshIntervalSec')
  - [ModuleMdDocumentationEnabled](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ModuleMdDocumentationEnabled 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ModuleMdDocumentationEnabled')
  - [ModuleSwaggerApiDocEnabled](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ModuleSwaggerApiDocEnabled 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ModuleSwaggerApiDocEnabled')
  - [ServerEnableWebSocketMonitor](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ServerEnableWebSocketMonitor 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ServerEnableWebSocketMonitor')
  - [ServerFtpFreeEngineEnabled](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ServerFtpFreeEngineEnabled 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ServerFtpFreeEngineEnabled')
  - [ServerFtpSecurityEnabled](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ServerFtpSecurityEnabled 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ServerFtpSecurityEnabled')
  - [ServerMvcWebPagesEngineEnabled](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ServerMvcWebPagesEngineEnabled 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ServerMvcWebPagesEngineEnabled')
  - [ServerRazorWebPagesEngineEnabled](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ServerRazorWebPagesEngineEnabled 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ServerRazorWebPagesEngineEnabled')
  - [ServerTimeTokenValidationEnabled](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ServerTimeTokenValidationEnabled 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ServerTimeTokenValidationEnabled')
  - [ServerWebBrowserEnabled](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ServerWebBrowserEnabled 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ServerWebBrowserEnabled')
  - [ServerWebSocketEngineEnabled](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ServerWebSocketEngineEnabled 'EASYDATACenter.ServerCoreDefinition.ServerSettings.ServerWebSocketEngineEnabled')
  - [SpecialCoreCheckerEmailSenderActive](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-SpecialCoreCheckerEmailSenderActive 'EASYDATACenter.ServerCoreDefinition.ServerSettings.SpecialCoreCheckerEmailSenderActive')
  - [SpecialEnableMassEmail](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-SpecialEnableMassEmail 'EASYDATACenter.ServerCoreDefinition.ServerSettings.SpecialEnableMassEmail')
  - [SpecialServerLanguage](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-SpecialServerLanguage 'EASYDATACenter.ServerCoreDefinition.ServerSettings.SpecialServerLanguage')
  - [SpecialServerServiceName](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-SpecialServerServiceName 'EASYDATACenter.ServerCoreDefinition.ServerSettings.SpecialServerServiceName')
  - [SpecialUseDbLocalAutoupdatedDials](#P-EASYDATACenter-ServerCoreDefinition-ServerSettings-SpecialUseDbLocalAutoupdatedDials 'EASYDATACenter.ServerCoreDefinition.ServerSettings.SpecialUseDbLocalAutoupdatedDials')
- [ServiceHealthCheck](#T-EASYDATACenter-ServerCoreDefinition-ServiceHealthCheck 'EASYDATACenter.ServerCoreDefinition.ServiceHealthCheck')
  - [Microsoft#Extensions#Diagnostics#HealthChecks#IHealthCheck#CheckHealthAsync(context,cancellationToken)](#M-EASYDATACenter-ServerCoreDefinition-ServiceHealthCheck-Microsoft#Extensions#Diagnostics#HealthChecks#IHealthCheck#CheckHealthAsync-Microsoft-Extensions-Diagnostics-HealthChecks-HealthCheckContext,System-Threading-CancellationToken- 'EASYDATACenter.ServerCoreDefinition.ServiceHealthCheck.Microsoft#Extensions#Diagnostics#HealthChecks#IHealthCheck#CheckHealthAsync(Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckContext,System.Threading.CancellationToken)')
- [SetReportFilter](#T-EASYDATACenter-ServerCoreDBSettings-SetReportFilter 'EASYDATACenter.ServerCoreDBSettings.SetReportFilter')
- [Startup](#T-EASYDATACenter-Startup 'EASYDATACenter.Startup')
  - [Configure(app,loggerFactory)](#M-EASYDATACenter-Startup-Configure-Microsoft-AspNetCore-Builder-IApplicationBuilder,Microsoft-Extensions-Logging-ILoggerFactory,Microsoft-Extensions-Hosting-IHostApplicationLifetime- 'EASYDATACenter.Startup.Configure(Microsoft.AspNetCore.Builder.IApplicationBuilder,Microsoft.Extensions.Logging.ILoggerFactory,Microsoft.Extensions.Hosting.IHostApplicationLifetime)')
  - [ConfigureServices(services)](#M-EASYDATACenter-Startup-ConfigureServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'EASYDATACenter.Startup.ConfigureServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [TemplateList](#T-EASYDATACenter-DBModel-TemplateList 'EASYDATACenter.DBModel.TemplateList')
- [WebSocketExtension](#T-EASYDATACenter-ServerCoreDefinition-WebSocketExtension 'EASYDATACenter.ServerCoreDefinition.WebSocketExtension')
- [WebSocketLogProvider](#T-EASYDATACenter-ServerCoreDefinition-ServerCoreHelpers-WebSocketLogProvider 'EASYDATACenter.ServerCoreDefinition.ServerCoreHelpers.WebSocketLogProvider')
- [WebSocketLogger](#T-EASYDATACenter-ServerCoreDefinition-ServerCoreHelpers-WebSocketLogger 'EASYDATACenter.ServerCoreDefinition.ServerCoreHelpers.WebSocketLogger')
  - [Log\`\`1(logLevel,eventId,state,exception,formatter)](#M-EASYDATACenter-ServerCoreDefinition-ServerCoreHelpers-WebSocketLogger-Log``1-Microsoft-Extensions-Logging-LogLevel,Microsoft-Extensions-Logging-EventId,``0,System-Exception,System-Func{``0,System-Exception,System-String}- 'EASYDATACenter.ServerCoreDefinition.ServerCoreHelpers.WebSocketLogger.Log``1(Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,``0,System.Exception,System.Func{``0,System.Exception,System.String})')

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

<a name='M-EASYDATACenter-BackendServer-RestartServer'></a>
### RestartServer() `method`

##### Summary

Server Restart Controller

##### Parameters

This method has no parameters.

<a name='M-EASYDATACenter-BackendServer-ServerStartupDbDataLoading'></a>
### ServerStartupDbDataLoading() `method`

##### Summary

Server Startup DB Data loading for minimize DB Connect TO Frequency Dials Without Changes
Example: LanguageList

##### Parameters

This method has no parameters.

<a name='M-EASYDATACenter-BackendServer-StartServer'></a>
### StartServer() `method`

##### Summary

Server Start Controller

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

<a name='T-EASYDATACenter-ServerCoreServers-HostedFtpServerMembershipProvider-CustomFtpUser'></a>
## CustomFtpUser `type`

##### Namespace

EASYDATACenter.ServerCoreServers.HostedFtpServerMembershipProvider

##### Summary

Custom FTP user implementation

<a name='M-EASYDATACenter-ServerCoreServers-HostedFtpServerMembershipProvider-CustomFtpUser-#ctor-System-String-'></a>
### #ctor(name) `constructor`

##### Summary

Initializes a new instance of the [CustomFtpUser](#T-EASYDATACenter-ServerCoreServers-HostedFtpServerMembershipProvider-CustomFtpUser 'EASYDATACenter.ServerCoreServers.HostedFtpServerMembershipProvider.CustomFtpUser') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The user name |

<a name='P-EASYDATACenter-ServerCoreServers-HostedFtpServerMembershipProvider-CustomFtpUser-Name'></a>
### Name `property`

##### Summary

*Inherit from parent.*

<a name='M-EASYDATACenter-ServerCoreServers-HostedFtpServerMembershipProvider-CustomFtpUser-IsInGroup-System-String-'></a>
### IsInGroup() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-EASYDATACenter-ServerCoreDBSettings-CustomString'></a>
## CustomString `type`

##### Namespace

EASYDATACenter.ServerCoreDBSettings

##### Summary

Custom Definition for Returning string List from Stored Procedures Name is ColumnName from
Stored Procedure Result

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

<a name='P-EASYDATACenter-ServerCoreDefinition-DBResultMessage-Status'></a>
### Status `property`

##### Summary

Gets or Sets the status.

<a name='T-EASYDATACenter-ServerCoreDBSettings-DatabaseContextExtensions'></a>
## DatabaseContextExtensions `type`

##### Namespace

EASYDATACenter.ServerCoreDBSettings

##### Summary

Database Context Extensions for All Types Procedures For Retun Data in procedure can be
Simple SELECT * XXX and you Create Same Class for returned DataSet

<a name='T-EASYDATACenter-ServerCoreDBSettings-DgmlSchemaApi'></a>
## DgmlSchemaApi `type`

##### Namespace

EASYDATACenter.ServerCoreDBSettings

##### Summary

Database Schema Diagram Controller

##### See Also

- [Microsoft.AspNetCore.Mvc.Controller](#T-Microsoft-AspNetCore-Mvc-Controller 'Microsoft.AspNetCore.Mvc.Controller')

<a name='M-EASYDATACenter-ServerCoreDBSettings-DgmlSchemaApi-#ctor-EASYDATACenter-ServerCoreDBSettings-EASYDATACenterContext-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [DgmlSchemaApi](#T-EASYDATACenter-ServerCoreDBSettings-DgmlSchemaApi 'EASYDATACenter.ServerCoreDBSettings.DgmlSchemaApi') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [EASYDATACenter.ServerCoreDBSettings.EASYDATACenterContext](#T-EASYDATACenter-ServerCoreDBSettings-EASYDATACenterContext 'EASYDATACenter.ServerCoreDBSettings.EASYDATACenterContext') | The context. |

<a name='M-EASYDATACenter-ServerCoreDBSettings-DgmlSchemaApi-Get'></a>
### Get() `method`

##### Summary

Creates a DGML class diagram of most of the entities in the project wher you go to
localhost/dgml See https://github.com/ErikEJ/SqlCeToolbox/wiki/EF-Core-Power-Tools

##### Returns

a DGML class diagram

##### Parameters

This method has no parameters.

<a name='T-EASYDATACenter-ServerCoreDBSettings-EASYDATACenterContext'></a>
## EASYDATACenterContext `type`

##### Namespace

EASYDATACenter.ServerCoreDBSettings

##### Summary

Server Main Database Settings Here is Included ScaffoldContext which is connected via Visual
Studio Tool Here can Be added customization which are not on the server Here is Extended the
Context with Insert News Functionality Customizing and implement Settings for Automatic
Adopted Database Schema for Unlimited Working and Operations For Specifics API schemas

<a name='M-EASYDATACenter-ServerCoreDBSettings-EASYDATACenterContext-GetApiUserId-Microsoft-AspNetCore-Http-HttpContext-'></a>
### GetApiUserId(httpContext) `method`

##### Summary

Return User From API Request if Exist other null

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| httpContext | [Microsoft.AspNetCore.Http.HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') |  |

<a name='M-EASYDATACenter-ServerCoreDBSettings-EASYDATACenterContext-IsAdmin-Microsoft-AspNetCore-Http-HttpContext-'></a>
### IsAdmin(httpContext) `method`

##### Summary

Return User From API Request if Exist other null

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| httpContext | [Microsoft.AspNetCore.Http.HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') |  |

<a name='T-EASYDATACenter-ControllersExtensions-GLOBALNETAuthenticationApi'></a>
## GLOBALNETAuthenticationApi `type`

##### Namespace

EASYDATACenter.ControllersExtensions

<a name='M-EASYDATACenter-ControllersExtensions-GLOBALNETAuthenticationApi-Authenticate-System-String,System-String-'></a>
### Authenticate(username,password) `method`

##### Summary

API Authenticated and Generate Token

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EASYDATACenter-ControllersExtensions-GLOBALNETAuthenticationApi-LifetimeValidator-System-Nullable{System-DateTime},System-Nullable{System-DateTime},Microsoft-IdentityModel-Tokens-SecurityToken,Microsoft-IdentityModel-Tokens-TokenValidationParameters-'></a>
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

<a name='M-EASYDATACenter-ControllersExtensions-GLOBALNETAuthenticationApi-RefreshUserToken-System-String,EASYDATACenter-ServerCoreDefinition-AuthenticateResponse-'></a>
### RefreshUserToken(username,token) `method`

##### Summary

API Refresh User Token

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| token | [EASYDATACenter.ServerCoreDefinition.AuthenticateResponse](#T-EASYDATACenter-ServerCoreDefinition-AuthenticateResponse 'EASYDATACenter.ServerCoreDefinition.AuthenticateResponse') |  |

<a name='T-EASYDATACenter-ControllersExtensions-GLOBALNETBackendCheckApi'></a>
## GLOBALNETBackendCheckApi `type`

##### Namespace

EASYDATACenter.ControllersExtensions

##### Summary

Simple Api for Checking Avaiability

##### See Also

- [Microsoft.AspNetCore.Mvc.ControllerBase](#T-Microsoft-AspNetCore-Mvc-ControllerBase 'Microsoft.AspNetCore.Mvc.ControllerBase')

<a name='M-EASYDATACenter-ControllersExtensions-GLOBALNETBackendCheckApi-GetBackendCheckApi'></a>
### GetBackendCheckApi() `method`

##### Summary

Gets the backend check API.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-EASYDATACenter-ServerCoreServers-HostedFtpServer'></a>
## HostedFtpServer `type`

##### Namespace

EASYDATACenter.ServerCoreServers

<a name='M-EASYDATACenter-ServerCoreServers-HostedFtpServer-#ctor-FubarDev-FtpServer-IFtpServerHost-'></a>
### #ctor(ftpServerHost) `constructor`

##### Summary

Initializes a new instance of the [HostedFtpServer](#T-EASYDATACenter-ServerCoreServers-HostedFtpServer 'EASYDATACenter.ServerCoreServers.HostedFtpServer') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ftpServerHost | [FubarDev.FtpServer.IFtpServerHost](#T-FubarDev-FtpServer-IFtpServerHost 'FubarDev.FtpServer.IFtpServerHost') | The FTP server host that gets wrapped as a hosted service. |

<a name='M-EASYDATACenter-ServerCoreServers-HostedFtpServer-StartAsync-System-Threading-CancellationToken-'></a>
### StartAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-EASYDATACenter-ServerCoreServers-HostedFtpServer-StopAsync-System-Threading-CancellationToken-'></a>
### StopAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-EASYDATACenter-ServerCoreServers-HostedFtpServerMembershipProvider'></a>
## HostedFtpServerMembershipProvider `type`

##### Namespace

EASYDATACenter.ServerCoreServers

##### Summary

Custom membership provider for Authentication Validation
Actual is Set by UserName and Password in Database

<a name='M-EASYDATACenter-ServerCoreServers-HostedFtpServerMembershipProvider-ValidateUser-System-String,System-String-'></a>
### ValidateUser(username,password) `method`

##### Summary

FTP User Validation
Its for Open FTP and User Validation

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The username. |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The password. |

<a name='M-EASYDATACenter-ServerCoreServers-HostedFtpServerMembershipProvider-ValidateUserAsync-System-String,System-String-'></a>
### ValidateUserAsync(username,password) `method`

##### Summary

FTP User Validation Async
Its for Open FTP and User Validation

##### Returns

The result of the validation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The user name. |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The password. |

<a name='T-EASYDATACenter-ServerCoreDBSettings-IdFilter'></a>
## IdFilter `type`

##### Namespace

EASYDATACenter.ServerCoreDBSettings

##### Summary

Custom Class Definition for Filtering by record Id

<a name='T-EASYDATACenter-ServerCoreDefinition-MailRequest'></a>
## MailRequest `type`

##### Namespace

EASYDATACenter.ServerCoreDefinition

##### Summary

Class Definition for Server Emailer
In List of this claas you can use Mass Emailer

<a name='T-EASYDATACenter-ServerCoreDBSettings-NameFilter'></a>
## NameFilter `type`

##### Namespace

EASYDATACenter.ServerCoreDBSettings

##### Summary

Custom Class Definition for Filtering by string

<a name='T-SHOPINGER-Controllers-SHOPINGERAuthenticationApi'></a>
## SHOPINGERAuthenticationApi `type`

##### Namespace

SHOPINGER.Controllers

<a name='M-SHOPINGER-Controllers-SHOPINGERAuthenticationApi-Authenticate-System-String,System-String-'></a>
### Authenticate(username,password) `method`

##### Summary

API Authenticated and Generate Token

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-SHOPINGER-Controllers-SHOPINGERAuthenticationApi-LifetimeValidator-System-Nullable{System-DateTime},System-Nullable{System-DateTime},Microsoft-IdentityModel-Tokens-SecurityToken,Microsoft-IdentityModel-Tokens-TokenValidationParameters-'></a>
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

<a name='M-SHOPINGER-Controllers-SHOPINGERAuthenticationApi-RefreshUserToken-System-String,EASYDATACenter-ServerCoreDefinition-AuthenticateResponse-'></a>
### RefreshUserToken(username,token) `method`

##### Summary

API Refresh User Token

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| token | [EASYDATACenter.ServerCoreDefinition.AuthenticateResponse](#T-EASYDATACenter-ServerCoreDefinition-AuthenticateResponse 'EASYDATACenter.ServerCoreDefinition.AuthenticateResponse') |  |

<a name='T-EASYDATACenter-ServerCoreConfiguration-ServerConfigurationServices'></a>
## ServerConfigurationServices `type`

##### Namespace

EASYDATACenter.ServerCoreConfiguration

##### Summary

Server Core Configuration Settings of Security, Communications, Technologies, Modules Rules,
Rights, Conditions, Formats, Services, Logging, etc..

<a name='M-EASYDATACenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureAuthentication-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureAuthentication(services) `method`

##### Summary

Server Core: Configure Server Authentication Support

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EASYDATACenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureControllers-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
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

<a name='M-EASYDATACenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureCookie-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureCookie(services) `method`

##### Summary

Server Core: Configure Cookie Politics

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EASYDATACenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureDatabaseContext-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureDatabaseContext(services) `method`

##### Summary

Server Core: Configure Custom Services

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EASYDATACenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureFTPServer-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureFTPServer(services) `method`

##### Summary

Custom Secure FTP Server

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') | The services. |

<a name='M-EASYDATACenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureLogging-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureLogging(services) `method`

##### Summary

Server Core: Configure Server Logging

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EASYDATACenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureScopes-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureScopes(services) `method`

##### Summary

Server Core: Configure Custom Core Services

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EASYDATACenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureServerWebPages-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureServerWebPages(services) `method`

##### Summary

Configures the MVC server pages.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') | The services. |

<a name='M-EASYDATACenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureThirdPartyApi-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureThirdPartyApi(services) `method`

##### Summary

Server Core: Configure HTTP Client for work with third party API

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EASYDATACenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureWebSocketLoggerMonitor-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureWebSocketLoggerMonitor(services) `method`

##### Summary

Server core: Configures the WebSocket logger monitor.
For multi monitoring and for Example Posibilities

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') | The services. |

<a name='T-EASYDATACenter-ServerCoreMethods-ServerCoreDbOperations'></a>
## ServerCoreDbOperations `type`

##### Namespace

EASYDATACenter.ServerCoreMethods

##### Summary

All Server Definitions of Database Operation method

<a name='M-EASYDATACenter-ServerCoreMethods-ServerCoreDbOperations-DBTranslate-System-String,System-String-'></a>
### DBTranslate(word,language) `method`

##### Summary

Default Operation for Call Translation

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| word | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| language | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EASYDATACenter-ServerCoreMethods-ServerCoreDbOperations-DBTranslateOffline-System-String,System-String-'></a>
### DBTranslateOffline(word,language) `method`

##### Summary

Database LanuageList for Off-line Using Definitions

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| word | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| language | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EASYDATACenter-ServerCoreMethods-ServerCoreDbOperations-DBTranslateOnline-System-String,System-String-'></a>
### DBTranslateOnline(word,language) `method`

##### Summary

Database LanuageList for On-line Using Definitions

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| word | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| language | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EASYDATACenter-ServerCoreMethods-ServerCoreDbOperations-LoadStaticDbDials-System-Nullable{EASYDATACenter-ServerCoreDefinition-ServerLocalDbDials}-'></a>
### LoadStaticDbDials(onlyThis) `method`

##### Summary

Method for All Server Defined Table for Local Using As Off line AutoUpdated Tables

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| onlyThis | [System.Nullable{EASYDATACenter.ServerCoreDefinition.ServerLocalDbDials}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{EASYDATACenter.ServerCoreDefinition.ServerLocalDbDials}') |  |

<a name='M-EASYDATACenter-ServerCoreMethods-ServerCoreDbOperations-WriteVisit-System-String,System-Int32,System-String-'></a>
### WriteVisit(ipAddress,userId,userName) `method`

##### Summary

Trigger User Login History

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ipAddress | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| userId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| userName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions'></a>
## ServerCoreFunctions `type`

##### Namespace

EASYDATACenter.ServerCoreMethods

<a name='M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-CheckDirectory-System-String-'></a>
### CheckDirectory(directory) `method`

##### Summary

Checks the directory.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| directory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The directory. |

<a name='M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-CheckFile-System-String-'></a>
### CheckFile(file) `method`

##### Summary

Checks the file.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file. |

<a name='M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-CopyFile-System-String,System-String-'></a>
### CopyFile(from,to) `method`

##### Summary

Copies the file.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| from | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | From. |
| to | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | To. |

<a name='M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-CreatePath-System-String-'></a>
### CreatePath(path) `method`

##### Summary

Creates the path.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The path. |

<a name='M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-FileDetectEncoding-System-String-'></a>
### FileDetectEncoding(FileName) `method`

##### Summary

Files the detect encoding.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| FileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the file. |

<a name='M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-GetSelfSignedCertificate-System-String-'></a>
### GetSelfSignedCertificate(password) `method`

##### Summary

Gets the self signed certificate For API Security HTTPS.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The password. |

<a name='M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-GetSelfSignedCertificateFromFile'></a>
### GetSelfSignedCertificateFromFile() `method`

##### Summary

Set Imported Certificate from file on Server for Https 
TODO

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-GetSystemErrMessage-System-Exception,System-Int32-'></a>
### GetSystemErrMessage(exception,msgCount) `method`

##### Summary

Mined-ed Error Message For System Save to Database For Simple Solving Problem

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') |  |
| msgCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-GetUserApiErrMessage-System-Exception,System-Int32-'></a>
### GetUserApiErrMessage(exception,msgCount) `method`

##### Summary

Mined-ed Error Message For Answer in API Error Response with detailed info about problem

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') |  |
| msgCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-LoadSettings'></a>
### LoadSettings() `method`

##### Summary

Server Local Startup Configuration Its Running as First - Load from Congig.Json After DB
connection Before Server Start Is This configuration Replaced By Data from DB And next
Server Start. Its for situation - Bad Connection Server Start with Configuration from File

##### Parameters

This method has no parameters.

<a name='M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-RandomString-System-Int32-'></a>
### RandomString(length) `method`

##### Summary

Randoms the string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length. |

<a name='M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-ReadFile-System-String-'></a>
### ReadFile(fileName) `method`

##### Summary

Reads the file.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the file. |

<a name='M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-SendEmail-EASYDATACenter-ServerCoreDefinition-MailRequest,System-Boolean-'></a>
### SendEmail(mailRequest,sendImmediately) `method`

##### Summary

System Mailer sending Emails To service email with detected fail for analyze and
corrections on the Way provide better services every time !!! This You can implement
everywhere, !!! In Debug mode is written to Console, in Release will be sent email
Empty Sender And Recipients set email for Service Recipient

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mailRequest | [EASYDATACenter.ServerCoreDefinition.MailRequest](#T-EASYDATACenter-ServerCoreDefinition-MailRequest 'EASYDATACenter.ServerCoreDefinition.MailRequest') |  |
| sendImmediately | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-SendMassEmail-System-Collections-Generic-List{EASYDATACenter-ServerCoreDefinition-MailRequest}-'></a>
### SendMassEmail(mailRequests) `method`

##### Summary

Sends the mass mail.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mailRequests | [System.Collections.Generic.List{EASYDATACenter.ServerCoreDefinition.MailRequest}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{EASYDATACenter.ServerCoreDefinition.MailRequest}') | The mail requests. |

<a name='M-EASYDATACenter-ServerCoreMethods-ServerCoreFunctions-UnicodeToUTF8-System-String-'></a>
### UnicodeToUTF8(strFrom) `method`

##### Summary

Unicodes to ut f8.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| strFrom | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string from. |

<a name='T-EASYDATACenter-ServerCoreDefinition-ServerCoreHelpers'></a>
## ServerCoreHelpers `type`

##### Namespace

EASYDATACenter.ServerCoreDefinition

##### Summary

System Helpers for EASY working
Here are extension for Database Model, WebSocket

<a name='M-EASYDATACenter-ServerCoreDefinition-ServerCoreHelpers-AddSocketConnectionToCentalList-System-Net-WebSockets-WebSocket,System-String-'></a>
### AddSocketConnectionToCentalList(newWebSocket,socketAPIPath) `method`

##### Summary

Add WeSocket Connection To Central List

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| newWebSocket | [System.Net.WebSockets.WebSocket](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.WebSockets.WebSocket 'System.Net.WebSockets.WebSocket') | The new web socket. |
| socketAPIPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The socket path. |

<a name='M-EASYDATACenter-ServerCoreDefinition-ServerCoreHelpers-BindList``1-System-Data-DataTable-'></a>
### BindList\`\`1(dt) `method`

##### Summary

Extension For Using Custom Defined Tables from Database Procedures
Its used as Database Context Extension as 'CollectionFromSql'
Method in Database Context

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dt | [System.Data.DataTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.DataTable 'System.Data.DataTable') | The dt. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-EASYDATACenter-ServerCoreDefinition-ServerCoreHelpers-DisposeSocketConnectionsWithTimeOut'></a>
### DisposeSocketConnectionsWithTimeOut() `method`

##### Summary

!! Global Method for Simple Using WebSockets
WebSocket Disposed - Cleaning monitored Sockets from Central List.
Are Closed and Disposed Only with Timeout or with closed Connection

##### Parameters

This method has no parameters.

<a name='M-EASYDATACenter-ServerCoreDefinition-ServerCoreHelpers-ListenClientWebSocketMessages-System-Net-WebSockets-WebSocket,System-String-'></a>
### ListenClientWebSocketMessages(webSocket,socketAPIPath) `method`

##### Summary

Register Listening Client WebSocket Communication
Ist for Receive messages from Client

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| webSocket | [System.Net.WebSockets.WebSocket](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.WebSockets.WebSocket 'System.Net.WebSockets.WebSocket') |  |
| socketAPIPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EASYDATACenter-ServerCoreDefinition-ServerCoreHelpers-SendMessageAndUpdateWebSocketsInSpecificPath-System-String,System-String-'></a>
### SendMessageAndUpdateWebSocketsInSpecificPath(socketAPIPath,message) `method`

##### Summary

Sends the message and update web sockets in specific path.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| socketAPIPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The socket API path. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message. |

<a name='M-EASYDATACenter-ServerCoreDefinition-ServerCoreHelpers-SendMessageToClientSocket-System-Net-WebSockets-WebSocket,System-String-'></a>
### SendMessageToClientSocket(webSocket,message) `method`

##### Summary

Sends the message to client WebSocket.
This Is Used by "SendMessageAndUpdateWebSocketsInSpecificPath"
For Update Informaions on All Connections in Same WebSocket Path
Its Solution FOR Teminals, Group Communications, etc.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| webSocket | [System.Net.WebSockets.WebSocket](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.WebSockets.WebSocket 'System.Net.WebSockets.WebSocket') | The web socket. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message. |

<a name='T-EASYDATACenter-ServerCoreDBSettings-ServerCoreLoggerWS'></a>
## ServerCoreLoggerWS `type`

##### Namespace

EASYDATACenter.ServerCoreDBSettings

##### Summary

WEBSocket Template still not used Ideal for Terminal Panels, chat, controlling services

<a name='M-EASYDATACenter-ServerCoreDBSettings-ServerCoreLoggerWS-Echo-Microsoft-AspNetCore-Http-HttpContext,System-Net-WebSockets-WebSocket-'></a>
### Echo(context,webSocket) `method`

##### Summary

WebSocket Communication Set Examle

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.AspNetCore.Http.HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') | The context. |
| webSocket | [System.Net.WebSockets.WebSocket](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.WebSockets.WebSocket 'System.Net.WebSockets.WebSocket') | The web socket. |

<a name='M-EASYDATACenter-ServerCoreDBSettings-ServerCoreLoggerWS-Get'></a>
### Get() `method`

##### Summary

WebSocket Registration Connection API Example

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EASYDATACenter-ServerCoreDBSettings-ServerCoreLoggerWS-GetBySocketAPIPath-System-String-'></a>
### GetBySocketAPIPath(id) `method`

##### Summary

Universal WebSocket API Definitions
for Connection Paths and Registering
To Server Central List ow WebSocket Connections

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-EASYDATACenter-ServerCoreDBSettings-ServerCorePagesApi'></a>
## ServerCorePagesApi `type`

##### Namespace

EASYDATACenter.ServerCoreDBSettings

##### Summary

Server Core Web Pages Controller

##### See Also

- [Microsoft.AspNetCore.Mvc.ControllerBase](#T-Microsoft-AspNetCore-Mvc-ControllerBase 'Microsoft.AspNetCore.Mvc.ControllerBase')

<a name='T-EASYDATACenter-ServerCoreDBSettings-ServerEmailerApi'></a>
## ServerEmailerApi `type`

##### Namespace

EASYDATACenter.ServerCoreDBSettings

##### Summary

Server Email sender Api for logged Communication

##### See Also

- [Microsoft.AspNetCore.Mvc.ControllerBase](#T-Microsoft-AspNetCore-Mvc-ControllerBase 'Microsoft.AspNetCore.Mvc.ControllerBase')

<a name='T-EASYDATACenter-ServerCoreConfiguration-ServerEnablingServices'></a>
## ServerEnablingServices `type`

##### Namespace

EASYDATACenter.ServerCoreConfiguration

##### Summary

Server Core Enabling Settings of Security, API Communications, Technologies, Modules,Rules,
Rights, Rules, Rights, Conditions, Cors, Cookies, Formats, Services, Logging, etc..

<a name='M-EASYDATACenter-ServerCoreConfiguration-ServerEnablingServices-EnableCors-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableCors() `method`

##### Summary

Server Cors Configuration

##### Parameters

This method has no parameters.

<a name='M-EASYDATACenter-ServerCoreConfiguration-ServerEnablingServices-EnableEndpoints-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableEndpoints() `method`

##### Summary

Server Endpoints Configuration

##### Parameters

This method has no parameters.

<a name='M-EASYDATACenter-ServerCoreConfiguration-ServerEnablingServices-EnableLogging-Microsoft-AspNetCore-Builder-IApplicationBuilder@,Microsoft-Extensions-Logging-ILoggerFactory@-'></a>
### EnableLogging(app,loggerFactory) `method`

##### Summary

Enable Server Logging in Debug Mode

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.IApplicationBuilder@](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder@ 'Microsoft.AspNetCore.Builder.IApplicationBuilder@') |  |
| loggerFactory | [Microsoft.Extensions.Logging.ILoggerFactory@](#T-Microsoft-Extensions-Logging-ILoggerFactory@ 'Microsoft.Extensions.Logging.ILoggerFactory@') |  |

<a name='M-EASYDATACenter-ServerCoreConfiguration-ServerEnablingServices-EnableWebSocket-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
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

<a name='T-EASYDATACenter-ServerCoreConfiguration-ServerModules'></a>
## ServerModules `type`

##### Namespace

EASYDATACenter.ServerCoreConfiguration

##### Summary

Configure Server Ad-dons and Modules

<a name='M-EASYDATACenter-ServerCoreConfiguration-ServerModules-ConfigureCoreAdmin-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureCoreAdmin(services) `method`

##### Summary

Server Module: Automatic DB Data Manager for work with data directly
services.AddCoreAdmin("Admin"); is Token RoleName

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EASYDATACenter-ServerCoreConfiguration-ServerModules-ConfigureDocumentation-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureDocumentation(services) `method`

##### Summary

Server Module: Generted Developer Documentation for Defvelopers Documentation contain
full Server Structure for extremelly simple developing

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EASYDATACenter-ServerCoreConfiguration-ServerModules-ConfigureHealthCheck-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureHealthCheck(services) `method`

##### Summary

Server Module: Automatic DB Data Manager for work with data directly

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EASYDATACenter-ServerCoreConfiguration-ServerModules-ConfigureSwagger-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureSwagger(services) `method`

##### Summary

Server Module: Swagger Api Doc Generator And Online Tester Configuration

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='T-EASYDATACenter-ServerCoreConfiguration-ServerModulesEnabling'></a>
## ServerModulesEnabling `type`

##### Namespace

EASYDATACenter.ServerCoreConfiguration

##### Summary

Enable Configured Server Ad-dons and Modules

<a name='M-EASYDATACenter-ServerCoreConfiguration-ServerModulesEnabling-EnableCoreAdmin-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableCoreAdmin() `method`

##### Summary

Server Module: Enable Swagger Api Doc Generator And Online Tester

##### Parameters

This method has no parameters.

<a name='M-EASYDATACenter-ServerCoreConfiguration-ServerModulesEnabling-EnableDocumentation-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableDocumentation() `method`

##### Summary

Server Module: Enable Generated Developer Documentation

##### Parameters

This method has no parameters.

<a name='M-EASYDATACenter-ServerCoreConfiguration-ServerModulesEnabling-EnableSwagger-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableSwagger() `method`

##### Summary

Server Module: Enable Swagger Api Doc Generator And Online Tester

##### Parameters

This method has no parameters.

<a name='T-EASYDATACenter-ServerCoreDBSettings-ServerRestartApi'></a>
## ServerRestartApi `type`

##### Namespace

EASYDATACenter.ServerCoreDBSettings

##### Summary

Server Restart Api for Remote Control

##### See Also

- [Microsoft.AspNetCore.Mvc.ControllerBase](#T-Microsoft-AspNetCore-Mvc-ControllerBase 'Microsoft.AspNetCore.Mvc.ControllerBase')

<a name='T-EASYDATACenter-ServerCoreDBSettings-ServerRootApi'></a>
## ServerRootApi `type`

##### Namespace

EASYDATACenter.ServerCoreDBSettings

##### Summary

Server Root Controller

##### See Also

- [Microsoft.AspNetCore.Mvc.ControllerBase](#T-Microsoft-AspNetCore-Mvc-ControllerBase 'Microsoft.AspNetCore.Mvc.ControllerBase')

<a name='M-EASYDATACenter-ServerCoreDBSettings-ServerRootApi-Index'></a>
### Index() `method`

##### Summary

Server Root "/" Redirection to "server" Folder

##### Returns



##### Parameters

This method has no parameters.

<a name='T-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData'></a>
## ServerRuntimeData `type`

##### Namespace

EASYDATACenter.ServerCoreDefinition

##### Summary

The server runtime data.

<a name='F-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-CentralWebSocketList'></a>
### CentralWebSocketList `constants`

##### Summary

Central WebSocket List for Easy one place Using

<a name='F-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-LocalDBTableList'></a>
### LocalDBTableList `constants`

##### Summary

The local db table list.

<a name='F-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-ServerArgs'></a>
### ServerArgs `constants`

##### Summary

Server Starup Args

<a name='F-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-ServerCancelToken'></a>
### ServerCancelToken `constants`

##### Summary

Cancellation Token for Server Remote Control

<a name='F-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-ServerCoreStatus'></a>
### ServerCoreStatus `constants`

##### Summary

Server Core Status

<a name='F-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-ServerFTPProvider'></a>
### ServerFTPProvider `constants`

##### Summary

Server Securited FTP Provider for Remote Control

<a name='F-EASYDATACenter-ServerCoreDefinition-ServerRuntimeData-ServerRestartRequest'></a>
### ServerRestartRequest `constants`

##### Summary

Server Restart Request Indicator

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

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigApiTokenTimeoutMin'></a>
### ConfigApiTokenTimeoutMin `property`

##### Summary

Bearer Token Timeout Setting in Minutes. Connection must be Refreshed in Interval After
Timeout connection Must Login Again. It is as needed. You Can Change Key for close All
connections Immediately. Timeout is good for Webpages
Recomended: 15

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigCertificateDomain'></a>
### ConfigCertificateDomain `property`

##### Summary

Its Domain for include to Automatic Generated Certificate For Server running on HTTPS.
Domain is for Your validation Certificate Domain. Can be Changed for commercial.
Recommended: 127.0.0.1

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigCertificatePassword'></a>
### ConfigCertificatePassword `property`

##### Summary

Password will be inserted to Server Generated Certificate for HTTPS.
Recommended: empty = Maximal Security Randomly generated 20 chars string

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigJwtLocalKey'></a>
### ConfigJwtLocalKey `property`

##### Summary

Special Functions:Server AutoGenerated encryption Key For Securing Communication On Each
Server Restart All Tokens not will be valid and the Login Reconnect is Requested. Its
AntiHacker Security Rule
Recommended: empty = Maximal Security Randomly generated 40 chars string

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigMaxWebSocketBufferSizeKb'></a>
### ConfigMaxWebSocketBufferSizeKb `property`

##### Summary

Maximum socket message size for control Traffic
Recomended: 10

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigServerStartupOnHttps'></a>
### ConfigServerStartupOnHttps `property`

##### Summary

Setting for Server URL Services. Logically can run only one Http or Https Server has
more Security Setting Politics.
Recommended: true

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigServerStartupPort'></a>
### ConfigServerStartupPort `property`

##### Summary

Set Server Startup Port on Http/HttpS/WebSocket and for All Engines, Modules, API
Controler and WebPages
Recommended: 5000

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ConfigWebSocketTimeoutMin'></a>
### ConfigWebSocketTimeoutMin `property`

##### Summary

WebSocket Timeout Connection Settings in Minutes. After timeout when not detected any
communication socket is closed Set according to your need
Recommended: 2

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-DatabaseConnectionString'></a>
### DatabaseConnectionString `property`

##### Summary

Server Database Connection string for Full Service of Database
Migration/Api/Check/Unlimited Develop !!!Warning: Check this connection for
Read/Write/Exec is enabled

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-DatabaseInternalCacheTimeoutMin'></a>
### DatabaseInternalCacheTimeoutMin `property`

##### Summary

Time in Minutes for Database Valid Cache Data and Refreshing Duplicit Functionality with
Database Server
Recommended: 30

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-DatabaseInternalCachingEnabled'></a>
### DatabaseInternalCachingEnabled `property`

##### Summary

Enable Disable Entity Framework Internal Cache I recommend turning it off : from Logic,
Duplicit Functionality with Database Server in complex process can generate problems
Recommended: false

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerSMTPLoginPassword'></a>
### EmailerSMTPLoginPassword `property`

##### Summary

SMTP Password for Login to External Mail Server Its Necessary for Correct running Server
Internal Core Monitoring

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerSMTPLoginUsername'></a>
### EmailerSMTPLoginUsername `property`

##### Summary

SMTP UserName for Login to External Mail Server Its Necessary for Correct running Server
Internal Core Monitoring

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerSMTPPort'></a>
### EmailerSMTPPort `property`

##### Summary

SMTP Port for Login to External Mail Server Its Necessary for Correct running Server
Internal Core Monitoring

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerSMTPServerAddress'></a>
### EmailerSMTPServerAddress `property`

##### Summary

SMTP Server Address for Login to External Mail Server Its Necessary for Correct running
Server Internal Core Monitoring

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerSMTPSslIsEnabled'></a>
### EmailerSMTPSslIsEnabled `property`

##### Summary

EmailerSMTPSslIsEnabled SSl Email Protocol for Login to External Mail Server Its
Necessary for Correct running Server Internal Core Monitoring

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-EmailerServiceEmailAddress'></a>
### EmailerServiceEmailAddress `property`

##### Summary

Service email, for info about not available service from HeatchCheck Can be used for
next Develop, automatic checking problems, missing data and all other Its Necessary for
Correct running Server Internal Core Monitoring

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ModuleDataManagerEnabled'></a>
### ModuleDataManagerEnabled `property`

##### Summary

Special Function: AutoGenerated Database DataManager for working with Data Running only
in Debug mode for simple Develop, can be modified. All changes are Reflected after
restart server

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ModuleDbDiagramGeneratorEnabled'></a>
### ModuleDbDiagramGeneratorEnabled `property`

##### Summary

Enable Automatic Database Diagram for Simple show Database structure with All bingings

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ModuleHealthServiceEnabled'></a>
### ModuleHealthServiceEnabled `property`

##### Summary

Special Function: More than 200 Server Statuses Can be monitored by HeathCheckService,
Over Net can Control Other Company Services Also as Central Control Point With Email
Service. For Example: Server/Memory/All DB Types/IP/HDD/Port/Api/NET/Cloud/Environment
Must be run for Metrics AddOn https://learn.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/monitor-app-health

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ModuleHealthServiceRefreshIntervalSec'></a>
### ModuleHealthServiceRefreshIntervalSec `property`

##### Summary

Special Function: More than 200 Server Statuses Can be monitored by HeathCheckService,
Over Net can Control Other Company Services Also as Central Control Point With Email
Service. For Example: Server/Memory/All DB Types/IP/HDD/Port/Api/NET/Cloud/Environment
Must be run for Metrics AddOn !!! run in Release mode for Good Reading of Logs without
HeathChecks Cycling info https://github.com/Xabaril/AspNetCore.Diagnostics.HealthChecks https://testfully.io/blog/api-health-check-monitoring/

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ModuleMdDocumentationEnabled'></a>
### ModuleMdDocumentationEnabled `property`

##### Summary

Enable Server Structure Documentation for Developers Using RootPath, - Block File
Browsing Is Good for Server with Documentation only Or Use for Show WebPage and Copy
"Only HTML"

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ModuleSwaggerApiDocEnabled'></a>
### ModuleSwaggerApiDocEnabled `property`

##### Summary

Special Function: Server Automatically Generate Full Documentation of API structure AND
Database Model. Plus Included API Interface for Online Testing All API Methods with
Authentication Its Automatic Solution for Third Party cooperation. All changes are
Reflected after restart server

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ServerEnableWebSocketMonitor'></a>
### ServerEnableWebSocketMonitor `property`

##### Summary

Server support online multi watch Logging
Its Run on Websocket and the Log Messages are
sent for All opened connections for wathing
on Path: ServerCoreMonitor
You can enable Mass Email Api

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ServerFtpFreeEngineEnabled'></a>
### ServerFtpFreeEngineEnabled `property`

##### Summary

Enable FTP File Server oppened for every connection with full rights

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ServerFtpSecurityEnabled'></a>
### ServerFtpSecurityEnabled `property`

##### Summary

Enable FTP Security
For access to FTP must be logged

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ServerMvcWebPagesEngineEnabled'></a>
### ServerMvcWebPagesEngineEnabled `property`

##### Summary

Enable Mvc WebPages support engine with Correct Configuration

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ServerRazorWebPagesEngineEnabled'></a>
### ServerRazorWebPagesEngineEnabled `property`

##### Summary

Enable Razor WebPages support engine with Correct Configuration for Automaping form
folder 'Pages'

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ServerTimeTokenValidationEnabled'></a>
### ServerTimeTokenValidationEnabled `property`

##### Summary

Enable Disable Bearer Token Timeout Validation Token can be valid EveryTime to using:
Example for machine connection Or is Control last activity

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ServerWebBrowserEnabled'></a>
### ServerWebBrowserEnabled `property`

##### Summary

Enable WebPages File Browsing from server Url on Server

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-ServerWebSocketEngineEnabled'></a>
### ServerWebSocketEngineEnabled `property`

##### Summary

Enable WebSocket Engine with Default Example Api Controller

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-SpecialCoreCheckerEmailSenderActive'></a>
### SpecialCoreCheckerEmailSenderActive `property`

##### Summary

Activation / Deactivation of Email Sender For Server Core Fails Checker All Catch Write
to SendEmail, In Debug mode is Written in console in Release mode is Sended email (All
incorrect server statuses are monitored) Can be writen to Database - !!! Warning for
infinite Cycling (DB shutdown example)
Recommended: true

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-SpecialEnableMassEmail'></a>
### SpecialEnableMassEmail `property`

##### Summary

Server support mass emailing as Service
You can enable Mass Email Api

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-SpecialServerLanguage'></a>
### SpecialServerLanguage `property`

##### Summary

Server Language for Translating Server internal statuses
Recommended: cz or en - other languages are not implemented

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-SpecialServerServiceName'></a>
### SpecialServerServiceName `property`

##### Summary

Server Service Name automatic figured in All IS/OS/Engines info
Recommended: EASYDATACenter

<a name='P-EASYDATACenter-ServerCoreDefinition-ServerSettings-SpecialUseDbLocalAutoupdatedDials'></a>
### SpecialUseDbLocalAutoupdatedDials `property`

##### Summary

Special Function: Using Selected Tables with AutoRefresh On change as Local DataSets,
For Optimize Traffic. For Example LanguageList - Static table with often reading
Recommended: true - functionality must be implemented in Server Code

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

<a name='T-EASYDATACenter-ServerCoreDBSettings-SetReportFilter'></a>
## SetReportFilter `type`

##### Namespace

EASYDATACenter.ServerCoreDBSettings

##### Summary

Database Model Extension Definitions Its API Filter, Extended Classes, Translation, etc

<a name='T-EASYDATACenter-Startup'></a>
## Startup `type`

##### Namespace

EASYDATACenter

##### Summary

Server Startup Definitions

<a name='M-EASYDATACenter-Startup-Configure-Microsoft-AspNetCore-Builder-IApplicationBuilder,Microsoft-Extensions-Logging-ILoggerFactory,Microsoft-Extensions-Hosting-IHostApplicationLifetime-'></a>
### Configure(app,loggerFactory) `method`

##### Summary

Server Core: Main Enabling of Server Services, Technologies, Modules, etc..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder') |  |
| loggerFactory | [Microsoft.Extensions.Logging.ILoggerFactory](#T-Microsoft-Extensions-Logging-ILoggerFactory 'Microsoft.Extensions.Logging.ILoggerFactory') |  |

<a name='M-EASYDATACenter-Startup-ConfigureServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### ConfigureServices(services) `method`

##### Summary

Server Core: Main Configure of Server Services, Technologies, Modules, etc..

##### Returns

void.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

<a name='T-EASYDATACenter-DBModel-TemplateList'></a>
## TemplateList `type`

##### Namespace

EASYDATACenter.DBModel

##### Summary

Template System Class, This Class has all DBLogic auto Fields and user join for simple
creating system Only Rename for your new table

<a name='T-EASYDATACenter-ServerCoreDefinition-WebSocketExtension'></a>
## WebSocketExtension `type`

##### Namespace

EASYDATACenter.ServerCoreDefinition

##### Summary

WebSocket Extension Definition For 
Simple Central Control All Connection
By Connection Path and Timeout

<a name='T-EASYDATACenter-ServerCoreDefinition-ServerCoreHelpers-WebSocketLogProvider'></a>
## WebSocketLogProvider `type`

##### Namespace

EASYDATACenter.ServerCoreDefinition.ServerCoreHelpers

##### Summary

!!! Implemented
Server Core WebSocket System LogProvider Stream
This Is Special Serice For Remote Monitoring
On More Devices in OneTime

##### See Also

- [Microsoft.Extensions.Logging.ILoggerProvider](#T-Microsoft-Extensions-Logging-ILoggerProvider 'Microsoft.Extensions.Logging.ILoggerProvider')

<a name='T-EASYDATACenter-ServerCoreDefinition-ServerCoreHelpers-WebSocketLogger'></a>
## WebSocketLogger `type`

##### Namespace

EASYDATACenter.ServerCoreDefinition.ServerCoreHelpers

##### Summary

Server Core WebSocket System Logger Interface

##### See Also

- [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger')

<a name='M-EASYDATACenter-ServerCoreDefinition-ServerCoreHelpers-WebSocketLogger-Log``1-Microsoft-Extensions-Logging-LogLevel,Microsoft-Extensions-Logging-EventId,``0,System-Exception,System-Func{``0,System-Exception,System-String}-'></a>
### Log\`\`1(logLevel,eventId,state,exception,formatter) `method`

##### Summary

Used to log the entry.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logLevel | [Microsoft.Extensions.Logging.LogLevel](#T-Microsoft-Extensions-Logging-LogLevel 'Microsoft.Extensions.Logging.LogLevel') | An instance of [LogLevel](#T-Microsoft-Extensions-Logging-LogLevel 'Microsoft.Extensions.Logging.LogLevel'). |
| eventId | [Microsoft.Extensions.Logging.EventId](#T-Microsoft-Extensions-Logging-EventId 'Microsoft.Extensions.Logging.EventId') | The event's ID. An instance of [EventId](#T-Microsoft-Extensions-Logging-EventId 'Microsoft.Extensions.Logging.EventId'). |
| state | [\`\`0](#T-``0 '``0') | The event's state. |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The event's exception. An instance of [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') |
| formatter | [System.Func{\`\`0,System.Exception,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Exception,System.String}') | A delegate that formats |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TState |  |
