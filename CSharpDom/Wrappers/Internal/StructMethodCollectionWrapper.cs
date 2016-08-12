using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class StructMethodCollectionWrapper :
        AbstractWrapper<IStructMethodCollection>
    {
        public StructMethodCollectionWrapper(IStructMethodCollection methodCollection)
            : base(methodCollection)
        {
        }

        public override void VisitStructMethodCollection<TMethod, TExplicitInterfaceMethod>(
            IStructMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
        {
            Value = new StructMethodCollection()
            {
                Methods = methodCollection.ToList(method => new StructMethodWrapper(method).Value),
                ExplicitInterfaceMethods = methodCollection.ExplicitInterfaceMethods.ToList(method => new ExplicitInterfaceMethodWrapper(method).Value)
            };
        }
    }
}
