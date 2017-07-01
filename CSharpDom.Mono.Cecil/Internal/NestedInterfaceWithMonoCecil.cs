using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class NestedInterfaceWithMonoCecil :
        AbstractNestedInterface<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            GenericParameterDeclarationWithMonoCecil,
            InterfaceReferenceWithMonoCecil,
            InterfaceEventWithMonoCecil,
            InterfacePropertyWithMonoCecil,
            InterfaceIndexerWithMonoCecil,
            InterfaceMethodWithMonoCecil>,
        IInterfaceTypeWithMonoCecil/*,
        IHasType,
        IVisitable<IReflectionVisitor>*/
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly TypeDefinition type;
        private readonly BasicTypeWithMonoCecil basicType;

        internal NestedInterfaceWithMonoCecil(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            this.declaringType = declaringType;
            this.type = type;
            basicType = new BasicTypeWithMonoCecil(this, type);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return basicType.Attributes; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return declaringType; }
        }
        
        public override IReadOnlyCollection<InterfaceEventWithMonoCecil> Events
        {
            get { return basicType.Events; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameters
        {
            get { return basicType.GenericParameters; }
        }

        public override IReadOnlyCollection<InterfaceIndexerWithMonoCecil> Indexers
        {
            get { return basicType.Indexers; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithMonoCecil> Interfaces
        {
            get { return basicType.Interfaces; }
        }

        public override IReadOnlyCollection<InterfaceMethodWithMonoCecil> Methods
        {
            get { return basicType.Methods; }
        }

        public override string Name
        {
            get { return type.Name(); }
        }

        public override IReadOnlyCollection<InterfacePropertyWithMonoCecil> Properties
        {
            get { return basicType.Properties; }
        }
        
        public TypeDefinition TypeDefinition
        {
            get { return type; }
        }

        public AssemblyWithMonoCecil Assembly
        {
            get { return declaringType.Assembly; }
        }

        public override bool IsPartial => false;

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNestedInterfaceWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
