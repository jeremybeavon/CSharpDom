using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class AbstractProperty : IAbstractProperty<AttributeGroup, IAbstractType, TypeReference, AbstractAccessor>
    {
        public AbstractProperty()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IAbstractType DeclaringType
        {
            get { return null; }
        }

        public AbstractAccessor GetAccessor { get; set; }
        
        public string Name { get; set; }

        public TypeReference PropertyType { get; set; }

        public AbstractAccessor SetAccessor { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractProperty(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitPropertyChildren(this, visitor);
        }
    }
}
