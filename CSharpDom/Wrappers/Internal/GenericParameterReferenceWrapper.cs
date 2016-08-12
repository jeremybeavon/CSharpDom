using System;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class GenericParameterReferenceWrapper : AbstractWrapper<IGenericParameterReference>, IGenericParameterReferenceWrapper
    {
        private Func<string> name;

        public GenericParameterReferenceWrapper(IGenericParameterReference genericParameterReference)
            : base(genericParameterReference)
        {
        }

        public string Name
        {
            get { return name(); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitGenericParameterReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }

        public override void VisitGenericParameterReference(IGenericParameterReference genericParameterReference)
        {
            name = () => genericParameterReference.Name;
        }
    }
}
