using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class Property : IProperty<AttributeGroup, IBasicType, TypeReference, Accessor>
    {
        public Property()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IBasicType DeclaringType
        {
            get { return null; }
        }

        public Accessor GetAccessor { get; set; }

        public MemberInheritanceModifier InheritanceModifier { get; set; }

        public string Name { get; set; }

        public TypeReference PropertyType { get; set; }

        public Accessor SetAccessor { get; set; }

        public MemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitProperty(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitPropertyChildren(this, visitor);
        }
    }
}
