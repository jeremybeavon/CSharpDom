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
        IHasId
    {
        private readonly Guid internalId;
        private readonly Func<AttributeSyntax> getAttribute;
        private readonly Action<AttributeSyntax> setAttribute;

        internal AttributeWithCodeAnalysis(AttributeGroupWithCodeAnalysis parent)
        {
            Parent = parent;
            getAttribute = () => Parent.AttributeList.GetChild(this);
            setAttribute = syntax => Parent.AttributeList.SetChild(this, syntax);
        }

        public override ClassReferenceWithCodeAnalysis AttributeType
        {
            get
            {
                return base.AttributeType;
            }
            set
            {
                base.AttributeType = value;
            }
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
    }
}
