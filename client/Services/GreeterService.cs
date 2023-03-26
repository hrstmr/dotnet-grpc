using Grpc.Core;

namespace client.Services;
public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;
    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        return Task.FromResult(new HelloReply
        {
            Message = "Hello " + request.Name
        });
    }
}

//public class ContractorService : Contractor.GreeterBase
//{
//    private readonly ILogger<ContractorService> _logger;
//    public ContractorService(ILogger<ContractorService> logger)
//    {
//        _logger = logger;
//    }

//    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
//    {
//        return Task.FromResult(new HelloReply
//        {
//            Message = "Hello " + request.Name
//        });
//    }
//}
