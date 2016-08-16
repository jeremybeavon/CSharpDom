using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using CSharpDom.Mono.Cecil.Internal.Hiding;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassWithCodeAnalysis :
        AbstractStaticClass<
            NamespaceWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            StaticClassEventCollectionWithCodeAnalysis,
            StaticClassPropertyWithCodeAnalysis,
            StaticClassMethodCollectionWithCodeAnalysis,
            StaticClassFieldCollectionWithCodeAnalysis,
            StaticClassNestedClassCollectionWithCodeAnalysis,
            StaticClassNestedDelegateWithCodeAnalysis,
            StaticClassNestedEnumWithCodeAnalysis,
            StaticClassNestedInterfaceCollectionWithCodeAnalysis,
            StaticClassNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IInternalTypeWithCodeAnalysis,
        IHasTypeDefinition//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly AssemblyWithCodeAnalysis assembly;
        private readonly NamespaceWithCodeAnalysis @namespace;
        private readonly TypeDefinition type;
        private readonly StaticTypeWithCodeAnalysis typeWithCodeAnalysis;
        private readonly HiddenMembersAnalyzer hiddenMembersAnalyzer;

        internal StaticClassWithCodeAnalysis(AssemblyWithCodeAnalysis assembly, NamespaceWithCodeAnalysis @namespace, TypeDefinition type)
        {
            this.assembly = assembly;
            this.@namespace = @namespace;
            this.type = type;
            typeWithCodeAnalysis = new StaticTypeWithCodeAnalysis(this);
            hiddenMembersAnalyzer = new HiddenMembersAnalyzer(assembly, type);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return typeWithCodeAnalysis.Attributes; }
        }

        public override StaticClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return typeWithCodeAnalysis.Classes; }
        }
        
        public override IReadOnlyCollection<StaticClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return typeWithCodeAnalysis.Delegates; }
        }
        
        public override IReadOnlyCollection<StaticClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return typeWithCodeAnalysis.Enums; }
        }
        
        public override StaticClassEventCollectionWithCodeAnalysis Events
        {
            get { return typeWithCodeAnalysis.Events; }
        }

        public override StaticClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return typeWithCodeAnalysis.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return typeWithCodeAnalysis.GenericParameters; }
        }
        
        public override StaticClassNestedInterfaceCollectionWithCodeAnalysis Interfaces
        {
            get { return typeWithCodeAnalysis.Interfaces; }
        }

        public override StaticClassMethodCollectionWithCodeAnalysis Methods
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
        
        public override AssemblyWithCodeAnalysis Project
        {
            get { return assembly; }
        }

        public override IReadOnlyCollection<StaticClassPropertyWithCodeAnalysis> Properties
        {
            get { return typeWithCodeAnalysis.Properties; }
        }

        public override AssemblyWithCodeAnalysis Solution
        {
            get { return assembly; }
        }

        public override StaticClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return typeWithCodeAnalysis.Structs; }
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

        internal StaticTypeWithCodeAnalysis TypeWithCodeAnalysis
        {
            get { return typeWithCodeAnalysis; }
        }

        public AssemblyWithCodeAnalysis Assembly
        {
            get { return assembly; }
        }

        HiddenMembersAnalyzer IInternalTypeWithCodeAnalysis.HiddenMembersAnalyzer
        {
            get { return hiddenMembersAnalyzer; }
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
