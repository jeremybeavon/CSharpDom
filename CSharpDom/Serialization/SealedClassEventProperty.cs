using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class SealedClassEventProperty :
        ISealedClassEventProperty<AttributeGroup, ISealedType, DelegateReference, MethodBody>
    {
        public SealedClassEventProperty()
        {
            Attributes = new List<AttributeGroup>();
        }

        public MethodBody AddBody { get; set; }

        public List<AttributeGroup> Attributes { get; set; }

        public ISealedType DeclaringType
        {
            get { return null; }
        }

        public DelegateReference EventType { get; set; }
        
        public string Name { get; set; }

        public MethodBody RemoveBody { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitSealedClassEventProperty(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitEventPropertyChildren(this, visitor);
        }
    }
}
