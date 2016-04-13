using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class NestedDestructor : INestedDestructor<AttributeGroup, INestedClass, MethodBody>
    {
        private INestedClass declaringType;

        public NestedDestructor()
        {
            Attributes = new List<AttributeGroup>();
        }
        
        public List<AttributeGroup> Attributes { get; set; }

        public MethodBody Body { get; set; }

        public INestedClass DeclaringType
        {
            get { return declaringType; }
        }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void AttachDeclaringType(INestedClass @class)
        {
            declaringType = @class;
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedDestructor(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedDestructorChildren(this, visitor);
        }
    }
}
