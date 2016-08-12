using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class AbstractClassMethodCollectionWrapper :
        AbstractWrapper<IAbstractClassMethodCollection>
    {
        public AbstractClassMethodCollectionWrapper(IAbstractClassMethodCollection methodCollection)
            : base(methodCollection)
        {
        }

        public override void VisitAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>(
            IAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod> methodCollection)
        {
            Value = new AbstractClassMethodCollection()
            {
                Methods = methodCollection.ToList(method => new ClassMethodWrapper(method).Value),
                AbstractMethods = methodCollection.AbstractMethods.ToList(method => new AbstractMethodWrapper(method).Value),
                ExplicitInterfaceMethods = methodCollection.ExplicitInterfaceMethods.ToList(method => new ExplicitInterfaceMethodWrapper(method).Value)
            };
        }
    }
}
