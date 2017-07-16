using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class Destructor : IDestructor<AttributeGroup, IClassType, MethodBody>
    {
        private IClassType declaringType;

        public Destructor()
        {
            Attributes = new List<AttributeGroup>();
            Body = new MethodBody();
        }
        
        public List<AttributeGroup> Attributes { get; set; }

        public MethodBody Body { get; set; }

        public IClassType DeclaringType
        {
            get { return declaringType; }
        }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void AttachDeclaringType(IClassType @class)
        {
            declaringType = @class;
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
