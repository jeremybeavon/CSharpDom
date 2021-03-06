﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CSharpDom.BaseClasses.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class CatchStatementWithCodeAnalysis :
        EditableCatchStatement<ITypeReferenceWithCodeAnalysis, IStatementWithCodeAnalysis>,
        IHasSyntax<CatchClauseSyntax>,
        IHasNode<CatchClauseSyntax>
    {
        private readonly Node<CatchStatementWithCodeAnalysis, CatchClauseSyntax> node;
        private readonly StatementListWrapper<CatchStatementWithCodeAnalysis, CatchClauseSyntax> statements;
        private readonly CachedTypeReferenceNode<CatchStatementWithCodeAnalysis, CatchClauseSyntax> type;

        internal CatchStatementWithCodeAnalysis()
        {
            node = new Node<CatchStatementWithCodeAnalysis, CatchClauseSyntax>(this);
            statements = new StatementListWrapper<CatchStatementWithCodeAnalysis, CatchClauseSyntax>(
                node,
                syntax => syntax.Block.Statements,
                (parentSyntax, childSyntax) => parentSyntax.WithBlock(SyntaxFactory.Block(childSyntax)));
            type = new CachedTypeReferenceNode<CatchStatementWithCodeAnalysis, CatchClauseSyntax>(
                node,
                syntax => syntax.Declaration.Type,
                (parentSyntax, childSyntax) => parentSyntax.WithDeclaration(parentSyntax.Declaration.WithType(childSyntax)));
        }

        public override IList<IStatementWithCodeAnalysis> Statements
        {
            get { return statements; }
            set { statements.ReplaceList(value); }
        }

        public CatchClauseSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        public override ITypeReferenceWithCodeAnalysis Type
        {
            get { return type.Value; }
            set { type.Value = value; }
        }

        public override string VariableName
        {
            get { return Syntax.Declaration.Identifier.Text; }
            set
            {
                CatchClauseSyntax syntax = Syntax;
                Syntax = syntax.WithDeclaration(syntax.Declaration.WithIdentifier(SyntaxFactory.Identifier(value)));
            }
        }
        
        INode<CatchClauseSyntax> IHasNode<CatchClauseSyntax>.Node
        {
            get { return node; }
        }
    }
}
