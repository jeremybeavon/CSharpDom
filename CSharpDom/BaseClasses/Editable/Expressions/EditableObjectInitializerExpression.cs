using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableObjectInitializerExpression<TCreateObjectExpression, TExpression, TObjectInitializer> :
        EditableExpression,
        IEditableObjectInitializerExpression<TCreateObjectExpression, TExpression, TObjectInitializer>
        where TCreateObjectExpression : IEditableCreateObjectExpression
        where TExpression : IEditableExpression
        where TObjectInitializer : IHasEditableObjectInitializers<TExpression, TObjectInitializer>
    {
        public abstract TCreateObjectExpression CreateObjectExpression { get; set; }

        public abstract IList<IList<TExpression>> Elements { get; set; }

        public abstract IDictionary<string, TObjectInitializer> Initializers { get; set; }

        public abstract IDictionary<string, TExpression> Members { get; set; }

        IReadOnlyList<IReadOnlyList<TExpression>> IHasObjectInitializers<TExpression, TObjectInitializer>.Elements
        {
            get
            {
                return new ReadOnlyCollection<IReadOnlyList<TExpression>>(
                    Elements.Select(element => (IReadOnlyList<TExpression>)new ReadOnlyCollection<TExpression>(element)).ToList());
            }
        }

        IReadOnlyDictionary<string, TExpression> IHasObjectInitializers<TExpression, TObjectInitializer>.Members =>
            new ReadOnlyDictionary<string, TExpression>(Members);

        IReadOnlyDictionary<string, TObjectInitializer> IHasObjectInitializers<TExpression, TObjectInitializer>.Initializers =>
            new ReadOnlyDictionary<string, TObjectInitializer>(Initializers);

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitObjectInitializerExpression(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitObjectInitializerExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitObjectInitializerExpressionChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
