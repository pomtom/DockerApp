# DockerApp



--https://hub.docker.com/r/microsoft/mssql-server-windows-express
--Pull the image from docker repository
docker pull microsoft/mssql-server-windows-express

--Run sql server instance more help 
docker run -d -p 1433:1433 -e sa_password=Password123 -e ACCEPT_EULA=Y microsoft/mssql-server-windows-express

--get docker images as local env
docker images

--remove docker image from local
docker rmi <imageid>


--get running container 
docker ps 

--get running and not running container
docker ps -a

--get container details
docker inspect <containerid>

--delete container from local env
docker rm <containerid>

--stop running container
docker stop <containerid> --force


-- start running container
docker start <containerid> 
  
  --Copy file from Host machine to container instance 
  
  docker cp c:\abc.doc <5c89d188636 acontainer id>:C:\inetpub\wwwroot\abc.doc
  
  
  
  
Run sql script which is added in solution folder name : e2edbscrip.sql
