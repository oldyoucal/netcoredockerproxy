## Executing test 
- Open commandline 
> c:\\netcoredockerproxy

- Build docker container
> build -t dockerproxycore .
- Start application and execute tests
> docker run -t -p 8080:80 dockerproxycore & dotnet test DockerProxyCore.Test
