using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassNestedInterfaceCollectionWrapper :
        AbstractWrapper<IStaticClassNestedInterfaceCollection>
    {
        public StaticClassNestedInterfaceCollectionWrapper(IStaticClassNestedInterfaceCollection collection)
            : base(collection)
        {
        }

        public override void VisitStaticClassNestedInterfaceCollection<TInterface, TPartialInterface>(
            IStaticClassNestedInterfaceCollection<TInterface, TPartialInterface> interfaceCollection)
        {
            Value = new StaticClassNestedInterfaceCollection()
            {
                Interfaces = interfaceCollection.ToList(@interface => new StaticClassNestedInterfaceWrapper(@interface).Value)
            };
        }
    }
}
