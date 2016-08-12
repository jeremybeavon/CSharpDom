﻿using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructNestedInterfaceWrapper : AbstractWrapper<IStructNestedInterface>
    {
        public StructNestedInterfaceWrapper(IStructNestedInterface @interface)
            : base(@interface)
        {
        }

        public override void VisitStructNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IStructNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
        {
            Value = new StructNestedInterface()
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
