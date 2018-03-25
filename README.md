## Executing test 
- build -t dockerproxycore .
- docker run -t -p 8080:80 dockerproxycore & dotnet test DockerProxyCore.Test
