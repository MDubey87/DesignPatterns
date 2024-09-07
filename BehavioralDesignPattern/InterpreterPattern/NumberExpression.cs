namespace InterpreterPattern
{
    /// <summary>
    /// Terminal Expression
    /// </summary>
    public class NumberExpression : Expression
    {
        private int _number;

        public NumberExpression(int number)
        {
            _number = number;
        }

        public override int Interpret()
        {
            return _number;
        }
    }
}
