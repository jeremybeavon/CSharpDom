using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class ClassEvent : IClassEvent<AttributeGroup, IClassType, DelegateReference>
    {
        public ClassEvent()
        {
            Attributes = new List<AttributeGroup>();
            FieldAttributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IClassType DeclaringType
        {
            get { return null; }
        }

        public DelegateReference EventType { get; set; }

        public List<AttributeGroup> FieldAttributes { get; set; }

        public ClassMemberInheritanceModifier InheritanceModifier { get; set; }

        public string Name { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyCollection<AttributeGroup> IHasFieldAttributes<AttributeGroup>.FieldAttributes
        {
            get { return FieldAttributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassEvent(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitEventChildren(this, visitor);
        }
    }
}
