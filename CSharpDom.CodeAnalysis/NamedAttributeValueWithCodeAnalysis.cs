using CSharpDom.Common.Expressions;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NamedAttributeValueWithCodeAnalysis :
        EditableNamedAttributeValue<IExpressionWithCodeAnalysis>,
        IHasSyntax<AttributeArgumentSyntax>,
        IHasNode<AttributeArgumentSyntax>
    {
        private readonly Node<NamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax> node;
        private readonly CachedExpressionNode<NamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax> value;
        
        internal NamedAttributeValueWithCodeAnalysis()
        {
            node = new Node<NamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax>(this);
            value = new CachedExpressionNode<NamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax>(
                node,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
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

        public override IExpressionWithCodeAnalysis Value
        {
            get { return value.Value; }
            set { this.value.Value = value; }
        }

        public AttributeArgumentSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        INode<AttributeArgumentSyntax> IHasNode<AttributeArgumentSyntax>.Node
        {
            get { return node; }
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
