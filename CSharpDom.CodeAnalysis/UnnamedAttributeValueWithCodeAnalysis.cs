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
        private readonly SimpleNode<
            AttributeWithCodeAnalysis,
            AttributeSyntax,
            UnnamedAttributeValueWithCodeAnalysis,
            AttributeArgumentSyntax> node;
        
        internal UnnamedAttributeValueWithCodeAnalysis(AttributeWithCodeAnalysis parent)
        {
            internalId = Guid.NewGuid();
            node = new SimpleNode<AttributeWithCodeAnalysis, AttributeSyntax, UnnamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax>(
                parent,
                this,
                newParent => newParent.UnnamedValueList);
        }

        public AttributeArgumentSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        public override IExpression Value
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
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
