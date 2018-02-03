using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Expressions
{
    internal class ArgumentListWrapper<TParent, TParentSyntax> :
        WrappedList<IInternalArgument, IExpressionWithCodeAnalysis>
        where TParent : class, IHasNode<TParentSyntax>
        where TParentSyntax : class
    {
        private readonly SeparatedSyntaxNodeList<TParent, TParentSyntax, IInternalArgument, ArgumentSyntax> list;
        private readonly Func<IExpressionWithCodeAnalysis, IInternalArgument> toParent;

        public ArgumentListWrapper(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, ArgumentListSyntax> getList,
            Func<TParentSyntax, ArgumentListSyntax, TParentSyntax> createList)
            : this(
                  node,
                  syntax => getList(syntax).Arguments,
                  (parentSyntax, childSyntax) => createList(parentSyntax, getList(parentSyntax).WithArguments(childSyntax)))
        {
        }

        public ArgumentListWrapper(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, BracketedArgumentListSyntax> getList,
            Func<TParentSyntax, BracketedArgumentListSyntax, TParentSyntax> createList)
            : this(
                  node,
                  syntax => getList(syntax).Arguments,
                  (parentSyntax, childSyntax) => createList(parentSyntax, getList(parentSyntax).WithArguments(childSyntax)))
        {
        }

        private ArgumentListWrapper(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<ArgumentSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<ArgumentSyntax>, TParentSyntax> createList)
            : this(ListFactory.CreateList(node, getList, createList, ArgumentSyntaxExtensions.ToInternalArgument))
        {
        }

        private ArgumentListWrapper(
            SeparatedSyntaxNodeList<TParent, TParentSyntax, IInternalArgument, ArgumentSyntax> list)
            : this(list, child => list.FirstOrDefault(parent => parent.Expression == child))
        {
        }

        private ArgumentListWrapper(
            SeparatedSyntaxNodeList<TParent, TParentSyntax, IInternalArgument, ArgumentSyntax> list,
            Func<IExpressionWithCodeAnalysis, IInternalArgument> toParent)
            : base(list, parent => parent.Expression, toParent)
        {
            this.list = list;
            this.toParent = toParent;
        }
        
        public void ReplaceList(IEnumerable<IExpressionWithCodeAnalysis> statement)
        {
            list.ReplaceList(statement.Select(toParent));
        }
    }
}
