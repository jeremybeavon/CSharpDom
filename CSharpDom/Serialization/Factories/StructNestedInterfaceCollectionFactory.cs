using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructNestedInterfaceCollectionFactory : AbstractFactory<IStructNestedInterfaceCollection, StructNestedInterfaceCollection>
    {
        public StructNestedInterfaceCollectionFactory(IStructNestedInterfaceCollection collection)
            : base(collection)
        {
        }

        public override void VisitStructNestedInterfaceCollection<TInterface, TPartialInterface>(
            IStructNestedInterfaceCollection<TInterface, TPartialInterface> interfaceCollection)
        {
            Value = new StructNestedInterfaceCollection()
            {
                Interfaces = interfaceCollection.ToList(@interface => new StructNestedInterfaceFactory(@interface).Value)
            };
        }
    }
}
