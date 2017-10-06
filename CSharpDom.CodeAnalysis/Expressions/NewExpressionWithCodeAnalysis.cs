﻿using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class NewExpressionWithCodeAnalysis :
        EditableNewExpression<ITypeReferenceWithCodeAnalysis, IExpressionWithCodeAnalysis>,
        IHasSyntax<ObjectCreationExpressionSyntax>,
        IInternalExpression
    {
        private readonly ExpressionNode<NewExpressionWithCodeAnalysis, ObjectCreationExpressionSyntax> node;
        private readonly ArgumentListWrapper<NewExpressionWithCodeAnalysis, ObjectCreationExpressionSyntax> parameters;
        private readonly CachedTypeReferenceNode<NewExpressionWithCodeAnalysis, ObjectCreationExpressionSyntax> type;

        public NewExpressionWithCodeAnalysis()
        {
            node = new ExpressionNode<NewExpressionWithCodeAnalysis, ObjectCreationExpressionSyntax>(this);
            parameters = new ArgumentListWrapper<NewExpressionWithCodeAnalysis, ObjectCreationExpressionSyntax>(
                node,
                syntax => syntax.ArgumentList,
                (parentSyntax, childSyntax) => parentSyntax.WithArgumentList(childSyntax));
            type = new CachedTypeReferenceNode<NewExpressionWithCodeAnalysis, ObjectCreationExpressionSyntax>(
                node,
                syntax => syntax.Type,
                (parentSyntax, childSyntax) => parentSyntax.WithType(childSyntax));
        }

        public override IList<IExpressionWithCodeAnalysis> Parameters
        {
            get { return parameters; }
            set { parameters.ReplaceList(value); }
        }

        public ObjectCreationExpressionSyntax Syntax
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
            set { Syntax = (ObjectCreationExpressionSyntax)value; }
        }
    }
}
