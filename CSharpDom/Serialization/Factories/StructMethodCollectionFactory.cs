using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class StructMethodCollectionFactory :
        AbstractFactory<IStructMethodCollection, StructMethodCollection>
    {
        public StructMethodCollectionFactory(IStructMethodCollection methodCollection)
            : base(methodCollection)
        {
        }

        public override void VisitStructMethodCollection<TMethod, TExplicitInterfaceMethod>(
            IStructMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
        {
            Value = new StructMethodCollection()
            {
                Methods = methodCollection.ToList(method => new StructMethodFactory(method).Value),
                ExplicitInterfaceMethods = methodCollection.ExplicitInterfaceMethods.ToList(method => new ExplicitInterfaceMethodFactory(method).Value)
            };
        }
    }
}
