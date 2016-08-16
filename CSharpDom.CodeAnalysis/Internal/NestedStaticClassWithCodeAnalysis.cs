using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using CSharpDom.Mono.Cecil.Internal.Hiding;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class NestedStaticClassWithCodeAnalysis :
        AbstractNestedStaticClass<
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
            StaticConstructorWithCodeAnalysis>,
        ITypeWithCodeAnalysis,
        IInternalTypeWithCodeAnalysis,
        IHasTypeDefinition
    {
        private readonly ITypeWithCodeAnalysis declaringType;
        private readonly HiddenMembersAnalyzer hiddenMembersAnalyzer;
        private readonly TypeDefinition type;
        private readonly StaticTypeWithCodeAnalysis typeWithCodeAnalysis;
        private readonly NestedStaticClassMethodCollectionWithCodeAnalysis methods;

        internal NestedStaticClassWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            this.declaringType = declaringType;
            hiddenMembersAnalyzer = new HiddenMembersAnalyzer(Assembly, type);
            this.type = type;
            typeWithCodeAnalysis = new StaticTypeWithCodeAnalysis(this);
            methods = new NestedStaticClassMethodCollectionWithCodeAnalysis(typeWithCodeAnalysis);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return typeWithCodeAnalysis.Attributes; }
        }

        public override StaticClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return typeWithCodeAnalysis.Classes; }
        }
        
        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return declaringType; }
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
        
        public override NestedStaticClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return methods; }
        }

        public override string Name
        {
            get { return type.Name(); }
        }

        public override IReadOnlyCollection<StaticClassPropertyWithCodeAnalysis> Properties
        {
            get { return typeWithCodeAnalysis.Properties; }
        }
        
        public override StaticClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return typeWithCodeAnalysis.Structs; }
        }
        
        public TypeDefinition TypeDefinition
        {
            get { return type; }
        }
        
        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return typeWithCodeAnalysis.StaticConstructor; }
        }

        public HiddenMembersAnalyzer HiddenMembersAnalyzer
        {
            get { return hiddenMembersAnalyzer; }
        }

        public AssemblyWithCodeAnalysis Assembly
        {
            get { return declaringType.Assembly; }
        }
    }
}
