# This file only used when you have published webapplication into single publish folder. after that you have to caopy this docker file into publish folder and run docker build -t app:v1 . 
FROM microsoft/aspnet:4.7.2-windowsservercore-1803
MAINTAINER pramodlawate
ARG source
WORKDIR /inetpub/wwwroot
COPY . /inetpub/wwwroot
