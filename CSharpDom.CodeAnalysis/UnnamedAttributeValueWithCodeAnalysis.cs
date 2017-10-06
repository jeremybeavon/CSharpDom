using System;
using CSharpDom.BaseClasses;
using CSharpDom.Common.Expressions;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class UnnamedAttributeValueWithCodeAnalysis :
        EditableUnnamedAttributeValue<IExpressionWithCodeAnalysis>,
        IHasSyntax<AttributeArgumentSyntax>,
        IHasNode<AttributeArgumentSyntax>
    {
        private readonly Node<UnnamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax> node;
        private readonly CachedExpressionNode<UnnamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax> value;
        
        internal UnnamedAttributeValueWithCodeAnalysis()
        {
            node = new Node<UnnamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax>(this);
            value = new CachedExpressionNode<UnnamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax>(
                node,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
        }

        public AttributeArgumentSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        public override IExpressionWithCodeAnalysis Value
        {
            get { return value.Value; }
            set { this.value.Value = value; }
        }
        
        INode<AttributeArgumentSyntax> IHasNode<AttributeArgumentSyntax>.Node
        {
            get { return node; }
        }
    }
}
