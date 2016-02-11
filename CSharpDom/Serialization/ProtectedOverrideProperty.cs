using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class ProtectedOverrideProperty :
        IProtectedOverrideProperty<AttributeGroup, ISealedType, TypeReference, SealedClassAccessor>
    {
        public ProtectedOverrideProperty()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public ISealedType DeclaringType
        {
            get { return null; }
        }
        
        public SealedClassAccessor GetAccessor { get; set; }
        
        public bool IsInternal { get; set; }

        public bool IsSealed { get; set; }

        public string Name { get; set; }

        public TypeReference PropertyType { get; set; }

        public SealedClassAccessor SetAccessor { get; set; }
        
        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitProtectedOverrideProperty(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitProtectedOverridePropertyChildren(this, visitor);
        }
    }
}
