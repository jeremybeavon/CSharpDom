using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Mono.Cecil
{
    public sealed class InterfaceWithMonoCecil :
        AbstractInterface<
            NamespaceWithMonoCecil,
            AssemblyWithMonoCecil,
            AssemblyWithMonoCecil,
            AssemblyWithMonoCecil,
            AttributeWithMonoCecil,
            GenericParameterDeclarationWithMonoCecil,
            InterfaceReferenceWithMonoCecil,
            InterfaceEventWithMonoCecil,
            InterfacePropertyWithMonoCecil,
            InterfaceIndexerWithMonoCecil,
            InterfaceMethodWithMonoCecil>,
        IInterfaceTypeWithMonoCecil,
        IHasTypeDefinition//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly AssemblyWithMonoCecil assembly;
        private readonly NamespaceWithMonoCecil @namespace;
        private readonly TypeDefinition type;
        private readonly BasicTypeWithMonoCecil basicType;

        internal InterfaceWithMonoCecil(AssemblyWithMonoCecil assembly, NamespaceWithMonoCecil @namespace, TypeDefinition type)
        {
            this.assembly = assembly;
            this.@namespace = @namespace;
            this.type = type;
            basicType = new BasicTypeWithMonoCecil(this, type);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return basicType.Attributes; }
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

        public override bool IsPartial
        {
            get { return false; }
        }

        public override IReadOnlyCollection<InterfaceMethodWithMonoCecil> Methods
        {
            get { return basicType.Methods; }
        }

        public override string Name
        {
            get { return type.Name(); }
        }

        public override NamespaceWithMonoCecil Namespace
        {
            get { return @namespace; }
        }

        public override AssemblyWithMonoCecil Project
        {
            get { return assembly; }
        }

        public override IReadOnlyCollection<InterfacePropertyWithMonoCecil> Properties
        {
            get { return basicType.Properties; }
        }

        public override AssemblyWithMonoCecil Solution
        {
            get { return assembly; }
        }

        public TypeDefinition TypeDefinition
        {
            get { return type; }
        }

        public override TypeVisibilityModifier Visibility
        {
            get { return type.Visibility(); }
        }

        public override AssemblyWithMonoCecil Document
        {
            get { return assembly; }
        }

        public AssemblyWithMonoCecil Assembly
        {
            get { return assembly; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitInterfaceWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
