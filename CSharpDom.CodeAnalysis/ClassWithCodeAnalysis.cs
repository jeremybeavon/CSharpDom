using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using CSharpDom.Mono.Cecil.Internal.Hiding;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassWithCodeAnalysis :
        AbstractClass<
            NamespaceWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            AttributeGroupWithCodeAnalysis,
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
            DestructorWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IClassTypeWithCodeAnalysis,
        IInternalTypeWithCodeAnalysis,
        IHasTypeDefinition//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly AssemblyWithCodeAnalysis assembly;
        private readonly NamespaceWithCodeAnalysis @namespace;
        private readonly TypeDefinition type;
        private readonly ClassReferenceWithCodeAnalysis baseClass;
        private readonly ClassTypeWithCodeAnalysis typeWithCodeAnalysis;
        private readonly Lazy<DestructorWithCodeAnalysis> destructor;
        private readonly HiddenMembersAnalyzer hiddenMembersAnalyzer;

        internal ClassWithCodeAnalysis(AssemblyWithCodeAnalysis assembly, NamespaceWithCodeAnalysis @namespace, TypeDefinition type)
        {
            this.assembly = assembly;
            this.@namespace = @namespace;
            this.type = type;
            if (type.BaseType != null && type.BaseType.FullName != "System.Object")
            {
                baseClass = new ClassReferenceWithCodeAnalysis(assembly, type.BaseType);
            }

            hiddenMembersAnalyzer = new HiddenMembersAnalyzer(assembly, type);
            typeWithCodeAnalysis = new ClassTypeWithCodeAnalysis(this);
            destructor = new Lazy<DestructorWithCodeAnalysis>(InitializeDestructor);
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

        public override IReadOnlyCollection<ClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return typeWithCodeAnalysis.Delegates; }
        }

        public override DestructorWithCodeAnalysis Destructor
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

        public override NamespaceWithCodeAnalysis Namespace
        {
            get { return @namespace; }
        }

        public override IReadOnlyCollection<OperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return typeWithCodeAnalysis.OperatorOverloads; }
        }

        public override AssemblyWithCodeAnalysis Project
        {
            get { return assembly; }
        }

        public override ClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return typeWithCodeAnalysis.Properties; }
        }

        public override AssemblyWithCodeAnalysis Solution
        {
            get { return assembly; }
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
        
        public override TypeVisibilityModifier Visibility
        {
            get { return type.Visibility(); }
        }

        public TypeDefinition TypeDefinition
        {
            get { return type; }
        }
        
        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return typeWithCodeAnalysis.StaticConstructor; }
        }

        public override AssemblyWithCodeAnalysis Document
        {
            get { return assembly; }
        }

        internal ClassTypeWithCodeAnalysis TypeWithCodeAnalysis
        {
            get { return typeWithCodeAnalysis; }
        }

        HiddenMembersAnalyzer IInternalTypeWithCodeAnalysis.HiddenMembersAnalyzer
        {
            get { return hiddenMembersAnalyzer; }
        }

        public AssemblyWithCodeAnalysis Assembly
        {
            get { return assembly; }
        }

        private DestructorWithCodeAnalysis InitializeDestructor()
        {
            MethodDefinition method = typeWithCodeAnalysis.Destructor;
            return method == null ? null : new DestructorWithCodeAnalysis(assembly, this, method);
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitClassWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
