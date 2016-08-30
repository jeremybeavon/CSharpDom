using CSharpDom.Editable;
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
        IHasId
    {
        private readonly Guid internalId;
        private readonly SimpleNode<
            AttributeGroupWithCodeAnalysis,
            AttributeListSyntax,
            AttributeWithCodeAnalysis,
            AttributeSyntax> node;
        private readonly CachedChildNode<
            AttributeWithCodeAnalysis,
            AttributeSyntax,
            ClassReferenceWithCodeAnalysis,
            NameSyntax> attributeType;
        private ImmutableListWrapper<
            AttributeWithCodeAnalysis,
            AttributeSyntax,
            NamedAttributeValueWithCodeAnalysis,
            AttributeArgumentSyntax> namedValues;
        private ImmutableListWrapper<
            AttributeWithCodeAnalysis,
            AttributeSyntax,
            UnnamedAttributeValueWithCodeAnalysis,
            AttributeArgumentSyntax> unnamedValues;

        internal AttributeWithCodeAnalysis(AttributeGroupWithCodeAnalysis parent)
        {
            internalId = Guid.NewGuid();
            node = new SimpleNode<AttributeGroupWithCodeAnalysis, AttributeListSyntax, AttributeWithCodeAnalysis, AttributeSyntax>(
                this,
                parent,
                syntax => Parent.AttributeList.GetChild(this),
                (parentSyntax, childSyntax) => { Parent.AttributeList.SetChild(this, childSyntax); return parentSyntax; });
            /*attributeType = new CachedChildNode<AttributeWithCodeAnalysis, ClassReferenceWithCodeAnalysis, AttributeSyntax>(
                this,
                node,
                syntax => new ClassReferenceWithCodeAnalysis(this),
                (syntax, value) => syntax.WithName(value.Syntax),
                (child, newParent) => child.ParentAttribute = newParent);*/
            Func<SeparatedSyntaxList<AttributeArgumentSyntax>> getArguments = () => node.Syntax.ArgumentList.Arguments;
            namedValues = new ImmutableListWrapper<AttributeWithCodeAnalysis, AttributeSyntax, NamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax>(
                node,
                new ImmutableAttributeArgumentListWrapper(getArguments, SetArguments, true),
                newParent => new NamedAttributeValueWithCodeAnalysis(newParent),
                (child, newParent) => child.Parent = newParent);
            unnamedValues = new ImmutableListWrapper<AttributeWithCodeAnalysis, AttributeSyntax, UnnamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax>(
                node,
                new ImmutableAttributeArgumentListWrapper(getArguments, SetArguments, false),
                newParent => new UnnamedAttributeValueWithCodeAnalysis(newParent),
                (child, newParent) => child.Parent = newParent);
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

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }

        internal AttributeGroupWithCodeAnalysis Parent
        {
            get { return node.Parent; }
            set { node.Parent = value; }
        }

        internal IChildCollection<NamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax> NamedValueList
        {
            get { return namedValues; }
        }

        internal IChildCollection<UnnamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax> UnnamedValueList
        {
            get { return unnamedValues; }
        }

        private void SetArguments(SeparatedSyntaxList<AttributeArgumentSyntax> syntax)
        {
            AttributeSyntax attribute = node.Syntax;
            node.Syntax = attribute.WithArgumentList(attribute.ArgumentList.WithArguments(syntax));
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
