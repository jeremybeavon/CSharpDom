﻿using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractSwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement> :
        AbstractStatement,
        ISwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement>
        where TExpression : IExpression
        where TSwitchCaseStatement : ISwitchCaseStatement
        where TDefaultCaseStatement : IDefaultCaseStatement
    {
        public abstract IReadOnlyCollection<TSwitchCaseStatement> Cases { get; }

        public abstract TDefaultCaseStatement DefaultCase { get; }

        public abstract TExpression Expression { get; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitSwitchStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitSwitchStatementChildren(this, visitor);
        }
    }
}
