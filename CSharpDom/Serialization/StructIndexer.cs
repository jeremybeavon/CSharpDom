using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StructIndexer : IStructIndexer<AttributeGroup, IType, TypeReference, Parameter, StructAccessor>
    {
        public StructIndexer()
        {
            Attributes = new List<AttributeGroup>();
            Parameters = new List<Parameter>();
        }
        
        public List<AttributeGroup> Attributes { get; set; }

        public IType DeclaringType
        {
            get { return null; }
        }

        public StructAccessor GetAccessor { get; set; }

        public TypeReference IndexerType { get; set; }
        
        public List<Parameter> Parameters { get; set; }

        public StructAccessor SetAccessor { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

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
            visitor.VisitStructIndexer(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitIndexerChildren(this, visitor);
        }
    }
}
