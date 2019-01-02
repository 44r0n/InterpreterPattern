namespace InterpreterPattern
{
    public interface BooleanExpression
    {
        bool Evaluate(Context context);
        BooleanExpression Replace(string name, BooleanExpression expression);
        BooleanExpression Copy();
    }
}