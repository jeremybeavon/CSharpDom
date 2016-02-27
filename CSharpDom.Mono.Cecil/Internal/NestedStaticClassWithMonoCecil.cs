using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.Mono.Cecil.Internal.Hiding;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class NestedStaticClassWithMonoCecil :
        AbstractNestedStaticClass<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            GenericParameterDeclarationWithMonoCecil,
            StaticClassEventCollectionWithMonoCecil,
            StaticClassPropertyWithMonoCecil,
            NestedStaticClassMethodCollectionWithMonoCecil,
            StaticClassFieldCollectionWithMonoCecil,
            StaticClassNestedClassCollectionWithMonoCecil,
            StaticClassNestedDelegateWithMonoCecil,
            StaticClassNestedEnumWithMonoCecil,
            StaticClassNestedInterfaceCollectionWithMonoCecil,
            StaticClassNestedStructCollectionWithMonoCecil,
            StaticConstructorWithMonoCecil>,
        ITypeWithMonoCecil,
        IInternalTypeWithMonoCecil,
        IHasType
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly HiddenMembersAnalyzer hiddenMembersAnalyzer;
        private readonly Type type;
        private readonly StaticTypeWithMonoCecil typeWithMonoCecil;
        private readonly NestedStaticClassMethodCollectionWithMonoCecil methods;

        internal NestedStaticClassWithMonoCecil(ITypeWithMonoCecil declaringType, Type type)
        {
            this.declaringType = declaringType;
            hiddenMembersAnalyzer = new HiddenMembersAnalyzer(type);
            this.type = type;
            typeWithMonoCecil = new StaticTypeWithMonoCecil(this);
            methods = new NestedStaticClassMethodCollectionWithMonoCecil(typeWithMonoCecil);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return typeWithMonoCecil.Attributes; }
        }

        public override StaticClassNestedClassCollectionWithMonoCecil Classes
        {
            get { return typeWithMonoCecil.Classes; }
        }
        
        public override ITypeWithMonoCecil DeclaringType
        {
            get { return declaringType; }
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
        
        public override NestedStaticClassMethodCollectionWithMonoCecil Methods
        {
            get { return methods; }
        }

        public override string Name
        {
            get { return type.Name; }
        }

        public override IReadOnlyCollection<StaticClassPropertyWithMonoCecil> Properties
        {
            get { return typeWithMonoCecil.Properties; }
        }
        
        public override StaticClassNestedStructCollectionWithMonoCecil Structs
        {
            get { return typeWithMonoCecil.Structs; }
        }
        
        public Type Type
        {
            get { return type; }
        }
        
        public override StaticConstructorWithMonoCecil StaticConstructor
        {
            get { return typeWithMonoCecil.StaticConstructor; }
        }

        public HiddenMembersAnalyzer HiddenMembersAnalyzer
        {
            get { return hiddenMembersAnalyzer; }
        }
    }
}
