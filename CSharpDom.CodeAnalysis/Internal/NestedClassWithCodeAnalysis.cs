using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using CSharpDom.Mono.Cecil.Internal.Hiding;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class NestedClassWithCodeAnalysis :
        AbstractNestedClass<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ClassReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            ClassEventCollectionWithCodeAnalysis,
            ClassPropertyCollectionWithCodeAnalysis,
            ClassIndexerCollectionWithCodeAnalysis,
            ClassMethodCollectionWithCodeAnalysis,
            ClassFieldCollectionWithCodeAnalysis,
            ClassConstructorWithCodeAnalysis,
            OperatorOverloadWithCodeAnalysis,
            ConversionOperatorWithCodeAnalysis,
            ClassNestedClassCollectionWithCodeAnalysis,
            ClassNestedDelegateWithCodeAnalysis,
            ClassNestedEnumWithCodeAnalysis,
            ClassNestedInterfaceCollectionWithCodeAnalysis,
            ClassNestedStructCollectionWithCodeAnalysis,
            NestedDestructorWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        ITypeWithCodeAnalysis,
        IInternalTypeWithCodeAnalysis,
        IHasTypeDefinition
    {
        private readonly ITypeWithCodeAnalysis declaringType;
        private readonly HiddenMembersAnalyzer hiddenMembersAnalyzer;
        private readonly TypeDefinition type;
        private readonly ClassReferenceWithCodeAnalysis baseClass;
        private readonly ClassTypeWithCodeAnalysis typeWithCodeAnalysis;
        private readonly Lazy<NestedDestructorWithCodeAnalysis> destructor;

        internal NestedClassWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            this.declaringType = declaringType;
            hiddenMembersAnalyzer = new HiddenMembersAnalyzer(declaringType.Assembly, type);
            this.type = type;
            if (type.BaseType != null && type.BaseType.FullName != "System.Object")
            {
                baseClass = new ClassReferenceWithCodeAnalysis(declaringType.Assembly, type.BaseType);
            }

            typeWithCodeAnalysis = new ClassTypeWithCodeAnalysis(this);
            destructor = new Lazy<NestedDestructorWithCodeAnalysis>(
                () => typeWithCodeAnalysis.Destructor == null ? null : new NestedDestructorWithCodeAnalysis(this, typeWithCodeAnalysis.Destructor));
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return typeWithCodeAnalysis.Attributes; }
        }

        public override ClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return typeWithCodeAnalysis.Classes; }
        }

        public override IReadOnlyCollection<ClassConstructorWithCodeAnalysis> Constructors
        {
            get { return typeWithCodeAnalysis.Constructors; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return typeWithCodeAnalysis.ConversionOperators; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return declaringType; }
        }

        public override IReadOnlyCollection<ClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return typeWithCodeAnalysis.Delegates; }
        }

        public override NestedDestructorWithCodeAnalysis Destructor
        {
            get { return destructor.Value; }
        }

        public override IReadOnlyCollection<ClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return typeWithCodeAnalysis.Enums; }
        }
        
        public override ClassEventCollectionWithCodeAnalysis Events
        {
            get { return typeWithCodeAnalysis.Events; }
        }

        public override ClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return typeWithCodeAnalysis.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return typeWithCodeAnalysis.GenericParameters; }
        }

        public override ClassIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return typeWithCodeAnalysis.Indexers; }
        }

        public override ClassNestedInterfaceCollectionWithCodeAnalysis Interfaces
        {
            get { return typeWithCodeAnalysis.Interfaces; }
        }
        
        public override ClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return typeWithCodeAnalysis.Methods; }
        }

        public override string Name
        {
            get { return type.Name(); }
        }
        
        public override IReadOnlyCollection<OperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return typeWithCodeAnalysis.OperatorOverloads; }
        }
        
        public override ClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return typeWithCodeAnalysis.Properties; }
        }
        
        public override ClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return typeWithCodeAnalysis.Structs; }
        }

        public override ClassReferenceWithCodeAnalysis BaseClass
        {
            get { return baseClass; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithCodeAnalysis> ImplementedInterfaces
        {
            get { return typeWithCodeAnalysis.ImplementedInterfaces; }
        }
        
        public TypeDefinition TypeDefinition
        {
            get { return type; }
        }
        
        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return typeWithCodeAnalysis.StaticConstructor; }
        }

        public HiddenMembersAnalyzer HiddenMembersAnalyzer
        {
            get { return hiddenMembersAnalyzer; }
        }

        public ClassTypeWithCodeAnalysis TypeWithCodeAnalysis
        {
            get { return typeWithCodeAnalysis; }
        }

        public AssemblyWithCodeAnalysis Assembly
        {
            get { return declaringType.Assembly; }
        }
    }
}
