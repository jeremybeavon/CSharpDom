using System;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class EnumReferenceWrapper : AbstractWrapper<IEnumReference>, IEnumReferenceWrapper
    {
        private Func<string> name;

        public EnumReferenceWrapper(IEnumReference enumReference)
            : base(enumReference)
        {
        }

        public string Name
        {
            get { return name(); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitEnumReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }

        public override void VisitEnumReference(IEnumReference enumReference)
        {
            name = () => enumReference.Name;
        }
    }
}
