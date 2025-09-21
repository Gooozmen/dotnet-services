using SoapApi.DataModel;
using SoapApi.ServiceContract;

namespace  SoapApi.Services;

public class CalculatorService : ICalculatorService
{
    public Task<decimal> Add(decimal a, decimal b)
    {
        var calc = new Calculation
        {
            Operation = "Add",
            Operand1 = a,
            Operand2 = b,
            Result = a + b
        };
        return Task.FromResult(calc.Result);
    }

    public Task<decimal> Subtract(decimal a, decimal b)
    {
        var calc = new Calculation
        {
            Operation = "Subtract",
            Operand1 = a,
            Operand2 = b,
            Result = a - b
        };
        
        return Task.FromResult(calc.Result);
    }
}
