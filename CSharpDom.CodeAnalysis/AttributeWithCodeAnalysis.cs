using CSharpDom.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private readonly SimpleNode<AttributeGroupWithCodeAnalysis, AttributeListSyntax, AttributeSyntax> node;
        private readonly CachedValueNode<AttributeSyntax, ClassReferenceWithCodeAnalysis> attributeType;
        private ImmutableListWrapper<NamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax, AttributeWithCodeAnalysis> namedValues;
        private ImmutableListWrapper<UnnamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax, AttributeWithCodeAnalysis> unnamedValues;

        internal AttributeWithCodeAnalysis(AttributeGroupWithCodeAnalysis parent)
        {
            internalId = Guid.NewGuid();
            node = new SimpleNode<AttributeGroupWithCodeAnalysis, AttributeListSyntax, AttributeSyntax>(
                parent,
                syntax => Parent.AttributeList.GetChild(this),
                (parentSyntax, childSyntax) => { Parent.AttributeList.SetChild(this, childSyntax); return parentSyntax; });
            attributeType = new CachedValueNode<AttributeSyntax, ClassReferenceWithCodeAnalysis>(
                node,
                syntax => new ClassReferenceWithCodeAnalysis(this),
                (syntax, value) => syntax.WithName(value.Syntax));
            Func<SeparatedSyntaxList<AttributeArgumentSyntax>> getArguments = () => node.Syntax.ArgumentList.Arguments;
            namedValues = new ImmutableListWrapper<NamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax, AttributeWithCodeAnalysis>(
                new ImmutableAttributeArgumentListWrapper(getArguments, SetArguments, true),
                () => new NamedAttributeValueWithCodeAnalysis(this),
                this,
                (child, newParent) => child.Parent = newParent);
            unnamedValues = new ImmutableListWrapper<UnnamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax, AttributeWithCodeAnalysis>(
                new ImmutableAttributeArgumentListWrapper(getArguments, SetArguments, false),
                () => new UnnamedAttributeValueWithCodeAnalysis(this),
                this,
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

        internal ImmutableListWrapper<NamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax, AttributeWithCodeAnalysis> NamedValueList
        {
            get { return namedValues; }
        }

        internal ImmutableListWrapper<UnnamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax, AttributeWithCodeAnalysis> UnnamedValueList
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
