using Grpc.Core;
using GRPC.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace GRPC.Server.Services
{
    public class DimAccountServices : DimAccount.DimAccountBase
    {
        private readonly AdventureWorksDw2019Context _context;

        public DimAccountServices(AdventureWorksDw2019Context context)
        {
            _context = context;
        }
        public override Task<GetAllDimAccountResponce> ListAllDimAccount(
            GetAllDimAccountRequest all, ServerCallContext context)
        {

            var result = new GetAllDimAccountResponce();

            foreach (var dimAccount in _context.DimAccounts)
            {
                result.AllDim.Add(new DimAccountResponce()
                {
                    AccountKey = dimAccount.AccountKey,
                    AccountDescription = dimAccount.AccountDescription
                });
            }

            return Task.FromResult(result);
        }




        //public override async Task StreamingFromServer(ExampleRequest request,
        //    IServerStreamWriter<ExampleResponse> responseStream, ServerCallContext context)
        //{
        //    for (var i = 0; i < 5; i++)
        //    {
        //        await responseStream.WriteAsync(new ExampleResponse());
        //        await Task.Delay(TimeSpan.FromSeconds(1));
        //    }
        //}
    }
}