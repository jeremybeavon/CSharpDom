using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StructConstructor : IStructConstructor<AttributeGroup, IStructType, ConstructorParameter, MethodBody>
    {
        private IStructType declaringType;

        public StructConstructor()
        {
            Attributes = new List<AttributeGroup>();
            Parameters = new List<ConstructorParameter>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public MethodBody Body { get; set; }

        public IStructType DeclaringType
        {
            get { return declaringType; }
        }

        public List<ConstructorParameter> Parameters { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyList<ConstructorParameter> IHasParameters<ConstructorParameter>.Parameters
        {
            get { return Parameters; }
        }

        public void AttachDeclaringType(IStructType @struct)
        {
            declaringType = @struct;
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructConstructor(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructConstructorChildren(this, visitor);
        }
    }
}
