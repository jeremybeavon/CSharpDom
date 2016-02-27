using CSharpDom.BaseClasses;
using CSharpDom.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal abstract class TypeWithMonoCecil<
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
        TNestedAbstractClass,
        TNestedClass,
        TNestedSealedClass,
        TNestedStaticClass,
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
            OperatorOverloadWithMonoCecil,
            ConversionOperatorWithMonoCecil,
            TNestedClassCollection,
            TNestedDelegate,
            TNestedEnum,
            TNestedInterfaceCollection,
            TNestedStructCollection,
            StaticConstructorWithMonoCecil>,
        ITypeWithMonoCecil,
        IEventFactory<TEvent, TEventProperty, TType>,
        INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>,
        IPropertyFactory<TProperty, TIndexer, TType>
        where TType : ITypeWithMonoCecil
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
        private readonly Lazy<Constructors<TConstructor>> constructors;
        
        protected TypeWithMonoCecil(TType declaringType)
        {
            Type = declaringType.Type;
            IDictionary<MethodInfo, Type> interfaceMethods =
                (from interfaceType in Type.GetInterfaces()
                 from targetMethod in Type.GetInterfaceMap(interfaceType).TargetMethods
                 where targetMethod.IsPrivate
                 select new KeyValuePair<MethodInfo, Type>(targetMethod, interfaceType))
                .ToDictionary(entry => entry.Key, entry => entry.Value);
            attributes = new Lazy<Attributes>(() => new Attributes(Type, typeof(DefaultMemberAttribute)));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(Type));
            implementedInterfaces = new Lazy<InterfaceReferences>(() => new InterfaceReferences(Type));
            FieldCollection = new FieldCollection<TField>(() => InitializeFields(declaringType, Type));
            constructors = new Lazy<Constructors<TConstructor>>(
                () => new Constructors<TConstructor>(declaringType, Type, CreateConstructor));
            EventCollection = new EventCollection<TEvent, TEventProperty, TType>(
                () => new Events<TEvent, TEventProperty, TType>(declaringType, this, interfaceMethods));
            PropertyCollection = new PropertyCollection<TProperty, TIndexer, TType>(
                () => new Properties<TProperty, TIndexer, TType>(declaringType, this, interfaceMethods));
            MethodCollection = new MethodCollection<TMethod, TType>(
                () => new Methods<TMethod, TType>(declaringType, CreateMethod, interfaceMethods));
            NestedTypeCollection = new NestedTypeCollection<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>(
                () => new NestedTypes<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>(declaringType, this));
        }

        public IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }
        
        public override IReadOnlyCollection<TConstructor> Constructors
        {
            get { return constructors.Value.ConstructorsWithMonoCecil; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithMonoCecil> ConversionOperators
        {
            get { return MethodCollection.Methods.ConversionOperatorsWithMonoCecil; }
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

        public IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameters
        {
            get { return genericParameters.Value.GenericParameterDeclarationsWithMonoCecil; }
        }

        public IReadOnlyCollection<InterfaceReferenceWithMonoCecil> ImplementedInterfaces
        {
            get { return implementedInterfaces.Value.InterfaceReferencesWithMonoCecil; }
        }

        public PropertyCollection<TProperty, TIndexer, TType> IndexerCollection
        {
            get { return PropertyCollection; }
        }

        public NestedTypeCollection<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct> NestedTypeCollection { get; private set; }

        public MethodCollection<TMethod, TType> MethodCollection { get; private set; }

        public override IReadOnlyCollection<OperatorOverloadWithMonoCecil> OperatorOverloads
        {
            get { return MethodCollection.Methods.OperatorOverloadsWithMonoCecil; }
        }

        public PropertyCollection<TProperty, TIndexer, TType> PropertyCollection { get; private set; }
        
        public override StaticConstructorWithMonoCecil StaticConstructor
        {
            get { return constructors.Value.StaticConstructorWithMonoCecil; }
        }
        
        TNestedClass INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedClass(
            ITypeWithMonoCecil declaringType,
            Type type)
        {
            return CreateNestedClass(declaringType, type);
        }

        TNestedAbstractClass INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedAbstractClass(
            ITypeWithMonoCecil declaringType,
            Type type)
        {
            return CreateNestedAbstractClass(declaringType, type);
        }

        TNestedSealedClass INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedSealedClass(
            ITypeWithMonoCecil declaringType,
            Type type)
        {
            return CreateNestedSealedClass(declaringType, type);
        }

        TNestedStaticClass INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedStaticClass(
            ITypeWithMonoCecil declaringType,
            Type type)
        {
            return CreateNestedStaticClass(declaringType, type);
        }

        TNestedDelegate INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedDelegate(
            ITypeWithMonoCecil declaringType,
            Type type)
        {
            return CreateNestedDelegate(declaringType, type);
        }

        TNestedEnum INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedEnum(
            ITypeWithMonoCecil declaringType,
            Type type)
        {
            return CreateNestedEnum(declaringType, type);
        }

        TNestedInterface INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedInterface(
            ITypeWithMonoCecil declaringType,
            Type type)
        {
            return CreateNestedInterface(declaringType, type);
        }

        TNestedStruct INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedStruct(
            ITypeWithMonoCecil declaringType,
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

        protected abstract TConstructor CreateConstructor(ITypeWithMonoCecil declaringType, ConstructorInfo constructor);

        protected abstract TEvent CreateEvent(TType declaringType, EventInfo @event);

        protected abstract TEventProperty CreateEventProperty(TType declaringType, EventInfo @event);

        protected abstract TField CreateField(TType declaringType, FieldInfo field);

        protected abstract TIndexer CreateIndexer(TType declaringType, PropertyInfo indexer);

        protected abstract TMethod CreateMethod(TType declaringType, MethodInfo method);

        protected abstract TNestedAbstractClass CreateNestedAbstractClass(ITypeWithMonoCecil declaringType, Type type);

        protected abstract TNestedSealedClass CreateNestedSealedClass(ITypeWithMonoCecil declaringType, Type type);

        protected abstract TNestedStaticClass CreateNestedStaticClass(ITypeWithMonoCecil declaringType, Type type);

        protected abstract TNestedClass CreateNestedClass(ITypeWithMonoCecil declaringType, Type type);

        protected abstract TNestedDelegate CreateNestedDelegate(ITypeWithMonoCecil declaringType, Type type);

        protected abstract TNestedEnum CreateNestedEnum(ITypeWithMonoCecil declaringType, Type type);

        protected abstract TNestedInterface CreateNestedInterface(ITypeWithMonoCecil declaringType, Type type);

        protected abstract TNestedStruct CreateNestedStruct(ITypeWithMonoCecil declaringType, Type type);

        protected abstract TProperty CreateProperty(TType declaringType, PropertyInfo property);

        private IReadOnlyCollection<TField> InitializeFields(TType declaringType, Type type)
        {
            return type.GetAllFields()
                .Where(field => !field.IsDefined(typeof(CompilerGeneratedAttribute)))
                .Select(field => CreateField(declaringType, field))
                .ToList();
        }

        private static IReadOnlyCollection<GenericParameterDeclarationWithMonoCecil> InitializeGenericParameterDeclarations(
            Type type)
        {
            return type.GetGenericArguments().Select(parameter => new GenericParameterDeclarationWithMonoCecil(parameter)).ToList();
        }
    }
}
