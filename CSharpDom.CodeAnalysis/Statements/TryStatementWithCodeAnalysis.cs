using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CSharpDom.Editable.Statements;
using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using CSharpDom.Wrappers.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class TryStatementWithCodeAnalysis :
        EditableTryStatement<IStatementWithCodeAnalysis, CatchStatementWithCodeAnalysis, FinallyStatementWithCodeAnalysis>,
        IHasSyntax<TryStatementSyntax>,
        IInternalStatement
    {
        private readonly Guid internalId;
        private readonly StatementNode<TryStatementWithCodeAnalysis, TryStatementSyntax> node;
        private readonly SyntaxListWrapper<
            TryStatementWithCodeAnalysis,
            TryStatementSyntax,
            CatchStatementWithCodeAnalysis,
            CatchClauseSyntax> catchStatements;
        private readonly CachedChildNode<
            TryStatementWithCodeAnalysis,
            TryStatementSyntax,
            FinallyStatementWithCodeAnalysis,
            FinallyClauseSyntax> finallyStatement;
        private readonly StatementListWrapper<TryStatementWithCodeAnalysis, TryStatementSyntax> tryStatements;

        public TryStatementWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            node = new StatementNode<TryStatementWithCodeAnalysis, TryStatementSyntax>(this);
            //catchStatements = new SyntaxListWrapper<TryStatementWithCodeAnalysis, TryStatementSyntax, CatchStatementWithCodeAnalysis, CatchClauseSyntax>(
            //    node,
            //    syntax => syntax,
            //    (parentSyntax, childSyntax) => parentSyntax,
            //    () => new CatchStatementWithCodeAnalysis(),
            //    null);
        }

        public override ICollection<CatchStatementWithCodeAnalysis> CatchStatements
        {
            get { return catchStatements; }
            set { catchStatements.ReplaceList(value); }
        }

        public override FinallyStatementWithCodeAnalysis FinallyStatement
        {
            get { return finallyStatement.Value; }
            set { finallyStatement.Value = value; }
        }

        public TryStatementSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        public override IList<IStatementWithCodeAnalysis> TryStatements
        {
            get { return tryStatements; }
            set { tryStatements.ReplaceList(value); }
        }
        
        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (TryStatementSyntax)value; }
        }

        INode<StatementSyntax> IHasNode<StatementSyntax>.Node
        {
            get { return node; }
        }
    }
}
