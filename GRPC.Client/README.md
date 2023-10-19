
client config:

1. install 
Install-Package Grpc.Net.Client
Install-Package Google.Protobuf
Install-Package Grpc.Tools



2. create "DimAccount.proto" file in "Protos" directory

set proto file build action to "proto compiler" and grpc stub classes to "client only"
right click on proto file and go to properties for do this (visual studio)


3. Build the project for add the configuration below to the .csproj file

  <ItemGroup>
    <Protobuf Include="Protos\DimAccount.proto" GrpcServices="Client" />
  </ItemGroup>





