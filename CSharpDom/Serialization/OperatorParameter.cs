using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class OperatorParameter : IOperatorParameter<AttributeGroup, TypeReference>
    {
        public OperatorParameter()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public ParameterModifier Modifier { get; set; }

        public string Name { get; set; }

        public TypeReference ParameterType { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitOperatorParameter(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitOperatorParameterChildren(this, visitor);
        }
    }
}
