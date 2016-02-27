using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class MethodWrapper<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> :
        AbstractMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>,
        IWrapper<IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IMethodParameter
    {
        public MethodWrapper(IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
        {
            WrappedObject = method;
        }

        public override IReadOnlyCollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
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

        public override TTypeReference ReturnType
        {
            get { return WrappedObject.ReturnType; }
        }

        public IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> WrappedObject { get; private set; }
    }
}
