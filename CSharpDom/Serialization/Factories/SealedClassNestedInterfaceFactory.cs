using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class SealedClassNestedInterfaceFactory : AbstractFactory<ISealedClassNestedInterface, SealedClassNestedInterface>
    {
        public SealedClassNestedInterfaceFactory(ISealedClassNestedInterface @interface)
            : base(@interface)
        {
        }

        public override void VisitSealedClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            ISealedClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
        {
            /*Value = new SealedClassNestedInterface()
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
