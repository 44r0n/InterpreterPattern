using System;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definition of boolean expression: (true and x) or (y and (not x))
            BooleanExpression expression;
            Context context = new Context();
            VariableExpression x = new VariableExpression("x");
            VariableExpression y = new VariableExpression("y");
            expression = new OrExpression(
                new AndExpression(new Constant(true), x),
                new AndExpression(y,new NotExpression(x))
            );
            context.Assign(x,false);
            context.Assign(y,true);

            bool result = expression.Evaluate(context); //result must be true
            Console.WriteLine(result);
        }
    }
}
