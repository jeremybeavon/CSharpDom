using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class IndexerParameter : IIndexerParameter<AttributeGroup, TypeReference>
    {
        public IndexerParameter()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IndexerParameterModifier Modifier { get; set; }

        public string Name { get; set; }

        public TypeReference ParameterType { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitIndexerParameter(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitIndexerParameterChildren(this, visitor);
        }
    }
}
