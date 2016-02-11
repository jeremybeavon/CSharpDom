using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class ClassMethodCollectionFactory :
        AbstractFactory<IClassMethodCollection, ClassMethodCollection>
    {
        public ClassMethodCollectionFactory(IClassMethodCollection methodCollection)
            : base(methodCollection)
        {
        }

        public override void VisitClassMethodCollection<TMethod, TExplicitInterfaceMethod>(
            IClassMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
        {
            Value = new ClassMethodCollection()
            {
                Methods = methodCollection.ToList(method => new ClassMethodFactory(method).Value),
                ExplicitInterfaceMethods = methodCollection.ExplicitInterfaceMethods.ToList(method => new ExplicitInterfaceMethodFactory(method).Value)
            };
        }
    }
}
