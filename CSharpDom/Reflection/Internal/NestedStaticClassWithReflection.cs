using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using CSharpDom.Reflection.Internal.Hiding;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class NestedStaticClassWithReflection :
        AbstractNestedStaticClass<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            StaticClassEventCollectionWithReflection,
            StaticClassPropertyCollectionWithReflection,
            NestedStaticClassMethodCollectionWithReflection,
            StaticClassFieldCollectionWithReflection,
            StaticClassNestedClassCollectionWithReflection,
            StaticClassNestedDelegateWithReflection,
            StaticClassNestedEnumWithReflection,
            StaticClassNestedInterfaceWithReflection,
            StaticClassNestedStructCollectionWithReflection,
            StaticConstructorWithReflection>,
        ITypeWithReflection,
        IInternalTypeWithReflection,
        IHasType
    {
        private readonly ITypeWithReflection declaringType;
        private readonly HiddenMembersAnalyzer hiddenMembersAnalyzer;
        private readonly Type type;
        private readonly StaticTypeWithReflection typeWithReflection;
        private readonly NestedStaticClassMethodCollectionWithReflection methods;

        internal NestedStaticClassWithReflection(ITypeWithReflection declaringType, Type type)
        {
            this.declaringType = declaringType;
            hiddenMembersAnalyzer = new HiddenMembersAnalyzer(type);
            this.type = type;
            typeWithReflection = new StaticTypeWithReflection(this);
            methods = new NestedStaticClassMethodCollectionWithReflection(typeWithReflection);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return typeWithReflection.Attributes; }
        }

        public override StaticClassNestedClassCollectionWithReflection Classes
        {
            get { return typeWithReflection.Classes; }
        }
        
        public override ITypeWithReflection DeclaringType
        {
            get { return declaringType; }
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
        
        public override IReadOnlyCollection<StaticClassNestedInterfaceWithReflection> Interfaces
        {
            get { return typeWithReflection.Interfaces; }
        }
        
        public override NestedStaticClassMethodCollectionWithReflection Methods
        {
            get { return methods; }
        }

        public override string Name
        {
            get { return type.Name(); }
        }

        public override StaticClassPropertyCollectionWithReflection Properties
        {
            get { return typeWithReflection.Properties; }
        }
        
        public override StaticClassNestedStructCollectionWithReflection Structs
        {
            get { return typeWithReflection.Structs; }
        }
        
        public Type Type
        {
            get { return type; }
        }
        
        public override StaticConstructorWithReflection StaticConstructor
        {
            get { return typeWithReflection.StaticConstructor; }
        }

        public HiddenMembersAnalyzer HiddenMembersAnalyzer
        {
            get { return hiddenMembersAnalyzer; }
        }
    }
}
