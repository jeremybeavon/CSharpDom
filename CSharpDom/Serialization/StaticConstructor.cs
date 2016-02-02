using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StaticConstructor : IStaticConstructor<AttributeGroup, IType, MethodBody>
    {
        public StaticConstructor()
        {
            Attributes = new List<AttributeGroup>();
        }
        
        public List<AttributeGroup> Attributes { get; set; }

        public MethodBody Body { get; set; }

        public IType DeclaringType
        {
            get { return null; }
        }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticConstructor(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticConstructorChildren(this, visitor);
        }
    }
}
