using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class OperatorOverload : IOperatorOverload<AttributeGroup, IType, TypeReference, OperatorParameter, MethodBody>
    {
        public OperatorOverload()
        {
            Attributes = new List<AttributeGroup>();
            Parameters = new List<OperatorParameter>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public MethodBody Body { get; set; }

        public IType DeclaringType
        {
            get { return null; }
        }

        public OperatorOverloadType OperatorType { get; set; }

        public List<OperatorParameter> Parameters { get; set; }

        public TypeReference ReturnType { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyList<OperatorParameter> IHasParameters<OperatorParameter>.Parameters
        {
            get { return Parameters; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitOperatorOverload(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitOperatorOverloadChildren(this, visitor);
        }
    }
}
