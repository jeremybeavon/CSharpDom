using System.Collections.Generic;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public sealed class ForStatement
    {
        public IEnumerable<ParameterExpression> DeclaredVariables { get; set; }

        public IEnumerable<Expression> Initializers { get; set; }

        public Expression Condition { get; set; }

        public IEnumerable<Expression> Incrementors { get; set; }

        public Expression Body { get; set; }

        public LabelTarget BreakTarget { get; set; }

        public LabelTarget ContinueTarget { get; set; }
    }
}
