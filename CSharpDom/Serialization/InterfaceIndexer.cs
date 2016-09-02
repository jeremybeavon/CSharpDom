using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class InterfaceIndexer :
        IInterfaceIndexer<AttributeGroup, IInterfaceType, TypeReference, IndexerParameter, InterfaceAccessor>
    {
        public InterfaceIndexer()
        {
            Attributes = new List<AttributeGroup>();
            Parameters = new List<IndexerParameter>();
        }
        
        public List<AttributeGroup> Attributes { get; set; }

        public IInterfaceType DeclaringType
        {
            get { return null; }
        }

        public InterfaceAccessor GetAccessor { get; set; }

        public TypeReference IndexerType { get; set; }

        public InterfaceMemberInheritanceModifier InheritanceModifier { get; set; }

        public List<IndexerParameter> Parameters { get; set; }

        public InterfaceAccessor SetAccessor { get; set; }

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
            visitor.VisitInterfaceIndexer(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitIndexerChildren(this, visitor);
        }
    }
}
