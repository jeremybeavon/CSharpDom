using CSharpDom.Editable;
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
        IHasParent<AttributeWithCodeAnalysis, AttributeSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private IHasChildWithId<AttributeWithCodeAnalysis, AttributeSyntax> parent;

        internal AttributeWithCodeAnalysis(IHasChildWithId<AttributeWithCodeAnalysis, AttributeSyntax> parent)
        {
            this.parent = parent;
        }

        public AttributeSyntax Syntax
        {
            get { return parent.GetChild(this); }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }

        IHasChildWithId<AttributeWithCodeAnalysis, AttributeSyntax> IHasParent<AttributeWithCodeAnalysis, AttributeSyntax>.Parent
        {
            get { return parent; }
            set { parent = value; }
        }
    }
}
