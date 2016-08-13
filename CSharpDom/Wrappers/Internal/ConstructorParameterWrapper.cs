using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ConstructorParameterWrapper : AbstractWrapper<IParameter>, IConstructorParameterWrapper
    {
        public ConstructorParameterWrapper(IParameter parameter)
            : base(parameter)
        {
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ParameterModifier Modifier
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ITypeReferenceWrapper ParameterType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Accept(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public override void VisitConstructorParameter<TAttributeGroup, TTypeReference>(
            IConstructorParameter<TAttributeGroup, TTypeReference> parameter)
        {
        }
    }
}
