using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class InterfaceCollectionWrapper : AbstractWrapper<IInterfaceCollection>
    {
        public InterfaceCollectionWrapper(IInterfaceCollection field)
            : base(field)
        {
        }

        public override void VisitInterfaceCollection<TInterface, TPartialInterface>(
            IInterfaceCollection<TInterface, TPartialInterface> interfaceCollection)
        {
            Value = new InterfaceCollection()
            {
                Interfaces = interfaceCollection.ToList(@class => new InterfaceWrapper(@class).Value)
            };
        }
    }
}
