using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class Expression : IExpression
    {
        [DefaultValue(null)]
        public AnonymousMethodExpression AnonymousMethodExpression { get; set; }

        [DefaultValue(null)]
        public ArrayIndexExpression ArrayIndexExpression { get; set; }

        [DefaultValue(null)]
        public AwaitExpression AwaitExpression { get; set; }

        [DefaultValue(null)]
        public BinaryOperatorExpression BinaryOperatorExpression { get; set; }

        [DefaultValue(null)]
        public CastExpression CastExpression { get; set; }

        [DefaultValue(null)]
        public DefaultExpression DefaultExpression { get; set; }

        [DefaultValue(null)]
        public DoubleConstantExpression DoubleConstantExpression { get; set; }

        [DefaultValue(null)]
        public IdentifierExpression IdentifierExpression { get; set; }

        private IEnumerable<IExpression> Expressions
        {
            get
            {
                yield return AnonymousMethodExpression;
                yield return ArrayIndexExpression;
                yield return AwaitExpression;
                yield return BinaryOperatorExpression;
                yield return CastExpression;
                yield return DefaultExpression;
                yield return DoubleConstantExpression;
                yield return IdentifierExpression;
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
