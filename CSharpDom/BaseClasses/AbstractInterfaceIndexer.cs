using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter> :
        AbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter>,
        IInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
        where TParameter : IParameter
    {
        public abstract bool HasGet { get; }

        public abstract bool HasSet { get; }

        public abstract InterfaceMemberInheritanceModifier InheritanceModifier { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitInterfaceIndexer(this);
        }
    }
}
