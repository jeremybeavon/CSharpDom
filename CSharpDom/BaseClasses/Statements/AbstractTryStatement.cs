﻿using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractTryStatement<TStatement, TCatchStatement, TFinallyStatement> :
        AbstractStatement,
        ITryStatement<TStatement, TCatchStatement, TFinallyStatement>
        where TStatement : IStatement
        where TCatchStatement : ICatchStatement
        where TFinallyStatement : IFinallyStatement
    {
        public abstract IReadOnlyCollection<TCatchStatement> CatchStatements { get; }

        public abstract TFinallyStatement FinallyStatement { get; }

        public abstract IReadOnlyList<TStatement> TryStatements { get; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitTryStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitTryStatementChildren(this, visitor);
        }
    }
}
