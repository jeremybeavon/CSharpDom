using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class UsingDirectiveWrapper : AbstractWrapper<IUsingDirective>
    {
        public UsingDirectiveWrapper(IUsingDirective usingDirective)
            : base(usingDirective)
        {
        }

        public override void VisitUsingDirective(IUsingDirective usingDirective)
        {
            Value = new UsingDirective()
            {
                Name = usingDirective.Name
            };
        }
    }
}
