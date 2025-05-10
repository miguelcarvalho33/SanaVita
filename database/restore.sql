RESTORE DATABASE SanaVita
FROM DISK = '/var/opt/mssql/backup/SanaVita.bak'
WITH MOVE 'SanaVita' TO '/var/opt/mssql/data/SanaVita.mdf',
     MOVE 'SanaVita_log' TO '/var/opt/mssql/data/SanaVita_log.ldf',
     REPLACE;
