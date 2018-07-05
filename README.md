# DockerApp



--https://hub.docker.com/r/microsoft/mssql-server-windows-express
--Pull the image from docker repository
docker pull microsoft/mssql-server-windows-express

--Run sql server instance more help 
docker run -d -p 1433:1433 -e sa_password=Password123 -e ACCEPT_EULA=Y microsoft/mssql-server-windows-express

--get running container 
docker ps 

--get container details
docker inspect <containerid>


Run sql script which is added in solution folder name : e2edbscrip.sql