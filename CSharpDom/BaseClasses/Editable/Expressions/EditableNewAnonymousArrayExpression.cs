using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableNewAnonymousArrayExpression : AbstractExpression, INewAnonymousArrayExpression
    {
        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNewAnonymousArrayExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
