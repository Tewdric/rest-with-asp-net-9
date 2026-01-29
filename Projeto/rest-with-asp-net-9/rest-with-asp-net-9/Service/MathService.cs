using rest_with_asp_net_9.Utils;
namespace rest_with_asp_net_9.Service
{
    public class MathService
    {
        public decimal Sum(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var sub = NumberHelper.ConvertToDecimal(firstNumber) + NumberHelper.ConvertToDecimal(secondNumber);
                return sub;
            }

            throw new ArgumentException("Invalid input number");

        }

        public decimal Subtration(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var sub = NumberHelper.ConvertToDecimal(firstNumber) - NumberHelper.ConvertToDecimal(secondNumber);
                return sub;
            }

            throw new ArgumentException("Invalid input number");
        }

        public decimal Multiplication(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var multiplication = NumberHelper.ConvertToDecimal(firstNumber) * NumberHelper.ConvertToDecimal(secondNumber);
                return multiplication;
            }

            throw new ArgumentException("Invalid input number");
        }

        public decimal Division(string firstNumber, string secondNumber)
        {
            if (!NumberHelper.IsNumeric(firstNumber) || !NumberHelper.IsNumeric(secondNumber))
            {
                throw new ArgumentException("Invalid input number");
            }

            decimal dividendo = NumberHelper.ConvertToDecimal(firstNumber);
            decimal divisor = NumberHelper.ConvertToDecimal(secondNumber);

            if (divisor == 0)
            {
                throw new DivideByZeroException("Cannot calculate division with zero!");
            }

            decimal resultado = dividendo / divisor;

            return (resultado);
        }

        public decimal Mean(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var mean = (NumberHelper.ConvertToDecimal(firstNumber) + NumberHelper.ConvertToDecimal(secondNumber)) / 2;
                return mean;
            }

            throw new ArgumentException("Invalid input number");
        }

        public double SquareRoot(string firstNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber))
            {
                var mean = Math.Sqrt((double)NumberHelper.ConvertToDecimal(firstNumber));
                if (mean < 0)
                {
                    throw new ArgumentOutOfRangeException("Cannot calculate the square root a negative number!");
                }
                return mean;
            }

            throw new ArgumentException("Invalid input number");
        }

    }
}
