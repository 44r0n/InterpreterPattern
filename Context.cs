using System.Collections.Generic;

namespace InterpreterPattern
{    
    public class Context
    {
        private Dictionary<string,bool> dictionary;
        public Context()
        {
            dictionary = new Dictionary<string, bool>();
        }
        public bool Loockup(string name)
        {
            if(!dictionary.ContainsKey(name))
                throw new KeyNotFoundException(nameof(name));
            return dictionary[name];
        }

        public void Assign(VariableExpression expression, bool value) => dictionary.Add(expression.Name,value);
    }
}