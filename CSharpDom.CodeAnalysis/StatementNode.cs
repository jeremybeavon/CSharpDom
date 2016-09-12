﻿using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal class StatementNode<TValue, TSyntax> : Node<TValue, TSyntax>
        where TValue : IInternalStatement
        where TSyntax : StatementSyntax
    {
        public StatementNode(TValue value)
            : base(value)
        {
        }

        public void SetStatementParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentNode, IChildCollection<IInternalStatement, StatementSyntax>> getCollection)
            where TParentNode : class, IHasSyntax<TParentSyntax>
        {
            SetParentNode<TParentNode, TParentSyntax>(parent, CreateChildCollection(getCollection));
        }

        public void SetStatementParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentSyntax, StatementSyntax> getChildSyntax,
            Func<TParentSyntax, StatementSyntax, TParentSyntax> createChildSyntax)
            where TParentNode : class, IHasSyntax<TParentSyntax>
        {
            SetParentNode<TParentNode, TParentSyntax>(
                parent,
                parentSyntax => (TSyntax)getChildSyntax(parentSyntax),
                (parentSyntax, childSyntax) => createChildSyntax(parentSyntax, childSyntax));
        }

        private Func<TParentNode, IChildCollection<TValue, TSyntax>> CreateChildCollection<TParentNode>(
            Func<TParentNode, IChildCollection<IInternalStatement, StatementSyntax>> getCollection)
        {
            return parent => new SimpleChildCollection<TValue, TSyntax>(
                value => (TSyntax)getCollection(parent).GetChild(value),
                (value, syntax) => getCollection(parent).SetChild(value, syntax));
        }
    }
}