using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StaticClassNestedStaticClassWithReflection :
        AbstractStaticClassNestedStaticClass<
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
            StaticConstructorWithReflection>
    {
        private readonly NestedStaticClassWithReflection nestedClass;

        internal StaticClassNestedStaticClassWithReflection(ITypeWithReflection declaringType, Type type)
        {
            nestedClass = new NestedStaticClassWithReflection(declaringType, type);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return nestedClass.Attributes; }
        }
        
        public override StaticClassNestedClassCollectionWithReflection Classes
        {
            get { return nestedClass.Classes; }
        }
        
        public override ITypeWithReflection DeclaringType
        {
            get { return nestedClass.DeclaringType; }
        }

        public override IReadOnlyCollection<StaticClassNestedDelegateWithReflection> Delegates
        {
            get { return nestedClass.Delegates; }
        }
        
        public override IReadOnlyCollection<StaticClassNestedEnumWithReflection> Enums
        {
            get { return nestedClass.Enums; }
        }
        
        public override StaticClassEventCollectionWithReflection Events
        {
            get { return nestedClass.Events; }
        }
        
        public override StaticClassFieldCollectionWithReflection Fields
        {
            get { return nestedClass.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return nestedClass.GenericParameters; }
        }
        
        public override IReadOnlyCollection<StaticClassNestedInterfaceWithReflection> Interfaces
        {
            get { return nestedClass.Interfaces; }
        }
        
        public override NestedStaticClassMethodCollectionWithReflection Methods
        {
            get { return nestedClass.Methods; }
        }

        public override string Name
        {
            get { return nestedClass.Name; }
        }
        
        public override StaticClassPropertyCollectionWithReflection Properties
        {
            get { return nestedClass.Properties; }
        }

        public override StaticConstructorWithReflection StaticConstructor
        {
            get { return nestedClass.StaticConstructor; }
        }

        public override StaticClassNestedStructCollectionWithReflection Structs
        {
            get { return nestedClass.Structs; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return nestedClass.Type.ClassMemberVisibility(); }
        }
    }
}
