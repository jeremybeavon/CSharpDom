using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class StaticClassMethodCollectionFactory :
        AbstractFactory<IStaticClassMethodCollection, StaticClassMethodCollection>
    {
        public StaticClassMethodCollectionFactory(IStaticClassMethodCollection methodCollection)
            : base(methodCollection)
        {
        }

        public override void VisitStaticClassMethodCollection<TMethod, TExtensionMethod>(
            IStaticClassMethodCollection<TMethod, TExtensionMethod> methodCollection)
        {
            Value = new StaticClassMethodCollection()
            {
                Methods = methodCollection.ToList(method => new StaticClassMethodFactory(method).Value),
                ExtensionMethods = methodCollection.ExtensionMethods.ToList(method => new ExtensionMethodFactory(method).Value)
            };
        }
    }
}
