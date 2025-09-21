using CoreWCF;

namespace  SoapApi.ServiceContract;

[ServiceContract]
public interface ICalculatorService
{
    [OperationContract]
    Task<decimal> Add(decimal a, decimal b);

    [OperationContract]
    Task<decimal> Subtract(decimal a, decimal b);
}
