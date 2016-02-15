using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractAsyncVoidClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody> :
        AbstractAsyncVoidMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>,
        IAsyncVoidClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TGenericParameter : IGenericParameterDeclaration
        where TParameter : IMethodParameter
        where TMethodBody : IMethodBody
    {
        public abstract ClassMemberInheritanceModifier InheritanceModifier { get; }

        public abstract ClassMemberVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAsyncVoidClassMethod(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAsyncVoidClassMethodChildren(this, visitor);
        }
    }
}
