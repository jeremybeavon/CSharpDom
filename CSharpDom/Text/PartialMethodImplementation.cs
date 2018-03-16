using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Text
{
    internal sealed class PartialMethodImplementation<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody> :
        AbstractMethod<TAttributeGroup, TDeclaringType, TGenericParameter, PartialMethodReturnType, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TGenericParameter : IGenericParameterDeclaration
        where TParameter : IMethodParameter
        where TMethodBody : IMethodBody
    {
        private readonly IPartialMethodImplementation<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody> method;

        public PartialMethodImplementation(IPartialMethodImplementation<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody> method)
        {
            this.method = method;
        }

        public override TMethodBody Body => method.Body;

        public override bool IsAsync => false;

        public override IReadOnlyCollection<TAttributeGroup> Attributes => method.Attributes;

        public override TDeclaringType DeclaringType => method.DeclaringType;

        public override IReadOnlyList<TGenericParameter> GenericParameters => method.GenericParameters;

        public override string Name => method.Name;

        public override IReadOnlyList<TParameter> Parameters => method.Parameters;

        public override IReadOnlyCollection<TAttributeGroup> ReturnAttributes => method.ReturnAttributes;

        public override PartialMethodReturnType ReturnType => PartialMethodReturnType.Instance;
    }
}
