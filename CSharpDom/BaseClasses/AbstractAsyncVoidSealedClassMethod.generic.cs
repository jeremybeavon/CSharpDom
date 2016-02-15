using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractAsyncVoidSealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody> :
        AbstractAsyncVoidMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>,
        IAsyncVoidSealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TGenericParameter : IGenericParameterDeclaration
        where TParameter : IMethodParameter
        where TMethodBody : IMethodBody
    {
        public abstract SealedClassMemberInheritanceModifier InheritanceModifier { get; }

        public abstract ClassMemberVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAsyncVoidSealedClassMethod(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAsyncVoidSealedClassMethodChildren(this, visitor);
        }
    }
}
