using CSharpDom.Common.Expressions;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NamedAttributeValueWithCodeAnalysis :
        EditableNamedAttributeValue<IExpression>,
        IHasSyntax<AttributeArgumentSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly SimpleNode<
            AttributeWithCodeAnalysis,
            AttributeSyntax,
            NamedAttributeValueWithCodeAnalysis,
            AttributeArgumentSyntax> node;
        
        internal NamedAttributeValueWithCodeAnalysis(AttributeWithCodeAnalysis parent)
        {
            internalId = Guid.NewGuid();
            node = new SimpleNode<AttributeWithCodeAnalysis, AttributeSyntax, NamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax>(
                parent,
                this,
                newParent => newParent.NamedValueList);
        }

        public override string Name
        {
            get { return node.Syntax.NameEquals.Name.Identifier.Text; }
            set
            {
                AttributeArgumentSyntax argument = node.Syntax;
                node.Syntax = argument.WithNameEquals(argument.NameEquals.WithName(SyntaxFactory.IdentifierName(value)));
            }
        }
        
        //public override IConstantExpressionWithCodeAnalysis Value
        //{
        //    get { return value; }
        //}

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

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNamedAttributeValueWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
