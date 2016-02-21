using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StaticClassNestedInterfaceCollectionFactory :
        AbstractFactory<IStaticClassNestedInterfaceCollection, StaticClassNestedInterfaceCollection>
    {
        public StaticClassNestedInterfaceCollectionFactory(IStaticClassNestedInterfaceCollection collection)
            : base(collection)
        {
        }

        public override void VisitStaticClassNestedInterfaceCollection<TInterface, TPartialInterface>(
            IStaticClassNestedInterfaceCollection<TInterface, TPartialInterface> interfaceCollection)
        {
            Value = new StaticClassNestedInterfaceCollection()
            {
                Interfaces = interfaceCollection.ToList(@interface => new StaticClassNestedInterfaceFactory(@interface).Value)
            };
        }
    }
}
