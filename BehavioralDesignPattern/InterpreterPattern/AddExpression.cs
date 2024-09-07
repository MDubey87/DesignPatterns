namespace InterpreterPattern
{
    /// <summary>
    /// Non-Terminal Expression
    /// </summary>
    public class AddExpression : Expression
    {
        private Expression _leftExpression;
        private Expression _rightExpression;

        public AddExpression(Expression leftExpression, Expression rightExpression)
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        public override int Interpret()
        {
            return _leftExpression.Interpret() + _rightExpression.Interpret();
        }
    }
}
