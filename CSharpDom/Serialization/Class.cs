using System;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.Serialization
{
    public sealed class Class :
        IClass<
            NamespaceNotSupported,
            ProjectNotSupported,
            SolutionNotSupported,
            AttributeGroup,
            GenericParameterDeclaration,
            ClassReference,
            InterfaceReference,
            ClassEvent,
            ClassProperty,
            ClassIndexer,
            ClassMethod,
            ClassField,
            ClassConstructor,
            ClassEventProperty,
            OperatorOverload,
            ConversionOperator,
            ClassNestedClass,
            ClassNestedDelegate,
            ClassNestedEnum,
            ClassNestedInterface,
            ClassNestedStruct,
            Destructor,
            StaticConstructor,
            ExplicitInterfaceEvent,
            ExplicitInterfaceProperty,
            ExplicitInterfaceIndexer,
            ExplicitInterfaceMethod>
    {
        public Class()
        {
            Attributes = new List<AttributeGroup>();
            Classes = new List<ClassNestedClass>();
            Constructors = new List<ClassConstructor>();
            ConversionOperators = new List<ConversionOperator>();
            Delegates = new List<ClassNestedDelegate>();
            Enums = new List<ClassNestedEnum>();
            EventProperties = new List<ClassEventProperty>();
            Events = new List<ClassEvent>();
            ExplicitInterfaceEvents = new List<ExplicitInterfaceEvent>();
            ExplicitInterfaceIndexers = new List<ExplicitInterfaceIndexer>();
            ExplicitInterfaceMethods = new List<ExplicitInterfaceMethod>();
            ExplicitInterfaceProperties = new List<ExplicitInterfaceProperty>();
            Fields = new List<ClassField>();
            GenericParameters = new List<GenericParameterDeclaration>();
            ImplementedInterfaces = new List<InterfaceReference>();
            Indexers = new List<ClassIndexer>();
            Interfaces = new List<ClassNestedInterface>();
            Methods = new List<ClassMethod>();
            OperatorOverloads = new List<OperatorOverload>();
            Properties = new List<ClassProperty>();
            Structs = new List<ClassNestedStruct>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public ClassReference BaseClass { get; set; }

        public List<ClassNestedClass> Classes { get; set; }

        public List<ClassConstructor> Constructors { get; set; }

        public List<ConversionOperator> ConversionOperators { get; set; }
        
        public List<ClassNestedDelegate> Delegates { get; set; }

        public Destructor Destructor { get; set; }

        public List<ClassNestedEnum> Enums { get; set; }

        public List<ClassEventProperty> EventProperties { get; set; }

        public List<ClassEvent> Events { get; set; }

        public List<ExplicitInterfaceEvent> ExplicitInterfaceEvents { get; set; }

        public List<ExplicitInterfaceIndexer> ExplicitInterfaceIndexers { get; set; }

        public List<ExplicitInterfaceMethod> ExplicitInterfaceMethods { get; set; }

        public List<ExplicitInterfaceProperty> ExplicitInterfaceProperties { get; set; }

        public List<ClassField> Fields { get; set; }

        public List<GenericParameterDeclaration> GenericParameters { get; set; }

        public List<InterfaceReference> ImplementedInterfaces { get; set; }

        public List<ClassIndexer> Indexers { get; set; }
        
        public List<ClassNestedInterface> Interfaces { get; set; }
        
        public List<ClassMethod> Methods { get; set; }

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

        public List<ClassProperty> Properties { get; set; }

        public SolutionNotSupported Solution
        {
            get { return null; }
        }

        public StaticConstructor StaticConstructor { get; set; }

        public List<ClassNestedStruct> Structs { get; set; }

        public TypeVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyCollection<ClassNestedClass> IHasClasses<ClassNestedClass>.Classes
        {
            get { return Classes; }
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

        IReadOnlyCollection<ClassEventProperty> IHasEventProperties<ClassEventProperty>.EventProperties
        {
            get { return EventProperties; }
        }

        IReadOnlyCollection<ClassEvent> IHasEvents<ClassEvent>.Events
        {
            get { return Events; }
        }

        IReadOnlyCollection<ExplicitInterfaceEvent> IHasExplicitInterfaceEvents<ExplicitInterfaceEvent>.ExplicitInterfaceEvents
        {
            get { return ExplicitInterfaceEvents; }
        }

        IReadOnlyCollection<ExplicitInterfaceIndexer> IHasExplicitInterfaceIndexers<ExplicitInterfaceIndexer>.ExplicitInterfaceIndexers
        {
            get { return ExplicitInterfaceIndexers; }
        }

        IReadOnlyCollection<ExplicitInterfaceMethod> IHasExplicitInterfaceMethods<ExplicitInterfaceMethod>.ExplicitInterfaceMethods
        {
            get { return ExplicitInterfaceMethods; }
        }

        IReadOnlyCollection<ExplicitInterfaceProperty> IHasExplicitInterfaceProperties<ExplicitInterfaceProperty>.ExplicitInterfaceProperties
        {
            get { return ExplicitInterfaceProperties; }
        }

        IReadOnlyCollection<ClassField> IHasFields<ClassField>.Fields
        {
            get { return Fields; }
        }

        IReadOnlyList<GenericParameterDeclaration> IHasGenericParameters<GenericParameterDeclaration>.GenericParameters
        {
            get { return GenericParameters; }
        }

        IReadOnlyCollection<InterfaceReference> IHasImplementedInterfaces<InterfaceReference>.ImplementedInterfaces
        {
            get { return ImplementedInterfaces; }
        }

        IReadOnlyCollection<ClassIndexer> IHasIndexers<ClassIndexer>.Indexers
        {
            get { return Indexers; }
        }

        IReadOnlyCollection<ClassNestedInterface> IHasInterfaces<ClassNestedInterface>.Interfaces
        {
            get { return Interfaces; }
        }

        IReadOnlyCollection<ClassMethod> IHasMethods<ClassMethod>.Methods
        {
            get { return Methods; }
        }

        IReadOnlyCollection<OperatorOverload> IHasOperatorOverloads<OperatorOverload>.OperatorOverloads
        {
            get { return OperatorOverloads; }
        }

        IReadOnlyCollection<ClassProperty> IHasProperties<ClassProperty>.Properties
        {
            get { return Properties; }
        }

        IReadOnlyCollection<ClassNestedStruct> IHasStructs<ClassNestedStruct>.Structs
        {
            get { return Structs; }
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
