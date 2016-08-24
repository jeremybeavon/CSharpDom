using System;
using CSharpDom.BaseClasses;
using CSharpDom.Common.Expressions;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class UnnamedAttributeValueWithCodeAnalysis :
        EditableUnnamedAttributeValue<IExpression>,
        IHasSyntax<AttributeArgumentSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly SimpleChildNode<
            AttributeWithCodeAnalysis,
            AttributeSyntax,
            UnnamedAttributeValueWithCodeAnalysis,
            AttributeArgumentSyntax> node;
        
        internal UnnamedAttributeValueWithCodeAnalysis(AttributeWithCodeAnalysis parent)
        {
            internalId = Guid.NewGuid();
            node = new SimpleChildNode<AttributeWithCodeAnalysis, AttributeSyntax, UnnamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax>(
                parent,
                this,
                () => Parent.UnnamedValueList);
        }

        public AttributeArgumentSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }

        internal AttributeWithCodeAnalysis Parent
        {
            get { return node.Parent; }
            set { node.Parent = value; }
        }
    }
}
