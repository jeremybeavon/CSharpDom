using CSharpDom.Common;
using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableArgument<TExpression> : EditableExpression, IEditableArgument<TExpression>
        where TExpression : IEditableExpression
    {
        public abstract TExpression Expression { get; set; }

        public abstract string Name { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitArgument(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitArgument(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitArgumentChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
