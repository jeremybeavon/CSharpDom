﻿using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableNewExpression<TTypeReference, TExpression> :
        INewExpression<TTypeReference, TExpression>
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
        public abstract IList<TExpression> Parameters { get; set; }

        public abstract TTypeReference Type { get; set; }

        IReadOnlyList<TExpression> INewExpression<TTypeReference, TExpression>.Parameters
        {
            get { return new ReadOnlyCollection<TExpression>(Parameters); }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNewExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitNewExpressionChildren(this, visitor);
        }
    }
}