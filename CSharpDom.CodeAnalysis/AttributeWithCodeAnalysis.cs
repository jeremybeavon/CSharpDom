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
        private readonly Func<AttributeSyntax> getAttribute;
        private readonly Action<AttributeSyntax> setAttribute;
        private ClassReferenceWithCodeAnalysis attributeType;
        private ImmutableListWrapper<NamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax, AttributeWithCodeAnalysis> namedValues;
        private ImmutableListWrapper<UnnamedAttributeValueWithCodeAnalysis, AttributeArgumentSyntax, AttributeWithCodeAnalysis> unnamedValues;

        internal AttributeWithCodeAnalysis(AttributeGroupWithCodeAnalysis parent)
        {
            internalId = Guid.NewGuid();
            Parent = parent;
            AttributeType = new ClassReferenceWithCodeAnalysis(this);
            getAttribute = () => Parent.AttributeList.GetChild(this);
            setAttribute = syntax => Parent.AttributeList.SetChild(this, syntax);
            Func<SeparatedSyntaxList<AttributeArgumentSyntax>> getArguments = () => getAttribute().ArgumentList.Arguments;
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
            get { return attributeType; }
            set
            {
                setAttribute(getAttribute().WithName(value.Syntax));
                value.ParentAttribute = this;
            }
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
            get { return getAttribute(); }
            internal set { setAttribute(value); }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }

        internal AttributeGroupWithCodeAnalysis Parent { get; set; }

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
            AttributeSyntax attribute = getAttribute();
            setAttribute(attribute.WithArgumentList(attribute.ArgumentList.WithArguments(syntax)));
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
