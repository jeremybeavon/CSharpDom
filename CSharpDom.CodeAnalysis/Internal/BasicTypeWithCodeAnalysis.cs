using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class BasicTypeWithCodeAnalysis : IBasicTypeWithCodeAnalysis
    {
        private readonly TypeDefinition type;
        private readonly IBasicTypeWithCodeAnalysis declaringType;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly Lazy<InterfaceReferences> interfaces;
        private readonly Lazy<IReadOnlyCollection<InterfaceEventWithCodeAnalysis>> events;
        private readonly Lazy<InterfaceProperties> properties;
        private readonly Lazy<IReadOnlyCollection<InterfaceMethodWithCodeAnalysis>> methods;

        public BasicTypeWithCodeAnalysis(IBasicTypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            this.declaringType = declaringType;
            this.type = type;
            attributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, type));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(declaringType.Assembly, type));
            interfaces = new Lazy<InterfaceReferences>(() => new InterfaceReferences(declaringType.Assembly, type));
            events = new Lazy<IReadOnlyCollection<InterfaceEventWithCodeAnalysis>>(InitializeEvents);
            properties = new Lazy<InterfaceProperties>(() => new InterfaceProperties(declaringType, type));
            methods = new Lazy<IReadOnlyCollection<InterfaceMethodWithCodeAnalysis>>(InitializeMethods);
        }

        public IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public IReadOnlyList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return genericParameters.Value.GenericParameterDeclarationsWithCodeAnalysis; }
        }

        public IReadOnlyCollection<InterfaceReferenceWithCodeAnalysis> Interfaces
        {
            get { return interfaces.Value.InterfaceReferencesWithCodeAnalysis; }
        }

        public IReadOnlyCollection<InterfaceEventWithCodeAnalysis> Events
        {
            get { return events.Value; }
        }

        public IReadOnlyCollection<InterfaceIndexerWithCodeAnalysis> Indexers
        {
            get { return properties.Value.IndexersWithCodeAnalysis; }
        }

        public IReadOnlyCollection<InterfaceMethodWithCodeAnalysis> Methods
        {
            get { return methods.Value; }
        }

        public IReadOnlyCollection<InterfacePropertyWithCodeAnalysis> Properties
        {
            get { return properties.Value.PropertiesWithCodeAnalysis; }
        }

        public TypeDefinition TypeDefinition
        {
            get { return type; }
        }

        public AssemblyWithCodeAnalysis Assembly
        {
            get { return declaringType.Assembly; }
        }

        private IReadOnlyCollection<InterfaceEventWithCodeAnalysis> InitializeEvents()
        {
            return type.Events.ToArray(@event => new InterfaceEventWithCodeAnalysis(declaringType, @event));
        }

        private IReadOnlyCollection<InterfaceMethodWithCodeAnalysis> InitializeMethods()
        {
            return type.Methods.ToArray(method => new InterfaceMethodWithCodeAnalysis(declaringType, method));
        }
    }
}
