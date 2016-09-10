using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableNewAnonymousTypeExpression : INewAnonymousTypeExpression
    {
        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNewAnonymousTypeExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
