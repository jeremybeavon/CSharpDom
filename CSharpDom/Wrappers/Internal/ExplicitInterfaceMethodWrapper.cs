using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ExplicitInterfaceMethodWrapper : AbstractWrapper<IExplicitInterfaceMethod>, IExplicitInterfaceMethodWrapper
    {
        public ExplicitInterfaceMethodWrapper(IExplicitInterfaceMethod method)
            : base(method)
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

        public IInterfaceReferenceWrapper ExplicitInterface
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyList<IGenericParameterDeclarationWrapper> GenericParameters
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsAsync
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

        public IReadOnlyList<IMethodParameterWrapper> Parameters
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

        public override void VisitExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
        }
    }
}
