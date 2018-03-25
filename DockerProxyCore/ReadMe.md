## Running test
Open command prompt
>dotnet restore
>dotnet build
>docker-compose  -f "docker-compose.yml" -f "docker-compose.override.yml" -f "obj\Docker\docker-compose.vs.debug.g.yml" -p dockercompose2301271651637787459 --no-ansi up -d --no-build --force-recreate --remove-orphans
>dotnet test DockerProxyCore.Test