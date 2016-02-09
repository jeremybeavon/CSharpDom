using CSharpDom.Common.Expressions;
using System.ComponentModel;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class CreateObjectExpression : ICreateObjectExpression
    {
        [DefaultValue(null)]
        public NewAnonymousTypeExpression NewAnonymousTypeExpression { get; set; }

        [DefaultValue(null)]
        public NewExpression NewExpression { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            if (NewAnonymousTypeExpression != null)
            {
                NewAnonymousTypeExpression.Accept(visitor);
            }
            else if (NewExpression != null)
            {
                NewExpression.Accept(visitor);
            }
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            if (NewAnonymousTypeExpression != null)
            {
                NewAnonymousTypeExpression.AcceptChildren(visitor);
            }
            else if (NewExpression != null)
            {
                NewExpression.AcceptChildren(visitor);
            }
        }
    }
}
