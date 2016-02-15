using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class AsyncVoidMethodWrapper<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody> :
        AbstractAsyncVoidMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>,
        IWrapper<IAsyncVoidMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TGenericParameter : IGenericParameterDeclaration
        where TParameter : IMethodParameter
        where TMethodBody : IMethodBody
    {
        public AsyncVoidMethodWrapper(IAsyncVoidMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody> method)
        {
            WrappedObject = method;
        }

        public override IReadOnlyCollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
        }

        public override TMethodBody Body
        {
            get { return WrappedObject.Body; }
        }

        public override TDeclaringType DeclaringType
        {
            get { return WrappedObject.DeclaringType; }
        }

        public override IReadOnlyList<TGenericParameter> GenericParameters
        {
            get { return WrappedObject.GenericParameters; }
        }

        public override string Name
        {
            get { return WrappedObject.Name; }
        }

        public override IReadOnlyList<TParameter> Parameters
        {
            get { return WrappedObject.Parameters; }
        }
        
        public IAsyncVoidMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody> WrappedObject { get; private set; }
    }
}
