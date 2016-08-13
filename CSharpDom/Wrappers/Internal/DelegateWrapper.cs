using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class DelegateWrapper : AbstractWrapper<IDelegate>, IDelegateWrapper
    {
        public DelegateWrapper(IDelegate @delegate)
            : base(@delegate)
        {
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IDocumentWrapper Document
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

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public INamespaceWrapper Namespace
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyList<IDelegateParameterWrapper> Parameters
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IProjectWrapper Project
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

        public ISolutionWrapper Solution
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public TypeVisibilityModifier Visibility
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

        public override void VisitDelegate<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter>(
            IDelegate<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter> @delegate)
        {
        }
    }
}
