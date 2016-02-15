using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StructIndexer : IStructIndexer<AttributeGroup, IStructType, TypeReference, IndexerParameter, StructAccessor>
    {
        public StructIndexer()
        {
            Attributes = new List<AttributeGroup>();
            Parameters = new List<IndexerParameter>();
        }
        
        public List<AttributeGroup> Attributes { get; set; }

        public IStructType DeclaringType
        {
            get { return null; }
        }

        public StructAccessor GetAccessor { get; set; }

        public TypeReference IndexerType { get; set; }
        
        public List<IndexerParameter> Parameters { get; set; }

        public StructAccessor SetAccessor { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyList<IndexerParameter> IHasParameters<IndexerParameter>.Parameters
        {
            get { return Parameters; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructIndexer(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitIndexerChildren(this, visitor);
        }
    }
}
