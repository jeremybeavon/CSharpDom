using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class ProtectedOverrideIndexer :
        IProtectedOverrideIndexer<AttributeGroup, ISealedType, TypeReference, Parameter, SealedClassAccessor>
    {
        public ProtectedOverrideIndexer()
        {
            Attributes = new List<AttributeGroup>();
            Parameters = new List<Parameter>();
        }
        
        public List<AttributeGroup> Attributes { get; set; }

        public ISealedType DeclaringType
        {
            get { return null; }
        }
        
        public SealedClassAccessor GetAccessor { get; set; }

        public TypeReference IndexerType { get; set; }

        public bool IsInternal { get; set; }

        public bool IsSealed { get; set; }

        public List<Parameter> Parameters { get; set; }

        public SealedClassAccessor SetAccessor { get; set; }
        
        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyList<Parameter> IHasParameters<Parameter>.Parameters
        {
            get { return Parameters; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitProtectedOverrideIndexer(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitProtectedOverrideIndexerChildren(this, visitor);
        }
    }
}
