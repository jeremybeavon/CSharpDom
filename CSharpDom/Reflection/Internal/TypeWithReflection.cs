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
        TEventCollection,
        TEvent,
        TEventProperty,
        TPropertyCollection,
        TProperty,
        TIndexerCollection,
        TIndexer,
        TMethodCollection,
        TMethod,
        TFieldCollection,
        TField,
        TConstructor,
        TNestedClassCollection,
        TNestedClass,
        TNestedDelegate,
        TNestedEnum,
        TNestedInterfaceCollection,
        TNestedInterface,
        TNestedStructCollection,
        TNestedStruct> :
        AbstractType<
            TEventCollection,
            TPropertyCollection,
            TIndexerCollection,
            TMethodCollection,
            TFieldCollection,
            TConstructor,
            OperatorOverloadWithReflection,
            ConversionOperatorWithReflection,
            TNestedClassCollection,
            TNestedDelegate,
            TNestedEnum,
            TNestedInterfaceCollection,
            TNestedStructCollection,
            StaticConstructorWithReflection>,
        ITypeWithReflection,
        IEventFactory<TEvent, TEventProperty, TType>,
        INestedTypeFactory<TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>,
        IPropertyFactory<TProperty, TIndexer, TType>
        where TType : ITypeWithReflection
        where TEventCollection : IEventCollection
        where TEvent : IEvent
        where TEventProperty : IEventProperty
        where TPropertyCollection : IPropertyCollection
        where TProperty : IProperty
        where TIndexerCollection : IIndexerCollection
        where TIndexer : IIndexer
        where TMethodCollection : IMethodCollection
        where TMethod : IMethod
        where TFieldCollection : IFieldCollection
        where TField : IFieldGroup
        where TConstructor : IConstructor
        where TNestedClassCollection : INestedClassCollection
        where TNestedClass : INestedClass
        where TNestedDelegate : INestedDelegate
        where TNestedEnum : INestedEnum
        where TNestedInterfaceCollection : INestedInterfaceCollection
        where TNestedInterface : INestedInterface
        where TNestedStructCollection : INestedStructCollection
        where TNestedStruct : INestedStruct
    {
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly Lazy<InterfaceReferences> implementedInterfaces;
        private readonly FieldCollection<TField> fields;
        private readonly Lazy<Constructors<TConstructor>> constructors;
        
        protected TypeWithReflection(TType declaringType)
        {
            Type = declaringType.Type;
            ISet<MethodInfo> interfaceMethods = new HashSet<MethodInfo>(
                Type.GetInterfaces().SelectMany(interfaceType => Type.GetInterfaceMap(interfaceType).TargetMethods));
            attributes = new Lazy<Attributes>(() => new Attributes(Type, typeof(DefaultMemberAttribute)));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(Type));
            implementedInterfaces = new Lazy<InterfaceReferences>(() => new InterfaceReferences(Type));
            fields = new FieldCollection<TField>(() => InitializeFields(declaringType, Type));
            constructors = new Lazy<Constructors<TConstructor>>(
                () => new Constructors<TConstructor>(declaringType, Type, CreateConstructor));
            EventCollection = new EventCollection<TEvent, TEventProperty, TType>(
                () => new Events<TEvent, TEventProperty, TType>(declaringType, this, interfaceMethods));
            PropertyCollection = new PropertyCollection<TProperty, TIndexer, TType>(
                () => new Properties<TProperty, TIndexer, TType>(declaringType, this, interfaceMethods));
            MethodCollection = new MethodCollection<TMethod, TType>(
                () => new Methods<TMethod, TType>(declaringType, CreateMethod, interfaceMethods));
            NestedTypeCollection = new NestedTypeCollection<TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>(
                () => new NestedTypes<TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>(declaringType, this));
        }

        public IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }
        
        public override IReadOnlyCollection<TConstructor> Constructors
        {
            get { return constructors.Value.ConstructorsWithReflection; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithReflection> ConversionOperators
        {
            get { return MethodCollection.Methods.ConversionOperatorsWithReflection; }
        }

        public override IReadOnlyCollection<TNestedDelegate> Delegates
        {
            get { return NestedTypeCollection.NestedTypes.NestedDelegates; }
        }

        public MethodInfo Destructor
        {
            get { return MethodCollection.Methods.Destructor; }
        }

        public override IReadOnlyCollection<TNestedEnum> Enums
        {
            get { return NestedTypeCollection.NestedTypes.NestedEnums; }
        }
        
        public EventCollection<TEvent, TEventProperty, TType> EventCollection { get; private set; }

        public FieldCollection<TField> FieldCollection { get; private set; }

        public IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return genericParameters.Value.GenericParameterDeclarationsWithReflection; }
        }

        public IReadOnlyCollection<InterfaceReferenceWithReflection> ImplementedInterfaces
        {
            get { return implementedInterfaces.Value.InterfaceReferencesWithReflection; }
        }

        public PropertyCollection<TProperty, TIndexer, TType> IndexerCollection
        {
            get { return PropertyCollection; }
        }

        public NestedTypeCollection<TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct> NestedTypeCollection { get; private set; }

        public MethodCollection<TMethod, TType> MethodCollection { get; private set; }

        public override IReadOnlyCollection<OperatorOverloadWithReflection> OperatorOverloads
        {
            get { return MethodCollection.Methods.OperatorOverloadsWithReflection; }
        }

        public PropertyCollection<TProperty, TIndexer, TType> PropertyCollection { get; private set; }
        
        public override StaticConstructorWithReflection StaticConstructor
        {
            get { return constructors.Value.StaticConstructorWithReflection; }
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
