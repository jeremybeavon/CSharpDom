using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class NestedInterfaceWithCodeAnalysis :
        AbstractNestedInterface<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            InterfaceEventWithCodeAnalysis,
            InterfacePropertyWithCodeAnalysis,
            InterfaceIndexerWithCodeAnalysis,
            InterfaceMethodWithCodeAnalysis>,
        IBasicTypeWithCodeAnalysis/*,
        IHasType,
        IVisitable<IReflectionVisitor>*/
    {
        private readonly ITypeWithCodeAnalysis declaringType;
        private readonly TypeDefinition type;
        private readonly BasicTypeWithCodeAnalysis basicType;

        internal NestedInterfaceWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            this.declaringType = declaringType;
            this.type = type;
            basicType = new BasicTypeWithCodeAnalysis(this, type);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return basicType.Attributes; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return declaringType; }
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

        public override IReadOnlyCollection<InterfaceMethodWithCodeAnalysis> Methods
        {
            get { return basicType.Methods; }
        }

        public override string Name
        {
            get { return type.Name(); }
        }

        public override IReadOnlyCollection<InterfacePropertyWithCodeAnalysis> Properties
        {
            get { return basicType.Properties; }
        }
        
        public TypeDefinition TypeDefinition
        {
            get { return type; }
        }

        public AssemblyWithCodeAnalysis Assembly
        {
            get { return declaringType.Assembly; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNestedInterfaceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
