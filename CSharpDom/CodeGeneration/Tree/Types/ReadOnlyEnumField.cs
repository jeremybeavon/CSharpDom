using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyEnumField :
        IEnumMember<AttributeGroupNotSupported, IEnum>,
        INestedEnumMember<AttributeGroupNotSupported, INestedEnum>
    {
        private readonly EnumField enumField;
        private readonly bool isNested;

        public ReadOnlyEnumField(EnumField enumField)
        {
            this.enumField = enumField;
        }

        public ReadOnlyEnumField(EnumField enumField, bool isNested)
        {
            this.enumField = enumField;
            this.isNested = isNested;
        }

        public IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public IEnum DeclaringType
        {
            get { return null; }
        }

        public string Name
        {
            get { return enumField.Name; }
        }

        INestedEnum IHasDeclaringType<INestedEnum>.DeclaringType
        {
            get { return null; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            if (isNested)
            {
                visitor.VisitNestedEnumMember(this);
            }
            else
            {
                visitor.VisitEnumMember(this);
            }
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            if (isNested)
            {
                GenericVisitor.VisitNestedEnumMemberChildren(this, visitor);
            }
            else
            {
                GenericVisitor.VisitEnumMemberChildren(this, visitor);
            }
        }
    }
}
