using CSharpDom.BaseClasses;
using CSharpDom.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CSharpDom.Reflection.Internal
{
    internal abstract class TypeWithReflection<
        TType,
        TEvent,
        TProperty,
        TIndexer,
        TMethod,
        TField,
        TConstructor,
        TEventProperty,
        TNestedClass,
        TNestedDelegate,
        TNestedEnum,
        TNestedInterface,
        TNestedStruct> :
        AbstractType<
            TEvent,
            TProperty,
            TIndexer,
            TMethod,
            TField,
            TConstructor,
            TEventProperty,
            OperatorOverloadWithReflection,
            ConversionOperatorWithReflection,
            TNestedClass,
            TNestedDelegate,
            TNestedEnum,
            TNestedInterface,
            TNestedStruct,
            StaticConstructorWithReflection,
            ExplicitInterfaceEventWithReflection,
            ExplicitInterfacePropertyWithReflection,
            ExplicitInterfaceIndexerWithReflection,
            ExplicitInterfaceMethodWithReflection>,
        ITypeWithReflection,
        IEventFactory<TEvent, TEventProperty, TType>,
        INestedTypeFactory<TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>,
        IPropertyFactory<TProperty, TIndexer, TType>
        where TType : ITypeWithReflection
        where TEvent : IEvent
        where TProperty : IProperty
        where TIndexer : IIndexer
        where TMethod : IMethod
        where TField : IField
        where TConstructor : IConstructor
        where TEventProperty : IEventProperty
        where TNestedClass : INestedClass
        where TNestedDelegate : INestedDelegate
        where TNestedEnum : INestedEnum
        where TNestedInterface : INestedInterface
        where TNestedStruct : INestedStruct
    {
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly Lazy<InterfaceReferences> implementedInterfaces;
        private readonly Lazy<IReadOnlyCollection<TField>> fields;
        private readonly Lazy<Constructors<TConstructor>> constructors;
        private readonly Lazy<Events<TEvent, TEventProperty, TType>> events;
        private readonly Lazy<Properties<TProperty, TIndexer, TType>> properties;
        private readonly Lazy<Methods<TMethod, TType>> methods;
        private readonly Lazy<NestedTypes<TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>> nestedTypes;

        protected TypeWithReflection(TType declaringType, Type type)
        {
            Type = type;
            ISet<MethodInfo> interfaceMethods = new HashSet<MethodInfo>(
                type.GetInterfaces().SelectMany(interfaceType => type.GetInterfaceMap(interfaceType).TargetMethods));
            attributes = new Lazy<Attributes>(() => new Attributes(type, typeof(DefaultMemberAttribute)));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(type));
            implementedInterfaces = new Lazy<InterfaceReferences>(() => new InterfaceReferences(type));
            fields = new Lazy<IReadOnlyCollection<TField>>(() => InitializeFields(declaringType, type));
            constructors = new Lazy<Constructors<TConstructor>>(
                () => new Constructors<TConstructor>(declaringType, type, CreateConstructor));
            events = new Lazy<Events<TEvent, TEventProperty, TType>>(
                () => new Events<TEvent, TEventProperty, TType>(declaringType, type, this, interfaceMethods));
            properties = new Lazy<Properties<TProperty, TIndexer, TType>>(
                () => new Properties<TProperty, TIndexer, TType>(declaringType, type, this, interfaceMethods));
            methods = new Lazy<Methods<TMethod, TType>>(
                () => new Methods<TMethod, TType>(declaringType, type, CreateMethod, interfaceMethods));
            nestedTypes = new Lazy<NestedTypes<TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>>(
                () => new NestedTypes<TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>(declaringType, type, this));
        }

        public IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override IReadOnlyCollection<TNestedClass> Classes
        {
            get { return nestedTypes.Value.NestedClasses; }
        }

        public override IReadOnlyCollection<TConstructor> Constructors
        {
            get { return constructors.Value.ConstructorsWithReflection; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithReflection> ConversionOperators
        {
            get { return methods.Value.ConversionOperatorsWithReflection; }
        }

        public override IReadOnlyCollection<TNestedDelegate> Delegates
        {
            get { return nestedTypes.Value.NestedDelegates; }
        }

        public MethodInfo Destructor
        {
            get { return methods.Value.Destructor; }
        }

        public override IReadOnlyCollection<TNestedEnum> Enums
        {
            get { return nestedTypes.Value.NestedEnums; }
        }

        public override IReadOnlyCollection<TEventProperty> EventProperties
        {
            get { return events.Value.EventPropertiesWithReflection; }
        }

        public override IReadOnlyCollection<TEvent> Events
        {
            get { return events.Value.EventsWithReflection; }
        }

        public override IReadOnlyCollection<TField> Fields
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

        public override IReadOnlyCollection<TIndexer> Indexers
        {
            get { return properties.Value.IndexersWithReflection; }
        }

        public override IReadOnlyCollection<TNestedInterface> Interfaces
        {
            get { return nestedTypes.Value.NestedInterfaces; }
        }

        public override IReadOnlyCollection<TMethod> Methods
        {
            get { return methods.Value.MethodsWithReflection; }
        }

        public override IReadOnlyCollection<OperatorOverloadWithReflection> OperatorOverloads
        {
            get { return methods.Value.OperatorOverloadsWithReflection; }
        }

        public override IReadOnlyCollection<TProperty> Properties
        {
            get { return properties.Value.PropertiesWithReflection; }
        }

        public override IReadOnlyCollection<TNestedStruct> Structs
        {
            get { return nestedTypes.Value.NestedStructs; }
        }

        public override StaticConstructorWithReflection StaticConstructor
        {
            get { return constructors.Value.StaticConstructorWithReflection; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceEventWithReflection> ExplicitInterfaceEvents
        {
            get { return events.Value.ExplictInterfaceEventsWithReflection; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceIndexerWithReflection> ExplicitInterfaceIndexers
        {
            get { return properties.Value.ExplicitInterfaceIndexersWithReflection; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceMethodWithReflection> ExplicitInterfaceMethods
        {
            get { return methods.Value.ExplicitInterfaceMethodsWithReflection; }
        }

        public override IReadOnlyCollection<ExplicitInterfacePropertyWithReflection> ExplicitInterfaceProperties
        {
            get { return properties.Value.ExplicitInterfacePropertiesWithReflection; }
        }

        TNestedClass INestedTypeFactory<TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedClass(
            ITypeWithReflection declaringType,
            Type type)
        {
            return CreateNestedClass(declaringType, type);
        }

        TNestedDelegate INestedTypeFactory<TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedDelegate(
            ITypeWithReflection declaringType,
            Type type)
        {
            return CreateNestedDelegate(declaringType, type);
        }

        TNestedEnum INestedTypeFactory<TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedEnum(
            ITypeWithReflection declaringType,
            Type type)
        {
            return CreateNestedEnum(declaringType, type);
        }

        TNestedInterface INestedTypeFactory<TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedInterface(
            ITypeWithReflection declaringType,
            Type type)
        {
            return CreateNestedInterface(declaringType, type);
        }

        TNestedStruct INestedTypeFactory<TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedStruct(
            ITypeWithReflection declaringType,
            Type type)
        {
            return CreateNestedStruct(declaringType, type);
        }

        TEvent IEventFactory<TEvent, TEventProperty, TType>.CreateEvent(TType declaringType, EventInfo @event)
        {
            return CreateEvent(declaringType, @event);
        }

        TEventProperty IEventFactory<TEvent, TEventProperty, TType>.CreateEventProperty(TType declaringType, EventInfo @event)
        {
            return CreateEventProperty(declaringType, @event);
        }

        TProperty IPropertyFactory<TProperty, TIndexer, TType>.CreateProperty(TType declaringType, PropertyInfo property)
        {
            return CreateProperty(declaringType, property);
        }

        TIndexer IPropertyFactory<TProperty, TIndexer, TType>.CreateIndexer(TType declaringType, PropertyInfo property)
        {
            return CreateIndexer(declaringType, property);
        }

        public Type Type { get; private set; }

        protected abstract TConstructor CreateConstructor(ITypeWithReflection declaringType, ConstructorInfo constructor);

        protected abstract TEvent CreateEvent(TType declaringType, EventInfo @event);

        protected abstract TEventProperty CreateEventProperty(TType declaringType, EventInfo @event);

        protected abstract TField CreateField(TType declaringType, FieldInfo field);

        protected abstract TIndexer CreateIndexer(TType declaringType, PropertyInfo indexer);

        protected abstract TMethod CreateMethod(TType declaringType, MethodInfo method);

        protected abstract TNestedClass CreateNestedClass(ITypeWithReflection declaringType, Type type);

        protected abstract TNestedDelegate CreateNestedDelegate(ITypeWithReflection declaringType, Type type);

        protected abstract TNestedEnum CreateNestedEnum(ITypeWithReflection declaringType, Type type);

        protected abstract TNestedInterface CreateNestedInterface(ITypeWithReflection declaringType, Type type);

        protected abstract TNestedStruct CreateNestedStruct(ITypeWithReflection declaringType, Type type);

        protected abstract TProperty CreateProperty(TType declaringType, PropertyInfo property);

        private IReadOnlyCollection<TField> InitializeFields(TType declaringType, Type type)
        {
            return type.GetAllFields()
                .Where(field => !field.IsDefined(typeof(CompilerGeneratedAttribute)))
                .Select(field => CreateField(declaringType, field))
                .ToList();
        }

        private static IReadOnlyCollection<GenericParameterDeclarationWithReflection> InitializeGenericParameterDeclarations(
            Type type)
        {
            return type.GetGenericArguments().Select(parameter => new GenericParameterDeclarationWithReflection(parameter)).ToList();
        }
    }
}
