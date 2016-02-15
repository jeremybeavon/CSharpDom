using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class AbstractIndexer :
        IAbstractIndexer<AttributeGroup, IAbstractType, TypeReference, IndexerParameter, AbstractAccessor>
    {
        public AbstractIndexer()
        {
            Attributes = new List<AttributeGroup>();
            Parameters = new List<IndexerParameter>();
        }
        
        public List<AttributeGroup> Attributes { get; set; }

        public IAbstractType DeclaringType
        {
            get { return null; }
        }

        public AbstractAccessor GetAccessor { get; set; }

        public TypeReference IndexerType { get; set; }
        
        public List<IndexerParameter> Parameters { get; set; }

        public AbstractAccessor SetAccessor { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

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
            visitor.VisitAbstractIndexer(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitIndexerChildren(this, visitor);
        }
    }
}
