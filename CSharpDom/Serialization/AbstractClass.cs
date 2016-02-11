using System;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.Serialization
{
    public sealed class AbstractClass :
        IAbstractClass<
            NamespaceNotSupported,
            DocumentNotSupported,
            ProjectNotSupported,
            SolutionNotSupported,
            AttributeGroup,
            GenericParameterDeclaration,
            ClassReference,
            InterfaceReference,
            AbstractClassEventCollection,
            AbstractClassPropertyCollection,
            AbstractClassIndexerCollection,
            AbstractClassMethodCollection,
            ClassFieldCollection,
            ClassConstructor,
            OperatorOverload,
            ConversionOperator,
            ClassNestedClassCollection,
            ClassNestedDelegate,
            ClassNestedEnum,
            ClassNestedInterfaceCollection,
            ClassNestedStructCollection,
            Destructor,
            StaticConstructor>
    {
        public AbstractClass()
        {
            Attributes = new List<AttributeGroup>();
            Classes = new ClassNestedClassCollection();
            Constructors = new List<ClassConstructor>();
            ConversionOperators = new List<ConversionOperator>();
            Delegates = new List<ClassNestedDelegate>();
            Enums = new List<ClassNestedEnum>();
            Events = new AbstractClassEventCollection();
            Fields = new ClassFieldCollection();
            GenericParameters = new List<GenericParameterDeclaration>();
            ImplementedInterfaces = new List<InterfaceReference>();
            Indexers = new AbstractClassIndexerCollection();
            Interfaces = new ClassNestedInterfaceCollection();
            Methods = new AbstractClassMethodCollection();
            OperatorOverloads = new List<OperatorOverload>();
            Properties = new AbstractClassPropertyCollection();
            Structs = new ClassNestedStructCollection();
        }

        public AbstractClassEventCollection Events { get; set; }

        public AbstractClassIndexerCollection Indexers { get; set; }

        public AbstractClassMethodCollection Methods { get; set; }

        public AbstractClassPropertyCollection Properties { get; set; }

        public List<AttributeGroup> Attributes { get; set; }

        public ClassReference BaseClass { get; set; }

        public ClassNestedClassCollection Classes { get; set; }

        public List<ClassConstructor> Constructors { get; set; }

        public List<ConversionOperator> ConversionOperators { get; set; }
        
        public List<ClassNestedDelegate> Delegates { get; set; }

        public Destructor Destructor { get; set; }

        public DocumentNotSupported Document
        {
            get { return null; }
        }

        public List<ClassNestedEnum> Enums { get; set; }

        public ClassFieldCollection Fields { get; set; }

        public List<GenericParameterDeclaration> GenericParameters { get; set; }

        public List<InterfaceReference> ImplementedInterfaces { get; set; }
        
        public ClassNestedInterfaceCollection Interfaces { get; set; }
        
        public string Name { get; set; }

        public NamespaceNotSupported Namespace
        {
            get { return null; }
        }

        public List<OperatorOverload> OperatorOverloads { get; set; }

        public ProjectNotSupported Project
        {
            get { return null; }
        }
        
        public SolutionNotSupported Solution
        {
            get { return null; }
        }

        public StaticConstructor StaticConstructor { get; set; }

        public ClassNestedStructCollection Structs { get; set; }

        public TypeVisibilityModifier Visibility { get; set; }
        
        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }
        
        IReadOnlyCollection<ClassConstructor> IHasConstructors<ClassConstructor>.Constructors
        {
            get { return Constructors; }
        }

        IReadOnlyCollection<ConversionOperator> IHasConversionOperators<ConversionOperator>.ConversionOperators
        {
            get { return ConversionOperators; }
        }

        IReadOnlyCollection<ClassNestedDelegate> IHasDelegates<ClassNestedDelegate>.Delegates
        {
            get { return Delegates; }
        }

        IReadOnlyCollection<ClassNestedEnum> IHasEnums<ClassNestedEnum>.Enums
        {
            get { return Enums; }
        }
        
        IReadOnlyList<GenericParameterDeclaration> IHasGenericParameters<GenericParameterDeclaration>.GenericParameters
        {
            get { return GenericParameters; }
        }

        IReadOnlyCollection<InterfaceReference> IHasImplementedInterfaces<InterfaceReference>.ImplementedInterfaces
        {
            get { return ImplementedInterfaces; }
        }
        
        IReadOnlyCollection<OperatorOverload> IHasOperatorOverloads<OperatorOverload>.OperatorOverloads
        {
            get { return OperatorOverloads; }
        }
        
        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractClass(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            //GenericVisitor.VisitAbstractClassChildren(this, visitor);
        }
    }
}
