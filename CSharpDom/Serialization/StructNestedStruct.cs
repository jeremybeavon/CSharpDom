using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StructNestedStruct :
        IStructNestedStruct<
            AttributeGroup,
            IStructType,
            GenericParameterDeclaration,
            InterfaceReference,
            StructEventCollection,
            StructPropertyCollection,
            StructIndexerCollection,
            StructMethodCollection,
            StructFieldCollection,
            StructConstructor,
            OperatorOverload,
            ConversionOperator,
            StructNestedClassCollection,
            StructNestedDelegate,
            StructNestedEnum,
            StructNestedInterfaceCollection,
            StructNestedStructCollection,
            StaticConstructor>
    {
        public StructNestedStruct()
        {
            Attributes = new List<AttributeGroup>();
            Classes = new StructNestedClassCollection();
            Constructors = new List<StructConstructor>();
            ConversionOperators = new List<ConversionOperator>();
            Delegates = new List<StructNestedDelegate>();
            Enums = new List<StructNestedEnum>();
            Events = new StructEventCollection();
            Fields = new StructFieldCollection();
            GenericParameters = new List<GenericParameterDeclaration>();
            ImplementedInterfaces = new List<InterfaceReference>();
            Indexers = new StructIndexerCollection();
            Interfaces = new StructNestedInterfaceCollection();
            Methods = new StructMethodCollection();
            OperatorOverloads = new List<OperatorOverload>();
            Properties = new StructPropertyCollection();
            Structs = new StructNestedStructCollection();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public StructNestedClassCollection Classes { get; set; }

        public List<StructConstructor> Constructors { get; set; }

        public List<ConversionOperator> ConversionOperators { get; set; }

        public IStructType DeclaringType
        {
            get { return null; }
        }

        public List<StructNestedDelegate> Delegates { get; set; }

        public List<StructNestedEnum> Enums { get; set; }
        
        public StructEventCollection Events { get; set; }
        
        public StructFieldCollection Fields { get; set; }

        public List<GenericParameterDeclaration> GenericParameters { get; set; }

        public List<InterfaceReference> ImplementedInterfaces { get; set; }

        public StructIndexerCollection Indexers { get; set; }

        public StructNestedInterfaceCollection Interfaces { get; set; }
        
        public StructMethodCollection Methods { get; set; }

        public string Name { get; set; }

        public List<OperatorOverload> OperatorOverloads { get; set; }

        public StructPropertyCollection Properties { get; set; }

        public StaticConstructor StaticConstructor { get; set; }

        public StructNestedStructCollection Structs { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
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
            visitor.VisitStructNestedStruct(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructNestedStructChildren(this, visitor);
        }
    }
}
