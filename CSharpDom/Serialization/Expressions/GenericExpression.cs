using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class GenericExpression : IGenericExpression
    {
        [DefaultValue(null)]
        public Expression Expression { get; set; }

        [DefaultValue(null)]
        public GenericMemberExpression GenericMemberExpression { get; set; }
        
        private IEnumerable<IGenericExpression> Expressions
        {
            get
            {
                yield return Expression;
                yield return GenericMemberExpression;
            }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            IGenericExpression expression = Expressions.FirstOrDefault(current => current != null);
            if (expression != null)
            {
                expression.Accept(visitor);
            }
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            IGenericExpression expression = Expressions.FirstOrDefault(current => current != null);
            if (expression != null)
            {
                expression.AcceptChildren(visitor);
            }
        }
    }
}
