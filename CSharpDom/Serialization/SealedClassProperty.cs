using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class SealedClassProperty :
        ISealedClassProperty<AttributeGroup, ISealedType, TypeReference, ClassAccessor>
    {
        public SealedClassProperty()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public ISealedType DeclaringType
        {
            get { return null; }
        }

        public ClassAccessor GetAccessor { get; set; }

        public SealedClassMemberInheritanceModifier InheritanceModifier { get; set; }

        public string Name { get; set; }

        public TypeReference PropertyType { get; set; }

        public ClassAccessor SetAccessor { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitSealedClassProperty(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitPropertyChildren(this, visitor);
        }
    }
}
