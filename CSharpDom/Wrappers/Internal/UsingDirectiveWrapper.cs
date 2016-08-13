using System;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class UsingDirectiveWrapper : AbstractWrapper<IUsingDirective>, IUsingDirectiveWrapper
    {
        private Func<string> name;

        public UsingDirectiveWrapper(IUsingDirective usingDirective)
            : base(usingDirective)
        {
        }

        public string Name
        {
            get { return name(); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitUsingDirective(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }

        public override void VisitUsingDirective(IUsingDirective usingDirective)
        {
            name = () => usingDirective.Name;
        }
    }
}
