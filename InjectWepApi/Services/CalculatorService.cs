using InjectWebApi.Interfaces;

namespace InjectWebApi.Services
{
  public class CalculatorService : ICalculator{

       // Implements the Add method
        public decimal Add(decimal left, decimal right)
        {
            return left + right;
        }

        // Implements the Subtract method
        public decimal Subtract(decimal left, decimal right)
        {
            return left - right;
        }

        // Implements the Multiply method
        public decimal Multiply(decimal left, decimal right)
        {
            return left * right;
        }

        // Implements the Divide method
        public decimal Divide(decimal left, decimal right)
        {
            // To avoid division by zero, return 0 or handle as needed
            if (right == 0)
                throw new DivideByZeroException("Division by zero is not allowed.");
            return left / right;
        }
  }
}