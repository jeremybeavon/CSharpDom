using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CSharpDom.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class BlockStatementWithCodeAnalysis :
        EditableBlockStatement<IStatementWithCodeAnalysis>,
        IHasSyntax<BlockSyntax>,
        IInternalStatement
    {
        private readonly Guid internalId;
        private readonly StatementNode<BlockStatementWithCodeAnalysis, BlockSyntax> node;
        private readonly StatementListWrapper<BlockStatementWithCodeAnalysis, BlockSyntax> statements;

        public BlockStatementWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            node = new StatementNode<BlockStatementWithCodeAnalysis, BlockSyntax>(this);
            statements = new StatementListWrapper<BlockStatementWithCodeAnalysis, BlockSyntax>(
                node,
                syntax => syntax.Statements,
                (parentSyntax, childSyntax) => parentSyntax.WithStatements(childSyntax));
        }

        public override IList<IStatementWithCodeAnalysis> Statements
        {
            get { return statements; }
            set { statements.ReplaceList(value); }
        }

        public BlockSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal StatementNode<BlockStatementWithCodeAnalysis, BlockSyntax> Node => node;


        INode<StatementSyntax> IHasNode<StatementSyntax>.Node
        {
            get { return node; }
        }

        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (BlockSyntax)value; }
        }
    }
}
