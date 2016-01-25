﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class TypeWithReflection : ITypeWithReflection
    {
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly Lazy<IReadOnlyCollection<FieldWithReflection>> fields;
        private readonly Lazy<Constructors> constructors;
        private readonly Lazy<Events> events;
        private readonly Lazy<Properties> properties;
        private readonly Lazy<Methods> methods;
        private readonly Lazy<NestedTypes> nestedTypes;

        public TypeWithReflection(ITypeWithReflection declaringType, Type type)
        {
            attributes = new Lazy<Attributes>(() => new Attributes(type));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(type));
            fields = new Lazy<IReadOnlyCollection<FieldWithReflection>>(() => InitializeFields(type));
            constructors = new Lazy<Constructors>(() => new Constructors(declaringType, type));
            events = new Lazy<Events>(() => new Events(declaringType, type));
            properties = new Lazy<Properties>(() => new Properties(declaringType, type));
            methods = new Lazy<Methods>(() => new Methods(declaringType, type));
            nestedTypes = new Lazy<NestedTypes>(() => new NestedTypes(declaringType, type));
        }

        public IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public IReadOnlyCollection<NestedClassWithReflection> Classes
        {
            get { return nestedTypes.Value.NestedClasses; }
        }

        public IReadOnlyCollection<ConstructorWithReflection> Constructors
        {
            get { return constructors.Value.ConstructorsWithReflection; }
        }

        public IReadOnlyCollection<ConversionOperatorWithReflection> ConversionOperators
        {
            get { return methods.Value.ConversionOperatorsWithReflection; }
        }

        public IReadOnlyCollection<NestedDelegateWithReflection> Delegates
        {
            get { return nestedTypes.Value.NestedDelegates; }
        }

        public MethodInfo Destructor
        {
            get { return methods.Value.Destructor; }
        }

        public IReadOnlyCollection<NestedEnumWithReflection> Enums
        {
            get { return nestedTypes.Value.NestedEnums; }
        }

        public IReadOnlyCollection<EventPropertyWithReflection> EventProperties
        {
            get { return events.Value.EventPropertiesWithReflection; }
        }

        public IReadOnlyCollection<EventWithReflection> Events
        {
            get { return events.Value.EventsWithReflection; }
        }

        public IReadOnlyCollection<FieldWithReflection> Fields
        {
            get { return fields.Value; }
        }

        public IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return genericParameters.Value.GenericParameterDeclarationsWithReflection; }
        }

        public IReadOnlyCollection<IndexerWithReflection> Indexers
        {
            get { return properties.Value.IndexersWithReflection; }
        }

        public IReadOnlyCollection<NestedInterfaceWithReflection> Interfaces
        {
            get { return nestedTypes.Value.NestedInterfaces; }
        }

        public IReadOnlyCollection<MethodWithReflection> Methods
        {
            get { return methods.Value.MethodsWithReflection; }
        }

        public IReadOnlyCollection<OperatorOverloadWithReflection> OperatorOverloads
        {
            get { return methods.Value.OperatorOverloadsWithReflection; }
        }

        public IReadOnlyCollection<PropertyWithReflection> Properties
        {
            get { return properties.Value.PropertiesWithReflection; }
        }

        public IReadOnlyCollection<NestedStructWithReflection> Structs
        {
            get { return nestedTypes.Value.NestedStructs; }
        }

        private static IReadOnlyCollection<FieldWithReflection> InitializeFields(Type type)
        {
            return null;
        }

        private static IReadOnlyCollection<GenericParameterDeclarationWithReflection> InitializeGenericParameterDeclarations(
            Type type)
        {
            return type.GetGenericArguments().Select(parameter => new GenericParameterDeclarationWithReflection(parameter)).ToList();
        }
    }
}
