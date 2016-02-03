using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class NestedDestructor : INestedDestructor<AttributeGroup, INestedClass, MethodBody>
    {
        public IReadOnlyCollection<AttributeGroup> Attributes { get; set; }

        public MethodBody Body { get; set; }

        public INestedClass DeclaringType
        {
            get { return null; }
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
