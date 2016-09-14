using System;
using System.Collections.Generic;
using CSharpDom.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class EmptyStatementWithCodeAnalysis :
        EditableEmptyStatement,
        IHasSyntax<EmptyStatementSyntax>,
        IInternalStatement
    {
        private readonly Guid internalId;
        private readonly StatementNode<EmptyStatementWithCodeAnalysis, EmptyStatementSyntax> node;

        public EmptyStatementWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            node = new StatementNode<EmptyStatementWithCodeAnalysis, EmptyStatementSyntax>(this);
        }

        public EmptyStatementSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
        
        INode<StatementSyntax> IHasNode<StatementSyntax>.Node
        {
            get { return node; }
        }

        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (EmptyStatementSyntax)value; }
        }
    }
}
