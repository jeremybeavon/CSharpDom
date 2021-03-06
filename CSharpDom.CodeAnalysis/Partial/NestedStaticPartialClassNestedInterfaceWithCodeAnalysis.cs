﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class NestedStaticPartialClassNestedInterfaceWithCodeAnalysis :
        EditableStaticClassNestedInterface<
            AttributeGroupWithCodeAnalysis,
            INestedStaticPartialTypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            InterfaceEventWithCodeAnalysis,
            InterfacePropertyWithCodeAnalysis,
            InterfaceIndexerWithCodeAnalysis,
            InterfaceMethodWithCodeAnalysis>,
        IHasSyntax<InterfaceDeclarationSyntax>
    {
        private readonly NestedStaticClassNestedInterfaceWithCodeAnalysis nestedInterface;

        public NestedStaticPartialClassNestedInterfaceWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            string name)
            : this(new NestedStaticClassNestedInterfaceWithCodeAnalysis(visibility, name))
        {
        }

        internal NestedStaticPartialClassNestedInterfaceWithCodeAnalysis(
            NestedStaticClassNestedInterfaceWithCodeAnalysis nestedInterface)
        {
            this.nestedInterface = nestedInterface;
            nestedInterface.DeclaringTypeFunc = () => DeclaringType.Class;
        }
        
        public NestedStaticClassNestedInterfaceWithCodeAnalysis Interface
        {
            get { return nestedInterface; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return nestedInterface.Attributes; }
            set { nestedInterface.Attributes = value; }
        }

        public override INestedStaticPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return nestedInterface.Interface.Interface.Node.GetParent<INestedStaticPartialTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ICollection<InterfaceEventWithCodeAnalysis> Events
        {
            get { return nestedInterface.Events; }
            set { nestedInterface.Events = value; }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return nestedInterface.GenericParameters; }
            set { nestedInterface.GenericParameters = value; }
        }

        public override ICollection<InterfaceIndexerWithCodeAnalysis> Indexers
        {
            get { return nestedInterface.Indexers; }
            set { nestedInterface.Indexers = value; }
        }

        public override ICollection<InterfaceReferenceWithCodeAnalysis> Interfaces
        {
            get { return nestedInterface.Interfaces; }
            set { nestedInterface.Interfaces = value; }
        }
        
        public override ICollection<InterfaceMethodWithCodeAnalysis> Methods
        {
            get { return nestedInterface.Methods; }
            set { nestedInterface.Methods = value; }
        }

        public override string Name
        {
            get { return nestedInterface.Name; }
            set { nestedInterface.Name = value; }
        }

        public override ICollection<InterfacePropertyWithCodeAnalysis> Properties
        {
            get { return nestedInterface.Properties; }
            set { nestedInterface.Properties = value; }
        }

        public InterfaceDeclarationSyntax Syntax
        {
            get { return nestedInterface.Syntax; }
            set { nestedInterface.Syntax = value; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return nestedInterface.Visibility; }
            set { nestedInterface.Visibility = value; }
        }

        public override bool IsPartial { get => nestedInterface.IsPartial; set => nestedInterface.IsPartial = value; }
    }
}
