using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> :
        IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
        where TParameter : IIndexerParameter
        where TAccessor : IAccessor
    {
        public virtual IReadOnlyCollection<TAttributeGroup> Attributes { get; set; }

        public virtual TDeclaringType DeclaringType { get; set; }

        public virtual TAccessor GetAccessor { get; set; }

        public virtual TTypeReference IndexerType { get; set; }

        public virtual IReadOnlyList<TParameter> Parameters { get; set; }

        public virtual TAccessor SetAccessor { get; set; }

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitIndexer(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitIndexerChildren(this, visitor);
        }
    }
}
