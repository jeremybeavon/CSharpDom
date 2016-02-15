using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class ParameterWrapper<TAttributeGroup, TTypeReference> :
        AbstractParameter<TAttributeGroup, TTypeReference>,
        IWrapper<IParameter<TAttributeGroup, TTypeReference>>
        where TAttributeGroup : IAttributeGroup
        where TTypeReference : ITypeReference
    {
        public ParameterWrapper(IParameter<TAttributeGroup, TTypeReference> parameter)
        {
            WrappedObject = parameter;
        }

        public override IReadOnlyCollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
        }

        public override string Name
        {
            get { return WrappedObject.Name; }
        }

        public override TTypeReference ParameterType
        {
            get { return WrappedObject.ParameterType; }
        }

        public IParameter<TAttributeGroup, TTypeReference> WrappedObject { get; private set; }
    }
}
