REM sqlcmd -U username -P password -S .\SQLEXPRESS -d GLOBALNET -Q "EXEC DB_BACKUP"
sqlcmd -U username -P password -S .\SQLEXPRESS -d LICENSESRV -Q "EXEC DB_BACKUP"
sqlcmd -U username -P password -S .\SQLEXPRESS -d PRUVODKY -Q "EXEC DB_BACKUP"
sqlcmd -U username -P password -S .\SQLEXPRESS -d SHOPINGER -Q "EXEC DB_BACKUP"
sqlcmd -U username -P password -S .\SQLEXPRESS -d LICENSESHOPER -Q "EXEC DB_BACKUP"
sqlcmd -U username -P password -S .\SQLEXPRESS -d EASYBUILDER -Q "EXEC DB_BACKUP"
