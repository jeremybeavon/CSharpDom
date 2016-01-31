using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class UsingDirectiveFactory : AbstractFactory<IUsingDirective, UsingDirective>
    {
        public UsingDirectiveFactory(IUsingDirective usingDirective)
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
