using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class InterfaceCollectionFactory : AbstractFactory<IInterfaceCollection, InterfaceCollection>
    {
        public InterfaceCollectionFactory(IInterfaceCollection field)
            : base(field)
        {
        }

        public override void VisitInterfaceCollection<TInterface, TPartialInterface>(
            IInterfaceCollection<TInterface, TPartialInterface> interfaceCollection)
        {
            Value = new InterfaceCollection()
            {
                Interfaces = interfaceCollection.ToList(@class => new InterfaceFactory(@class).Value)
            };
        }
    }
}
