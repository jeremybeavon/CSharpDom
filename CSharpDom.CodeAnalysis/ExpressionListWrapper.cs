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
        IChildCollection<IInternalExpression, ExpressionSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
    {
        private readonly InternalExpressionListWrapper<TParentNode, TParentSyntax> list;

        public ExpressionListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<ExpressionSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<ExpressionSyntax>, TParentSyntax> createList,
            Func<TParentNode, IChildCollection<IInternalExpression, ExpressionSyntax>> getCollection)
            : this(new InternalExpressionListWrapper<TParentNode, TParentSyntax>(node, getList, createList, getCollection))
        {
        }

        private ExpressionListWrapper(InternalExpressionListWrapper<TParentNode, TParentSyntax> list)
            : base(list, parent => parent, child => child as IInternalExpression)
        {
            this.list = list;
        }

        public ExpressionSyntax GetChild(IInternalExpression child)
        {
            return list.GetChild(child);
        }

        public void SetChild(IInternalExpression child, ExpressionSyntax syntax)
        {
            list.SetChild(child, syntax);
        }

        public void ReplaceList(IEnumerable<IExpressionWithCodeAnalysis> statement)
        {
            list.ReplaceList(statement.Cast<IInternalExpression>());
        }
    }
}
