## Executing test 
- Open commandline 
> c:\\netcoredockerproxy

- Build docker container
> docker build -t dockerproxycore .
- Start application 
> docker run -t -p 8080:80 dockerproxycore 
- Get running container id
> docker ps
- Get container's IP
> docker inspect -f '{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' [container ID]
- Modify "BaseApiAddress" IP from appsettings.json within DockerProxyCore.Test with container's IP 
- Run tests
> dotnet test DockerProxyCore.Test 
