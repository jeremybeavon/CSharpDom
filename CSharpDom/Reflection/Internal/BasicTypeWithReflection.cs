using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class BasicTypeWithReflection : IBasicTypeWithReflection
    {
        private readonly Type type;
        private readonly IBasicTypeWithReflection declaringType;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly Lazy<InterfaceReferences> interfaces;
        private readonly Lazy<IReadOnlyCollection<InterfaceEventWithReflection>> events;
        private readonly Lazy<InterfaceProperties> properties;
        private readonly Lazy<IReadOnlyCollection<InterfaceMethodWithReflection>> methods;

        public BasicTypeWithReflection(IBasicTypeWithReflection declaringType, Type type)
        {
            this.declaringType = declaringType;
            this.type = type;
            attributes = new Lazy<Attributes>(() => new Attributes(type));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(type));
            interfaces = new Lazy<InterfaceReferences>(() => new InterfaceReferences(type));
            events = new Lazy<IReadOnlyCollection<InterfaceEventWithReflection>>(InitializeEvents);
            properties = new Lazy<InterfaceProperties>(() => new InterfaceProperties(declaringType, type));
            methods = new Lazy<IReadOnlyCollection<InterfaceMethodWithReflection>>(InitializeMethods);
        }

        public IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return genericParameters.Value.GenericParameterDeclarationsWithReflection; }
        }

        public IReadOnlyCollection<InterfaceReferenceWithReflection> Interfaces
        {
            get { return interfaces.Value.InterfaceReferencesWithReflection; }
        }

        public IReadOnlyCollection<InterfaceEventWithReflection> Events
        {
            get { return events.Value; }
        }

        public IReadOnlyCollection<InterfaceIndexerWithReflection> Indexers
        {
            get { return properties.Value.IndexersWithReflection; }
        }

        public IReadOnlyCollection<InterfaceMethodWithReflection> Methods
        {
            get { return methods.Value; }
        }

        public IReadOnlyCollection<InterfacePropertyWithReflection> Properties
        {
            get { return properties.Value.PropertiesWithReflection; }
        }

        public Type Type
        {
            get { return type; }
        }

        private IReadOnlyCollection<InterfaceEventWithReflection> InitializeEvents()
        {
            return type.GetAllEvents().ToArray(@event => new InterfaceEventWithReflection(declaringType, @event));
        }

        private IReadOnlyCollection<InterfaceMethodWithReflection> InitializeMethods()
        {
            return type.GetAllMethods().ToArray(method => new InterfaceMethodWithReflection(declaringType, method));
        }
    }
}
