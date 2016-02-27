using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StaticClassNestedStaticClassWithMonoCecil :
        AbstractStaticClassNestedStaticClass<
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
            StaticConstructorWithMonoCecil>
    {
        private readonly NestedStaticClassWithMonoCecil nestedClass;

        internal StaticClassNestedStaticClassWithMonoCecil(ITypeWithMonoCecil declaringType, Type type)
        {
            nestedClass = new NestedStaticClassWithMonoCecil(declaringType, type);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return nestedClass.Attributes; }
        }
        
        public override StaticClassNestedClassCollectionWithMonoCecil Classes
        {
            get { return nestedClass.Classes; }
        }
        
        public override ITypeWithMonoCecil DeclaringType
        {
            get { return nestedClass.DeclaringType; }
        }

        public override IReadOnlyCollection<StaticClassNestedDelegateWithMonoCecil> Delegates
        {
            get { return nestedClass.Delegates; }
        }
        
        public override IReadOnlyCollection<StaticClassNestedEnumWithMonoCecil> Enums
        {
            get { return nestedClass.Enums; }
        }
        
        public override StaticClassEventCollectionWithMonoCecil Events
        {
            get { return nestedClass.Events; }
        }
        
        public override StaticClassFieldCollectionWithMonoCecil Fields
        {
            get { return nestedClass.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameters
        {
            get { return nestedClass.GenericParameters; }
        }
        
        public override StaticClassNestedInterfaceCollectionWithMonoCecil Interfaces
        {
            get { return nestedClass.Interfaces; }
        }
        
        public override NestedStaticClassMethodCollectionWithMonoCecil Methods
        {
            get { return nestedClass.Methods; }
        }

        public override string Name
        {
            get { return nestedClass.Name; }
        }
        
        public override IReadOnlyCollection<StaticClassPropertyWithMonoCecil> Properties
        {
            get { return nestedClass.Properties; }
        }

        public override StaticConstructorWithMonoCecil StaticConstructor
        {
            get { return nestedClass.StaticConstructor; }
        }

        public override StaticClassNestedStructCollectionWithMonoCecil Structs
        {
            get { return nestedClass.Structs; }
        }

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return nestedClass.Type.StaticClassMemberVisibility(); }
        }
    }
}
