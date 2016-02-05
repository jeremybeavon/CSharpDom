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
            /*Value = new Interface()
            {
                Attributes = @interface.Attributes.ToAttributeListUsingFactory(),
                Events = @interface.Events.ToList(@event => new EventFactory(@event).Value),
                GenericParameters = @interface.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                Indexers = @interface.Indexers.ToList(indexer => new IndexerFactory(indexer).Value),
                Interfaces = @interface.Interfaces.ToList(baseInterface => new InterfaceReferenceFactory(baseInterface).Value),
                IsPartial = @interface.IsPartial,
                Methods = @interface.Methods.ToList(method => new MethodFactory(method).Value),
                Name = @interface.Name,
                Properties = @interface.Properties.ToList(property => new PropertyFactory(property).Value),
                Visibility = @interface.Visibility
            };*/
        }
    }
}
