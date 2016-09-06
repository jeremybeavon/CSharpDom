using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassNestedInterfaceWithCodeAnalysis :
        EditableClassNestedInterface<
            AttributeGroupWithCodeAnalysis,
            IClassType,
            GenericParameterDeclarationWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            InterfaceEventWithCodeAnalysis,
            InterfacePropertyWithCodeAnalysis,
            InterfaceIndexerWithCodeAnalysis,
            InterfaceMethodWithCodeAnalysis>,
        IHasSyntax<InterfaceDeclarationSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly NestedInterfaceWithCodeAnalysis type;

        internal ClassNestedInterfaceWithCodeAnalysis(ClassTypeWithCodeAnalysis parent)
            : this()
        {
            type = new NestedInterfaceWithCodeAnalysis(parent, this);
        }

        private ClassNestedInterfaceWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
        }

        public NestedInterfaceWithCodeAnalysis Interface
        {
            get { return type; }
        }

        public NestedInterfaceWithCodeAnalysis Type
        {
            get { return type; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return type.Attributes; }
            set { type.Attributes = value; }
        }

        public override ICollection<InterfaceEventWithCodeAnalysis> Events
        {
            get { return type.Events; }
            set { type.Events = value; }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return type.GenericParameters; }
            set { type.GenericParameters = value; }
        }

        public override ICollection<InterfaceIndexerWithCodeAnalysis> Indexers
        {
            get { return type.Indexers; }
            set { type.Indexers = value; }
        }

        public override ICollection<InterfaceReferenceWithCodeAnalysis> Interfaces
        {
            get { return type.Interfaces; }
            set { type.Interfaces = value; }
        }

        public override ICollection<InterfaceMethodWithCodeAnalysis> Methods
        {
            get { return type.Methods; }
            set { type.Methods = value; }
        }

        public override string Name
        {
            get { return type.Name; }
            set { type.Name = value; }
        }

        public override ICollection<InterfacePropertyWithCodeAnalysis> Properties
        {
            get { return type.Properties; }
            set { type.Properties = value; }
        }

        public InterfaceDeclarationSyntax Syntax
        {
            get { return type.Syntax; }
            set { type.Syntax = value; }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }
    }
}
