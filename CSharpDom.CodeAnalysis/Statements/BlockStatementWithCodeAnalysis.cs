using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CSharpDom.BaseClasses.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class BlockStatementWithCodeAnalysis :
        EditableBlockStatement<IStatementWithCodeAnalysis>,
        IHasSyntax<BlockSyntax>,
        IInternalStatement,
        IHasNode<BlockSyntax>
    {
        private readonly StatementNode<BlockStatementWithCodeAnalysis, BlockSyntax> node;
        private readonly StatementListWrapper<BlockStatementWithCodeAnalysis, BlockSyntax> statements;

        public BlockStatementWithCodeAnalysis(IEnumerable<IStatementWithCodeAnalysis> statements)
            : this()
        {
            Syntax = SyntaxFactory.Block(statements.Select(statement => statement.Syntax));
        }

        internal BlockStatementWithCodeAnalysis()
        {
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

        INode<BlockSyntax> IHasNode<BlockSyntax>.Node => node;

        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (BlockSyntax)value; }
        }
    }
}
