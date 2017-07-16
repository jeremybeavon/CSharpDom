using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructReferenceWrapper : AbstractWrapper<IStructReference>, IStructReferenceWrapper
    {
        private Func<IReadOnlyList<ITypeReferenceWrapper>> genericParameters;
        private Func<string> name;

        public StructReferenceWrapper(IStructReference structReference)
            : base(structReference)
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
            visitor.VisitStructReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructReferenceChildren(this, visitor);
        }

        public override void VisitStructReference<TGenericParameter>(IStructReference<TGenericParameter> structReference)
        {
            genericParameters = () => new ReadOnlyListWrapper<TGenericParameter, ITypeReferenceWrapper>(
                structReference.GenericParameters,
                input => TypeReferenceWrapper.Create(input));
            name = () => structReference.Name;
        }
    }
}
