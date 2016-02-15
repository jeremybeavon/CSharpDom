using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class DelegateParameter : IDelegateParameter<AttributeGroup, TypeReference>
    {
        public DelegateParameter()
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
            visitor.VisitDelegateParameter(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitDelegateParameterChildren(this, visitor);
        }
    }
}
