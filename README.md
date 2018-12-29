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
 docker cp D:\Web.config 08b941ef6754:C:\inetpub\wwwroot\Web.config
  
  --copy from docker container to Host machine.
  docker cp 08b941ef6754:C:\inetpub\wwwroot\Web.config D:\Web.config
   
  
Run sql script which is added in solution folder name : e2edbscrip.sql
