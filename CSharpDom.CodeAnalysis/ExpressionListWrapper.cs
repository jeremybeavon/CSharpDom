using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal class ExpressionListWrapper<TParent, TParentSyntax> :
        WrappedList<IInternalExpression, IExpressionWithCodeAnalysis>
        where TParent : class, IHasNode<TParentSyntax>
        where TParentSyntax : class
    {
        private readonly SeparatedSyntaxNodeList<TParent, TParentSyntax, IInternalExpression, ExpressionSyntax> list;

        public ExpressionListWrapper(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<ExpressionSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<ExpressionSyntax>, TParentSyntax> createList)
            : this(ListFactory.CreateNodeList(node, getList, createList, ExpressionSyntaxExtensions.ToInternalExpression))
        {
        }

        private ExpressionListWrapper(
            SeparatedSyntaxNodeList<TParent, TParentSyntax, IInternalExpression, ExpressionSyntax> list)
            : base(list, parent => parent, child => child as IInternalExpression)
        {
            this.list = list;
        }
        
        public void ReplaceList(IEnumerable<IExpressionWithCodeAnalysis> statement)
        {
            list.ReplaceList(statement.Cast<IInternalExpression>());
        }
    }
}
