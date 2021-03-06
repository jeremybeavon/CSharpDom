﻿using CSharpDom.Editable.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class ObjectInitializerExpressionWithCodeAnalysis<TCreateObjectExpression, TExpression, TObjectInitializer> :
        IObjectInitializerExpression<TCreateObjectExpression, TExpression, TObjectInitializer>
        where TCreateObjectExpression : ICreateObjectExpression
        where TExpression : IExpression
        where TObjectInitializer : IHasObjectInitializers<TExpression, TObjectInitializer>
    {
        public abstract TCreateObjectExpression CreateObjectExpression { get; set; }

        public abstract IList<IList<TExpression>> Elements { get; set; }

        public abstract IReadOnlyDictionary<string, TObjectInitializer> Initializers { get; set; }

        public abstract IReadOnlyDictionary<string, TExpression> Members { get; set; }

        IReadOnlyList<IReadOnlyList<TExpression>> IHasObjectInitializers<TExpression, TObjectInitializer>.Elements
        {
            get
            {
                return new ReadOnlyCollection<IReadOnlyList<TExpression>>(
                    Elements.Select(element => (IReadOnlyList<TExpression>)new ReadOnlyCollection<TExpression>(element)).ToList());
            }
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
