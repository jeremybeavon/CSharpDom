using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class ClassMethodCollectionWrapper :
        AbstractWrapper<IClassMethodCollection>
    {
        public ClassMethodCollectionWrapper(IClassMethodCollection methodCollection)
            : base(methodCollection)
        {
        }

        public override void VisitClassMethodCollection<TMethod, TExplicitInterfaceMethod>(
            IClassMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
        {
            Value = new ClassMethodCollection()
            {
                Methods = methodCollection.ToList(method => new ClassMethodWrapper(method).Value),
                ExplicitInterfaceMethods = methodCollection.ExplicitInterfaceMethods.ToList(method => new ExplicitInterfaceMethodWrapper(method).Value)
            };
        }
    }
}
