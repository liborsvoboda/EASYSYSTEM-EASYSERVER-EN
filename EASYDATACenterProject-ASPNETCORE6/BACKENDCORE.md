<a name='assembly'></a>
# BACKENDCORE

## Contents

- [GLOBALNETTemplateListApi](#T-GLOBALNET-Controllers-GLOBALNETTemplateListApi 'GLOBALNET.Controllers.GLOBALNETTemplateListApi')
  - [DeleteTemplateList(id)](#M-GLOBALNET-Controllers-GLOBALNETTemplateListApi-DeleteTemplateList-System-String- 'GLOBALNET.Controllers.GLOBALNETTemplateListApi.DeleteTemplateList(System.String)')
  - [GetTemplateList()](#M-GLOBALNET-Controllers-GLOBALNETTemplateListApi-GetTemplateList 'GLOBALNET.Controllers.GLOBALNETTemplateListApi.GetTemplateList')
  - [GetTemplateListByFilter(filter)](#M-GLOBALNET-Controllers-GLOBALNETTemplateListApi-GetTemplateListByFilter-System-String- 'GLOBALNET.Controllers.GLOBALNETTemplateListApi.GetTemplateListByFilter(System.String)')
  - [GetTemplateListKey(id)](#M-GLOBALNET-Controllers-GLOBALNETTemplateListApi-GetTemplateListKey-System-Int32- 'GLOBALNET.Controllers.GLOBALNETTemplateListApi.GetTemplateListKey(System.Int32)')
  - [InsertTemplateList(record)](#M-GLOBALNET-Controllers-GLOBALNETTemplateListApi-InsertTemplateList-GLOBALNET-DBModel-TemplateList- 'GLOBALNET.Controllers.GLOBALNETTemplateListApi.InsertTemplateList(GLOBALNET.DBModel.TemplateList)')
  - [UpdateTemplateList(record)](#M-GLOBALNET-Controllers-GLOBALNETTemplateListApi-UpdateTemplateList-GLOBALNET-DBModel-TemplateList- 'GLOBALNET.Controllers.GLOBALNETTemplateListApi.UpdateTemplateList(GLOBALNET.DBModel.TemplateList)')
- [Program](#T-BACKENDCORE-Program 'BACKENDCORE.Program')
  - [BackendServiceName](#F-BACKENDCORE-Program-BackendServiceName 'BACKENDCORE.Program.BackendServiceName')
  - [ConfigFile](#F-BACKENDCORE-Program-ConfigFile 'BACKENDCORE.Program.ConfigFile')
  - [DebugMode](#F-BACKENDCORE-Program-DebugMode 'BACKENDCORE.Program.DebugMode')
  - [Startup_path](#F-BACKENDCORE-Program-Startup_path 'BACKENDCORE.Program.Startup_path')
  - [ServerSettings](#P-BACKENDCORE-Program-ServerSettings 'BACKENDCORE.Program.ServerSettings')
- [ServerCoreConfiguration](#T-BACKENDCORE-ServerCoreConfiguration 'BACKENDCORE.ServerCoreConfiguration')
  - [ConfigureAuthentication(services)](#M-BACKENDCORE-ServerCoreConfiguration-ConfigureAuthentication-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'BACKENDCORE.ServerCoreConfiguration.ConfigureAuthentication(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureControllers(services)](#M-BACKENDCORE-ServerCoreConfiguration-ConfigureControllers-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'BACKENDCORE.ServerCoreConfiguration.ConfigureControllers(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureCookie(services)](#M-BACKENDCORE-ServerCoreConfiguration-ConfigureCookie-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'BACKENDCORE.ServerCoreConfiguration.ConfigureCookie(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureDatabaseContext(services)](#M-BACKENDCORE-ServerCoreConfiguration-ConfigureDatabaseContext-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'BACKENDCORE.ServerCoreConfiguration.ConfigureDatabaseContext(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureLogging(services)](#M-BACKENDCORE-ServerCoreConfiguration-ConfigureLogging-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'BACKENDCORE.ServerCoreConfiguration.ConfigureLogging(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureScopes(services)](#M-BACKENDCORE-ServerCoreConfiguration-ConfigureScopes-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'BACKENDCORE.ServerCoreConfiguration.ConfigureScopes(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureThirdPartyApi(services)](#M-BACKENDCORE-ServerCoreConfiguration-ConfigureThirdPartyApi-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'BACKENDCORE.ServerCoreConfiguration.ConfigureThirdPartyApi(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
- [ServerEnablingServices](#T-BACKENDCORE-ServerEnablingServices 'BACKENDCORE.ServerEnablingServices')
  - [EnableCors(services)](#M-BACKENDCORE-ServerEnablingServices-EnableCors-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'BACKENDCORE.ServerEnablingServices.EnableCors(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
  - [EnableEndpoints(services)](#M-BACKENDCORE-ServerEnablingServices-EnableEndpoints-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'BACKENDCORE.ServerEnablingServices.EnableEndpoints(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
  - [EnableLogging(app)](#M-BACKENDCORE-ServerEnablingServices-EnableLogging-Microsoft-AspNetCore-Builder-IApplicationBuilder@,Microsoft-Extensions-Logging-ILoggerFactory@- 'BACKENDCORE.ServerEnablingServices.EnableLogging(Microsoft.AspNetCore.Builder.IApplicationBuilder@,Microsoft.Extensions.Logging.ILoggerFactory@)')
  - [EnableWebSocket(app)](#M-BACKENDCORE-ServerEnablingServices-EnableWebSocket-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'BACKENDCORE.ServerEnablingServices.EnableWebSocket(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
- [ServerModulesConfiguration](#T-BACKENDCORE-ServerModulesConfiguration 'BACKENDCORE.ServerModulesConfiguration')
  - [ConfigureCoreAdmin(services)](#M-BACKENDCORE-ServerModulesConfiguration-ConfigureCoreAdmin-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'BACKENDCORE.ServerModulesConfiguration.ConfigureCoreAdmin(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureHealthCheck(services)](#M-BACKENDCORE-ServerModulesConfiguration-ConfigureHealthCheck-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'BACKENDCORE.ServerModulesConfiguration.ConfigureHealthCheck(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureSwagger(services)](#M-BACKENDCORE-ServerModulesConfiguration-ConfigureSwagger-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'BACKENDCORE.ServerModulesConfiguration.ConfigureSwagger(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
- [ServerModulesEnabling](#T-BACKENDCORE-ServerModulesEnabling 'BACKENDCORE.ServerModulesEnabling')
  - [EnableCoreAdmin(services)](#M-BACKENDCORE-ServerModulesEnabling-EnableCoreAdmin-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'BACKENDCORE.ServerModulesEnabling.EnableCoreAdmin(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
  - [EnableSwagger(services)](#M-BACKENDCORE-ServerModulesEnabling-EnableSwagger-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'BACKENDCORE.ServerModulesEnabling.EnableSwagger(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
- [Startup](#T-BACKENDCORE-Startup 'BACKENDCORE.Startup')
  - [Configure(app,loggerFactory)](#M-BACKENDCORE-Startup-Configure-Microsoft-AspNetCore-Builder-IApplicationBuilder,Microsoft-Extensions-Logging-ILoggerFactory- 'BACKENDCORE.Startup.Configure(Microsoft.AspNetCore.Builder.IApplicationBuilder,Microsoft.Extensions.Logging.ILoggerFactory)')
  - [ConfigureServices(app,loggerFactory)](#M-BACKENDCORE-Startup-ConfigureServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'BACKENDCORE.Startup.ConfigureServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')

<a name='T-GLOBALNET-Controllers-GLOBALNETTemplateListApi'></a>
## GLOBALNETTemplateListApi `type`

##### Namespace

GLOBALNET.Controllers

##### Summary

Universal Template For Make Any Full Backend Server
One Template Has All data operation Controls for simple copy and build ANY Backend Server

<a name='M-GLOBALNET-Controllers-GLOBALNETTemplateListApi-DeleteTemplateList-System-String-'></a>
### DeleteTemplateList(id) `method`

##### Summary

Operation: Delete record by unique Id key
Standart API for delete existing record in DB table

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GLOBALNET-Controllers-GLOBALNETTemplateListApi-GetTemplateList'></a>
### GetTemplateList() `method`

##### Summary

Operation: Select All records
Standart API for return all records from DB table

##### Returns



##### Parameters

This method has no parameters.

<a name='M-GLOBALNET-Controllers-GLOBALNETTemplateListApi-GetTemplateListByFilter-System-String-'></a>
### GetTemplateListByFilter(filter) `method`

##### Summary

Operation: Select By sent SQL Where Condition
Standart API for return records by Where condition in Query from DB table

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GLOBALNET-Controllers-GLOBALNETTemplateListApi-GetTemplateListKey-System-Int32-'></a>
### GetTemplateListKey(id) `method`

##### Summary

Operation: Select Unique record
Standart API for return one record by primary Id key from DB table

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-GLOBALNET-Controllers-GLOBALNETTemplateListApi-InsertTemplateList-GLOBALNET-DBModel-TemplateList-'></a>
### InsertTemplateList(record) `method`

##### Summary

Operation: Insert new record
Standart API for insert new record to DB table

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| record | [GLOBALNET.DBModel.TemplateList](#T-GLOBALNET-DBModel-TemplateList 'GLOBALNET.DBModel.TemplateList') |  |

<a name='M-GLOBALNET-Controllers-GLOBALNETTemplateListApi-UpdateTemplateList-GLOBALNET-DBModel-TemplateList-'></a>
### UpdateTemplateList(record) `method`

##### Summary

Operation: Update record by unique Id key
Standart API for update existing record in DB table

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| record | [GLOBALNET.DBModel.TemplateList](#T-GLOBALNET-DBModel-TemplateList 'GLOBALNET.DBModel.TemplateList') |  |

<a name='T-BACKENDCORE-Program'></a>
## Program `type`

##### Namespace

BACKENDCORE

<a name='F-BACKENDCORE-Program-BackendServiceName'></a>
### BackendServiceName `constants`

##### Summary

Server Core: Registered Service Name

<a name='F-BACKENDCORE-Program-ConfigFile'></a>
### ConfigFile `constants`

##### Summary

Server Core: Server Configuration File

<a name='F-BACKENDCORE-Program-DebugMode'></a>
### DebugMode `constants`

##### Summary

Server Core: Startup Mode

<a name='F-BACKENDCORE-Program-Startup_path'></a>
### Startup_path `constants`

##### Summary

Server Core: Server Startup Path

<a name='P-BACKENDCORE-Program-ServerSettings'></a>
### ServerSettings `property`

##### Summary

Server Core: Loaded Server Configuration First File, After connect to DB are rewritten by DB Data

<a name='T-BACKENDCORE-ServerCoreConfiguration'></a>
## ServerCoreConfiguration `type`

##### Namespace

BACKENDCORE

##### Summary

Server Core: Configuration Server Net Communications, Core Technologies, Security, Cache, Etc..

<a name='M-BACKENDCORE-ServerCoreConfiguration-ConfigureAuthentication-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureAuthentication(services) `method`

##### Summary

Server Core: Configure Server Authentication Support

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-BACKENDCORE-ServerCoreConfiguration-ConfigureControllers-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureControllers(services) `method`

##### Summary

Server Core: Configure Server Controllers
options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = [ValidateNever] in Class
options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore = [JsonIgnore] in Class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-BACKENDCORE-ServerCoreConfiguration-ConfigureCookie-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureCookie(services) `method`

##### Summary

Server Core: Configure Cookie Politics

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-BACKENDCORE-ServerCoreConfiguration-ConfigureDatabaseContext-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureDatabaseContext(services) `method`

##### Summary

Server Core: Configure Custom Services

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-BACKENDCORE-ServerCoreConfiguration-ConfigureLogging-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureLogging(services) `method`

##### Summary

Server Core: Configure Server Logging

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-BACKENDCORE-ServerCoreConfiguration-ConfigureScopes-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureScopes(services) `method`

##### Summary

Server Core: Configure Custom Core Services

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-BACKENDCORE-ServerCoreConfiguration-ConfigureThirdPartyApi-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureThirdPartyApi(services) `method`

##### Summary

Server Core: Configure HTTP Client for work with third party API

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='T-BACKENDCORE-ServerEnablingServices'></a>
## ServerEnablingServices `type`

##### Namespace

BACKENDCORE

##### Summary

Server configuration services, modules, Politics, etc.

<a name='M-BACKENDCORE-ServerEnablingServices-EnableCors-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableCors(services) `method`

##### Summary

Server Cors Configuration

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.AspNetCore.Builder.IApplicationBuilder@](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder@ 'Microsoft.AspNetCore.Builder.IApplicationBuilder@') |  |

<a name='M-BACKENDCORE-ServerEnablingServices-EnableEndpoints-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableEndpoints(services) `method`

##### Summary

Server Endpoints Configuration

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.AspNetCore.Builder.IApplicationBuilder@](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder@ 'Microsoft.AspNetCore.Builder.IApplicationBuilder@') |  |

<a name='M-BACKENDCORE-ServerEnablingServices-EnableLogging-Microsoft-AspNetCore-Builder-IApplicationBuilder@,Microsoft-Extensions-Logging-ILoggerFactory@-'></a>
### EnableLogging(app) `method`

##### Summary

Enable Server Logging in Debug Mode

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.IApplicationBuilder@](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder@ 'Microsoft.AspNetCore.Builder.IApplicationBuilder@') |  |

<a name='M-BACKENDCORE-ServerEnablingServices-EnableWebSocket-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableWebSocket(app) `method`

##### Summary

Server WebSocket Configuration

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.IApplicationBuilder@](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder@ 'Microsoft.AspNetCore.Builder.IApplicationBuilder@') |  |

<a name='T-BACKENDCORE-ServerModulesConfiguration'></a>
## ServerModulesConfiguration `type`

##### Namespace

BACKENDCORE

##### Summary

Configure Server Addons and Modules

<a name='M-BACKENDCORE-ServerModulesConfiguration-ConfigureCoreAdmin-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureCoreAdmin(services) `method`

##### Summary

Server Module: Automatic DB Data Manager for work with data directly
services.AddCoreAdmin("Admin"); is Token Rolename

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-BACKENDCORE-ServerModulesConfiguration-ConfigureHealthCheck-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureHealthCheck(services) `method`

##### Summary

Server Module: Automatic DB Data Manager for work with data directly

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-BACKENDCORE-ServerModulesConfiguration-ConfigureSwagger-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureSwagger(services) `method`

##### Summary

Server Module: Swagger Api Doc Generator And Online Tester Configuration

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='T-BACKENDCORE-ServerModulesEnabling'></a>
## ServerModulesEnabling `type`

##### Namespace

BACKENDCORE

##### Summary

Enable Configured Server Addons and Modules

<a name='M-BACKENDCORE-ServerModulesEnabling-EnableCoreAdmin-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableCoreAdmin(services) `method`

##### Summary

Server Module: Enable Swagger Api Doc Generator And Online Tester

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.AspNetCore.Builder.IApplicationBuilder@](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder@ 'Microsoft.AspNetCore.Builder.IApplicationBuilder@') |  |

<a name='M-BACKENDCORE-ServerModulesEnabling-EnableSwagger-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableSwagger(services) `method`

##### Summary

Server Module: Enable Swagger Api Doc Generator And Online Tester

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.AspNetCore.Builder.IApplicationBuilder@](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder@ 'Microsoft.AspNetCore.Builder.IApplicationBuilder@') |  |

<a name='T-BACKENDCORE-Startup'></a>
## Startup `type`

##### Namespace

BACKENDCORE

<a name='M-BACKENDCORE-Startup-Configure-Microsoft-AspNetCore-Builder-IApplicationBuilder,Microsoft-Extensions-Logging-ILoggerFactory-'></a>
### Configure(app,loggerFactory) `method`

##### Summary

Server Core: Main Enabling of Server Services, Technologies, Modules, etc..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder') |  |
| loggerFactory | [Microsoft.Extensions.Logging.ILoggerFactory](#T-Microsoft-Extensions-Logging-ILoggerFactory 'Microsoft.Extensions.Logging.ILoggerFactory') |  |

<a name='M-BACKENDCORE-Startup-ConfigureServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### ConfigureServices(app,loggerFactory) `method`

##### Summary

Server Core: Main Configure of Server Services, Technologies, Modules, etc..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |
