using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialStructNestedInterfaceWithCodeAnalysis :
        EditableStructNestedInterface<
            AttributeGroupWithCodeAnalysis,
            IPartialStructTypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            InterfaceEventWithCodeAnalysis,
            InterfacePropertyWithCodeAnalysis,
            InterfaceIndexerWithCodeAnalysis,
            InterfaceMethodWithCodeAnalysis>,
        IHasSyntax<InterfaceDeclarationSyntax>
    {
        private readonly StructNestedInterfaceWithCodeAnalysis type;

        public PartialStructNestedInterfaceWithCodeAnalysis(
            StructMemberVisibilityModifier visibility,
            string name)
            : this(new StructNestedInterfaceWithCodeAnalysis(visibility, name))
        {
        }

        internal PartialStructNestedInterfaceWithCodeAnalysis(StructNestedInterfaceWithCodeAnalysis type)
        {
            this.type = type;
        }
        
        public StructNestedInterfaceWithCodeAnalysis Interface
        {
            get { return type; }
        }
        
        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return type.Attributes; }
            set { type.Attributes = value; }
        }

        public override IPartialStructTypeWithCodeAnalysis DeclaringType
        {
            get { return type.Interface.Interface.Node.GetParentNode<IPartialStructTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
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

        public override StructMemberVisibilityModifier Visibility
        {
            get { return type.Visibility; }
            set { type.Visibility = value; }
        }

        public override bool IsPartial { get => Syntax.IsPartial(); set => Syntax = Syntax.IsPartial(value); }
    }
}
