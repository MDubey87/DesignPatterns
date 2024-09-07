namespace InterpreterPattern
{
    /// <summary>
    /// Context
    /// </summary>
    public class Context
    {
        private Dictionary<string, int> _variables;

        public Context()
        {
            _variables = new Dictionary<string, int>();
        }

        public int GetVariable(string name)
        {
            return _variables[name];
        }

        public void SetVariable(string name, int value)
        {
            _variables[name] = value;
        }
    }
}
