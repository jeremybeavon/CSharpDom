using CSharpDom.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class NestedDelegateWrapper<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> :
        AbstractNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>,
        IWrapper<INestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IDelegateParameter
    {
        public NestedDelegateWrapper(INestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
        {
            WrappedObject = nestedDelegate;
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

        public INestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> WrappedObject { get; private set; }
    }
}
