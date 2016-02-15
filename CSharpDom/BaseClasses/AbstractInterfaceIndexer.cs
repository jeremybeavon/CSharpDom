using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> :
        AbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>,
        IInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
        where TParameter : IIndexerParameter
        where TAccessor : IInterfaceAccessor
    {
        public abstract InterfaceMemberInheritanceModifier InheritanceModifier { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitInterfaceIndexer(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            base.Accept(visitor);
        }
    }
}
