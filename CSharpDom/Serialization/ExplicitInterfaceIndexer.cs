using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class ExplicitInterfaceIndexer :
        IExplicitInterfaceIndexer<AttributeGroup, IType, InterfaceReference, TypeReference, IndexerParameter, Accessor>
    {
        public ExplicitInterfaceIndexer()
        {
            Attributes = new List<AttributeGroup>();
            Parameters = new List<IndexerParameter>();
        }
        
        public List<AttributeGroup> Attributes { get; set; }

        public IType DeclaringType
        {
            get { return null; }
        }

        public InterfaceReference ExplicitInterface { get; set; }

        public Accessor GetAccessor { get; set; }

        public TypeReference IndexerType { get; set; }
        
        public List<IndexerParameter> Parameters { get; set; }

        public Accessor SetAccessor { get; set; }
        
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
            visitor.VisitExplicitInterfaceIndexer(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitIndexerChildren(this, visitor);
        }
    }
}
