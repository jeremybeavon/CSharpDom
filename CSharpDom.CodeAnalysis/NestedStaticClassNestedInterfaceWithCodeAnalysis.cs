using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NestedStaticClassNestedInterfaceWithCodeAnalysis :
        EditableStaticClassNestedInterface<
            AttributeGroupWithCodeAnalysis,
            INestedStaticTypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            InterfaceEventWithCodeAnalysis,
            InterfacePropertyWithCodeAnalysis,
            InterfaceIndexerWithCodeAnalysis,
            InterfaceMethodWithCodeAnalysis>,
        IHasSyntax<InterfaceDeclarationSyntax>,
        IHasNode<InterfaceDeclarationSyntax>
    {
        private readonly NestedInterfaceWithCodeAnalysis nestedInterface;

        public NestedStaticClassNestedInterfaceWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            string name)
            : this()
        {
            Syntax = SyntaxFactory.InterfaceDeclaration(
                default(SyntaxList<AttributeListSyntax>),
                default(SyntaxTokenList).WithClassMemberVisibilityModifier(visibility),
                SyntaxFactory.Identifier(name),
                null,
                null,
                default(SyntaxList<TypeParameterConstraintClauseSyntax>),
                default(SyntaxList<MemberDeclarationSyntax>));
        }

        internal NestedStaticClassNestedInterfaceWithCodeAnalysis()
        {
            nestedInterface = new NestedInterfaceWithCodeAnalysis();
        }
        
        public NestedInterfaceWithCodeAnalysis Interface
        {
            get { return nestedInterface; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return nestedInterface.Attributes; }
            set { nestedInterface.Attributes = value; }
        }

        public override INestedStaticTypeWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? nestedInterface.Interface.Node.GetParentNode<INestedStaticTypeWithCodeAnalysis>(); }
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
            get { return Syntax.Modifiers.ToClassMemberVisibilityModifier(); }
            set
            {
                InterfaceDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassMemberVisibilityModifier(value));
            }
        }

        public override bool IsPartial { get => Syntax.IsPartial(); set => Syntax = Syntax.IsPartial(value); }

        INode<InterfaceDeclarationSyntax> IHasNode<InterfaceDeclarationSyntax>.Node
        {
            get { return nestedInterface.Interface.Node; }
        }

        internal Func<INestedStaticTypeWithCodeAnalysis> DeclaringTypeFunc { get; set; }
    }
}
