using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class Destructor : IDestructor<AttributeGroup, IClass, MethodBody>
    {
        public Destructor()
        {
            Attributes = new List<AttributeGroup>();
        }
        
        public List<AttributeGroup> Attributes { get; set; }

        public MethodBody Body { get; set; }

        public IClass DeclaringType
        {
            get { return null; }
        }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitDestructor(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitDestructor(this, visitor);
        }
    }
}
