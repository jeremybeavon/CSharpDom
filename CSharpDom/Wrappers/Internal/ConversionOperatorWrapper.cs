using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ConversionOperatorWrapper : AbstractWrapper<IConversionOperator>, IConversionOperatorWrapper
    {
        public ConversionOperatorWrapper(IConversionOperator conversionOperator)
            : base(conversionOperator)
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

        public ConversionOperatorType OperatorType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IOperatorParameterWrapper Parameter
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> ReturnAttributes
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

        public override void VisitConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> conversionOperator)
        {
        }
    }
}
