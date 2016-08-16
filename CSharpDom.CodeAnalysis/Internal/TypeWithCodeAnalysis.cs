using CSharpDom.BaseClasses;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal abstract class TypeWithCodeAnalysis<
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
        TConstant,
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
            OperatorOverloadWithCodeAnalysis,
            ConversionOperatorWithCodeAnalysis,
            TNestedClassCollection,
            TNestedDelegate,
            TNestedEnum,
            TNestedInterfaceCollection,
            TNestedStructCollection,
            StaticConstructorWithCodeAnalysis>,
        ITypeWithCodeAnalysis,
        IEventFactory<TEvent, TEventProperty, TType>,
        IFieldFactory<TField, TConstant, TType>,
        INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>,
        IPropertyFactory<TProperty, TIndexer, TType>
        where TType : ITypeWithCodeAnalysis
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
        where TConstant : IConstantGroup
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
        
        protected TypeWithCodeAnalysis(TType declaringType)
        {
            TypeDefinition = declaringType.TypeDefinition;
            AssemblyWithCodeAnalysis assembly = declaringType.Assembly;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, TypeDefinition, typeof(DefaultMemberAttribute)));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(assembly, TypeDefinition));
            implementedInterfaces = new Lazy<InterfaceReferences>(() => new InterfaceReferences(assembly, TypeDefinition));
            FieldCollection = new FieldCollection<TField, TConstant, TType>(
                () => new Fields<TField, TConstant, TType>(declaringType, this));
            EventCollection = new EventCollection<TEvent, TEventProperty, TType>(
                () => new Events<TEvent, TEventProperty, TType>(declaringType, this));
            PropertyCollection = new PropertyCollection<TProperty, TIndexer, TType>(
                () => new Properties<TProperty, TIndexer, TType>(declaringType, this));
            MethodCollection = new MethodCollection<TConstructor, TMethod, TType>(
                () => new Methods<TConstructor, TMethod, TType>(declaringType, CreateConstructor, CreateMethod));
            NestedTypeCollection = new NestedTypeCollection<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>(
                () => new NestedTypes<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>(declaringType, this));
        }

        public IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }
        
        public override IReadOnlyCollection<TConstructor> Constructors
        {
            get { return MethodCollection.Methods.ConstructorsWithCodeAnalysis; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return MethodCollection.Methods.ConversionOperatorsWithCodeAnalysis; }
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

        public FieldCollection<TField, TConstant, TType> FieldCollection { get; private set; }

        public IReadOnlyList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return genericParameters.Value.GenericParameterDeclarationsWithCodeAnalysis; }
        }

        public IReadOnlyCollection<InterfaceReferenceWithCodeAnalysis> ImplementedInterfaces
        {
            get { return implementedInterfaces.Value.InterfaceReferencesWithCodeAnalysis; }
        }

        public PropertyCollection<TProperty, TIndexer, TType> IndexerCollection
        {
            get { return PropertyCollection; }
        }

        public NestedTypeCollection<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct> NestedTypeCollection { get; private set; }

        public MethodCollection<TConstructor, TMethod, TType> MethodCollection { get; private set; }

        public override IReadOnlyCollection<OperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return MethodCollection.Methods.OperatorOverloadsWithCodeAnalysis; }
        }

        public PropertyCollection<TProperty, TIndexer, TType> PropertyCollection { get; private set; }
        
        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return MethodCollection.Methods.StaticConstructorWithCodeAnalysis; }
        }
        
        TNestedClass INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedClass(
            ITypeWithCodeAnalysis declaringType,
            TypeDefinition type)
        {
            return CreateNestedClass(declaringType, type);
        }

        TNestedAbstractClass INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedAbstractClass(
            ITypeWithCodeAnalysis declaringType,
            TypeDefinition type)
        {
            return CreateNestedAbstractClass(declaringType, type);
        }

        TNestedSealedClass INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedSealedClass(
            ITypeWithCodeAnalysis declaringType,
            TypeDefinition type)
        {
            return CreateNestedSealedClass(declaringType, type);
        }

        TNestedStaticClass INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedStaticClass(
            ITypeWithCodeAnalysis declaringType,
            TypeDefinition type)
        {
            return CreateNestedStaticClass(declaringType, type);
        }

        TNestedDelegate INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedDelegate(
            ITypeWithCodeAnalysis declaringType,
            TypeDefinition type)
        {
            return CreateNestedDelegate(declaringType, type);
        }

        TNestedEnum INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedEnum(
            ITypeWithCodeAnalysis declaringType,
            TypeDefinition type)
        {
            return CreateNestedEnum(declaringType, type);
        }

        TNestedInterface INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedInterface(
            ITypeWithCodeAnalysis declaringType,
            TypeDefinition type)
        {
            return CreateNestedInterface(declaringType, type);
        }

        TNestedStruct INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>.CreateNestedStruct(
            ITypeWithCodeAnalysis declaringType,
            TypeDefinition type)
        {
            return CreateNestedStruct(declaringType, type);
        }

        TConstant IFieldFactory<TField, TConstant, TType>.CreateConstant(TType declaringType, FieldDefinition field)
        {
            return CreateConstant(declaringType, field);
        }

        TField IFieldFactory<TField, TConstant, TType>.CreateField(TType declaringType, FieldDefinition field)
        {
            return CreateField(declaringType, field);
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

        public AssemblyWithCodeAnalysis Assembly
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

        protected abstract TConstant CreateConstant(TType declaringType, FieldDefinition field);

        protected abstract TIndexer CreateIndexer(TType declaringType, PropertyDefinition indexer);

        protected abstract TMethod CreateMethod(TType declaringType, MethodDefinition method);

        protected abstract TNestedAbstractClass CreateNestedAbstractClass(ITypeWithCodeAnalysis declaringType, TypeDefinition type);

        protected abstract TNestedSealedClass CreateNestedSealedClass(ITypeWithCodeAnalysis declaringType, TypeDefinition type);

        protected abstract TNestedStaticClass CreateNestedStaticClass(ITypeWithCodeAnalysis declaringType, TypeDefinition type);

        protected abstract TNestedClass CreateNestedClass(ITypeWithCodeAnalysis declaringType, TypeDefinition type);

        protected abstract TNestedDelegate CreateNestedDelegate(ITypeWithCodeAnalysis declaringType, TypeDefinition type);

        protected abstract TNestedEnum CreateNestedEnum(ITypeWithCodeAnalysis declaringType, TypeDefinition type);

        protected abstract TNestedInterface CreateNestedInterface(ITypeWithCodeAnalysis declaringType, TypeDefinition type);

        protected abstract TNestedStruct CreateNestedStruct(ITypeWithCodeAnalysis declaringType, TypeDefinition type);

        protected abstract TProperty CreateProperty(TType declaringType, PropertyDefinition property);
        
        private IReadOnlyCollection<GenericParameterDeclarationWithCodeAnalysis> InitializeGenericParameterDeclarations(
            TypeDefinition type)
        {
            return type.GenericParameters.Select(parameter => new GenericParameterDeclarationWithCodeAnalysis(Assembly, parameter)).ToList();
        }
    }
}
