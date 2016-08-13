using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class OperatorOverloadWrapper : AbstractWrapper<IOperatorOverload>, IOperatorOverloadWrapper
    {
        public OperatorOverloadWrapper(IOperatorOverload operatorOverload)
            : base(operatorOverload)
        {
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IMethodBodyWrapper Body
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ITypeWrapper DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public OperatorOverloadType OperatorType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyList<IOperatorParameterWrapper> Parameters
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ITypeReferenceWrapper ReturnType
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

        public override void VisitOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> operatorOverload)
        {
        }
    }
}
