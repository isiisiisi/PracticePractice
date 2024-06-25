using System;
using System.Data;
using System.Text;

namespace PracticePractice
{
    public static class ExpressionEvaluator
    {
        public static double Evaluate(string expression)
        {
            try
            {
                expression = FixParentheses(expression);
                var result = new DataTable().Compute(expression, null);
                return Convert.ToDouble(result);
            }
            catch (FormatException)
            {
                throw new ArgumentException("Invalid format in expression");
            }
            catch (InvalidExpressionException)
            {
                throw new ArgumentException("Invalid expression");
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error evaluating expression", ex);
            }
        }

        private static string FixParentheses(string expression)
        {
            StringBuilder fixedExpression = new StringBuilder();

            for (int i = 0; i < expression.Length; i++)
            {
                char currentChar = expression[i];
                fixedExpression.Append(currentChar);

                if (i + 1 < expression.Length)
                {
                    char nextChar = expression[i + 1];
                    if ((currentChar == ')' && (Char.IsDigit(nextChar) || nextChar == '(')) ||
                        (Char.IsDigit(currentChar) && nextChar == '('))
                    {
                        fixedExpression.Append('*'); 
                    }
                }
            }

            return fixedExpression.ToString();
        }
    }
}