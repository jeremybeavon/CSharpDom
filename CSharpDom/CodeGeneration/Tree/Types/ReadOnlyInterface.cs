using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyInterface :
        AbstractInterface<
            NamespaceNotSupported,
            ProjectNotSupported,
            SolutionNotSupported,
            AttributeGroupNotSupported,
            ReadOnlyGenericParameterDeclaration,
            ReadOnlyInterfaceReference,
            ReadOnlyInterfaceEvent,
            ReadOnlyInterfaceProperty,
            IndexerNotSupported,
            ReadOnlyInterfaceMethod>
    {
        private readonly Interface @interface;
        private readonly IReadOnlyList<ReadOnlyGenericParameterDeclaration> genericParameters;
        private readonly IReadOnlyCollection<ReadOnlyInterfaceReference> interfaces;
        private readonly IReadOnlyCollection<ReadOnlyInterfaceEvent> events;
        private readonly IReadOnlyCollection<ReadOnlyInterfaceProperty> properties;
        private readonly IReadOnlyCollection<ReadOnlyInterfaceMethod> methods;

        public ReadOnlyInterface(Interface @interface)
        {
            this.@interface = @interface;
            genericParameters = ReadOnlyGenericParameterDeclaration.Create(@interface.GenericParameters);
            interfaces = ReadOnlyInterfaceReference.Create(@interface.Interfaces);
            events = ReadOnlyInterfaceEvent.Create(@interface.Body.Events);
            properties = ReadOnlyInterfaceProperty.Create(@interface.Body.Properties);
            methods = ReadOnlyInterfaceMethod.Create(@interface.Body.Methods);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
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

        public override bool IsPartial
        {
            get { return @interface.IsPartial; }
        }

        public override IReadOnlyCollection<ReadOnlyInterfaceMethod> Methods
        {
            get { return methods; }
        }

        public override string Name
        {
            get { return @interface.Name; }
        }

        public override NamespaceNotSupported Namespace
        {
            get { return new NamespaceNotSupported(); }
        }

        public override ProjectNotSupported Project
        {
            get { return new ProjectNotSupported(); }
        }

        public override IReadOnlyCollection<ReadOnlyInterfaceProperty> Properties
        {
            get { return properties; }
        }

        public override SolutionNotSupported Solution
        {
            get { return new SolutionNotSupported(); }
        }

        public override TypeVisibilityModifier Visibility
        {
            get { return @interface.Visibility; }
        }
    }
}
