using Mono.Cecil;
using System;
using System.Collections.Generic;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class BasicTypeWithMonoCecil : IInterfaceTypeWithMonoCecil
    {
        private readonly TypeDefinition type;
        private readonly IInterfaceTypeWithMonoCecil declaringType;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly Lazy<InterfaceReferences> interfaces;
        private readonly Lazy<IReadOnlyCollection<InterfaceEventWithMonoCecil>> events;
        private readonly Lazy<InterfaceProperties> properties;
        private readonly Lazy<IReadOnlyCollection<InterfaceMethodWithMonoCecil>> methods;

        public BasicTypeWithMonoCecil(IInterfaceTypeWithMonoCecil declaringType, TypeDefinition type)
        {
            this.declaringType = declaringType;
            this.type = type;
            attributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, type));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(declaringType.Assembly, type));
            interfaces = new Lazy<InterfaceReferences>(() => new InterfaceReferences(declaringType.Assembly, type));
            events = new Lazy<IReadOnlyCollection<InterfaceEventWithMonoCecil>>(InitializeEvents);
            properties = new Lazy<InterfaceProperties>(() => new InterfaceProperties(declaringType, type));
            methods = new Lazy<IReadOnlyCollection<InterfaceMethodWithMonoCecil>>(InitializeMethods);
        }

        public IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameters
        {
            get { return genericParameters.Value.GenericParameterDeclarationsWithMonoCecil; }
        }

        public IReadOnlyCollection<InterfaceReferenceWithMonoCecil> Interfaces
        {
            get { return interfaces.Value.InterfaceReferencesWithMonoCecil; }
        }

        public IReadOnlyCollection<InterfaceEventWithMonoCecil> Events
        {
            get { return events.Value; }
        }

        public IReadOnlyCollection<InterfaceIndexerWithMonoCecil> Indexers
        {
            get { return properties.Value.IndexersWithMonoCecil; }
        }

        public IReadOnlyCollection<InterfaceMethodWithMonoCecil> Methods
        {
            get { return methods.Value; }
        }

        public IReadOnlyCollection<InterfacePropertyWithMonoCecil> Properties
        {
            get { return properties.Value.PropertiesWithMonoCecil; }
        }

        public TypeDefinition TypeDefinition
        {
            get { return type; }
        }

        public AssemblyWithMonoCecil Assembly
        {
            get { return declaringType.Assembly; }
        }

        private IReadOnlyCollection<InterfaceEventWithMonoCecil> InitializeEvents()
        {
            return type.Events.ToArray(@event => new InterfaceEventWithMonoCecil(declaringType, @event));
        }

        private IReadOnlyCollection<InterfaceMethodWithMonoCecil> InitializeMethods()
        {
            return type.Methods.ToArray(method => new InterfaceMethodWithMonoCecil(declaringType, method));
        }
    }
}
