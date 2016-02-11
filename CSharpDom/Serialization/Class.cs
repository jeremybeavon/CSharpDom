using System;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.Serialization
{
    public sealed class Class :
        IClass<
            NamespaceNotSupported,
            DocumentNotSupported,
            ProjectNotSupported,
            SolutionNotSupported,
            AttributeGroup,
            GenericParameterDeclaration,
            ClassReference,
            InterfaceReference,
            ClassEventCollection,
            ClassPropertyCollection,
            ClassIndexerCollection,
            ClassMethodCollection,
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
        public Class()
        {
            Attributes = new List<AttributeGroup>();
            Classes = new ClassNestedClassCollection();
            Constructors = new List<ClassConstructor>();
            ConversionOperators = new List<ConversionOperator>();
            Delegates = new List<ClassNestedDelegate>();
            Enums = new List<ClassNestedEnum>();
            Events = new ClassEventCollection();
            Fields = new ClassFieldCollection();
            GenericParameters = new List<GenericParameterDeclaration>();
            ImplementedInterfaces = new List<InterfaceReference>();
            Indexers = new ClassIndexerCollection();
            Interfaces = new ClassNestedInterfaceCollection();
            Methods = new ClassMethodCollection();
            OperatorOverloads = new List<OperatorOverload>();
            Properties = new ClassPropertyCollection();
            Structs = new ClassNestedStructCollection();
        }

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

        public ClassEventCollection Events { get; set; }
        
        public ClassFieldCollection Fields { get; set; }

        public List<GenericParameterDeclaration> GenericParameters { get; set; }

        public List<InterfaceReference> ImplementedInterfaces { get; set; }

        public ClassIndexerCollection Indexers { get; set; }
        
        public ClassNestedInterfaceCollection Interfaces { get; set; }
        
        public ClassMethodCollection Methods { get; set; }

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

        public ClassPropertyCollection Properties { get; set; }

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
            visitor.VisitClass(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassChildren(this, visitor);
        }
    }
}
