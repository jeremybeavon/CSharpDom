using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableNewAnonymousTypeExpression : AbstractExpression, INewAnonymousTypeExpression
    {
        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNewAnonymousTypeExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
