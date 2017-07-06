using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Expressions
{
    internal class ArgumentListWrapper<TParentNode, TParentSyntax> :
        WrappedList<IInternalArgument, IExpressionWithCodeAnalysis>,
        IChildCollection<IInternalExpression, ExpressionSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
    {
        private readonly SeparatedSyntaxListWrapper<TParentNode, TParentSyntax, IInternalArgument, ArgumentSyntax> list;
        private readonly Func<IExpressionWithCodeAnalysis, IInternalArgument> toParent;

        public ArgumentListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, ArgumentListSyntax> getList,
            Func<TParentSyntax, ArgumentListSyntax, TParentSyntax> createList)
            : this(
                  node,
                  syntax => getList(syntax).Arguments,
                  (parentSyntax, childSyntax) => createList(parentSyntax, getList(parentSyntax).WithArguments(childSyntax)))
        {
        }

        public ArgumentListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, BracketedArgumentListSyntax> getList,
            Func<TParentSyntax, BracketedArgumentListSyntax, TParentSyntax> createList)
            : this(
                  node,
                  syntax => getList(syntax).Arguments,
                  (parentSyntax, childSyntax) => createList(parentSyntax, getList(parentSyntax).WithArguments(childSyntax)))
        {
        }

        private ArgumentListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<ArgumentSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<ArgumentSyntax>, TParentSyntax> createList)
            : this(ListFactory.CreateList(node, getList, createList, ArgumentSyntaxExtensions.ToInternalArgument))
        {
        }

        private ArgumentListWrapper(
            SeparatedSyntaxListWrapper<TParentNode, TParentSyntax, IInternalArgument, ArgumentSyntax> list)
            : this(list, child => list.FirstOrDefault(parent => parent.Expression == child))
        {
        }

        private ArgumentListWrapper(
            SeparatedSyntaxListWrapper<TParentNode, TParentSyntax, IInternalArgument, ArgumentSyntax> list,
            Func<IExpressionWithCodeAnalysis, IInternalArgument> toParent)
            : base(list, parent => parent.Expression, toParent)
        {
            this.list = list;
            this.toParent = toParent;
        }

        public ExpressionSyntax GetChild(IInternalExpression child)
        {
            return list.GetChild(toParent(child)).Expression;
        }

        public void SetChild(IInternalExpression child, ExpressionSyntax syntax)
        {
            //list.SetChild(toParent(child), syntax);
        }

        public void ReplaceList(IEnumerable<IExpressionWithCodeAnalysis> statement)
        {
            list.ReplaceList(statement.Select(toParent));
        }
    }
}
