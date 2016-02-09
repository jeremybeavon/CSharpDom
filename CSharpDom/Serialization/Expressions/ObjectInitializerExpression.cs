using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class ObjectInitializerExpression : IObjectInitializerExpression<CreateObjectExpression, Expression, ObjectInitializersExpression>
    {
        public ObjectInitializerExpression()
        {
            Elements = new List<List<Expression>>();
            Initializers = new Dictionary<string, ObjectInitializersExpression>();
            Members = new Dictionary<string, Expression>();
        }

        public CreateObjectExpression CreateObjectExpression { get; set; }

        public List<List<Expression>> Elements { get; set; }

        public Dictionary<string, ObjectInitializersExpression> Initializers { get; set; }

        public Dictionary<string, Expression> Members { get; set; }

        IReadOnlyList<IReadOnlyList<Expression>> IHasObjectInitializers<Expression, ObjectInitializersExpression>.Elements
        {
            get { return Elements; }
        }

        IReadOnlyDictionary<string, ObjectInitializersExpression> IHasObjectInitializers<Expression, ObjectInitializersExpression>.Initializers
        {
            get { return Initializers; }
        }

        IReadOnlyDictionary<string, Expression> IHasObjectInitializers<Expression, ObjectInitializersExpression>.Members
        {
            get { return Members; }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitObjectInitializerExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitObjectInitializerExpressionChildren(this, visitor);
        }
    }
}
