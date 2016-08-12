using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class DelegateReferenceWrapper : AbstractWrapper<IDelegateReference>, IDelegateReferenceWrapper
    {
        private Func<IReadOnlyList<IGenericParameterWrapper>> genericParameters;
        private Func<string> name;

        public DelegateReferenceWrapper(IDelegateReference delegateReference)
            : base(delegateReference)
        {
        }

        public IReadOnlyList<IGenericParameterWrapper> GenericParameters
        {
            get { return genericParameters(); }
        }

        public string Name
        {
            get { return name(); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitDelegateReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitDelegateReferenceChildren(this, visitor);
        }

        public override void VisitDelegateReference<TGenericParameter>(IDelegateReference<TGenericParameter> delegateReference)
        {
            genericParameters = () => new ReadOnlyListWrapper<TGenericParameter, IGenericParameterWrapper>(
                delegateReference.GenericParameters,
                input => new GenericParameterWrapper(input));
            name = () => delegateReference.Name;
        }
    }
}
