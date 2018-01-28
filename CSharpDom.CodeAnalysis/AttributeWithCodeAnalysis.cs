using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AttributeWithCodeAnalysis :
        EditableAttribute<
            ClassReferenceWithCodeAnalysis,
            UnnamedAttributeValueWithCodeAnalysis,
            NamedAttributeValueWithCodeAnalysis>,
        IHasSyntax<AttributeSyntax>,
        IHasNode<AttributeSyntax>
    {
        private readonly Guid internalId;
        private readonly Node<AttributeWithCodeAnalysis, AttributeSyntax> node;
        private readonly CachedChildNode<
            AttributeWithCodeAnalysis,
            AttributeSyntax,
            ClassReferenceWithCodeAnalysis,
            NameSyntax> attributeType;
        private ChildNodeList<
            AttributeWithCodeAnalysis,
            AttributeSyntax,
            NamedAttributeValueWithCodeAnalysis,
            AttributeArgumentSyntax> namedValues;
        private ChildNodeList<
            AttributeWithCodeAnalysis,
            AttributeSyntax,
            UnnamedAttributeValueWithCodeAnalysis,
            AttributeArgumentSyntax> unnamedValues;

        internal AttributeWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            node = new Node<AttributeWithCodeAnalysis, AttributeSyntax>(this);
            attributeType = new CachedChildNode<AttributeWithCodeAnalysis, AttributeSyntax, ClassReferenceWithCodeAnalysis, NameSyntax>(
                node,
                () => new ClassReferenceWithCodeAnalysis(new UnspecifiedTypeReferenceWithCodeAnalysis()),
                syntax => syntax.Name,
                (parentSyntax, childSyntax) => parentSyntax.WithName(childSyntax));
            Func<SeparatedSyntaxList<AttributeArgumentSyntax>> getArguments = () => node.Syntax.ArgumentList?.Arguments ?? SyntaxFactory.SeparatedList<AttributeArgumentSyntax>();
            namedValues = new ChildNodeList<AttributeWithCodeAnalysis, AttributeSyntax, NamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax>(
                node,
                new ImmutableAttributeArgumentListWrapper(getArguments, SetArguments, true),
                () => new NamedAttributeValueWithCodeAnalysis());
            unnamedValues = new ChildNodeList<AttributeWithCodeAnalysis, AttributeSyntax, UnnamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax>(
                node,
                new ImmutableAttributeArgumentListWrapper(getArguments, SetArguments, false),
                () => new UnnamedAttributeValueWithCodeAnalysis());
        }

        public override ClassReferenceWithCodeAnalysis AttributeType
        {
            get { return attributeType.Value; }
            set { attributeType.Value = value; }
        }

        public override ICollection<NamedAttributeValueWithCodeAnalysis> NamedValues
        {
            get { return namedValues; }
            set { SetArguments(unnamedValues, value); }
        }

        public override IList<UnnamedAttributeValueWithCodeAnalysis> UnnamedValues
        {
            get { return unnamedValues; }
            set { SetArguments(value, namedValues); }
        }

        public AttributeSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
        
        internal IChildCollection<AttributeSyntax, NamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax> NamedValueList
        {
            get { return namedValues; }
        }

        internal IChildCollection<AttributeSyntax, UnnamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax> UnnamedValueList
        {
            get { return unnamedValues; }
        }

        INode<AttributeSyntax> IHasNode<AttributeSyntax>.Node
        {
            get { return node; }
        }

        private void SetArguments(SeparatedSyntaxList<AttributeArgumentSyntax> syntax)
        {
            AttributeSyntax attribute = node.Syntax;
            node.Syntax = attribute.WithArgumentList((attribute.ArgumentList ?? SyntaxFactory.AttributeArgumentList()).WithArguments(syntax));
        }

        private void SetArguments(
            IEnumerable<UnnamedAttributeValueWithCodeAnalysis> unnamedValues,
            IEnumerable<NamedAttributeValueWithCodeAnalysis> namedValues)
        {
            IEnumerable<AttributeArgumentSyntax> arguments =
                unnamedValues.Select(node => node.Syntax).Concat(namedValues.Select(node => node.Syntax));
            SetArguments(SyntaxFactory.SeparatedList(arguments));
        }
    }
}
