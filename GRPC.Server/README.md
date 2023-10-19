
server config:

1. install "Grpc.AspNetCore"


2. add "builder.Services.AddGrpc();" to di



(3.0) scaffold microsoft AdventureWorks sample databases
https://learn.microsoft.com/en-us/sql/samples/adventureworks-install-configure?view=sql-server-ver16

3. create "DimAccount.proto" file in "Protos" directory

set proto file build action to "proto compiler" and grpc stub classes to "server only"
right click on proto file and go to properties for do this (visual studio)

4. create Services file for implement all services like "DimAccountServices.cs"

5. add "DimAccountServices" to app pipeline
'''
app.MapGrpcService<DimAccountServices>();
'''



6. Build the project for add the configuration below to the .csproj file

  <ItemGroup>
    <Protobuf Include="Protos\DimAccount.proto" GrpcServices="Server" />
  </ItemGroup>

