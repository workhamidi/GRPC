
using Grpc.Net.Client;


// option csharp_namespace = "GRPC.Client";
using GRPC.Client;


// server initialization
await Task.Delay(5000);

var message = new GetAllDimAccountRequest();


// grpc server address
var channel = GrpcChannel.ForAddress("https://localhost:7171");

var client = new DimAccount.DimAccountClient(channel);

var serverResponse = await client.ListAllDimAccountAsync(message);

Console.WriteLine(serverResponse.AllDim);

Console.WriteLine("Press any key to exit...");

Console.ReadKey();


