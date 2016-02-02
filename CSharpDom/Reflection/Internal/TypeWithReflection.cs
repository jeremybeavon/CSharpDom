using CSharpDom.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class TypeWithReflection : ITypeWithReflection,
        IType<
            EventWithReflection,
            PropertyWithReflection,
            IndexerWithReflection,
            MethodWithReflection,
            FieldWithReflection,
            ConstructorWithReflection,
            EventPropertyWithReflection,
            OperatorOverloadWithReflection,
            ConversionOperatorWithReflection,
            NestedClassWithReflection,
            NestedDelegateWithReflection,
            NestedEnumWithReflection,
            NestedInterfaceWithReflection,
            NestedStructWithReflection,
            StaticConstructorWithReflection,
            ExplicitInterfaceEventWithReflection,
            ExplicitInterfacePropertyWithReflection,
            ExplicitInterfaceIndexerWithReflection,
            ExplicitInterfaceMethodWithReflection>
    {
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly Lazy<InterfaceReferences> implementedInterfaces;
        private readonly Lazy<IReadOnlyCollection<FieldWithReflection>> fields;
        private readonly Lazy<Constructors> constructors;
        private readonly Lazy<Events> events;
        private readonly Lazy<Properties> properties;
        private readonly Lazy<Methods> methods;
        private readonly Lazy<NestedTypes> nestedTypes;

        public TypeWithReflection(ITypeWithReflection declaringType, Type type)
        {
            Type = type;
            attributes = new Lazy<Attributes>(() => new Attributes(type));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(type));
            implementedInterfaces = new Lazy<InterfaceReferences>(() => new InterfaceReferences(type));
            fields = new Lazy<IReadOnlyCollection<FieldWithReflection>>(() => InitializeFields(declaringType, type));
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

        public IReadOnlyCollection<InterfaceReferenceWithReflection> ImplementedInterfaces
        {
            get { return implementedInterfaces.Value.InterfaceReferencesWithReflection; }
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

        public StaticConstructorWithReflection StaticConstructor
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<ExplicitInterfaceEventWithReflection> ExplicitInterfaceEvents
        {
            get { return events.Value.ExplictInterfaceEventsWithReflection; }
        }

        public IReadOnlyCollection<ExplicitInterfaceIndexerWithReflection> ExplicitInterfaceIndexers
        {
            get { return properties.Value.ExplicitInterfaceIndexersWithReflection; }
        }

        public IReadOnlyCollection<ExplicitInterfaceMethodWithReflection> ExplicitInterfaceMethods
        {
            get { return methods.Value.ExplicitInterfaceMethodsWithReflection; }
        }

        public IReadOnlyCollection<ExplicitInterfacePropertyWithReflection> ExplicitInterfaceProperties
        {
            get { return properties.Value.ExplicitInterfacePropertiesWithReflection; }
        }
        
        public Type Type { get; private set; }

        private static IReadOnlyCollection<FieldWithReflection> InitializeFields(ITypeWithReflection declaringType, Type type)
        {
            return type.GetAllFields().Select(field => new FieldWithReflection(declaringType, field)).ToList();
        }

        private static IReadOnlyCollection<GenericParameterDeclarationWithReflection> InitializeGenericParameterDeclarations(
            Type type)
        {
            return type.GetGenericArguments().Select(parameter => new GenericParameterDeclarationWithReflection(parameter)).ToList();
        }
    }
}
