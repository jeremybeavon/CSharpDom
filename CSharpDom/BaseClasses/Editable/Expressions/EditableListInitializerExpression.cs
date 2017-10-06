using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Linq;
using CSharpDom.BaseClasses.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableListInitializerExpression<TCreateListExpression, TExpression> :
        AbstractExpression,
        IListInitializerExpression<TCreateListExpression, TExpression>
        where TCreateListExpression : ICreateListExpression
        where TExpression : IExpression
    {
        public abstract TCreateListExpression CreateListExpression { get; set; }

        public abstract IList<IList<TExpression>> InitialValues { get; set; }

        IReadOnlyList<IReadOnlyList<TExpression>> IListInitializerExpression<TCreateListExpression, TExpression>.InitialValues
        {
            get
            {
                return new ReadOnlyCollection<IReadOnlyList<TExpression>>(
                    InitialValues.Select(value => (IReadOnlyList<TExpression>)new ReadOnlyCollection<TExpression>(value)).ToList());
            }
        }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitListInitializerExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitListInitializerExpressionChildren(this, visitor);
        }
    }
}
