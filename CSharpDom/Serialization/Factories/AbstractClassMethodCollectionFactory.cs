using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class AbstractClassMethodCollectionFactory :
        AbstractFactory<IAbstractClassMethodCollection, AbstractClassMethodCollection>
    {
        public AbstractClassMethodCollectionFactory(IAbstractClassMethodCollection methodCollection)
            : base(methodCollection)
        {
        }

        public override void VisitAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>(
            IAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod> methodCollection)
        {
            Value = new AbstractClassMethodCollection()
            {
                Methods = methodCollection.ToList(method => new ClassMethodFactory(method).Value),
                AbstractMethods = methodCollection.AbstractMethods.ToList(method => new AbstractMethodFactory(method).Value),
                ExplicitInterfaceMethods = methodCollection.ExplicitInterfaceMethods.ToList(method => new ExplicitInterfaceMethodFactory(method).Value)
            };
        }
    }
}
