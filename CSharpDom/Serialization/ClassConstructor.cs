using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class ClassConstructor : IClassConstructor<AttributeGroup, IClassType, ConstructorParameter, MethodBody>
    {
        private IClassType declaringType;

        public ClassConstructor()
        {
            Attributes = new List<AttributeGroup>();
            Parameters = new List<ConstructorParameter>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public MethodBody Body { get; set; }

        public IClassType DeclaringType
        {
            get { return declaringType; }
        }

        public List<ConstructorParameter> Parameters { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyList<ConstructorParameter> IHasParameters<ConstructorParameter>.Parameters
        {
            get { return Parameters; }
        }

        public void AttachDeclaringType(IClassType @class)
        {
            declaringType = @class;
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassConstructor(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassConstructorChildren(this, visitor);
        }
    }
}
