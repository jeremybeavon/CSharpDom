using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StaticClassEventProperty :
        IStaticClassEventProperty<AttributeGroup, IStaticType, DelegateReference, MethodBody>
    {
        public StaticClassEventProperty()
        {
            Attributes = new List<AttributeGroup>();
        }

        public MethodBody AddBody { get; set; }

        public List<AttributeGroup> Attributes { get; set; }

        public IStaticType DeclaringType
        {
            get { return null; }
        }

        public DelegateReference EventType { get; set; }

        public string Name { get; set; }

        public MethodBody RemoveBody { get; set; }

        public StaticClassMemberVisibilityModifier InheritanceModifier { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassEventProperty(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitEventPropertyChildren(this, visitor);
        }
    }
}
