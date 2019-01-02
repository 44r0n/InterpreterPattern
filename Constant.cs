namespace InterpreterPattern
{
    public class Constant : BooleanExpression
    {
        private readonly bool value;
        public Constant(bool value)
        {
            this.value = value;
        }
        public bool Evaluate(Context context)
        {
            return value;
        }

        public BooleanExpression Replace(string name, BooleanExpression expression)
        {
            return this;
        }

        public BooleanExpression Copy()
        {
            return new Constant(value);
        }

        
    }
}