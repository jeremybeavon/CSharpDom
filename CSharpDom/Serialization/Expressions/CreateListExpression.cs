using CSharpDom.Common.Expressions;
using System.ComponentModel;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class CreateListExpression : ICreateListExpression
    {
        [DefaultValue(null)]
        public NewAnonymousArrayExpression NewAnonymousArrayExpression { get; set; }

        [DefaultValue(null)]
        public NewArrayExpression NewArrayExpression { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            if (NewAnonymousArrayExpression != null)
            {
                NewAnonymousArrayExpression.Accept(visitor);
            }
            else if (NewArrayExpression != null)
            {
                NewArrayExpression.Accept(visitor);
            }
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            if (NewAnonymousArrayExpression != null)
            {
                NewAnonymousArrayExpression.AcceptChildren(visitor);
            }
            else if (NewArrayExpression != null)
            {
                NewArrayExpression.AcceptChildren(visitor);
            }
        }
    }
}
