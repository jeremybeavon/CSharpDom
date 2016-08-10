﻿using System;
using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom.Serialization
{
    public sealed class StaticClassNestedSealedClass :
        IStaticClassNestedSealedClass<
            AttributeGroup,
            IStaticType,
            GenericParameterDeclaration,
            ClassReference,
            InterfaceReference,
            SealedClassEventCollection,
            SealedClassPropertyCollection,
            SealedClassIndexerCollection,
            SealedClassMethodCollection,
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
        public StaticClassNestedSealedClass()
        {
            Attributes = new List<AttributeGroup>();
            Classes = new ClassNestedClassCollection();
            Constructors = new List<ClassConstructor>();
            ConversionOperators = new List<ConversionOperator>();
            Delegates = new List<ClassNestedDelegate>();
            Enums = new List<ClassNestedEnum>();
            Events = new SealedClassEventCollection();
            Fields = new ClassFieldCollection();
            GenericParameters = new List<GenericParameterDeclaration>();
            ImplementedInterfaces = new List<InterfaceReference>();
            Indexers = new SealedClassIndexerCollection();
            Interfaces = new ClassNestedInterfaceCollection();
            Methods = new SealedClassMethodCollection();
            OperatorOverloads = new List<OperatorOverload>();
            Properties = new SealedClassPropertyCollection();
            Structs = new ClassNestedStructCollection();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public ClassReference BaseClass { get; set; }

        public ClassNestedClassCollection Classes { get; set; }

        public List<ClassConstructor> Constructors { get; set; }

        public List<ConversionOperator> ConversionOperators { get; set; }

        public IStaticType DeclaringType
        {
            get { return null; }
        }

        public List<ClassNestedDelegate> Delegates { get; set; }

        public NestedDestructor Destructor { get; set; }

        public List<ClassNestedEnum> Enums { get; set; }
        
        public SealedClassEventCollection Events { get; set; }
        
        public ClassFieldCollection Fields { get; set; }

        public List<GenericParameterDeclaration> GenericParameters { get; set; }

        public List<InterfaceReference> ImplementedInterfaces { get; set; }

        public SealedClassIndexerCollection Indexers { get; set; }
        
        public ClassNestedInterfaceCollection Interfaces { get; set; }
        
        public SealedClassMethodCollection Methods { get; set; }

        public string Name { get; set; }

        public List<OperatorOverload> OperatorOverloads { get; set; }

        public SealedClassPropertyCollection Properties { get; set; }

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
            visitor.VisitStaticClassNestedSealedClass(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassNestedSealedClassChildren(this, visitor);
        }
    }
}
