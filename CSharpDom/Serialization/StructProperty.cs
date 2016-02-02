using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StructProperty : IStructProperty<AttributeGroup, IType, TypeReference, StructAccessor>
    {
        public StructProperty()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IType DeclaringType
        {
            get { return null; }
        }

        public StructAccessor GetAccessor { get; set; }

        public string Name { get; set; }

        public TypeReference PropertyType { get; set; }

        public StructAccessor SetAccessor { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructProperty(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitPropertyChildren(this, visitor);
        }
    }
}
