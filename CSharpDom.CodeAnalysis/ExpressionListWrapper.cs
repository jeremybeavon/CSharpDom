using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal class ExpressionListWrapper<TParentNode, TParentSyntax> :
        WrappedList<IInternalExpression, IExpressionWithCodeAnalysis>,
        IChildCollection<TParentSyntax, IInternalExpression, ExpressionSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
    {
        private readonly SeparatedSyntaxListWrapper<TParentNode, TParentSyntax, IInternalExpression, ExpressionSyntax> list;

        public ExpressionListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<ExpressionSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<ExpressionSyntax>, TParentSyntax> createList)
            : this(ListFactory.CreateList(node, getList, createList, ExpressionSyntaxExtensions.ToInternalExpression))
        {
        }

        private ExpressionListWrapper(
            SeparatedSyntaxListWrapper<TParentNode, TParentSyntax, IInternalExpression, ExpressionSyntax> list)
            : base(list, parent => parent, child => child as IInternalExpression)
        {
            this.list = list;
        }

        public ExpressionSyntax GetChild(IInternalExpression child)
        {
            return list.GetChild(child);
        }

        public TParentSyntax SetChild(IInternalExpression child, ExpressionSyntax syntax)
        {
            return list.SetChild(child, syntax);
        }

        public void ReplaceList(IEnumerable<IExpressionWithCodeAnalysis> statement)
        {
            list.ReplaceList(statement.Cast<IInternalExpression>());
        }
    }
}
