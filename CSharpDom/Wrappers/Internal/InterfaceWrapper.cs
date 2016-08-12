using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class InterfaceWrapper : AbstractWrapper<IInterface>
    {
        public InterfaceWrapper(IInterface @interface)
            : base(@interface)
        {
        }

        public override void VisitInterface<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IInterface<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
        {
            Value = new Interface()
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
