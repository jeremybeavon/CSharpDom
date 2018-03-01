using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using CSharpDom.Mono.Cecil.Internal.Hiding;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StaticClassWithMonoCecil :
        AbstractStaticClass<
            NamespaceWithMonoCecil,
            AssemblyWithMonoCecil,
            AssemblyWithMonoCecil,
            AssemblyWithMonoCecil,
            AttributeWithMonoCecil,
            GenericParameterDeclarationWithMonoCecil,
            StaticClassEventCollectionWithMonoCecil,
            StaticClassPropertyCollectionWithMonoCecil,
            StaticClassMethodCollectionWithMonoCecil,
            StaticClassFieldCollectionWithMonoCecil,
            StaticClassNestedClassCollectionWithMonoCecil,
            StaticClassNestedDelegateWithMonoCecil,
            StaticClassNestedEnumWithMonoCecil,
            StaticClassNestedInterfaceWithMonoCecil,
            StaticClassNestedStructCollectionWithMonoCecil,
            StaticConstructorWithMonoCecil>,
        IInternalTypeWithMonoCecil,
        IHasTypeDefinition//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly AssemblyWithMonoCecil assembly;
        private readonly NamespaceWithMonoCecil @namespace;
        private readonly TypeDefinition type;
        private readonly StaticTypeWithMonoCecil typeWithMonoCecil;
        private readonly HiddenMembersAnalyzer hiddenMembersAnalyzer;

        internal StaticClassWithMonoCecil(AssemblyWithMonoCecil assembly, NamespaceWithMonoCecil @namespace, TypeDefinition type)
        {
            this.assembly = assembly;
            this.@namespace = @namespace;
            this.type = type;
            typeWithMonoCecil = new StaticTypeWithMonoCecil(this);
            hiddenMembersAnalyzer = new HiddenMembersAnalyzer(assembly, type);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return typeWithMonoCecil.Attributes; }
        }

        public override StaticClassNestedClassCollectionWithMonoCecil Classes
        {
            get { return typeWithMonoCecil.Classes; }
        }
        
        public override IReadOnlyCollection<StaticClassNestedDelegateWithMonoCecil> Delegates
        {
            get { return typeWithMonoCecil.Delegates; }
        }
        
        public override IReadOnlyCollection<StaticClassNestedEnumWithMonoCecil> Enums
        {
            get { return typeWithMonoCecil.Enums; }
        }
        
        public override StaticClassEventCollectionWithMonoCecil Events
        {
            get { return typeWithMonoCecil.Events; }
        }

        public override StaticClassFieldCollectionWithMonoCecil Fields
        {
            get { return typeWithMonoCecil.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameters
        {
            get { return typeWithMonoCecil.GenericParameters; }
        }
        
        public override IReadOnlyCollection<StaticClassNestedInterfaceWithMonoCecil> Interfaces
        {
            get { return typeWithMonoCecil.Interfaces; }
        }

        public override StaticClassMethodCollectionWithMonoCecil Methods
        {
            get { return typeWithMonoCecil.Methods; }
        }

        public override string Name
        {
            get { return type.Name(); }
        }

        public override NamespaceWithMonoCecil Namespace
        {
            get { return @namespace; }
        }
        
        public override AssemblyWithMonoCecil Project
        {
            get { return assembly; }
        }

        public override StaticClassPropertyCollectionWithMonoCecil Properties
        {
            get { return typeWithMonoCecil.Properties; }
        }

        public override AssemblyWithMonoCecil Solution
        {
            get { return assembly; }
        }

        public override StaticClassNestedStructCollectionWithMonoCecil Structs
        {
            get { return typeWithMonoCecil.Structs; }
        }
        
        public override TypeVisibilityModifier Visibility
        {
            get { return type.Visibility(); }
        }

        public TypeDefinition TypeDefinition
        {
            get { return type; }
        }
        
        public override StaticConstructorWithMonoCecil StaticConstructor
        {
            get { return typeWithMonoCecil.StaticConstructor; }
        }

        public override AssemblyWithMonoCecil Document
        {
            get { return assembly; }
        }

        internal StaticTypeWithMonoCecil TypeWithMonoCecil
        {
            get { return typeWithMonoCecil; }
        }

        public AssemblyWithMonoCecil Assembly
        {
            get { return assembly; }
        }

        HiddenMembersAnalyzer IInternalTypeWithMonoCecil.HiddenMembersAnalyzer
        {
            get { return hiddenMembersAnalyzer; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitClassWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
