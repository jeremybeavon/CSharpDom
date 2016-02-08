using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class Expression : IExpression
    {
        [DefaultValue(null)]
        public DefaultExpression DefaultExpression { get; set; }

        private IEnumerable<IExpression> Expressions
        {
            get
            {
                yield return DefaultExpression;
            }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            IExpression expressions = Expressions.FirstOrDefault(current => current != null);
            if (expressions != null)
            {
                expressions.Accept(visitor);
            }
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            IExpression expressions = Expressions.FirstOrDefault(current => current != null);
            if (expressions != null)
            {
                expressions.AcceptChildren(visitor);
            }
        }
    }
}
