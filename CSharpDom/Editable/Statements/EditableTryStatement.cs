﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CSharpDom.Common.Statements;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable.Statements
{
    public abstract class EditableTryStatement<TStatement, TCatchStatement, TFinallyStatement> :
        ITryStatement<TStatement, TCatchStatement, TFinallyStatement>
        where TStatement : IStatement
        where TCatchStatement : ICatchStatement
        where TFinallyStatement : IFinallyStatement
    {
        public abstract ICollection<TCatchStatement> CatchStatements { get; set; }

        public abstract TFinallyStatement FinallyStatement { get; set; }

        public abstract IList<TStatement> TryStatements { get; set; }

        IReadOnlyCollection<TCatchStatement> ITryStatement<TStatement, TCatchStatement, TFinallyStatement>.CatchStatements
        {
            get { return new ReadOnlyCollectionWrapper<TCatchStatement>(CatchStatements); }
        }

        IReadOnlyList<TStatement> ITryStatement<TStatement, TCatchStatement, TFinallyStatement>.TryStatements
        {
            get { return new ReadOnlyCollection<TStatement>(TryStatements); }
        }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitTryStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitTryStatementChildren(this, visitor);
        }
    }
}