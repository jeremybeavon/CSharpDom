using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassNestedInterfaceCollectionWrapper : AbstractWrapper<IClassNestedInterfaceCollection>
    {
        public ClassNestedInterfaceCollectionWrapper(IClassNestedInterfaceCollection collection)
            : base(collection)
        {
        }

        public override void VisitClassNestedInterfaceCollection<TInterface, TPartialInterface>(
            IClassNestedInterfaceCollection<TInterface, TPartialInterface> interfaceCollection)
        {
            Value = new ClassNestedInterfaceCollection()
            {
                Interfaces = interfaceCollection.ToList(@interface => new ClassNestedInterfaceWrapper(@interface).Value)
            };
        }
    }
}
