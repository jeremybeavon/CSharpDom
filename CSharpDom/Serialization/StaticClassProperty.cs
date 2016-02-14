using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StaticClassProperty :
        IStaticClassProperty<AttributeGroup, IStaticType, TypeReference, StaticClassAccessor>
    {
        public StaticClassProperty()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IStaticType DeclaringType
        {
            get { return null; }
        }

        public StaticClassAccessor GetAccessor { get; set; }
        
        public string Name { get; set; }

        public TypeReference PropertyType { get; set; }

        public StaticClassAccessor SetAccessor { get; set; }

        public StaticClassMemberVisibilityModifier InheritanceModifier { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassProperty(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitPropertyChildren(this, visitor);
        }
    }
}
