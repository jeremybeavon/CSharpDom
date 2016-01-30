using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class Indexer : IIndexer<AttributeGroup, IBasicType, TypeReference, Parameter, Accessor>
    {
        public Indexer()
        {
            Attributes = new List<AttributeGroup>();
            Parameters = new List<Parameter>();
        }
        
        public List<AttributeGroup> Attributes { get; set; }

        public IBasicType DeclaringType
        {
            get { return null; }
        }

        public Accessor GetAccessor { get; set; }

        public TypeReference IndexerType { get; set; }

        public MemberInheritanceModifier InheritanceModifier { get; set; }

        public List<Parameter> Parameters { get; set; }

        public Accessor SetAccessor { get; set; }

        public MemberVisibilityModifier Visibility { get; set; }

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
            visitor.VisitIndexer(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitIndexerChildren(this, visitor);
        }
    }
}
