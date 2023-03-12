# **DATABASES on Modern way - finally**
One Command and One Database in Project, never less - its my new Idea


### Possible DB Technologies for immediately using by start click only


### ALL MAIN DATABASE TYPES IN EASYDATACenter by EF6 (entity framework) are supported
    ORACLE
    MSSQL
    MYSQL
    POSTGRESQL
    SQLITE
    DB2
    etc
    
### SHARED PROJECT FILES
   [MSSQL EASYBuilder Full System Core Database](https://github.com/liborsvoboda/EASYSYSTEM-EASYSERVER-EN/raw/main/DatabasesKnowledge/MSSQL_EASYBuilderDBModel%26DefaultData.sql "")  
[MSSQL EASYBuilder DB installation script](https://github.com/liborsvoboda/EASYSYSTEM-EASYSERVER-EN/raw/main/DatabasesKnowledge/MSSQL_EASYBuilderDB_UploadDBscript.sql "")

---
### MSSQL ENGINE HELP COMMANDS AND TYPES
```bash
#Run stored procedure for Backup Database via MSSQL user login
sqlcmd -U ,username -P password -S .\SQLEXPRESS -d DatabaseName -Q "EXEC DB_BACKUP"
```

```bash
#Run stored procedure for Backup Database via Windows Login
sqlcmd -S .\SQLEXPRESS -d DatabaseName -Q "EXEC DB_BACKUP"
```

```bash
#Recovery Database via MSSQL user Login and set Right for Database by running stored procedure 'DB_SETRIGHTS
sqlcmd -U username -P password -S .\SQLEXPRESS -Q "ALTER DATABASE [LICENSESRV] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;RESTORE DATABASE [LICENSESRV] FROM DISK = N'C:\Database\DEFAULT_DATABASES\LICENSESRV.bak' WITH MOVE N'LICENSESRV' TO N'C:\Database\LICENSESRV.mdf',  MOVE N'LICENSESRV_log' TO N'C:\Database\LICENSESRV_log.ldf', FILE = 2,RECOVERY,  REPLACE,  STATS = 10;ALTER DATABASE [LICENSESRV] SET MULTI_USER;"

sqlcmd -U username -P password -S .\SQLEXPRESS -d LICENSESRV -Q "EXEC DB_SETRIGHTS"
```
    

---

### MYSQL ENGINE HELP COMMANDS AND TYPES






