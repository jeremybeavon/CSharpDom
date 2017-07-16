using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class InterfaceReferenceWrapper : AbstractWrapper<IInterfaceReference>, IInterfaceReferenceWrapper
    {
        private Func<IReadOnlyList<ITypeReferenceWrapper>> genericParameters;
        private Func<string> name;

        public InterfaceReferenceWrapper(IInterfaceReference interfaceReference)
            : base(interfaceReference)
        {
        }

        public IReadOnlyList<ITypeReferenceWrapper> GenericParameters
        {
            get { return genericParameters(); }
        }

        public string Name
        {
            get { return name(); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitInterfaceReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitInterfaceReferenceChildren(this, visitor);
        }

        public override void VisitInterfaceReference<TGenericParameter>(IInterfaceReference<TGenericParameter> interfaceReference)
        {
            genericParameters = () => new ReadOnlyListWrapper<TGenericParameter, ITypeReferenceWrapper>(
                interfaceReference.GenericParameters,
                input => TypeReferenceWrapper.Create(input));
            name = () => interfaceReference.Name;
        }
    }
}
