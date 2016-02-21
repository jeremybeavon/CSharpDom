using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;

namespace CSharpDom.Reflection
{
    public sealed class StaticClassWithReflection :
        AbstractStaticClass<
            NamespaceWithReflection,
            AssemblyWithReflection,
            AssemblyWithReflection,
            AssemblyWithReflection,
            AttributeWithReflection,
            GenericParameterDeclarationWithReflection,
            StaticClassEventCollectionWithReflection,
            StaticClassPropertyWithReflection,
            StaticClassMethodCollectionWithReflection,
            StaticClassFieldCollectionWithReflection,
            StaticClassNestedClassCollectionWithReflection,
            StaticClassNestedDelegateWithReflection,
            StaticClassNestedEnumWithReflection,
            StaticClassNestedInterfaceCollectionWithReflection,
            StaticClassNestedStructCollectionWithReflection,
            StaticConstructorWithReflection>,
        ITypeWithReflection,
        IHasType//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly AssemblyWithReflection assembly;
        private readonly NamespaceWithReflection @namespace;
        private readonly Type type;
        private readonly StaticTypeWithReflection typeWithReflection;

        internal StaticClassWithReflection(AssemblyWithReflection assembly, NamespaceWithReflection @namespace, Type type)
        {
            this.assembly = assembly;
            this.@namespace = @namespace;
            this.type = type;
            typeWithReflection = new StaticTypeWithReflection(this);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return typeWithReflection.Attributes; }
        }

        public override StaticClassNestedClassCollectionWithReflection Classes
        {
            get { return typeWithReflection.Classes; }
        }
        
        public override IReadOnlyCollection<StaticClassNestedDelegateWithReflection> Delegates
        {
            get { return typeWithReflection.Delegates; }
        }
        
        public override IReadOnlyCollection<StaticClassNestedEnumWithReflection> Enums
        {
            get { return typeWithReflection.Enums; }
        }
        
        public override StaticClassEventCollectionWithReflection Events
        {
            get { return typeWithReflection.Events; }
        }

        public override StaticClassFieldCollectionWithReflection Fields
        {
            get { return typeWithReflection.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return typeWithReflection.GenericParameters; }
        }
        
        public override StaticClassNestedInterfaceCollectionWithReflection Interfaces
        {
            get { return typeWithReflection.Interfaces; }
        }

        public override StaticClassMethodCollectionWithReflection Methods
        {
            get { return typeWithReflection.Methods; }
        }

        public override string Name
        {
            get { return type.Name(); }
        }

        public override NamespaceWithReflection Namespace
        {
            get { return @namespace; }
        }
        
        public override AssemblyWithReflection Project
        {
            get { return assembly; }
        }

        public override IReadOnlyCollection<StaticClassPropertyWithReflection> Properties
        {
            get { return typeWithReflection.Properties; }
        }

        public override AssemblyWithReflection Solution
        {
            get { return assembly; }
        }

        public override StaticClassNestedStructCollectionWithReflection Structs
        {
            get { return typeWithReflection.Structs; }
        }
        
        public override TypeVisibilityModifier Visibility
        {
            get { return type.Visibility(); }
        }

        public Type Type
        {
            get { return type; }
        }
        
        public override StaticConstructorWithReflection StaticConstructor
        {
            get { return typeWithReflection.StaticConstructor; }
        }

        public override AssemblyWithReflection Document
        {
            get { return assembly; }
        }

        internal StaticTypeWithReflection TypeWithReflection
        {
            get { return typeWithReflection; }
        }
        
        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitClassWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
