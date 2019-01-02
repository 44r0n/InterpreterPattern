namespace InterpreterPattern
{
    public class VariableExpression : BooleanExpression
    {
        private readonly string name;
        public VariableExpression(string name)
        {
            this.name = string.Copy(name);
        }

        public string Name => name;

        public BooleanExpression Copy()
        {
            return new VariableExpression(name);
        }

        public bool Evaluate(Context context)
        {
            return context.Loockup(name);
        }

        public BooleanExpression Replace(string name, BooleanExpression expression)
        {
            if(name.Equals(this.name))
            {
                return expression.Copy();
            }
            else
            {
                return Copy();
            }
        }
    }
}