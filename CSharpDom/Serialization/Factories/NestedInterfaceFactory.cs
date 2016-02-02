using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class NestedInterfaceFactory : AbstractFactory<IClassNestedInterface, ClassNestedInterface>
    {
        public NestedInterfaceFactory(IClassNestedInterface @interface)
            : base(@interface)
        {
        }

        public override void VisitClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
        {
            /*Value = new ClassNestedInterface()
            {
                Attributes = @interface.Attributes.ToAttributeListUsingFactory(),
                Events = @interface.Events.ToList(@event => new EventFactory(@event).Value),
                GenericParameters = @interface.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                Indexers = @interface.Indexers.ToList(indexer => new IndexerFactory(indexer).Value),
                Interfaces = @interface.Interfaces.ToList(baseInterface => new InterfaceReferenceFactory(baseInterface).Value),
                Methods = @interface.Methods.ToList(method => new MethodFactory(method).Value),
                Name = @interface.Name,
                Properties = @interface.Properties.ToList(property => new PropertyFactory(property).Value),
                Visibility = @interface.Visibility
            };*/
        }
    }
}
