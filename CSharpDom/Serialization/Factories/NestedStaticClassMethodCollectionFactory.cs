using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class NestedStaticClassMethodCollectionFactory :
        AbstractFactory<INestedStaticClassMethodCollection, NestedStaticClassMethodCollection>
    {
        public NestedStaticClassMethodCollectionFactory(INestedStaticClassMethodCollection methodCollection)
            : base(methodCollection)
        {
        }

        public override void VisitNestedStaticClassMethodCollection<TMethod>(
            INestedStaticClassMethodCollection<TMethod> methodCollection)
        {
            Value = new NestedStaticClassMethodCollection()
            {
                Methods = methodCollection.ToList(method => new StaticClassMethodFactory(method).Value)
            };
        }
    }
}
