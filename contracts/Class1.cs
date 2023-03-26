using Grpc.Core;
using Mycontracts;

namespace contracts;
public class Class1 : Contractor.ContractorBase
{
    public Class1()
    {
        
    }
    public override Task<HelloReply> SayHelloCont(HelloRequest request, ServerCallContext context)
    {
        return base.SayHelloCont(request, context);
    }
}
