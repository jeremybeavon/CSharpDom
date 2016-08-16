using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    public sealed class InterfaceWithCodeAnalysis :
        AbstractInterface<
            NamespaceWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            InterfaceEventWithCodeAnalysis,
            InterfacePropertyWithCodeAnalysis,
            InterfaceIndexerWithCodeAnalysis,
            InterfaceMethodWithCodeAnalysis>,
        IBasicTypeWithCodeAnalysis,
        IHasTypeDefinition//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly AssemblyWithCodeAnalysis assembly;
        private readonly NamespaceWithCodeAnalysis @namespace;
        private readonly TypeDefinition type;
        private readonly BasicTypeWithCodeAnalysis basicType;

        internal InterfaceWithCodeAnalysis(AssemblyWithCodeAnalysis assembly, NamespaceWithCodeAnalysis @namespace, TypeDefinition type)
        {
            this.assembly = assembly;
            this.@namespace = @namespace;
            this.type = type;
            basicType = new BasicTypeWithCodeAnalysis(this, type);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return basicType.Attributes; }
        }

        public override IReadOnlyCollection<InterfaceEventWithCodeAnalysis> Events
        {
            get { return basicType.Events; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return basicType.GenericParameters; }
        }

        public override IReadOnlyCollection<InterfaceIndexerWithCodeAnalysis> Indexers
        {
            get { return basicType.Indexers; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithCodeAnalysis> Interfaces
        {
            get { return basicType.Interfaces; }
        }

        public override bool IsPartial
        {
            get { return false; }
        }

        public override IReadOnlyCollection<InterfaceMethodWithCodeAnalysis> Methods
        {
            get { return basicType.Methods; }
        }

        public override string Name
        {
            get { return type.Name(); }
        }

        public override NamespaceWithCodeAnalysis Namespace
        {
            get { return @namespace; }
        }

        public override AssemblyWithCodeAnalysis Project
        {
            get { return assembly; }
        }

        public override IReadOnlyCollection<InterfacePropertyWithCodeAnalysis> Properties
        {
            get { return basicType.Properties; }
        }

        public override AssemblyWithCodeAnalysis Solution
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

        public override AssemblyWithCodeAnalysis Document
        {
            get { return assembly; }
        }

        public AssemblyWithCodeAnalysis Assembly
        {
            get { return assembly; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitInterfaceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
