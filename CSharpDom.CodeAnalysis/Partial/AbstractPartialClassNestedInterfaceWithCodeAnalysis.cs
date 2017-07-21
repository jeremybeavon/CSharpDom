using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassNestedInterfaceWithCodeAnalysis :
        EditableClassNestedInterface<
            AttributeGroupWithCodeAnalysis,
            IAbstractPartialTypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            InterfaceEventWithCodeAnalysis,
            InterfacePropertyWithCodeAnalysis,
            InterfaceIndexerWithCodeAnalysis,
            InterfaceMethodWithCodeAnalysis>,
        IHasSyntax<InterfaceDeclarationSyntax>
    {
        private readonly ClassNestedInterfaceWithCodeAnalysis type;

        public AbstractPartialClassNestedInterfaceWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            string name)
            : this(new ClassNestedInterfaceWithCodeAnalysis(visibility, name))
        {
        }

        internal AbstractPartialClassNestedInterfaceWithCodeAnalysis(ClassNestedInterfaceWithCodeAnalysis @interface)
        {
            type = @interface;
        }
        
        public NestedInterfaceWithCodeAnalysis Interface
        {
            get { return type.Interface; }
        }
        
        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return type.Attributes; }
            set { type.Attributes = value; }
        }

        public override IAbstractPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return type.Interface.Interface.Node.GetParentNode<IAbstractPartialTypeWithCodeAnalysis>(); }
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

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return type.Visibility; }
            set { type.Visibility = value; }
        }

        public override bool IsPartial { get => Syntax.IsPartial(); set => Syntax = Syntax.IsPartial(value); }

        internal ClassNestedInterfaceWithCodeAnalysis InternalInterface
        {
            get { return type; }
        }
    }
}
