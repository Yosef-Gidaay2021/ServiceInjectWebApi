
namespace InjectWebApi.Interfaces{

    public interface ICalculator
    {
        // Method for adding two numbers
        decimal Add(decimal left, decimal right);
        
        // Method for subtracting the second number from the first
        decimal Subtract(decimal left, decimal right);
        
        // Method for multiplying two numbers
        decimal Multiply(decimal left, decimal right);
        
        // Method for dividing the first number by the second
        decimal Divide(decimal left, decimal right);
    }
}
 

