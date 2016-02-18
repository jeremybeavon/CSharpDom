using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StructEventProperty : IStructEventProperty<AttributeGroup, IStructType, DelegateReference, MethodBody>
    {
        public StructEventProperty()
        {
            Attributes = new List<AttributeGroup>();
            AddAttributes = new List<AttributeGroup>();
            RemoveAttributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> AddAttributes { get; set; }

        public MethodBody AddBody { get; set; }

        public List<AttributeGroup> Attributes { get; set; }

        public IStructType DeclaringType
        {
            get { return null; }
        }

        public DelegateReference EventType { get; set; }

        public string Name { get; set; }

        public List<AttributeGroup> RemoveAttributes { get; set; }

        public MethodBody RemoveBody { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasEventPropertyBodyAttributes<AttributeGroup>.AddAttributes
        {
            get { return AddAttributes; }
        }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyCollection<AttributeGroup> IHasEventPropertyBodyAttributes<AttributeGroup>.RemoveAttributes
        {
            get { return RemoveAttributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructEventProperty(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitEventPropertyChildren(this, visitor);
        }
    }
}
