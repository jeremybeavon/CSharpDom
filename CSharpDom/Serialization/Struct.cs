using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.Serialization
{
    public sealed class Struct :
        IStruct<
            NamespaceNotSupported,
            ProjectNotSupported,
            SolutionNotSupported,
            AttributeGroup,
            GenericParameterDeclaration,
            InterfaceReference,
            Event,
            Property,
            Indexer,
            Method,
            Field,
            Constructor,
            EventProperty,
            OperatorOverload,
            ConversionOperator,
            NestedClass,
            NestedDelegate,
            NestedEnum,
            NestedInterface,
            NestedStruct>
    {
        public Struct()
        {
            Attributes = new List<AttributeGroup>();
            Classes = new List<NestedClass>();
            Constructors = new List<Constructor>();
            ConversionOperators = new List<ConversionOperator>();
            Delegates = new List<NestedDelegate>();
            Enums = new List<NestedEnum>();
            EventProperties = new List<EventProperty>();
            Events = new List<Event>();
            Fields = new List<Field>();
            GenericParameters = new List<GenericParameterDeclaration>();
            ImplementedInterfaces = new List<InterfaceReference>();
            Indexers = new List<Indexer>();
            Interfaces = new List<NestedInterface>();
            Methods = new List<Method>();
            OperatorOverloads = new List<OperatorOverload>();
            Properties = new List<Property>();
            Structs = new List<NestedStruct>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public List<NestedClass> Classes { get; set; }

        public List<Constructor> Constructors { get; set; }

        public List<ConversionOperator> ConversionOperators { get; set; }
        
        public List<NestedDelegate> Delegates { get; set; }

        public List<NestedEnum> Enums { get; set; }

        public List<EventProperty> EventProperties { get; set; }

        public List<Event> Events { get; set; }

        public List<Field> Fields { get; set; }

        public List<GenericParameterDeclaration> GenericParameters { get; set; }

        public List<InterfaceReference> ImplementedInterfaces { get; set; }

        public List<Indexer> Indexers { get; set; }

        public List<NestedInterface> Interfaces { get; set; }

        public bool IsPartial { get; set; }

        public List<Method> Methods { get; set; }

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

        public List<Property> Properties { get; set; }

        public SolutionNotSupported Solution
        {
            get { return null; }
        }

        public List<NestedStruct> Structs { get; set; }

        public TypeVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyCollection<NestedClass> IHasClasses<NestedClass>.Classes
        {
            get { return Classes; }
        }

        IReadOnlyCollection<Constructor> IHasConstructors<Constructor>.Constructors
        {
            get { return Constructors; }
        }

        IReadOnlyCollection<ConversionOperator> IHasConversionOperators<ConversionOperator>.ConversionOperators
        {
            get { return ConversionOperators; }
        }

        IReadOnlyCollection<NestedDelegate> IHasDelegates<NestedDelegate>.Delegates
        {
            get { return Delegates; }
        }

        IReadOnlyCollection<NestedEnum> IHasEnums<NestedEnum>.Enums
        {
            get { return Enums; }
        }

        IReadOnlyCollection<EventProperty> IHasEventProperties<EventProperty>.EventProperties
        {
            get { return EventProperties; }
        }

        IReadOnlyCollection<Event> IHasEvents<Event>.Events
        {
            get { return Events; }
        }

        IReadOnlyCollection<Field> IHasFields<Field>.Fields
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

        IReadOnlyCollection<Indexer> IHasIndexers<Indexer>.Indexers
        {
            get { return Indexers; }
        }

        IReadOnlyCollection<NestedInterface> IHasInterfaces<NestedInterface>.Interfaces
        {
            get { return Interfaces; }
        }

        IReadOnlyCollection<Method> IHasMethods<Method>.Methods
        {
            get { return Methods; }
        }

        IReadOnlyCollection<OperatorOverload> IHasOperatorOverloads<OperatorOverload>.OperatorOverloads
        {
            get { return OperatorOverloads; }
        }

        IReadOnlyCollection<Property> IHasProperties<Property>.Properties
        {
            get { return Properties; }
        }

        IReadOnlyCollection<NestedStruct> IHasStructs<NestedStruct>.Structs
        {
            get { return Structs; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStruct(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructChildren(this, visitor);
        }
    }
}
