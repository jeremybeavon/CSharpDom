using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructNestedInterface :
        AbstractStructNestedInterface<
            AttributeGroupNotSupported,
            IType,
            ReadOnlyGenericParameterDeclaration,
            ReadOnlyInterfaceReference,
            ReadOnlyInterfaceEvent,
            ReadOnlyInterfaceProperty,
            IndexerNotSupported,
            ReadOnlyInterfaceMethod>
    {
        private readonly StructNestedInterface nestedInterface;
        private readonly IReadOnlyList<ReadOnlyGenericParameterDeclaration> genericParameters;
        private readonly IReadOnlyCollection<ReadOnlyInterfaceReference> interfaces;
        private readonly IReadOnlyCollection<ReadOnlyInterfaceEvent> events;
        private readonly IReadOnlyCollection<ReadOnlyInterfaceProperty> properties;
        private readonly IReadOnlyCollection<ReadOnlyInterfaceMethod> methods;

        public ReadOnlyStructNestedInterface(StructNestedInterface nestedInterface)
        {
            this.nestedInterface = nestedInterface;
            genericParameters = ReadOnlyGenericParameterDeclaration.Create(nestedInterface.GenericParameters);
            interfaces = ReadOnlyInterfaceReference.Create(nestedInterface.Interfaces);
            events = ReadOnlyInterfaceEvent.Create(nestedInterface.Body.Events);
            properties = ReadOnlyInterfaceProperty.Create(nestedInterface.Body.Properties);
            methods = ReadOnlyInterfaceMethod.Create(nestedInterface.Body.Methods);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IType DeclaringType
        {
            get { return null; }
        }

        public override IReadOnlyCollection<ReadOnlyInterfaceEvent> Events
        {
            get { return events; }
        }

        public override IReadOnlyList<ReadOnlyGenericParameterDeclaration> GenericParameters
        {
            get { return genericParameters; }
        }

        public override IReadOnlyCollection<IndexerNotSupported> Indexers
        {
            get { return new IndexerNotSupported[0]; }
        }

        public override IReadOnlyCollection<ReadOnlyInterfaceReference> Interfaces
        {
            get { return interfaces; }
        }

        public override IReadOnlyCollection<ReadOnlyInterfaceMethod> Methods
        {
            get { return methods; }
        }

        public override string Name
        {
            get { return nestedInterface.Name; }
        }
        
        public override IReadOnlyCollection<ReadOnlyInterfaceProperty> Properties
        {
            get { return properties; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return nestedInterface.Visibility; }
        }

        public override bool IsPartial
        {
            get { return nestedInterface.IsPartial; }
        }
    }
}
