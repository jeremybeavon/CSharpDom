using System;
using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom.Serialization
{
    public sealed class ClassNestedClass :
        IClassNestedClass<
            AttributeGroup,
            IClassType,
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
            ClassNestedInterface,
            ClassNestedStructCollection,
            StaticConstructor,
            Destructor>
    {
        public ClassNestedClass()
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
            Interfaces = new List<ClassNestedInterface>();
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

        public IClassType DeclaringType
        {
            get { return null; }
        }

        public List<ClassNestedDelegate> Delegates { get; set; }

        public Destructor Destructor { get; set; }

        public List<ClassNestedEnum> Enums { get; set; }
        
        public ClassEventCollection Events { get; set; }
        
        public ClassFieldCollection Fields { get; set; }

        public List<GenericParameterDeclaration> GenericParameters { get; set; }

        public List<InterfaceReference> ImplementedInterfaces { get; set; }

        public ClassIndexerCollection Indexers { get; set; }
        
        public List<ClassNestedInterface> Interfaces { get; set; }
        
        public ClassMethodCollection Methods { get; set; }

        public string Name { get; set; }

        public List<OperatorOverload> OperatorOverloads { get; set; }

        public ClassPropertyCollection Properties { get; set; }

        public StaticConstructor StaticConstructor { get; set; }

        public ClassNestedStructCollection Structs { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

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

        IReadOnlyCollection<ClassNestedInterface> IHasInterfaces<ClassNestedInterface>.Interfaces => Interfaces;

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassNestedClass(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedClassChildren(this, visitor);
        }
    }
}
