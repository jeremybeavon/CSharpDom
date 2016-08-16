using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassNestedInterfaceWithCodeAnalysis :
        AbstractStaticClassNestedInterface<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            InterfaceEventWithCodeAnalysis,
            InterfacePropertyWithCodeAnalysis,
            InterfaceIndexerWithCodeAnalysis,
            InterfaceMethodWithCodeAnalysis>
    {
        private readonly NestedInterfaceWithCodeAnalysis nestedInterface;

        internal StaticClassNestedInterfaceWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            nestedInterface = new NestedInterfaceWithCodeAnalysis(declaringType, type);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return nestedInterface.Attributes; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return nestedInterface.DeclaringType; }
        }

        public override IReadOnlyCollection<InterfaceEventWithCodeAnalysis> Events
        {
            get { return nestedInterface.Events; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return nestedInterface.GenericParameters; }
        }

        public override IReadOnlyCollection<InterfaceIndexerWithCodeAnalysis> Indexers
        {
            get { return nestedInterface.Indexers; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithCodeAnalysis> Interfaces
        {
            get { return nestedInterface.Interfaces; }
        }
        
        public override IReadOnlyCollection<InterfaceMethodWithCodeAnalysis> Methods
        {
            get { return nestedInterface.Methods; }
        }

        public override string Name
        {
            get { return nestedInterface.Name; }
        }

        public override IReadOnlyCollection<InterfacePropertyWithCodeAnalysis> Properties
        {
            get { return nestedInterface.Properties; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return nestedInterface.TypeDefinition.ClassMemberVisibility(); }
        }
    }
}
