using System;
using System.Collections.Generic;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class BasicTypeWithReflection : IBasicTypeWithReflection
    {
        private readonly Lazy<IReadOnlyCollection<EventWithReflection>> events;
        private readonly Lazy<Properties> properties;
        private readonly Lazy<IReadOnlyCollection<MethodWithReflection>> methods;

        public BasicTypeWithReflection(IBasicTypeWithReflection declaringType, Type type)
        {
            events = new Lazy<IReadOnlyCollection<EventWithReflection>>(() => InitializeEvents(type));
            properties = new Lazy<Properties>(() => new Properties(declaringType, type));
            methods = new Lazy<IReadOnlyCollection<MethodWithReflection>>(() => InitializeMethods(type));
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
