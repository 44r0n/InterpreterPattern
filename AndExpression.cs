namespace InterpreterPattern
{
    public class AndExpression : BooleanExpression
    {
        private readonly BooleanExpression operand1;
        private readonly BooleanExpression operand2;
        public AndExpression(BooleanExpression op1, BooleanExpression op2)
        {
            operand1 = op1;
            operand2 = op2;
        }
        public bool Evaluate(Context context)
        {
            return operand1.Evaluate(context) && operand2.Evaluate(context);
        }

        public BooleanExpression Replace(string name, BooleanExpression expression)
        {
            return new AndExpression(operand1.Replace(name,expression),operand2.Replace(name,expression));
        }

        public BooleanExpression Copy()
        {
            return new AndExpression(operand1.Copy(), operand2.Copy());
        }

        
    }
}