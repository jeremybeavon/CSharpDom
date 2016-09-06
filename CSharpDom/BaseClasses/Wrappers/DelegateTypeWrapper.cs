using CSharpDom.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class DelegateTypeWrapper<TAttributeGroup, TGenericParameter, TTypeReference, TParameter> :
        AbstractDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter>,
        IWrapper<IDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter>>
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IDelegateParameter
    {
        public DelegateTypeWrapper(IDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter> delegateType)
        {
            WrappedObject = delegateType;
        }

        public override IReadOnlyCollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
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

        public IDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter> WrappedObject { get; private set; }
    }
}
