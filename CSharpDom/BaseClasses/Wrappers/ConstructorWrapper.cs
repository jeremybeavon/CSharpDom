using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class ConstructorWrapper<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> :
        AbstractConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>,
        IWrapper<IConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TParameter : IParameter
        where TMethodBody : IMethodBody
    {
        public ConstructorWrapper(IConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
        {
            WrappedObject = constructor;
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

        public override IReadOnlyList<TParameter> Parameters
        {
            get { return WrappedObject.Parameters; }
        }

        public IConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> WrappedObject { get; private set; }
    }
}
