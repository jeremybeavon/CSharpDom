using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class ClassIndexer : IClassIndexer<AttributeGroup, IType, TypeReference, Parameter, ClassAccessor>
    {
        public ClassIndexer()
        {
            Attributes = new List<AttributeGroup>();
            Parameters = new List<Parameter>();
        }
        
        public List<AttributeGroup> Attributes { get; set; }

        public IType DeclaringType
        {
            get { return null; }
        }

        public ClassAccessor GetAccessor { get; set; }

        public TypeReference IndexerType { get; set; }

        public ClassMemberInheritanceModifier InheritanceModifier { get; set; }

        public List<Parameter> Parameters { get; set; }

        public ClassAccessor SetAccessor { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

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
            visitor.VisitClassIndexer(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitIndexerChildren(this, visitor);
        }
    }
}
