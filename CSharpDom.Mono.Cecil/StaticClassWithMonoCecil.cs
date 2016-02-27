﻿using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using System;
using System.Collections.Generic;

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
            StaticClassPropertyWithMonoCecil,
            StaticClassMethodCollectionWithMonoCecil,
            StaticClassFieldCollectionWithMonoCecil,
            StaticClassNestedClassCollectionWithMonoCecil,
            StaticClassNestedDelegateWithMonoCecil,
            StaticClassNestedEnumWithMonoCecil,
            StaticClassNestedInterfaceCollectionWithMonoCecil,
            StaticClassNestedStructCollectionWithMonoCecil,
            StaticConstructorWithMonoCecil>,
        ITypeWithMonoCecil,
        IHasType//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly AssemblyWithMonoCecil assembly;
        private readonly NamespaceWithMonoCecil @namespace;
        private readonly Type type;
        private readonly StaticTypeWithMonoCecil typeWithMonoCecil;

        internal StaticClassWithMonoCecil(AssemblyWithMonoCecil assembly, NamespaceWithMonoCecil @namespace, Type type)
        {
            this.assembly = assembly;
            this.@namespace = @namespace;
            this.type = type;
            typeWithMonoCecil = new StaticTypeWithMonoCecil(this);
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
        
        public override StaticClassNestedInterfaceCollectionWithMonoCecil Interfaces
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

        public override IReadOnlyCollection<StaticClassPropertyWithMonoCecil> Properties
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

        public Type Type
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
