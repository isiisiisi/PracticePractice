using System;
using System.Collections.Generic;
using System.Globalization;

public class Class1
{
    public double Evaluate(string expression)
    {
        expression = FixImplicitMultiplication(expression);

        var values = new Stack<double>();
        var operators = new Stack<char>();
        int i = 0;

        while (i < expression.Length)
        {
            if (char.IsWhiteSpace(expression[i]))
            {
                i++;
                continue;
            }

            if (char.IsDigit(expression[i]) || expression[i] == '.')
            {
                string value = "";
                while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == '.'))
                {
                    value += expression[i];
                    i++;
                }
                values.Push(double.Parse(value, CultureInfo.InvariantCulture));
            }
            else if (expression[i] == '(')
            {
                operators.Push(expression[i]);
                i++;
            }
            else if (expression[i] == ')')
            {
                while (operators.Count > 0 && operators.Peek() != '(')
                {
                    double b = values.Pop();
                    double a = values.Pop();
                    char op = operators.Pop();
                    values.Push(ApplyOperation(a, b, op));
                }
                operators.Pop(); 
                i++;
            }
            else if (IsOperator(expression[i]))
            {
                while (operators.Count > 0 && ShouldApplyOperator(expression[i], operators.Peek()))
                {
                    double b = values.Pop();
                    double a = values.Pop();
                    char op = operators.Pop();
                    values.Push(ApplyOperation(a, b, op));
                }
                operators.Push(expression[i]);
                i++;
            }
            else
            {
                throw new ArgumentException("Invalid character in expression");
            }
        }

        while (operators.Count > 0)
        {
            double b = values.Pop();
            double a = values.Pop();
            char op = operators.Pop();
            values.Push(ApplyOperation(a, b, op));
        }

        return values.Pop();
    }

    private bool IsOperator(char c)
    {
        return c == '+' || c == '-' || c == '*' || c == '/';
    }

    private bool ShouldApplyOperator(char newOp, char existingOp)
    {
        int precedenceNew = GetPrecedence(newOp);
        int precedenceExisting = GetPrecedence(existingOp);

        return precedenceNew <= precedenceExisting;
    }

    private int GetPrecedence(char op)
    {
        switch (op)
        {
            case '+':
            case '-':
                return 1;
            case '*':
            case '/':
                return 2;
            default:
                return 0;
        }
    }

    private double ApplyOperation(double a, double b, char op)
    {
        switch (op)
        {
            case '+': return a + b;
            case '-': return a - b;
            case '*': return a * b;
            case '/': return a / b;
            default: throw new ArgumentException("Invalid operator");
        }
    }

    private string FixImplicitMultiplication(string expression)
    {
        string pattern = @"(\d+)(\()";
        string replacement = @"$1*$2";

        return System.Text.RegularExpressions.Regex.Replace(expression, pattern, replacement);
    }
}