using Mach8.TestACC.Core.Abstractions;
using Mach8.TestACC.Core.Entities;
using Mach8.TestACC.Core.Exceptions;
using Mach8.TestACC.Core.ValueObjects;

namespace Mach8.TestACC.Core.Services;

public class OperationService : IOperationService
{
    private readonly IList<ResponseModel> _result;

    public OperationService() 
        => _result = new List<ResponseModel>();

    public IList<ResponseModel> Validate(Operation parameter)
    {
        if (parameter.Numbers.Count == 0)
            return _result;

        ValidateParameters(parameter);

        int numberToValidate = parameter.Numbers[0];
        ValidateSumsInListOfNumbers(parameter, numberToValidate);

        parameter.Numbers.Remove(numberToValidate);
        Validate(parameter);

        return _result;
    }

    private void ValidateParameters(Operation parameter)
    {
        if (parameter.ValueToFind == 0)
            throw new ValidationException("The ValueToFind parameter cannot be zero or null.");
    }

    private void ValidateSumsInListOfNumbers(Operation parameter, int numberToValidate)
    {
        foreach (var number in parameter.Numbers.Where(x => x != numberToValidate))
        {
            if (number + numberToValidate == parameter.ValueToFind)
            {
                _result.Add(new ResponseModel
                {
                    Value1 = numberToValidate,
                    Value2 = number
                });
                RemoveItemsFromNumberList(parameter, numberToValidate, number);
                break;
            }
        }
    }

    private void RemoveItemsFromNumberList(Operation parameter, int numberToValidate, int number)
    {
        parameter.Numbers.Remove(numberToValidate);
        parameter.Numbers.Remove(number);
    }
}
