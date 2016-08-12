using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassNestedInterfaceWrapper : AbstractWrapper<IStaticClassNestedInterface>
    {
        public StaticClassNestedInterfaceWrapper(IStaticClassNestedInterface @interface)
            : base(@interface)
        {
        }

        public override void VisitStaticClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IStaticClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
        {
            Value = new StaticClassNestedInterface()
            {
                Attributes = @interface.Attributes.ToAttributeListUsingWrapper(),
                Events = @interface.Events.ToList(@event => new InterfaceEventWrapper(@event).Value),
                GenericParameters = @interface.GenericParameters.ToGenericParameterDeclarationListUsingWrapper(),
                Indexers = @interface.Indexers.ToList(indexer => new InterfaceIndexerWrapper(indexer).Value),
                Interfaces = @interface.Interfaces.ToList(baseInterface => new InterfaceReferenceWrapper(baseInterface).Value),
                Methods = @interface.Methods.ToList(method => new InterfaceMethodWrapper(method).Value),
                Name = @interface.Name,
                Properties = @interface.Properties.ToList(property => new InterfacePropertyWrapper(property).Value),
                Visibility = @interface.Visibility
            };
        }
    }
}
