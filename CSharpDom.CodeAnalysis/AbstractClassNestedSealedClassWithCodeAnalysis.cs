using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractClassNestedSealedClassWithCodeAnalysis :
        EditableClassNestedSealedClass<
            AttributeGroupWithCodeAnalysis,
            IAbstractTypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ClassReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            SealedClassEventCollectionWithCodeAnalysis,
            SealedClassPropertyCollectionWithCodeAnalysis,
            SealedClassIndexerCollectionWithCodeAnalysis,
            SealedClassMethodCollectionWithCodeAnalysis,
            SealedClassFieldCollectionWithCodeAnalysis,
            SealedClassConstructorWithCodeAnalysis,
            OperatorOverloadWithCodeAnalysis,
            ConversionOperatorWithCodeAnalysis,
            SealedClassNestedClassCollectionWithCodeAnalysis,
            SealedClassNestedDelegateWithCodeAnalysis,
            SealedClassNestedEnumWithCodeAnalysis,
            SealedClassNestedInterfaceWithCodeAnalysis,
            SealedClassNestedStructCollectionWithCodeAnalysis,
            DestructorWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>,
        IHasNode<ClassDeclarationSyntax>
    {
        private readonly ClassNestedSealedClassWithCodeAnalysis classType;

        internal AbstractClassNestedSealedClassWithCodeAnalysis(ClassNestedSealedClassWithCodeAnalysis @class)
        {
            classType = @class ?? new ClassNestedSealedClassWithCodeAnalysis();
        }
        
        public NestedSealedClassWithCodeAnalysis Class
        {
            get { return classType.Class; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return classType.Attributes; }
            set { classType.Attributes = value; }
        }

        public override ClassReferenceWithCodeAnalysis BaseClass
        {
            get { return classType.BaseClass; }
            set { classType.BaseClass = value; }
        }

        public override SealedClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return classType.Classes; }
            set { classType.Classes = value; }
        }

        public override ICollection<SealedClassConstructorWithCodeAnalysis> Constructors
        {
            get { return classType.Constructors; }
            set { classType.Constructors = value; }
        }

        public override ICollection<ConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return classType.ConversionOperators; }
            set { classType.ConversionOperators = value; }
        }

        public override IAbstractTypeWithCodeAnalysis DeclaringType
        {
            get { return classType.InternalClass.InternalClass.Type.Node.GetParentNode<IAbstractTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ICollection<SealedClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return classType.Delegates; }
            set { classType.Delegates = value; }
        }

        public override DestructorWithCodeAnalysis Destructor
        {
            get { return classType.Destructor; }
            set { classType.Destructor = value; }
        }

        public override ICollection<SealedClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return classType.Enums; }
            set { classType.Enums = value; }
        }

        public override SealedClassEventCollectionWithCodeAnalysis Events
        {
            get { return classType.Events; }
            set { classType.Events = value; }
        }

        public override SealedClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return classType.Fields; }
            set { classType.Fields = value; }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return classType.GenericParameters; }
            set { classType.GenericParameters = value; }
        }

        public override ICollection<InterfaceReferenceWithCodeAnalysis> ImplementedInterfaces
        {
            get { return classType.ImplementedInterfaces; }
            set { classType.ImplementedInterfaces = value; }
        }

        public override SealedClassIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return classType.Indexers; }
            set { classType.Indexers = value; }
        }

        public override ICollection<SealedClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return classType.Interfaces; }
            set { classType.Interfaces = value; }
        }

        public override SealedClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return classType.Methods; }
            set { classType.Methods = value; }
        }

        public override string Name
        {
            get { return classType.Name; }
            set { classType.Name = value; }
        }

        public override ICollection<OperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return classType.OperatorOverloads; }
            set { classType.OperatorOverloads = value; }
        }

        public override SealedClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return classType.Properties; }
            set { classType.Properties = value; }
        }

        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return classType.StaticConstructor; }
            set { classType.StaticConstructor = value; }
        }

        public override SealedClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return classType.Structs; }
            set { classType.Structs = value; }
        }

        public ClassDeclarationSyntax Syntax
        {
            get { return classType.Syntax; }
            set { classType.Syntax = value; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return classType.Visibility; }
            set { classType.Visibility = value; }
        }
        
        INode<ClassDeclarationSyntax> IHasNode<ClassDeclarationSyntax>.Node
        {
            get { return classType.InternalClass.InternalClass.Type.Node; }
        }

        internal ClassNestedSealedClassWithCodeAnalysis InternalClass
        {
            get { return classType; }
        }
    }
}
