using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableNewAnonymousArrayExpression : INewAnonymousArrayExpression
    {
        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNewAnonymousArrayExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
