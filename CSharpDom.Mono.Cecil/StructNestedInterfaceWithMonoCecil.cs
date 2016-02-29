using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StructNestedInterfaceWithMonoCecil :
        AbstractStructNestedInterface<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            GenericParameterDeclarationWithMonoCecil,
            InterfaceReferenceWithMonoCecil,
            InterfaceEventWithMonoCecil,
            InterfacePropertyWithMonoCecil,
            InterfaceIndexerWithMonoCecil,
            InterfaceMethodWithMonoCecil>
    {
        private readonly NestedInterfaceWithMonoCecil nestedInterface;

        internal StructNestedInterfaceWithMonoCecil(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            nestedInterface = new NestedInterfaceWithMonoCecil(declaringType, type);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return nestedInterface.Attributes; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return nestedInterface.DeclaringType; }
        }

        public override IReadOnlyCollection<InterfaceEventWithMonoCecil> Events
        {
            get { return nestedInterface.Events; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameters
        {
            get { return nestedInterface.GenericParameters; }
        }

        public override IReadOnlyCollection<InterfaceIndexerWithMonoCecil> Indexers
        {
            get { return nestedInterface.Indexers; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithMonoCecil> Interfaces
        {
            get { return nestedInterface.Interfaces; }
        }
        
        public override IReadOnlyCollection<InterfaceMethodWithMonoCecil> Methods
        {
            get { return nestedInterface.Methods; }
        }

        public override string Name
        {
            get { return nestedInterface.Name; }
        }

        public override IReadOnlyCollection<InterfacePropertyWithMonoCecil> Properties
        {
            get { return nestedInterface.Properties; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return nestedInterface.TypeDefinition.StructMemberVisibility(); }
        }
    }
}
