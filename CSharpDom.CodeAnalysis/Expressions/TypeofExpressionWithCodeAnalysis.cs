using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class TypeofExpressionWithCodeAnalysis :
        EditableTypeofExpression<ITypeReferenceWithCodeAnalysis>,
        IHasSyntax<TypeOfExpressionSyntax>,
        IInternalExpression
    {
        private readonly ExpressionNode<TypeofExpressionWithCodeAnalysis, TypeOfExpressionSyntax> node;
        private readonly CachedTypeReferenceNode<TypeofExpressionWithCodeAnalysis, TypeOfExpressionSyntax> type;

        public TypeofExpressionWithCodeAnalysis()
        {
            node = new ExpressionNode<TypeofExpressionWithCodeAnalysis, TypeOfExpressionSyntax>(this);
            type = new CachedTypeReferenceNode<TypeofExpressionWithCodeAnalysis, TypeOfExpressionSyntax>(
                node,
                syntax => syntax.Type,
                (parentSyntax, childSyntax) => parentSyntax.WithType(childSyntax));
        }

        public TypeOfExpressionSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        public override ITypeReferenceWithCodeAnalysis Type
        {
            get { return type.Value; }
            set { type.Value = value; }
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node
        {
            get { return node; }
        }

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (TypeOfExpressionSyntax)value; }
        }
    }
}
