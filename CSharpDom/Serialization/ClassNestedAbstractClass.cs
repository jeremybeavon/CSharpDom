using System;
using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom.Serialization
{
    public sealed class ClassNestedAbstractClass :
        IClassNestedAbstractClass<
            AttributeGroup,
            IClassType,
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
            NestedDestructor,
            StaticConstructor>
    {
        public ClassNestedAbstractClass()
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

        public NestedDestructor Destructor { get; set; }

        public List<ClassNestedEnum> Enums { get; set; }
        
        public AbstractClassEventCollection Events { get; set; }
        
        public ClassFieldCollection Fields { get; set; }

        public List<GenericParameterDeclaration> GenericParameters { get; set; }

        public List<InterfaceReference> ImplementedInterfaces { get; set; }

        public AbstractClassIndexerCollection Indexers { get; set; }
        
        public ClassNestedInterfaceCollection Interfaces { get; set; }
        
        public AbstractClassMethodCollection Methods { get; set; }

        public string Name { get; set; }

        public List<OperatorOverload> OperatorOverloads { get; set; }

        public AbstractClassPropertyCollection Properties { get; set; }

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
        
        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassNestedAbstractClass(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassNestedAbstractClassChildren(this, visitor);
        }
    }
}
