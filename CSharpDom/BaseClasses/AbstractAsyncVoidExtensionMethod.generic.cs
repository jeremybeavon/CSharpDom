using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractAsyncVoidExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TExtensionParameter, TParameter, TMethodBody> :
        AbstractAsyncVoidMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>,
        IAsyncVoidExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TExtensionParameter, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticClass
        where TGenericParameter : IGenericParameterDeclaration
        where TExtensionParameter : IExtensionParameter
        where TParameter : IMethodParameter
        where TMethodBody : IMethodBody
    {
        public abstract TExtensionParameter ExtensionParameter { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAsyncVoidExtensionMethod(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAsyncVoidExtensionMethodChildren(this, visitor);
        }
    }
}
