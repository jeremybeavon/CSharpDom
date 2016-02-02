using System;
using System.Collections.Generic;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class BasicTypeWithReflection : IBasicTypeWithReflection
    {
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly Lazy<InterfaceReferences> interfaces;
        private readonly Lazy<IReadOnlyCollection<EventWithReflection>> events;
        private readonly Lazy<Properties> properties;
        private readonly Lazy<IReadOnlyCollection<MethodWithReflection>> methods;

        public BasicTypeWithReflection(IBasicTypeWithReflection declaringType, Type type)
        {
            attributes = new Lazy<Attributes>(() => new Attributes(type));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(type));
            interfaces = new Lazy<InterfaceReferences>(() => new InterfaceReferences(type));
            events = new Lazy<IReadOnlyCollection<EventWithReflection>>(() => InitializeEvents(type));
            properties = new Lazy<Internal.Properties>();
            //properties = new Lazy<Properties>(() => new Properties(declaringType, type));
            methods = new Lazy<IReadOnlyCollection<MethodWithReflection>>(() => InitializeMethods(type));
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

        public IReadOnlyCollection<EventWithReflection> Events
        {
            get { return events.Value; }
        }

        public IReadOnlyCollection<IndexerWithReflection> Indexers
        {
            get { return properties.Value.IndexersWithReflection; }
        }

        public IReadOnlyCollection<MethodWithReflection> Methods
        {
            get { return methods.Value; }
        }

        public IReadOnlyCollection<PropertyWithReflection> Properties
        {
            get { return properties.Value.PropertiesWithReflection; }
        }

        public Type Type
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        private static IReadOnlyCollection<EventWithReflection> InitializeEvents(Type type)
        {
            return null;
        }

        private static IReadOnlyCollection<MethodWithReflection> InitializeMethods(Type type)
        {
            return null;
        }
    }
}
