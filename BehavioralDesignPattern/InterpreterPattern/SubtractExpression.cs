namespace InterpreterPattern
{
    /// <summary>
    /// Non-Terminal Expression
    /// </summary>
    public class SubtractExpression : Expression
    {
        private Expression _leftExpression;
        private Expression _rightExpression;

        public SubtractExpression(Expression leftExpression, Expression rightExpression)
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        public override int Interpret()
        {
            return _leftExpression.Interpret() - _rightExpression.Interpret();
        }
    }
}
