namespace rest_with_asp_net_9.Utils
{
    public class NumberHelper
    {
        public static decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(
                                strNumber,
                                System.Globalization.NumberStyles.Any,
                                System.Globalization.NumberFormatInfo.InvariantInfo,
                                out decimalValue
                                ))
            {
                return decimalValue;
            }

            throw new ArgumentException("Invalid input number");
        }

        public static bool IsNumeric(string strNumber)
        {

            decimal decimalValue;
            bool isNumber = decimal.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out decimalValue
                );
            return isNumber;
        }
    }
}
