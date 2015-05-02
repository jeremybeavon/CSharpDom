using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal sealed class LocalVariables
    {
        private readonly Stack<IDictionary<string, ParameterExpression>> localVariables;

        public LocalVariables()
        {
            localVariables = new Stack<IDictionary<string, ParameterExpression>>();
            localVariables.Push(new Dictionary<string, ParameterExpression>());
        }

        public IEnumerable<ParameterExpression> CurrentLocalVariables
        {
            get { return localVariables.Peek().Values; }
        }

        public void AddLocalVariable(string name, ParameterExpression parameter)
        {
            localVariables.Peek().Add(name, parameter);
        }

        public ParameterExpression GetLocalVariable(string name)
        {
            return localVariables.Select(variables => GetParameter(variables, name)).First(parameter => parameter != null);
        }

        public void StartBlock()
        {
            localVariables.Push(new Dictionary<string, ParameterExpression>());
        }

        public void EndBlock()
        {
            localVariables.Pop();
        }

        private static ParameterExpression GetParameter(IDictionary<string, ParameterExpression> variables, string name)
        {
            ParameterExpression parameter;
            variables.TryGetValue(name, out parameter);
            return parameter;
        }
    }
}
