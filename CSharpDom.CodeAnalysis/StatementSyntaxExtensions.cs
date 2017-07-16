﻿using CSharpDom.CodeAnalysis.Statements;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal static class StatementSyntaxExtensions
    {
        private static readonly TypedFactory<IInternalStatement> factory = new TypedFactory<IInternalStatement>()
        {
            { typeof(BlockSyntax), () => new BlockStatementWithCodeAnalysis() },
            { typeof(BreakStatementSyntax), () => new BreakStatementWithCodeAnalysis() },
            //{ typeof(CheckedStatementSyntax),  }
            { typeof(ContinueStatementSyntax), () => new ContinueStatementWithCodeAnalysis() },
            { typeof(DoStatementSyntax), () => new DoStatementWithCodeAnalysis() },
            { typeof(EmptyStatementSyntax), () => new EmptyStatementWithCodeAnalysis() },
            { typeof(ExpressionStatementSyntax), () => new ExpressionStatementWithCodeAnalysis() },
            //{ typeof(FixedStatementSyntax) }
            { typeof(ForEachStatementSyntax), () => new ForeachStatementWithCodeAnalysis() },
            { typeof(ForStatementSyntax), () => new ForStatementWithCodeAnalysis() },
            { typeof(GotoStatementSyntax), () => new GotoStatementWithCodeAnalysis() },
            { typeof(IfStatementSyntax), () => new IfStatementWithCodeAnalysis() },
            //{ typeof(LabeledStatementSyntax), () => new lab }
            //{ typeof(LocalDeclarationStatementSyntax), () => new var }
            { typeof(LockStatementSyntax), () => new LockStatementWithCodeAnalysis() },
            { typeof(ReturnStatementSyntax), () => new ReturnStatementWithCodeAnalysis() },
            //{ typeof(SwitchStatementSyntax), () => new swit }
            //{ typeof(ThrowStatementSyntax), () => new ThrowStatementSyntax }
            { typeof(TryStatementSyntax), () => new TryStatementWithCodeAnalysis() },
            //{ typeof(UnsafeStatementSyntax) }
            { typeof(UsingStatementSyntax), () => new UsingStatementWithCodeAnalysis() },
            { typeof(WhileStatementSyntax), () => new WhileStatementWithCodeAnalysis() }
            //{ typeof(YieldStatementSyntax), () =>  }
        };

        public static IInternalStatement ToInternalStatement(this StatementSyntax syntax)
        {
            return factory.Create(syntax.GetType());
        }
    }
}
