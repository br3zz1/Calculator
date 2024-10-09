using NCalc;

namespace CalculatorWeb.Services
{
    public class CalculationService : ICalculationService
    {

        public string Evaluate(string expression)
        {
            if(string.IsNullOrEmpty(expression))
            {
                return "";
            }

            try
            {
                // NCalc doesn't support ',' as decimal separator
                var cleanExpression = expression.Replace(',', '.');

                var ncalcExpression = new Expression(cleanExpression);
                var result = ncalcExpression.Evaluate();
                return result.ToString() ?? "";
            }
            catch(Exception e)
            {
                return "Error";
            }
        }

    }
}
