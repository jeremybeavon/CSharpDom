﻿using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using CSharpDom.Editable.Statements;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class AnonymousMethodExpressionWithCodeAnalysis<TParameter, TStatement> :
        IAnonymousMethodExpression<TParameter, TStatement>
        where TParameter : IParameter
        where TStatement : IStatement
    {
        public abstract TStatement Body { get; set; }

        public abstract IList<TParameter> Parameters { get; set; }

        IReadOnlyList<TParameter> IAnonymousMethodExpression<TParameter, TStatement>.Parameters
        {
            get { return new ReadOnlyCollection<TParameter>(Parameters); }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitAnonymousMethodExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}