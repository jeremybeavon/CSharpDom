using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StructNestedInterfaceWithReflection :
        AbstractStructNestedInterface<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            InterfaceReferenceWithReflection,
            InterfaceEventWithReflection,
            InterfacePropertyWithReflection,
            InterfaceIndexerWithReflection,
            InterfaceMethodWithReflection>
    {
        private readonly NestedInterfaceWithReflection nestedInterface;

        internal StructNestedInterfaceWithReflection(ITypeWithReflection declaringType, Type type)
        {
            nestedInterface = new NestedInterfaceWithReflection(declaringType, type);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return nestedInterface.Attributes; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return nestedInterface.DeclaringType; }
        }

        public override IReadOnlyCollection<InterfaceEventWithReflection> Events
        {
            get { return nestedInterface.Events; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return nestedInterface.GenericParameters; }
        }

        public override IReadOnlyCollection<InterfaceIndexerWithReflection> Indexers
        {
            get { return nestedInterface.Indexers; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithReflection> Interfaces
        {
            get { return nestedInterface.Interfaces; }
        }
        
        public override IReadOnlyCollection<InterfaceMethodWithReflection> Methods
        {
            get { return nestedInterface.Methods; }
        }

        public override string Name
        {
            get { return nestedInterface.Name; }
        }

        public override IReadOnlyCollection<InterfacePropertyWithReflection> Properties
        {
            get { return nestedInterface.Properties; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return nestedInterface.Type.StructMemberVisibility(); }
        }

        public override bool IsPartial => false;
    }
}
