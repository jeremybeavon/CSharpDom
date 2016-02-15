using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class SealedClassIndexer :
        ISealedClassIndexer<AttributeGroup, ISealedType, TypeReference, IndexerParameter, ClassAccessor>
    {
        public SealedClassIndexer()
        {
            Attributes = new List<AttributeGroup>();
            Parameters = new List<IndexerParameter>();
        }
        
        public List<AttributeGroup> Attributes { get; set; }

        public ISealedType DeclaringType
        {
            get { return null; }
        }

        public ClassAccessor GetAccessor { get; set; }

        public TypeReference IndexerType { get; set; }

        public SealedClassMemberInheritanceModifier InheritanceModifier { get; set; }

        public List<IndexerParameter> Parameters { get; set; }

        public ClassAccessor SetAccessor { get; set; }

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
            visitor.VisitSealedClassIndexer(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitIndexerChildren(this, visitor);
        }
    }
}
