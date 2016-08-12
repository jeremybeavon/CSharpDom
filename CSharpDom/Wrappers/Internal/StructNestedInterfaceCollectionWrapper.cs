using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructNestedInterfaceCollectionWrapper : AbstractWrapper<IStructNestedInterfaceCollection>
    {
        public StructNestedInterfaceCollectionWrapper(IStructNestedInterfaceCollection collection)
            : base(collection)
        {
        }

        public override void VisitStructNestedInterfaceCollection<TInterface, TPartialInterface>(
            IStructNestedInterfaceCollection<TInterface, TPartialInterface> interfaceCollection)
        {
            Value = new StructNestedInterfaceCollection()
            {
                Interfaces = interfaceCollection.ToList(@interface => new StructNestedInterfaceWrapper(@interface).Value)
            };
        }
    }
}
