using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CSharpDom.BaseClasses.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class FinallyStatementWithCodeAnalysis :
        EditableFinallyStatement<IStatementWithCodeAnalysis>,
        IHasSyntax<FinallyClauseSyntax>,
        IHasNode<FinallyClauseSyntax>
    {
        private readonly Node<FinallyStatementWithCodeAnalysis, FinallyClauseSyntax> node;
        private readonly StatementListWrapper<FinallyStatementWithCodeAnalysis, FinallyClauseSyntax> statements;

        public FinallyStatementWithCodeAnalysis()
        {
            node = new Node<FinallyStatementWithCodeAnalysis, FinallyClauseSyntax>(this);
            statements = new StatementListWrapper<FinallyStatementWithCodeAnalysis, FinallyClauseSyntax>(
                node,
                syntax => syntax.Block.Statements,
                (parentSyntax, childSyntax) => parentSyntax.WithBlock(parentSyntax.Block.WithStatements(childSyntax)));
        }

        public override IList<IStatementWithCodeAnalysis> Statements
        {
            get { return statements; }
            set { statements.ReplaceList(value); }
        }

        public FinallyClauseSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        INode<FinallyClauseSyntax> IHasNode<FinallyClauseSyntax>.Node
        {
            get { return node; }
        }
    }
}
