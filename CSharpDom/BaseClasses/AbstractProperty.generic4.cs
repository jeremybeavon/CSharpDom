using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        AbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference>,
        IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TAccessor : IAccessor
    {
        public abstract TAccessor GetAccessor { get; }
     
        public abstract TAccessor SetAccessor { get; }
        
        public sealed override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitPropertyChildren(this, visitor);
        }
    }
}
