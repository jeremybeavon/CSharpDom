using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class InterfaceFactory : AbstractFactory<IInterface, Interface>
    {
        public InterfaceFactory(IInterface @interface)
            : base(@interface)
        {
        }

        public override void VisitInterface<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IInterface<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
        {
            Value = new Interface()
            {
                Attributes = @interface.Attributes.ToAttributeListUsingFactory(),
                Events = @interface.Events.ToList(@event => new InterfaceEventFactory(@event).Value),
                GenericParameters = @interface.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                Indexers = @interface.Indexers.ToList(indexer => new InterfaceIndexerFactory(indexer).Value),
                Interfaces = @interface.Interfaces.ToList(baseInterface => new InterfaceReferenceFactory(baseInterface).Value),
                Methods = @interface.Methods.ToList(method => new InterfaceMethodFactory(method).Value),
                Name = @interface.Name,
                Properties = @interface.Properties.ToList(property => new InterfacePropertyFactory(property).Value),
                Visibility = @interface.Visibility
            };
        }
    }
}
