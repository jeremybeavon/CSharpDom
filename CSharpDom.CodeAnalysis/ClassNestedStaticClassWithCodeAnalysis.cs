using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassNestedStaticClassWithCodeAnalysis :
        AbstractClassNestedStaticClass<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            StaticClassEventCollectionWithCodeAnalysis,
            StaticClassPropertyWithCodeAnalysis,
            NestedStaticClassMethodCollectionWithCodeAnalysis,
            StaticClassFieldCollectionWithCodeAnalysis,
            StaticClassNestedClassCollectionWithCodeAnalysis,
            StaticClassNestedDelegateWithCodeAnalysis,
            StaticClassNestedEnumWithCodeAnalysis,
            StaticClassNestedInterfaceCollectionWithCodeAnalysis,
            StaticClassNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>
    {
        private readonly NestedStaticClassWithCodeAnalysis nestedClass;

        internal ClassNestedStaticClassWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            nestedClass = new NestedStaticClassWithCodeAnalysis(declaringType, type);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return nestedClass.Attributes; }
        }
        
        public override StaticClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return nestedClass.Classes; }
        }
        
        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return nestedClass.DeclaringType; }
        }

        public override IReadOnlyCollection<StaticClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return nestedClass.Delegates; }
        }
        
        public override IReadOnlyCollection<StaticClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return nestedClass.Enums; }
        }
        
        public override StaticClassEventCollectionWithCodeAnalysis Events
        {
            get { return nestedClass.Events; }
        }
        
        public override StaticClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return nestedClass.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return nestedClass.GenericParameters; }
        }
        
        public override StaticClassNestedInterfaceCollectionWithCodeAnalysis Interfaces
        {
            get { return nestedClass.Interfaces; }
        }
        
        public override NestedStaticClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return nestedClass.Methods; }
        }

        public override string Name
        {
            get { return nestedClass.Name; }
        }
        
        public override IReadOnlyCollection<StaticClassPropertyWithCodeAnalysis> Properties
        {
            get { return nestedClass.Properties; }
        }

        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return nestedClass.StaticConstructor; }
        }

        public override StaticClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return nestedClass.Structs; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return nestedClass.TypeDefinition.ClassMemberVisibility(); }
        }
    }
}
