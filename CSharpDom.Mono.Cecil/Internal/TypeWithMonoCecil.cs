using CSharpDom.BaseClasses;
using CSharpDom.Common;
using Mono.Cecil;
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
        
        protected TypeWithMonoCecil(TType declaringType)
        {
            TypeDefinition = declaringType.TypeDefinition;
            AssemblyWithMonoCecil assembly = declaringType.Assembly;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, TypeDefinition, typeof(DefaultMemberAttribute)));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(assembly, TypeDefinition));
            implementedInterfaces = new Lazy<InterfaceReferences>(() => new InterfaceReferences(assembly, TypeDefinition));
            FieldCollection = new FieldCollection<TField>(() => InitializeFields(declaringType, TypeDefinition));
            EventCollection = new EventCollection<TEvent, TEventProperty, TType>(
                () => new Events<TEvent, TEventProperty, TType>(declaringType, this));
            PropertyCollection = new PropertyCollection<TProperty, TIndexer, TType>(
                () => new Properties<TProperty, TIndexer, TType>(declaringType, this));
            MethodCollection = new MethodCollection<TConstructor, TMethod, TType>(
                () => new Methods<TConstructor, TMethod, TType>(declaringType, CreateConstructor, CreateMethod));
            NestedTypeCollection = new NestedTypeCollection<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>(
                () => new NestedTypes<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>(declaringType, this));
        }

        public IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }
        
        public override IReadOnlyCollection<TConstructor> Constructors
        {
            get { return MethodCollection.Methods.ConstructorsWithMonoCecil; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithMonoCecil> ConversionOperators
        {
            get { return MethodCollection.Methods.ConversionOperatorsWithMonoCecil; }
        }

        public override IReadOnlyCollection<TNestedDelegate> Delegates
        {
            get { return NestedTypeCollection.NestedTypes.NestedDelegates; }
        }

        public MethodDefinition Destructor
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

        public MethodCollection<TConstructor, TMethod, TType> MethodCollection { get; private set; }

        public override IReadOnlyCollection<OperatorOverloadWithMonoCecil> OperatorOverloads
        {
            get { return MethodCollection.Methods.OperatorOverloadsWithMonoCecil; }
        }

        public PropertyCollection<TProperty, TIndexer, TType> PropertyCollection { get; private set; }
        
        public override StaticConstructorWithMonoCecil StaticConstructor
        {
            get { return MethodCollection.Methods.StaticConstructorWithMonoCecil; }
        }
        
        TNestedClass INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedClass(
            ITypeWithMonoCecil declaringType,
            TypeDefinition type)
        {
            return CreateNestedClass(declaringType, type);
        }

        TNestedAbstractClass INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedAbstractClass(
            ITypeWithMonoCecil declaringType,
            TypeDefinition type)
        {
            return CreateNestedAbstractClass(declaringType, type);
        }

        TNestedSealedClass INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedSealedClass(
            ITypeWithMonoCecil declaringType,
            TypeDefinition type)
        {
            return CreateNestedSealedClass(declaringType, type);
        }

        TNestedStaticClass INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedStaticClass(
            ITypeWithMonoCecil declaringType,
            TypeDefinition type)
        {
            return CreateNestedStaticClass(declaringType, type);
        }

        TNestedDelegate INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedDelegate(
            ITypeWithMonoCecil declaringType,
            TypeDefinition type)
        {
            return CreateNestedDelegate(declaringType, type);
        }

        TNestedEnum INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedEnum(
            ITypeWithMonoCecil declaringType,
            TypeDefinition type)
        {
            return CreateNestedEnum(declaringType, type);
        }

        TNestedInterface INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedInterface(
            ITypeWithMonoCecil declaringType,
            TypeDefinition type)
        {
            return CreateNestedInterface(declaringType, type);
        }

        TNestedStruct INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedStruct(
            ITypeWithMonoCecil declaringType,
            TypeDefinition type)
        {
            return CreateNestedStruct(declaringType, type);
        }

        TEvent IEventFactory<TEvent, TEventProperty, TType>.CreateEvent(TType declaringType, EventDefinition @event)
        {
            return CreateEvent(declaringType, @event);
        }

        TEventProperty IEventFactory<TEvent, TEventProperty, TType>.CreateEventProperty(TType declaringType, EventDefinition @event)
        {
            return CreateEventProperty(declaringType, @event);
        }

        TProperty IPropertyFactory<TProperty, TIndexer, TType>.CreateProperty(TType declaringType, PropertyDefinition property)
        {
            return CreateProperty(declaringType, property);
        }

        TIndexer IPropertyFactory<TProperty, TIndexer, TType>.CreateIndexer(TType declaringType, PropertyDefinition property)
        {
            return CreateIndexer(declaringType, property);
        }

        public TypeDefinition TypeDefinition { get; private set; }

        public AssemblyWithMonoCecil Assembly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected abstract TConstructor CreateConstructor(TType declaringType, MethodDefinition constructor);

        protected abstract TEvent CreateEvent(TType declaringType, EventDefinition @event);

        protected abstract TEventProperty CreateEventProperty(TType declaringType, EventDefinition @event);

        protected abstract TField CreateField(TType declaringType, FieldDefinition field);

        protected abstract TIndexer CreateIndexer(TType declaringType, PropertyDefinition indexer);

        protected abstract TMethod CreateMethod(TType declaringType, MethodDefinition method);

        protected abstract TNestedAbstractClass CreateNestedAbstractClass(ITypeWithMonoCecil declaringType, TypeDefinition type);

        protected abstract TNestedSealedClass CreateNestedSealedClass(ITypeWithMonoCecil declaringType, TypeDefinition type);

        protected abstract TNestedStaticClass CreateNestedStaticClass(ITypeWithMonoCecil declaringType, TypeDefinition type);

        protected abstract TNestedClass CreateNestedClass(ITypeWithMonoCecil declaringType, TypeDefinition type);

        protected abstract TNestedDelegate CreateNestedDelegate(ITypeWithMonoCecil declaringType, TypeDefinition type);

        protected abstract TNestedEnum CreateNestedEnum(ITypeWithMonoCecil declaringType, TypeDefinition type);

        protected abstract TNestedInterface CreateNestedInterface(ITypeWithMonoCecil declaringType, TypeDefinition type);

        protected abstract TNestedStruct CreateNestedStruct(ITypeWithMonoCecil declaringType, TypeDefinition type);

        protected abstract TProperty CreateProperty(TType declaringType, PropertyDefinition property);

        private IReadOnlyCollection<TField> InitializeFields(TType declaringType, TypeDefinition type)
        {
            return type.Fields
                .Where(field => !field.IsDefined(declaringType.Assembly, typeof(CompilerGeneratedAttribute)))
                .Select(field => CreateField(declaringType, field))
                .ToList();
        }

        private IReadOnlyCollection<GenericParameterDeclarationWithMonoCecil> InitializeGenericParameterDeclarations(
            TypeDefinition type)
        {
            return type.GenericParameters.Select(parameter => new GenericParameterDeclarationWithMonoCecil(Assembly, parameter)).ToList();
        }
    }
}
