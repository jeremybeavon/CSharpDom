using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ExtensionParameterWrapper : AbstractWrapper<IParameter>, IExtensionParameterWrapper
    {
        public ExtensionParameterWrapper(IParameter parameter)
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

        public override void VisitExtensionParameter<TAttributeGroup, TTypeReference>(
            IExtensionParameter<TAttributeGroup, TTypeReference> parameter)
        {
        }
    }
}
