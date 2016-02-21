using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassNestedInterfaceCollectionFactory : AbstractFactory<IClassNestedInterfaceCollection, ClassNestedInterfaceCollection>
    {
        public ClassNestedInterfaceCollectionFactory(IClassNestedInterfaceCollection collection)
            : base(collection)
        {
        }

        public override void VisitClassNestedInterfaceCollection<TInterface, TPartialInterface>(
            IClassNestedInterfaceCollection<TInterface, TPartialInterface> interfaceCollection)
        {
            Value = new ClassNestedInterfaceCollection()
            {
                Interfaces = interfaceCollection.ToList(@interface => new ClassNestedInterfaceFactory(@interface).Value)
            };
        }
    }
}
