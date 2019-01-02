namespace InterpreterPattern
{
    public class OrExpression : BooleanExpression
    {
        private readonly BooleanExpression operand1;
        private readonly BooleanExpression operand2;
        public OrExpression(BooleanExpression op1, BooleanExpression op2)
        {
            operand1 = op1;
            operand2 = op2;
        }
        public bool Evaluate(Context context)
        {
            return operand1.Evaluate(context) || operand2.Evaluate(context);
        }

        public BooleanExpression Replace(string name, BooleanExpression expression)
        {
            return new OrExpression(operand1.Replace(name,expression),operand2.Replace(name,expression));
        }

        public BooleanExpression Copy()
        {
            return new OrExpression(operand1.Copy(), operand2.Copy());
        }

        
    }
}