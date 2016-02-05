using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class ClassNestedStruct :
        IClassNestedStruct<
            AttributeGroup,
            IClassType,
            GenericParameterDeclaration,
            InterfaceReference,
            StructEvent,
            StructProperty,
            StructIndexer,
            StructMethod,
            StructField,
            StructConstructor,
            StructEventProperty,
            OperatorOverload,
            ConversionOperator,
            StructNestedClass,
            StructNestedDelegate,
            StructNestedEnum,
            StructNestedInterface,
            StructNestedStruct,
            StaticConstructor,
            ExplicitInterfaceEvent,
            ExplicitInterfaceProperty,
            ExplicitInterfaceIndexer,
            ExplicitInterfaceMethod>
    {
        public ClassNestedStruct()
        {
            Attributes = new List<AttributeGroup>();
            Classes = new List<StructNestedClass>();
            Constructors = new List<StructConstructor>();
            ConversionOperators = new List<ConversionOperator>();
            Delegates = new List<StructNestedDelegate>();
            Enums = new List<StructNestedEnum>();
            EventProperties = new List<StructEventProperty>();
            Events = new List<StructEvent>();
            ExplicitInterfaceEvents = new List<ExplicitInterfaceEvent>();
            ExplicitInterfaceIndexers = new List<ExplicitInterfaceIndexer>();
            ExplicitInterfaceMethods = new List<ExplicitInterfaceMethod>();
            ExplicitInterfaceProperties = new List<ExplicitInterfaceProperty>();
            Fields = new List<StructField>();
            GenericParameters = new List<GenericParameterDeclaration>();
            ImplementedInterfaces = new List<InterfaceReference>();
            Indexers = new List<StructIndexer>();
            Interfaces = new List<StructNestedInterface>();
            Methods = new List<StructMethod>();
            OperatorOverloads = new List<OperatorOverload>();
            Properties = new List<StructProperty>();
            Structs = new List<StructNestedStruct>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public List<StructNestedClass> Classes { get; set; }

        public List<StructConstructor> Constructors { get; set; }

        public List<ConversionOperator> ConversionOperators { get; set; }

        public IClassType DeclaringType
        {
            get { return null; }
        }

        public List<StructNestedDelegate> Delegates { get; set; }

        public List<StructNestedEnum> Enums { get; set; }

        public List<StructEventProperty> EventProperties { get; set; }

        public List<StructEvent> Events { get; set; }

        public List<ExplicitInterfaceEvent> ExplicitInterfaceEvents { get; set; }

        public List<ExplicitInterfaceIndexer> ExplicitInterfaceIndexers { get; set; }

        public List<ExplicitInterfaceMethod> ExplicitInterfaceMethods { get; set; }

        public List<ExplicitInterfaceProperty> ExplicitInterfaceProperties { get; set; }

        public List<StructField> Fields { get; set; }

        public List<GenericParameterDeclaration> GenericParameters { get; set; }

        public List<InterfaceReference> ImplementedInterfaces { get; set; }

        public List<StructIndexer> Indexers { get; set; }

        public List<StructNestedInterface> Interfaces { get; set; }

        public bool IsPartial { get; set; }

        public List<StructMethod> Methods { get; set; }

        public string Name { get; set; }

        public List<OperatorOverload> OperatorOverloads { get; set; }

        public List<StructProperty> Properties { get; set; }

        public StaticConstructor StaticConstructor { get; set; }

        public List<StructNestedStruct> Structs { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyCollection<StructNestedClass> IHasClasses<StructNestedClass>.Classes
        {
            get { return Classes; }
        }

        IReadOnlyCollection<StructConstructor> IHasConstructors<StructConstructor>.Constructors
        {
            get { return Constructors; }
        }

        IReadOnlyCollection<ConversionOperator> IHasConversionOperators<ConversionOperator>.ConversionOperators
        {
            get { return ConversionOperators; }
        }

        IReadOnlyCollection<StructNestedDelegate> IHasDelegates<StructNestedDelegate>.Delegates
        {
            get { return Delegates; }
        }

        IReadOnlyCollection<StructNestedEnum> IHasEnums<StructNestedEnum>.Enums
        {
            get { return Enums; }
        }

        IReadOnlyCollection<StructEventProperty> IHasEventProperties<StructEventProperty>.EventProperties
        {
            get { return EventProperties; }
        }

        IReadOnlyCollection<StructEvent> IHasEvents<StructEvent>.Events
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

        IReadOnlyCollection<StructField> IHasFields<StructField>.Fields
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

        IReadOnlyCollection<StructIndexer> IHasIndexers<StructIndexer>.Indexers
        {
            get { return Indexers; }
        }

        IReadOnlyCollection<StructNestedInterface> IHasInterfaces<StructNestedInterface>.Interfaces
        {
            get { return Interfaces; }
        }

        IReadOnlyCollection<StructMethod> IHasMethods<StructMethod>.Methods
        {
            get { return Methods; }
        }

        IReadOnlyCollection<OperatorOverload> IHasOperatorOverloads<OperatorOverload>.OperatorOverloads
        {
            get { return OperatorOverloads; }
        }

        IReadOnlyCollection<StructProperty> IHasProperties<StructProperty>.Properties
        {
            get { return Properties; }
        }

        IReadOnlyCollection<StructNestedStruct> IHasStructs<StructNestedStruct>.Structs
        {
            get { return Structs; }
        }

        ClassMemberVisibilityModifier IHasClassMemberVisibilityModifier.Visibility
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassNestedStruct(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedStructChildren(this, visitor);
        }
    }
}
