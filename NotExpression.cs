namespace InterpreterPattern
{
    public class NotExpression : BooleanExpression
    {
        private readonly BooleanExpression operand;
        public NotExpression(BooleanExpression op)
        {
            operand = op;
        }
        public bool Evaluate(Context context)
        {
            return !operand.Evaluate(context);
        }

        public BooleanExpression Replace(string name, BooleanExpression expression)
        {
            return new NotExpression(operand.Replace(name,expression));
        }

        public BooleanExpression Copy()
        {
            return new NotExpression(operand.Copy());
        }

        
    }
}